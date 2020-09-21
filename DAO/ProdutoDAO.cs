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
    class ProdutoDAO
    {

        public List<Produto> listProdutos()
        {
            var retorno = new List<Produto>();
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM PRODUTO";
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var item = new Produto
                        {
                            id = Convert.ToInt32(dr["IDPRODUTO"]),
                            nome = Convert.ToString(dr["NOME"]),
                            preco = Convert.ToDouble(dr["PRECO"]),
                            descricao = Convert.ToString("DESCRICAO"),
                            tamanho = Convert.ToString("TAMANHO"),
                            tipo = Convert.ToString(dr["TIPO"])
                        };
                        retorno.Add(item);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retorno;
        }
            public void InsertProduto(String nome, String descricao, double preco, String tipo, String tamanho)
            {
            SqlCommand cmd = new SqlCommand() ;
            Conexao conexao = new Conexao();


            cmd.CommandText = "INSERT INTO PRODUTO (NOME, DESCRICAO, PRECO, TIPO, TAMANHO) VALUES(@NOME, @DESCRICAO, @PRECO, @TIPO, @TAMANHO)";
                cmd.Parameters.AddWithValue("@NOME", nome);
                cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
                cmd.Parameters.AddWithValue("@PRECO", preco);
                cmd.Parameters.AddWithValue("@TIPO", tipo);
                cmd.Parameters.AddWithValue("@TAMANHO", tamanho);
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
        }
}
