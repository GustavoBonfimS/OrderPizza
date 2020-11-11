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
    public partial class frmCadProduto : Form
    {
        public frmCadProduto()
        {
            InitializeComponent();
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
    }
}
