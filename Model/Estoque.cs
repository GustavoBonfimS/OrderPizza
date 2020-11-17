using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPizza.Model
{
    public class Estoque
    {
        public int id;
        public string descricao;
        public double quantidade;
        public string medida;
        public List<Pizza> pizzas;

        public Estoque()
        {
            pizzas = new List<Pizza>();
        }
     }
}
