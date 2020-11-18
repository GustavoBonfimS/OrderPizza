using OrderPizza.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows;

namespace OrderPizza.DAO
{
    class RelatorioDAO
    {
        public async static Task<bool> inserirRegistro(int idPedido, string descricao, int idCliente)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            var retorno = false;

            cmd.CommandText = "INSERT INTO RELATORIO (IDPEDIDO, DESCRICAO, DATA, HORA, IDCLIENTE)" +
                "VALUES(@IDPEDIDO, @DESCRICAO, @DATA, @HORA, @IDCLIENTE)";
            cmd.Parameters.AddWithValue("@IDPEDIDO", idPedido);
            cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
            cmd.Parameters.AddWithValue("@DATA", (DateTime.Now).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@HORA", (DateTime.Now).ToString("HH:mm"));
            cmd.Parameters.AddWithValue("@IDCLIENTE", idCliente);
            try
            {
                cmd.Connection = conexao.conectar();
                await cmd.ExecuteNonQueryAsync();
                retorno = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retorno;
        }

        public static List<Registro> gerarRelatorio(string buscarPor, string telefone = "", int idPedido = 0)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlDataReader dr;

            switch (buscarPor)
            {
                case "geral":
                    cmd.CommandText = "SELECT * FROM RELATORIO";
                    break;
                case "cliente":
                    cmd.CommandText = "SELECT * FROM RELATORIO WHERE IDCLIENTE = " +
                        "(SELECT IDCLIENTE FROM CLIENTE WHERE CLIENTE.TELEFONE = @TELEFONE)";
                    cmd.Parameters.AddWithValue("@TELEFONE", telefone);
                    break;
                case "pedido":
                    cmd.CommandText = "SELECT * FROM RELATORIO WHERE IDPEDIDO = @ID";
                    cmd.Parameters.AddWithValue("@ID", idPedido);
                    break;
            }

            List<Registro> retorno = new List<Registro>();
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Registro reg = new Registro();
                        reg.idRelatorio = Convert.ToInt32(dr["IDRELATORIO"]);
                        reg.idPedido = Convert.ToInt32(dr["IDPEDIDO"]);
                        reg.data = DateTime.Parse(Convert.ToString(dr["DATA"]));
                        reg.hora = DateTime.Parse(Convert.ToString(dr["HORA"]));
                        reg.descricao = Convert.ToString(dr["DESCRICAO"]);
                        retorno.Add(reg);
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

        public static List<Registro> listRegistros()
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM RELATORIO";
            List<Registro> retorno = new List<Registro>();
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Registro reg = new Registro();
                        reg.idPedido = Convert.ToInt32(dr["IDPEDIDO"]);
                        reg.idRelatorio = Convert.ToInt32(dr["IDRELATORIO"]);
                        reg.data = DateTime.Parse(Convert.ToString(dr["DATA"]));
                        reg.hora = DateTime.Parse(Convert.ToString(dr["HORA"]));
                        reg.descricao = Convert.ToString(dr["DESCRICAO"]);
                        retorno.Add(reg);
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
