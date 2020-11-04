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

        public async Task<bool> insertPedido(Pedido pedido)
        {
            var retorno = false;
            pedido.data = DateTime.Now;
            cmd.CommandText = "INSERT INTO PEDIDO(VALOR, IDCLIENTE, FORMAPAGAMENTO, DATA, HORA) VALUES(@VALOR, @IDCLIENTE, @FORMAPAGAMENTO, @DATA, @HORA)";
            cmd.Parameters.AddWithValue("@VALOR", pedido.valor);
            cmd.Parameters.AddWithValue("@IDCLIENTE", pedido.idCliente);
            cmd.Parameters.AddWithValue("@FORMAPAGAMENTO", pedido.formaPagamento);
            cmd.Parameters.AddWithValue("@DATA", (pedido.data).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@HORA", (pedido.data).ToString("HH:mm"));
            try
            {
                cmd.Connection = new Conexao().conectar();
                await cmd.ExecuteNonQueryAsync();
                insertPedidoOnVenda(pedido);
                retorno = true;
                cmd.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return retorno;
        }

        private bool insertPedidoOnVenda(Pedido pedido)
        {
            var retorno = false;
            
            pedido.produtos.ForEach(prod =>
            {
                // gambiarra necessaria
                // declarando variaveis com parameter.addWithValues gera um erro de variavel ja alocada
                cmd.CommandText = "INSERT INTO VENDA(IDPEDIDO, IDPRODUTO) VALUES" +
                "((SELECT IDPEDIDO FROM PEDIDO WHERE DATA = @DATA AND HORA = @HORA AND " +
                "IDCLIENTE = "+ pedido.idCliente.ToString() + "), " + prod.id.ToString() + ")";
                
                try
                {
                    cmd.ExecuteNonQuery();
                    retorno = true;
                }
                catch (SqlException ex)
                {
                    retorno = false;
                    MessageBox.Show(ex.Message);
                }
            });


            cmd.Dispose();
            return retorno;
        }
    }
}
