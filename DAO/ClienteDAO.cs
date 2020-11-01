using OrderPizza.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OrderPizza.DAO
{
    class ClienteDAO
    {
        SqlCommand cmd;
        SqlDataReader dr;

        public ClienteDAO()
        {
            this.cmd = new SqlCommand();
        }

        public List<Cliente> getCliente(string numero)
        {
            var retorno = new List<Cliente>();

            cmd.CommandText = "SELECT * FROM CLIENTE WHERE TELEFONE = " + numero.ToString();

            try
            {
                cmd.Connection = new Conexao().conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var client = new Cliente();
                        client.id = Convert.ToInt32(dr["IDCLIENTE"]);
                        client.endereco = Convert.ToString(dr["ENDERECO"]);
                        client.telefone = Convert.ToString(dr["TELEFONE"]);
                        client.nome = Convert.ToString(dr["NOME"]);
                        retorno.Add(client);
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

        public async void insertCliente(Cliente cliente)
        {
            cmd.CommandText = "INSERT INTO CLIENTE(NOME, TELEFONE, ENDERECO) VALUES(@NOME, @TELEFONE, @ENDERECO)";
            cmd.Parameters.AddWithValue("@NOME", cliente.nome);
            cmd.Parameters.AddWithValue("@TELEFONE", cliente.telefone);
            cmd.Parameters.AddWithValue("@ENDERECO", cliente.endereco);
            try
            {
                cmd.Connection = new Conexao().conectar();
                await cmd.ExecuteNonQueryAsync();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
