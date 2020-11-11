using OrderPizza.DAO;
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
            cbxTipo.Items.Add("Tradicional");
            cbxTipo.Items.Add("Doces");
            cbxTipo.Items.Add("Bebidas");
            cbxTamanho.Items.Add("Família");
            cbxTamanho.Items.Add("Normal");
            cbxTamanho.Items.Add("250ml");

        }

        private void btncCadProd_Click(object sender, EventArgs e)
        {
            // O tamnho e tipo eram text box porém agora são combobox, necessário mudar a lógica da progrmação as"//" indcam onde são delcaradas

            String nome;
            String descricao;
            double preco;
            String tipo;
            String tamanho;

          
            if (String.IsNullOrEmpty(txbDescricao.Text) ||
                String.IsNullOrEmpty(txbNome.Text) ||
                String.IsNullOrEmpty(txbPreco.Text) ||
                String.IsNullOrEmpty(cbxTipo.Text) ||
                String.IsNullOrEmpty(cbxTamanho.Text))
                
            {
                MessageBox.Show("Um dos Campos exigidos está vazio!!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                nome = txbNome.Text;
                descricao = txbDescricao.Text;
                preco = Convert.ToDouble(txbPreco.Text);
                tipo = cbxTipo.Text;
                tamanho = cbxTamanho.Text;
                var dao = new ProdutoDAO();

                if (Math.Abs(preco % 1) <= (Double.Epsilon * 100))
                {
                    MessageBox.Show("Represente virgula ao inves de ponto para representar" +
                        "as casas decimais!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                       cbxTipo.Focus();
                    return;
                }

                if (dao.InsertProduto(nome, descricao, preco, tipo, tamanho))
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
