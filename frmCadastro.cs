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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String nome;
            String descricao;
            double preco;
            String tipo;
            String tamanho;
            if (String.IsNullOrEmpty(txbDescricao.Text) ||
                String.IsNullOrEmpty(txbNome.Text) ||
                String.IsNullOrEmpty(txbPreco.Text) ||
                String.IsNullOrEmpty(txbTamanho.Text) ||
                String.IsNullOrEmpty(txbTipo.Text))
            {
                MessageBox.Show("Um dos Campos exigidos está vazio!!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                nome = txbNome.Text;
                descricao = txbDescricao.Text;
                preco = Convert.ToDouble(txbPreco.Text);
                tipo = txbTipo.Text;
                tamanho = txbTamanho.Text;
                var dao = new ProdutoDAO();

                if (Math.Abs(preco % 1) <= (Double.Epsilon * 100))
                {
                    MessageBox.Show("Represente virgula ao inves de ponto para representar" +
                        "as casas decimais!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbTipo.Focus();
                    return;
                }

                if (dao.InsertProduto(nome, descricao, preco, tipo, tamanho))
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            string login;
            string senha;
            string tipo;

            if (string.IsNullOrEmpty(txbLogin.Text) ||
                string.IsNullOrEmpty(txbSenha.Text) ||
                string.IsNullOrEmpty(txbTipoUsu.Text))
            {
                MessageBox.Show("Um dos campos está vazio, verifique e tente novamente!!","Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                login = txbLogin.Text;
                senha = txbSenha.Text;
                tipo = txbTipoUsu.Text;
                var dao = new FuncionarioDAO();
               if(dao.InsertUsuario(login, senha, tipo))
                {
                    MessageBox.Show("Usuario cadastrado com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
    }
}
