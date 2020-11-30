using OrderPizza.Relatorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            new frmCadastro().Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            new frmOption().Show();
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            var estoque = new frmCadEstoque();
            estoque.Show();
        }

        private void btncCadastroProd_Click(object sender, EventArgs e)
        {
            new frmCadProduto().Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
