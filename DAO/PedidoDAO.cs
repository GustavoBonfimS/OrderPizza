using OrderPizza.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;

namespace OrderPizza.DAO
{
    class PedidoDAO
    {
        SqlCommand cmd;
        SqlDataReader dr;

        public PedidoDAO()
        {
            cmd = new SqlCommand();
        }

        public List<Pedido> ListPedidos()
        {
            var retorno = new List<Pedido>();

            cmd.CommandText = "SELECT * FROM PEDIDO";

            try
            {
                cmd.Connection = new Conexao().conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var pedido = new Pedido();
                        pedido.id = Convert.ToInt32(dr["IDPEDIDO"]);
                        pedido.idCliente = Convert.ToInt32(dr["IDCLIENTE"]);
                        pedido.valor = Convert.ToDouble(dr["VALOR"]);
                        pedido.formaPagamento = Convert.ToString(dr["FORMAPAGAMENTO"]);
                        pedido.data = Convert.ToDateTime(dr["DATA"]);
                        pedido.hora = Convert.ToDateTime(dr["HORA"]);
                        
                        retorno.Add(pedido);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retorno;
        }

        public List<Pedido> ListPedidosDoDia(int idFunc)
        {
            var retorno = new List<Pedido>();

            cmd.CommandText = "SELECT * FROM PEDIDO WHERE DATA = @DATA AND IDFUNCIONARIO = @IDFUNC ORDER BY HORA DESC";
            cmd.Parameters.AddWithValue("@DATA", (DateTime.Now).ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("@IDFUNC", idFunc);

            try
            {
                cmd.Connection = new Conexao().conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var pedido = new Pedido();
                        pedido.id = Convert.ToInt32(dr["IDPEDIDO"]);
                        pedido.idCliente = Convert.ToInt32(dr["IDCLIENTE"]);
                        pedido.valor = Convert.ToDouble(dr["VALOR"]);
                        pedido.formaPagamento = Convert.ToString(dr["FORMAPAGAMENTO"]);
                        pedido.data = DateTime.Parse(Convert.ToString(dr["DATA"]));
                        pedido.hora = DateTime.Parse(Convert.ToString(dr["HORA"]));
                        pedido.idFuncionario = Convert.ToInt32(dr["IDFUNCIONARIO"]);

                        retorno.Add(pedido);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retorno;
        }

        private Pedido getPedidoByDate(Pedido pedido)
        {
            var retorno = new Pedido();

            cmd.CommandText = "SELECT * FROM PEDIDO WHERE DATA = @DATA AND HORA = @HORA";
            // cmd.Parameters.AddWithValue("@DATA", pedido.data);
            // cmd.Parameters.AddWithValue("@HORA", pedido.hora);

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        retorno.id = Convert.ToInt32(dr["IDPEDIDO"]);
                        retorno.idCliente = Convert.ToInt32(dr["IDCLIENTE"]);
                        retorno.valor = Convert.ToDouble(dr["VALOR"]);
                        retorno.formaPagamento = Convert.ToString(dr["FORMAPAGAMENTO"]);
                        retorno.data = DateTime.Parse(Convert.ToString(dr["DATA"]));
                        retorno.hora = DateTime.Parse(Convert.ToString(dr["HORA"]));
                    }
                }
                cmd.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retorno;
        }

        public void insertPedido(Pedido pedido, string nome)
        { 
            pedido.data = DateTime.Now;
            cmd.CommandText = "INSERT INTO PEDIDO(VALOR, IDCLIENTE, FORMAPAGAMENTO, DATA, HORA, IDFUNCIONARIO) VALUES(@VALOR, " +
                "(SELECT IDCLIENTE FROM CLIENTE WHERE NOME = '" + nome + "')" + ", @FORMAPAGAMENTO, @DATA, @HORA, @IDFUNC)";
            cmd.Parameters.AddWithValue("@VALOR", pedido.valor);
            cmd.Parameters.AddWithValue("@FORMAPAGAMENTO", pedido.formaPagamento);
            cmd.Parameters.AddWithValue("@DATA", (pedido.data).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@HORA", (pedido.data).ToString("HH:mm"));
            cmd.Parameters.AddWithValue("@IDFUNC", Funcionario.id);
            try
            {
                cmd.Connection = new Conexao().conectar();
                cmd.ExecuteNonQuery();
                insertPedidoOnVenda(pedido, nome);
                cmd.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertPedidoOnVenda(Pedido pedido, string nome)
        {
            var subSelect = "(SELECT IDCLIENTE FROM CLIENTE WHERE NOME = '" + nome + "')";
            pedido.produtos.ForEach(prod =>
            {
                // gambiarra necessaria
                // declarando variaveis com parameter.addWithValues gera um erro de variavel ja alocada
                cmd.CommandText = "INSERT INTO VENDA(IDPEDIDO, IDPRODUTO) VALUES" +
                "((SELECT IDPEDIDO FROM PEDIDO WHERE DATA = @DATA AND HORA = @HORA AND " +
                "IDCLIENTE = "+ subSelect + "), " + prod.id.ToString() + ")";
                
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
            pedido = getPedidoByDate(pedido);
            cmd.Dispose();
            RelatorioDAO.inserirRegistro(pedido.id, "Pedido fianlizado", pedido.idCliente);
        }
    }
}
