using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPizza.Model
{
    public class Pedido
    {
        public int id;
        public int idFuncionario;
        public double valor;
        public int idCliente;
        public DateTime data;
        public DateTime hora;
        public string formaPagamento;
        public List<Produto> produtos;
    }
}
