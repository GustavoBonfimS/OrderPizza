using OrderPizza.DAO;
using OrderPizza.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace OrderPizza
{
    public partial class frmCardapio : Form
    {
        private ProdutoDAO produtoDAO = new ProdutoDAO();
        List<Produto> produtos;
        ObservableCollection<Produto> carrinho;
        int X = 0;
        int Y = 0;

        public frmCardapio()
        {
            //this.Icon = new Icon("pizza.ico");
            InitializeComponent();

            produtos = new List<Produto>();
            carrinho = new ObservableCollection<Produto>();
            this.produtos = this.produtoDAO.listProdutos();
            cbPesquisar.DropDownStyle = ComboBoxStyle.DropDown;
            cbPesquisar.DataSource = produtos.Select(prod => prod.nome).ToArray();
            cbPesquisar.SelectedItem = null;

            carrinho.CollectionChanged += carrinho_CollectionChanged;
        }

        private void frmCardapio_Load(object sender, EventArgs e)
        {
            setProdutos();
            cbPesquisar.TextChanged += CbPesquisar_TextChanged;
        }

        private void CbPesquisar_TextChanged(object sender, EventArgs e)
        {
            var txt = cbPesquisar.Text;
            var prod = produtos.Where(item => item.nome == txt).ToArray();
            if (prod.Length == 1)
            {
                markItemChecked(prod[0]);
                cbPesquisar.Text = null;
                cbPesquisar.Focus();
            }
        }

        private void carrinho_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            double valorTotal = 0;
            foreach (var item in carrinho)
            {
                valorTotal += item.preco;
            }
            lbTotal.Text = valorTotal.ToString("N2");
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (carrinho.Count < 1)
            {
                MessageBox.Show("Selecione um produto antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new frmInfoCliente(carrinho).Show();
            this.Hide();
        }

        private void checkedPizzas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.SetItemsCheckOnCarrinho(checkedPizzas, e);
        }

        private void checkedDoces_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.SetItemsCheckOnCarrinho(checkedDoces, e);
        }

        private void checkedBebidas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.SetItemsCheckOnCarrinho(checkedBebidas, e);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void setProdutos()
        {
            checkedPizzas.Items.Clear();
            checkedDoces.Items.Clear();
            checkedBebidas.Items.Clear();
            foreach (var item in produtos)
            {
                switch (item.tipo.ToLower())
                {
                    case "tradicional":
                        checkedPizzas.Items.Add(item.nome + " : " + item.tamanho);
                        break;
                    case "doce":
                        checkedDoces.Items.Add(item.nome + " : " + item.tamanho);
                        break;
                    case "bebida":
                        checkedBebidas.Items.Add(item.nome + " : " + item.tamanho);
                        break;
                }
            }
        }

        private void btnBackdoor_Click(object sender, EventArgs e)
        {
            new frmCadastro().Show();
        }


        private void SetItemsCheckOnCarrinho(CheckedListBox list, ItemCheckEventArgs e)
        {
            try
            {
                var nome = list.Items[e.Index].ToString().Split(':')[0].Trim();
                if (list.GetItemCheckState(e.Index) == CheckState.Unchecked)
                {
                    // foi marcado agora
                    this.carrinho.Add(this.produtos.Where(prod => prod.nome == nome).ToArray()[0]);
                }

                if (list.GetItemCheckState(e.Index) == CheckState.Checked)
                {
                    // foi desmarcado agora
                    this.carrinho.Remove(this.produtos.Where(prod => prod.nome == nome).ToArray()[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void markItemChecked(Produto prod)
        {
            switch (prod.tipo.ToLower())
            {
                case "tradicional":
                    var index = checkedPizzas.Items.IndexOf(prod.nome + " : " + prod.tamanho);
                    var state = true;
                    if (checkedPizzas.GetItemCheckState(index) == CheckState.Checked)
                    {
                        state = false;
                    }
                    checkedPizzas.SetItemChecked(index, state);
                    break;
                case "doce":
                    var indexDoce = checkedDoces.Items.IndexOf(prod.nome + " : " + prod.tamanho);
                    var stateDoce = true;
                    if (checkedDoces.GetItemCheckState(indexDoce) == CheckState.Checked)
                    {
                        stateDoce = false;
                    }
                    checkedDoces.SetItemChecked(indexDoce, stateDoce);
                    break;
                case "bebida":
                    var indexBebida = checkedBebidas.Items.IndexOf(prod.nome + " : " + prod.tamanho);
                    var stateBebida = true;
                    if (checkedBebidas.GetItemCheckState(indexBebida) == CheckState.Checked)
                    {
                        stateBebida = false;
                    }
                    checkedBebidas.SetItemChecked(indexBebida, stateBebida);
                    break;
            }
        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            new frmFecharCaixa().Show();
        }

        private void frmCardapio_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmCardapio_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
