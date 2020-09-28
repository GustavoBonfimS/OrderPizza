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
                            quantidade = Convert.ToDouble(dr["QUANTIDADE"]),
                        };
                        retorno.Add(itens);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retorno;
        }
        public bool InsertEstoque(String descricao, double quantidade)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            var retorno = false;

            cmd.CommandText = "INSERT INTO PRODUTO (DESCRICAO, QUANTIDADE) VALUES(@DESCRICAO, @QUANTIDADE)";
            cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
            cmd.Parameters.AddWithValue("@QUANTIDADE", quantidade);
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
