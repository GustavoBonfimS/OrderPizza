﻿using OrderPizza.Model;
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
            Conexao conexao = new Conexao();

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
                InsertOnPizza(estoque);
                retorno = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return retorno;
        }

        public bool InsertOnPizza(Estoque estoque)
        {
            var retorno = false;
            estoque.pizzas.ForEach(prod =>
            {
                MessageBox.Show(prod.quantidade.ToString());
                // gambiarra necessaria
                // declarando variaveis com parameter.addWithValues gera um erro de variavel ja alocada
                cmd.CommandText = "INSERT INTO PIZZA(IDESTOQUE, IDPRODUTO, QUANTIDADE) VALUES" +
                "((SELECT IDESTOQUE FROM ESTOQUE WHERE DESCRICAO = @DESCRICAO)," + prod.id.ToString() + "," + prod.quantidade.ToString()+")";

                try
                {
                    cmd.ExecuteNonQuery();
                    retorno = true;
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
