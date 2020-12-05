using OrderPizza.DAO;
using OrderPizza.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class frmCadEstoque : Form
    {
        private ProdutoDAO produtoDAO = new ProdutoDAO();

        public frmCadEstoque()
        {
            InitializeComponent();
        }
        
        private void btnCadEstoque_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbDescricao.Text)){
                MessageBox.Show("O campo descrição está vazio, verifique e tente novamente!!", "Error", MessageBoxButtons.OK,
        MessageBoxIcon.Error);
                txbDescricao.Focus();
            }
            if (string.IsNullOrEmpty(txbQuantidade.Text)){
                MessageBox.Show("O campo quantidade está vazio, verifique e tente novamente!!", "Error", MessageBoxButtons.OK,
        MessageBoxIcon.Error);
                txbQuantidade.Focus();
            }
            if (string.IsNullOrEmpty(txbMedida.Text)){
                MessageBox.Show("O campo medida, verifique e tente novamente!!", "Error", MessageBoxButtons.OK,
        MessageBoxIcon.Error);
            }
     
            else
            {
                var es = new Estoque();
                es.descricao = txbDescricao.Text;
                es.quantidade = Convert.ToDouble(txbQuantidade.Text);
                es.medida = txbMedida.Text;
                if (Math.Abs(es.quantidade % 1) <= (Double.Epsilon * 100))
                {
                    MessageBox.Show("Represente virgula ao inves de ponto para representar" +
                        "as casas decimais!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbQuantidade.Focus();
                    return;
                }

                var dao = new EstoqueDAO();
                if (dao.InsertEstoque(es))
                {
                    MessageBox.Show("Item de estoque cadastrado com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void txbMedida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo só aceita números e vírgulas, por favor verifique oque esta sendo digitado", "Aviso"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }

        private void btnMinimizar_1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
