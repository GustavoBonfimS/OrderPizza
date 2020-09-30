using OrderPizza.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

namespace OrderPizza.DAO
{
    class PedidoDAO
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public PedidoDAO()
        {
            cmd.Connection = new Conexao().conectar();
        }

        public List<Pedido> ListPedidos()
        {
            var retorno = new List<Pedido>();

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
                        pedido.fomraPagamento = Convert.ToString(dr["FORMAPAGAMENTO"]);
                        
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
    }
}
