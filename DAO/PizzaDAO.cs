using OrderPizza.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OrderPizza.DAO
{
    class PizzaDAO
    {
        public bool InsertPizza(double quantidade, int idestoque, int idproduto)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            var retorno = false;

            cmd.CommandText = "INSERT INTO PIZZA (QUANTIDADE, IDESTOQUE, IDPRODUTO) VALUES(@QUANTIDADE, @IDESTOQUE, @IDPRODUTO)";
            cmd.Parameters.AddWithValue("@QUANTIDADE", quantidade);
            cmd.Parameters.AddWithValue("@IDESTOQUE", idestoque);
            cmd.Parameters.AddWithValue("@IDPRODUTO", idproduto);
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
