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
    }
}
