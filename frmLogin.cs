using System;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

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
