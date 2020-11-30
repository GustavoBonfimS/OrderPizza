using OrderPizza.DAO;
using OrderPizza.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class frmCadEstoque : Form
    {
        private ProdutoDAO produtoDAO = new ProdutoDAO();
        List<Produto> produtos;
        List<Produto> pizza;

        public frmCadEstoque()
        {
            produtos = new List<Produto>();
            InitializeComponent();
            this.produtos = this.produtoDAO.listProdutos();
            pizza = new List<Produto>();
        }
        private void cbPizza_CheckedChanged(object sender, EventArgs e)
        {
            var prod = produtos.Where(item => item.tipo == "Tradicional" || item.tipo == "Doce").ToList();
            if (cbPizza.Checked == true)
            {
                foreach (var item in prod)
                {
                    lbPizzas.Items.Add(item.id + " - " + item.nome + " - " + item.descricao);
                }
            }
            if (cbPizza.Checked == false)
            {
                lbPizzas.Items.Clear();
            }
        }
        private void btnCadEstoque_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbDescricao.Text) ||
                string.IsNullOrEmpty(txbQuantidade.Text) ||
                string.IsNullOrEmpty(txbMedida.Text))
            {
                MessageBox.Show("Um dos campos está vazio, verifique e tente novamente!!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var es = new Estoque();
                es.descricao = txbDescricao.Text;
                es.quantidade = Convert.ToDouble(txbQuantidade.Text);
                es.medida = txbMedida.Text;
                if (Math.Abs(es.quantidade % 1) <= (Double.Epsilon * 100))
                {
                    MessageBox.Show("Represente virgula ao inves de ponto para representar" +
                        "as casas decimais!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbQuantidade.Focus();
                    return;
                }


                this.pizza.ForEach(item =>
                {
                    var obj = new Pizza();
                    obj.id = item.id;
                    var atual = item.id.ToString();
                    obj.quantidade = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Informe a Quantidade de ingredientes usada na pizza de número:"+ atual,
                         "Inf Pizza", "*", 150, 150));
                    es.pizzas.Add(obj);
                });





                var dao = new EstoqueDAO();
                if (dao.InsertEstoque(es))
                {
                    MessageBox.Show("Item de estoque cadastrado com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void lbPizzas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                var id = lbPizzas.Items[e.Index].ToString().Split('-')[0].Trim();
                if (lbPizzas.GetItemCheckState(e.Index) == CheckState.Unchecked)
                {
                    // foi marcado agora
                    pizza.Add(this.produtos.Where(p => p.id == Convert.ToInt32(id)).ToArray()[0]);
                }

                if (lbPizzas.GetItemCheckState(e.Index) == CheckState.Checked)
                {
                    // foi desmarcado agora
                    pizza.Remove(this.produtos.Where(p => p.id == Convert.ToInt32(id)).ToArray()[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
