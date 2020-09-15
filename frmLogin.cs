using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Icon = new Icon("pizza.ico");
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txbLogin.LostFocus += TxbLogin_LostFocus;
            txbSenha.LostFocus += TxbSenha_LostFocus;
        }

        private void txbLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (txbLogin.Text == "usuario")
            {
                txbLogin.Text = null;
            }
        }

        private void TxbLogin_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbLogin.Text))
            {
                txbLogin.Text = "usuario";
            }
        }

        private void txbSenha_MouseClick(object sender, MouseEventArgs e)
        {
            if (txbSenha.Text == "senha")
            {
                txbSenha.Text = null;
            }
        }

        private void TxbSenha_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbSenha.Text))
            {
                txbSenha.Text = "senha";
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                // seta o funcionario
                new frmCardapio().Show();
                this.Hide();
            }
        }

        private bool ValidaCampos()
        {
            if (String.IsNullOrEmpty(txbLogin.Text))
            {
                MessageBox.Show("Campo *login orbigatório");
                txbLogin.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbSenha.Text))
            {
                MessageBox.Show("Campo *senha obrigatório");
                txbSenha.Focus();
                return false;
            }
            return true;
        }
    }
}
