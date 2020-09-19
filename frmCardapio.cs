using OrderPizza.DAO;
using OrderPizza.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class frmCardapio : Form
    {
        private ProdutoDAO produtoDAO = new ProdutoDAO();
        public frmCardapio()
        {
            InitializeComponent();
            //this.Icon = new Icon("pizza.ico");
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

        private void frmCardapio_Load(object sender, EventArgs e)
        {
            cbPesquisar.SelectedItem = null;
            setProdutos();
        }

        private void setProdutos()
        {
            List<Produto> produtos = this.produtoDAO.listProdutos();
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
                        checkedBebidaas.Items.Add(item.nome);
                        break;
                }
            }
        }

        private void btnBackdoor_Click(object sender, EventArgs e)
        {
           new frmAdmin().Show();
        }
    }
}
