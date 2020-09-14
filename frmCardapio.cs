using System;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class frmCardapio : Form
    {
        private string[] arrProdutos =
        {
            "mussarela", "queijo", "calabresa", "frango c/ catupiry"
        };
        public frmCardapio()
        {
            InitializeComponent();
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
            cbPesquisar.DataSource = arrProdutos;
        }
    }
}
