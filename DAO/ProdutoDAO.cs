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
        SqlCommand cmd;
        SqlDataReader dr;
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
                            tamanho = Convert.ToString(dr["TAMANHO"]),
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
        public bool InsertProduto(Produto produto)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            var retorno = false;

            cmd.CommandText = "INSERT INTO PRODUTO (NOME, DESCRICAO, PRECO, TIPO, TAMANHO) VALUES (@NOME, @DESCRICAO, @PRECO, @TIPO, @TAMANHO)";
            cmd.Parameters.AddWithValue("@NOME", produto.nome);
            cmd.Parameters.AddWithValue("@DESCRICAO", produto.descricao);
            cmd.Parameters.AddWithValue("@PRECO", produto.preco);
            cmd.Parameters.AddWithValue("@TIPO", produto.tipo);
            cmd.Parameters.AddWithValue("@TAMANHO", produto.tamanho);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                InsertOnPizza(produto);
                retorno = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return retorno;
        }
        public bool InsertOnPizza(Produto produto)
        {
            var retorno = false;
            produto.pizzas.ForEach(prod =>
            {
                // gambiarra necessaria
                // declarando variaveis com parameter.addWithValues gera um erro de variavel ja alocada
                cmd.CommandText = "INSERT INTO PIZZA(IDPRODUTO, IDESTOQUE, QUANTIDADE) VALUES" +
            "((SELECT IDPRODUTO FROM PRODUTO WHERE DESCRICAO = @DESCRICAO)," + prod.idEstoque.ToString() + "," + prod.quantidade.ToString() + ")";
                try
                {
                    cmd.ExecuteNonQuery();
                    retorno = true;
                    cmd.Dispose();
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
