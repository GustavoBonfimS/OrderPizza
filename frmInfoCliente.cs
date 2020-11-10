using OrderPizza.DAO;
using OrderPizza.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class frmInfoCliente : Form
    {
        private ClienteDAO dao = new ClienteDAO();
        private List<Cliente> clientes;
        private ObservableCollection<Produto> carrinho;
        double valorTotal = 0;

        public frmInfoCliente(ObservableCollection<Produto> _carrinho)
        {
            InitializeComponent();
            this.carrinho = _carrinho;
            this.lbResultado.Hide();

            foreach (var item in carrinho)
            {
                valorTotal += item.preco;
            }
            lblValor.Text = valorTotal.ToString("N2");
        }

        private void txbTelefone_TextChanged(object sender, EventArgs e)
        {
            var txt = txbTelefone.Text;
            if (txt.Length == 9)
            {
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
            //
            var index = lbResultado.SelectedIndex;
            txbEndereco.Text = this.clientes[index].endereco;
            txbTelefone.Text = this.clientes[index].telefone;
            txbNome.Text = this.clientes[index].nome;
        }

        private void frmInfoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                registraPedido();
                // subtrai do estoque

                if (this.clientes.Count == 0)
                {
                    var newClient = new Cliente
                    {
                        telefone = txbTelefone.Text,
                        endereco = txbEndereco.Text,
                        nome = txbNome.Text
                    };
                    await dao.insertCliente(newClient);
                }
                
                new frmCardapio().Show();
                this.Hide();
            }
        }

        private async void registraPedido()
        {
            var pedidoDAO = new PedidoDAO();
            var pedido = new Pedido
            {
                formaPagamento = txbPagamento.Text,
                valor = valorTotal,
                idCliente = this.clientes[lbResultado.SelectedIndex].id,
                produtos = carrinho.ToList()
            };

            await pedidoDAO.insertPedido(pedido);
            // registra na tabela de relatorio dentro de PedidoDAO
            // subtrair no estoque
        }

        private bool validaCampos()
        {
            if (String.IsNullOrEmpty(txbTelefone.Text))
            {
                MessageBox.Show("Campo *telefone obrigatório", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbTelefone.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbEndereco.Text))
            {
                MessageBox.Show("Campo *endereco obrigatório");
                txbEndereco.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txbPagamento.Text))
            {
                MessageBox.Show("Campo *forma de pagamnto obrigatório");
                txbPagamento.Focus();
                return false;
            }
            return true;
        }

    }
}
