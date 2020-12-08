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
        int X = 0;
        int Y = 0;

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
                return;
            }
            if (string.IsNullOrEmpty(txbQuantidade.Text)){
                MessageBox.Show("O campo quantidade está vazio, verifique e tente novamente!!", "Error", MessageBoxButtons.OK,
        MessageBoxIcon.Error);
                txbQuantidade.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cbxMedida.Text)){
                MessageBox.Show("O campo medida, verifique e tente novamente!!", "Error", MessageBoxButtons.OK,
        MessageBoxIcon.Error);
            }
            else
            {
                var es = new Estoque();
                es.descricao = txbDescricao.Text;
                es.quantidade = Convert.ToDouble(txbQuantidade.Text);
                es.medida = cbxMedida.Text;
                Math.Round(es.quantidade, 1);
                var dao = new EstoqueDAO();
                if (dao.InsertEstoque(es))
                {
                    MessageBox.Show("Item de estoque cadastrado com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txbDescricao.Text = string.Empty;
                txbQuantidade.Text = string.Empty;
                cbxMedida.Text = string.Empty;
            }
        }

        private void txbMedida_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnMinimizar_1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmCadEstoque_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmCadEstoque_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void txbQuantidade_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
