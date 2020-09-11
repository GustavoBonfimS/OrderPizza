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
            this.cmd.Connection = Conexao.con;
        }
        public bool Logar(string login, string senha)
        {
            bool isValid = false;
            cmd.CommandText = "SELECT * FROM USUARIO WHERE USUARIO.LOGIN = @login AND USUARIO.SENHA = @senha";
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
                        Funcionario.id = Convert.ToInt32(dr["id"]);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return isValid;
        }
        public void insertUsuario(String login, String senha, String email, String cpf, String tipo)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO USUARIO (LOGIN, SENHA, CPF, EMAIL, TIPO, COMISSAO) VALUES(@LOGIN, @SENHA, @CPF, @EMAIL, @TIPO, @COMISSAO)";
            cmd.Parameters.AddWithValue("@LOGIN", login);
            cmd.Parameters.AddWithValue("@SENHA", senha);
            cmd.Parameters.AddWithValue("@CPF", cpf);
            cmd.Parameters.AddWithValue("@EMAIL", email);
            cmd.Parameters.AddWithValue("@TIPO", tipo);
            cmd.Parameters.AddWithValue("@COMISSAO", 0);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
