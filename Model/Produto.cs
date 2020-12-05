using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPizza.Model
{
    public class Produto
    {
        public int id;
        public string nome;
        public string descricao;
        public double preco;
        public string tipo;
        public string tamanho;
        public List<Pizza> pizzas;

        public Produto()
        {
           pizzas = new List<Pizza>();
        }
    }

}
