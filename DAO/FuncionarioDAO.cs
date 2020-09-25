using OrderPizza.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrderPizza.DAO
{
    class FuncionarioDAO
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public FuncionarioDAO()
        {
            cmd.Connection = new Conexao().conectar();
        }
        public bool Logar(string login, string senha)
        {
            bool isValid = false;
            cmd.CommandText = "SELECT * FROM FUNCIONARIO WHERE FUNCIONARIO.LOGIN = @login AND FUNCIONARIO.SENHA = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    isValid = true;
                    while (dr.Read()) // seta o funcionario
                    {
                        Funcionario.id = Convert.ToInt32(dr["idfuncionario"]);
                        Funcionario.login = login;
                        Funcionario.senha = senha;
                        Funcionario.tipo = Convert.ToString(dr["tipo"]);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return isValid;
        }
        public bool InsertUsuario(String login, String senha, String tipo)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            var retorno = false;

            cmd.CommandText = "INSERT INTO FUNCIONARIO(LOGIN, SENHA,TIPO) VALUES(@LOGIN, @SENHA, @TIPO)";
            cmd.Parameters.AddWithValue("@LOGIN", login);
            cmd.Parameters.AddWithValue("@SENHA", senha);
            cmd.Parameters.AddWithValue("@Tipo", tipo);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retorno;
        }

    }
}
