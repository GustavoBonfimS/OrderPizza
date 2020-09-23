using OrderPizza.DAO;
using OrderPizza.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public frmCardapio()
        {
            this.Icon = new Icon("pizza.ico");
            InitializeComponent();

            produtos = new List<Produto>();
            carrinho = new ObservableCollection<Produto>();
            this.produtos = this.produtoDAO.listProdutos();

            carrinho.CollectionChanged += carrinho_CollectionChanged;
        }

        private void frmCardapio_Load(object sender, EventArgs e)
        {
            cbPesquisar.SelectedItem = null;
            setProdutos();

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
            foreach (var item in carrinho)
            {
                MessageBox.Show(item.nome + item.preco.ToString());
            }
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
            checkedDoces.Items.Clear();
            foreach (var item in produtos)
            {
                switch (item.tipo.ToLower())
                {
                    case "tradicional":
                        checkedPizzas.Items.Add(item.nome);
                        break;
                    case "doce":
                        checkedDoces.Items.Add(item.nome);
                        break;
                    case "bebida":
                        checkedBebidas.Items.Add(item.nome);
                        break;
                }
            }
        }

        private void btnBackdoor_Click(object sender, EventArgs e)
        {
           new frmAdmin().Show();
        }
        
        
        private void SetItemsCheckOnCarrinho(CheckedListBox list, ItemCheckEventArgs e)
        {
            if (list.GetItemCheckState(e.Index) == CheckState.Unchecked)
            {
                // foi marcado agora
                this.carrinho.Add(this.produtos.Where(prod => prod.nome == list.Items[e.Index].ToString()).ToArray()[0]);
            }

            if (list.GetItemCheckState(e.Index) == CheckState.Checked)
            {
                // foi desmarcado agora
                this.carrinho.Remove(this.produtos.Where(prod => prod.nome == list.Items[e.Index].ToString()).ToArray()[0]);
            }
        }
    }
}
