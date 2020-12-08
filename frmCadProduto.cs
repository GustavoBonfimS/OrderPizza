using OrderPizza.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderPizza.Model;

namespace OrderPizza
{
    public partial class frmCadProduto : Form
    {
        private EstoqueDAO estoqueDAO = new EstoqueDAO();
        List<Estoque> ingredientes;
        List<Estoque> pizza;
        int X = 0;
        int Y = 0;
        public frmCadProduto()
        {
            ingredientes = new List<Estoque>();
            InitializeComponent();
            this.ingredientes = this.estoqueDAO.listEstoque();
            cbIngrediente.Hide();
            pizza = new List<Estoque>();

        }

        private void btnMinimizar_1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmCadProduto_Load(object sender, EventArgs e)
        {
        }

        private void btncCadProd_Click(object sender, EventArgs e)
        {
            // O tamnho e tipo eram text box porém agora são combobox, necessário mudar a lógica da progrmação as"//" indcam onde são delcaradas

            if (String.IsNullOrEmpty(txbDescricao.Text))
            {
                MessageBox.Show("O campo descrição está vazio, verifique e tente novamente!!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txbDescricao.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txbNome.Text))
            {
                MessageBox.Show("O campo nome está vazio, verifique e tente novamente!!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txbNome.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txbPreco.Text))
            {
                MessageBox.Show("O campo preço está vazio, verifique e tente novamente!!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txbPreco.Focus();
            }
            if (String.IsNullOrEmpty(cbxTipo.Text))
            {
                MessageBox.Show("O campo tipo está vazio, verifique e tente novamente!!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cbxTipo.Focus();
                return;
            }
            if (String.IsNullOrEmpty(cbxTamanho.Text))
            {
                MessageBox.Show("O campo tamanho está vazio, verifique e tente novamente!!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cbxTamanho.Focus();
                return;
            }
            else
            {
                var pr = new Produto
                {
                    nome = txbNome.Text,
                    descricao = txbDescricao.Text,
                    preco = Convert.ToDouble(txbPreco.Text),
                    tipo = cbxTipo.Text,
                    tamanho = cbxTamanho.Text
                };
                var dao = new ProdutoDAO();

                if (pr.tipo.ToLower() == "bebida")
                {
                    var qtd = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Quantas unidades está inserindo?",
                         "Cadastro de bebida", "1", 150, 150));

                    var est = new Estoque();
                    est.descricao = pr.nome;
                    est.medida = "Unidade(Un)";
                    est.quantidade = qtd;
                    estoqueDAO.InsertEstoque(est);
                    this.ingredientes = this.estoqueDAO.listEstoque();
                    var item = this.ingredientes.Where(esto => esto.descricao.ToLower() == est.descricao.ToLower()).ToList()[0];

                    var pizzaObj = new Pizza();
                    pizzaObj.idEstoque = item.id;
                    // 1 pra subtrair ao vender
                    pizzaObj.quantidade = 1;
                    pr.pizzas.Add(pizzaObj);

                }
                else
                {
                    this.pizza.ForEach(item =>
                    {
                        var obj = new Pizza();
                        obj.idEstoque = item.id;
                        var atual = item.descricao.ToString();
                        obj.quantidade = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Qual a quantidade de " + atual + " usada nesta pizza?",
                             "Inf Ingrediente", "*", 150, 150));
                        pr.pizzas.Add(obj);
                    });
                }
                if (dao.InsertProduto(pr))
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cbPizza_CheckedChanged(object sender, EventArgs e)
        {
            var prod = ingredientes;
            if (cbPizza.Checked == true)
            {
                cbIngrediente.Show();
                foreach (var item in prod)
                {
                    cbIngrediente.Items.Add(item.id + " - " + item.descricao + " - " + item.quantidade + " - " + item.medida);
                }
            }
            if (cbPizza.Checked == false)
            {
                cbIngrediente.Items.Clear();
                cbIngrediente.Hide();
            }
        }

        private void cbIngrediente_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                var id = cbIngrediente.Items[e.Index].ToString().Split('-')[0].Trim();
                if (cbIngrediente.GetItemCheckState(e.Index) == CheckState.Unchecked)
                {
                    // foi marcado agora
                    pizza.Add(this.ingredientes.Where(p => p.id == Convert.ToInt32(id)).ToArray()[0]);
                }

                if (cbIngrediente.GetItemCheckState(e.Index) == CheckState.Checked)
                {
                    // foi desmarcado agora
                    pizza.Remove(this.ingredientes.Where(p => p.id == Convert.ToInt32(id)).ToArray()[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo só aceita números e vírgulas, por favor verifique oque esta sendo digitado", "Aviso"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }

        private void frmCadProduto_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmCadProduto_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
