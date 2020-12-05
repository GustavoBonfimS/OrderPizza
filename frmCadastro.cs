using OrderPizza.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OrderPizza
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }
        private void btnCadFunc_Click_Click(object sender, EventArgs e)
        {
            string login;
            string senha;
            string tipo;

            if (string.IsNullOrEmpty(txbLogin.Text){
                MessageBox.Show("O campo login está vazio, verifique e tente novamente!!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txbLogin.Focus();
            }
            if (string.IsNullOrEmpty(txbSenha.Text)) {
                MessageBox.Show("O campo senha está vazio, verifique e tente novamente!!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txbSenha.Focus();
            } 
            else
            {
                login = txbLogin.Text;
                senha = txbSenha.Text;
                tipo = cbxTipoUsu.Text;
                var dao = new FuncionarioDAO();
                if (dao.InsertUsuario(login, senha, tipo))
                {
                    MessageBox.Show("Usuario cadastrado com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
