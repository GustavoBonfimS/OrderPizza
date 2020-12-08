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
    class EstoqueDAO
    {
        SqlCommand cmd;
        SqlDataReader dr;

        public EstoqueDAO()
        {
           cmd = new SqlCommand();
        }
        public List<Estoque> listEstoque()
        {
            var retorno = new List<Estoque>();
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM ESTOQUE";
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var itens = new Estoque
                        {
                            id = Convert.ToInt32(dr["IDESTOQUE"]),
                            descricao = Convert.ToString(dr["DESCRICAO"]),
                            medida = Convert.ToString(dr["MEDIDA"]),
                            quantidade = Convert.ToDouble(dr["QUANTIDADE"]),
                        };
                        retorno.Add(itens);
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
        public bool InsertEstoque(Estoque estoque)
        {
            Conexao conexao = new Conexao();
            var retorno = false;

            cmd.CommandText = "INSERT INTO ESTOQUE(DESCRICAO, QUANTIDADE, MEDIDA) VALUES(@DESCRICAO, @QUANTIDADE, @MEDIDA)";
            cmd.Parameters.AddWithValue("@DESCRICAO", estoque.descricao);
            cmd.Parameters.AddWithValue("@QUANTIDADE", estoque.quantidade);
            cmd.Parameters.AddWithValue("@MEDIDA", estoque.medida);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                retorno = true;
                cmd.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return retorno;
        }
        public void SelectProdQtdIngredientes(List<Produto> prods)
        {
            cmd.Connection = new Conexao().conectar();
            prods.ForEach(prod =>
            {
                cmd.CommandText = "SELECT * FROM PIZZA WHERE IDPRODUTO = @IDPRODUTO";
                cmd.Parameters.AddWithValue("@IDPRODUTO", prod.id);
                try
                {
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            var item = new Pizza
                            {
                                id = Convert.ToInt32(dr["IDPIZZA"]),
                                idEstoque = Convert.ToInt32(dr["IDESTOQUE"]),
                                idProduto = Convert.ToInt32(dr["IDPRODUTO"]),
                                quantidade = Convert.ToInt32(dr["QUANTIDADE"])
                            };
                            subtrairEstoque(item);
                        }
                    }
                    cmd.Dispose();
                    dr.Close();
                    cmd.Parameters.Clear();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        public void subtrairEstoque(Pizza pizza)
        {
            cmd = new SqlCommand();
            cmd.Connection = new Conexao().conectar();
            cmd.CommandText = "UPDATE ESTOQUE SET QUANTIDADE = " +
                "(SELECT QUANTIDADE FROM ESTOQUE WHERE IDESTOQUE = @IDESTOQUE) - @QTD WHERE IDESTOQUE = @IDESTOQUE";
            cmd.Parameters.AddWithValue("@IDESTOQUE", pizza.idEstoque);
            cmd.Parameters.AddWithValue("@QTD", pizza.quantidade);
            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public bool UpdateEstoque(Estoque estoque)
        {
            var retorno = false;
            Conexao conexao = new Conexao();
            cmd.CommandText = "UPDATE ESTOQUE SET QUANTIDADE = @QUANTIDADE WHERE IDESTOQUE = @IDESTOQUE";
            cmd.Parameters.AddWithValue("@IDESTOQUE", estoque.id);
            cmd.Parameters.AddWithValue("@QUANTIDADE", estoque.quantidade);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch(SqlException ex)
            {
                retorno = false;
                MessageBox.Show(ex.Message);
            }
            return retorno;
        }
        public bool DeleteEstoque(Estoque estoque)
        {
            var retorno = false;
            Conexao conexao = new Conexao();
            cmd.CommandText = "DELETE FROM ESTOQUE WHERE ESTOQUE.IDESTOQUE = @IDESTOQUE ";
            cmd.Parameters.AddWithValue("@IDESTOQUE", estoque.id);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (SqlException ex)
            {
                retorno = false;
                MessageBox.Show(ex.Message);
            }
            return retorno;
        }

    }
}
