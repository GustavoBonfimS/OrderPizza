using OrderPizza.DAO;
using OrderPizza.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class frmInfoCliente : Form
    {
        private ClienteDAO dao = new ClienteDAO();
        private List<Cliente> clientes;
        private ObservableCollection<Produto> carrinho;
        private double valorTotal = 0;
        int X = 0;
        int Y = 0;

        public frmInfoCliente(ObservableCollection<Produto> _carrinho)
        {
            InitializeComponent();
            this.carrinho = _carrinho;
            this.lbResultado.Hide();
            lblTroco.Hide();
            lblValorTroco.Hide();
            this.txbDinheiro.LostFocus += TxbDinheiro_LostFocus;
            this.txbCartao.LostFocus += TxbCartao_LostFocus;

            foreach (var item in carrinho)
            {
                valorTotal += item.preco;
            }
            lblValor.Text = valorTotal.ToString("C2");
        }

        private void txbTelefone_TextChanged(object sender, EventArgs e)
        {
            var txt = txbTelefone.Text;
            if (txt.Length == 9)
            {
                lbResultado.Items.Clear();
                this.clientes = getClient(txt);
            }
        }

        private List<Cliente> getClient(string number)
        {
            var cliente = this.dao.getCliente(number);
            lbResultado.Show();
            if (cliente.Count == 0)
            {
                lbResultado.Items.Add("Nenhum cliente encontrado com esse numero.");
                lbResultado.Items.Add("");
                lbResultado.Items.Add("Preencha o restante das informações do cliente para ser cadastrdo ao finalizar.");
            }
            else
            {
                cliente.ForEach(item =>
                {
                    lbResultado.Items.Add(item.endereco + " - " + item.telefone + " - " + item.nome);
                });
            }

            return cliente;
        }

        private void lbResultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = 0;
            if (lbResultado.SelectedIndex < 0)
            {
                lbResultado.SelectedIndex = 0;
            }
            index = lbResultado.SelectedIndex;
            txbEndereco.Text = this.clientes[index]?.endereco;
            txbTelefone.Text = this.clientes[index]?.telefone;
            txbNome.Text = this.clientes[index]?.nome;
        }

        private void frmInfoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                if (this.clientes.Count == 0)
                {
                    var newClient = new Cliente
                    {
                        telefone = txbTelefone.Text,
                        endereco = txbEndereco.Text,
                        nome = txbNome.Text
                    };
                    dao.insertCliente(newClient);
                }

                registraPedido();
                subtrairEstoque();

                MessageBox.Show("Pedido finalizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new frmCardapio().Show();
                this.Dispose();
            }
        }

        private void subtrairEstoque()
        {
            var estoqueDAO = new EstoqueDAO();
            var prods = carrinho.ToList();
            estoqueDAO.SelectProdQtdIngredientes(prods);
            
        }

        private void registraPedido()
        {
            var pagamento = "";
            if (!string.IsNullOrEmpty(txbDinheiro.Text))
            {
                pagamento += "dinheiro: " + txbDinheiro.Text;
            }
            if (!string.IsNullOrWhiteSpace(txbCartao.Text))
            {
                pagamento += "cartão: " + txbCartao.Text;
            }
            if (!string.IsNullOrWhiteSpace(txbCartao.Text) && !string.IsNullOrWhiteSpace(txbDinheiro.Text))
            {
                pagamento = "dinheiro: " + txbDinheiro.Text + ", cartão: " + txbCartao.Text;
            }

            var pedidoDAO = new PedidoDAO();
            var pedido = new Pedido
            {
                formaPagamento = pagamento,
                valor = valorTotal,
                idFuncionario = Funcionario.id,
                produtos = carrinho.ToList()
            };

            pedidoDAO.insertPedido(pedido, txbNome.Text);
            // registra na tabela de relatorio dentro de PedidoDAO
            // subtrair no estoque
        }

        private bool validaCampos()
        {
            if (string.IsNullOrEmpty(txbTelefone.Text))
            {
                MessageBox.Show("Campo *telefone obrigatório", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbTelefone.Focus();
                return false;
            }
            if (txbTelefone.Text.Length > 11)
            {
                MessageBox.Show("Campo *telefone não pode ter mais que 11 digitos", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbTelefone.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbEndereco.Text))
            {
                MessageBox.Show("Campo *endereco obrigatório");
                txbEndereco.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbDinheiro.Text) && string.IsNullOrEmpty(txbCartao.Text))
            {
                MessageBox.Show("Informe uma forma de pagamento");
                txbDinheiro.Focus();
                return false;
            }

            if ((Convert.ToDouble(txbDinheiro.Text) + Convert.ToDouble(txbCartao.Text)) < Convert.ToDouble(valorTotal.ToString("N2")))
            {
                MessageBox.Show("O valor informado nas formas de pagamento é inferiror ao valor total");
                txbDinheiro.Focus();
                return false;
            }

           return true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbValorTotal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbDinheiro_MouseClick(object sender, MouseEventArgs e)
        {
            if (txbDinheiro.Text == "0")
            {
                txbDinheiro.Text = string.Empty;
            }
        }

        private void TxbDinheiro_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbDinheiro.Text))
            {
                txbDinheiro.Text = "0";
            }

            if (Convert.ToDouble(txbDinheiro.Text) + Convert.ToDouble(txbCartao.Text) > valorTotal)
            {
                var troco = (Convert.ToDouble(txbDinheiro.Text) + Convert.ToDouble(txbCartao.Text)) - (Convert.ToDouble(valorTotal.ToString("N2")));
                lblValorTroco.Text = troco.ToString("C2");
                lblTroco.Show();
                lblValorTroco.Show();
            }
            else
            {
                lblTroco.Hide();
                lblValorTroco.Hide();
            }
        }

        private void txbCartao_MouseClick(object sender, MouseEventArgs e)
        {
            if (txbCartao.Text == "0")
            {
                txbCartao.Text = string.Empty;
            }
        }

        private void TxbCartao_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbCartao.Text))
            {
                txbCartao.Text = "0";
            }

            if (Convert.ToDouble(txbDinheiro.Text) + Convert.ToDouble(txbCartao.Text) > valorTotal)
            {
                var troco = (Convert.ToDouble(txbDinheiro.Text) + Convert.ToDouble(txbCartao.Text)) - (Convert.ToDouble(valorTotal.ToString("N2")));
                lblValorTroco.Text = troco.ToString("C2");
                lblTroco.Show();
                lblValorTroco.Show();
            }
            else
            {
                lblTroco.Hide();
                lblValorTroco.Hide();
            }
        }

        private void txbTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo só aceita números, por favor verifique oque esta sendo digitado", "Aviso"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }

        private void frmInfoCliente_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmInfoCliente_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCardapio().Show();
        }
    }
    
}
