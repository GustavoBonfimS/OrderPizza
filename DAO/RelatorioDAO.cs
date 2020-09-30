using OrderPizza.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

namespace OrderPizza.DAO
{
    class RelatorioDAO
    {
        public static void inserirRegistro(int idPedido, string descricao)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();

            cmd.CommandText = "INSERT INTO RELATORIO (IDPEDIDO, DESCRICAO, DATA, HORA)" +
                "VALUES(@IDPEDIDO, @DESCRICAO, @DATA, @HORA)";
            cmd.Parameters.AddWithValue("@IDPEDIDO", descricao);
            cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
            cmd.Parameters.AddWithValue("@DATA", (DateTime.Now).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@HORA", DateTime.Now.ToString("HH:mm"));
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static List<Registro> gerarRelatorio(string buscarPor, int id)
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
                    cmd.CommandText = "SELECT * FROM RELATORIO WHERE IDPEDIDO = " +
                        "(SELECT IDPEDIDO FROM PEDIDO WHERE PEDIDO.IDCLIENTE = @ID)";
                    cmd.Parameters.AddWithValue("@ID", id);
                    break;
                case "pedido":
                    cmd.CommandText = "SELECT * FROM RELATORIO WHERE IDPEDIDO = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
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
