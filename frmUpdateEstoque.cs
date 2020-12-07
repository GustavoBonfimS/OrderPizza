﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderPizza.DAO;
using OrderPizza.Model;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class frmUpdateEstoque : Form
    {
        private EstoqueDAO estoqueDAO = new EstoqueDAO();
        List<Estoque> estoque;
        int X = 0;
        int Y = 0;

        public frmUpdateEstoque()
        {
            estoque = new List<Estoque>();
            InitializeComponent();
            this.estoque = this.estoqueDAO.listEstoque();
        }

        private void frmUpdateEstoque_Load(object sender, EventArgs e)
        {
         
                lbEstoque.Show();
                foreach (var item in estoque)
                {
                    lbEstoque.Items.Add(item.descricao + " - " + item.quantidade + " " +item.medida);
                }
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (lbEstoque.CheckedItems.Count > 0)
            {
                var nome = lbEstoque.CheckedItems[0].ToString().Split('-')[0].Trim();
                var est = estoque.Where(es => es.descricao == nome).ToArray()[0];
                var dao = new EstoqueDAO();
                var quanti = Convert.ToDouble(txbQuantidade.Text);

                if (cbxMedida.Equals("Grama(G)"))
                {
                    quanti = quanti / 1000;
                }
                if (cbxMedida.Equals("Quilograma(KG)")){

                }
                est.quantidade = quanti + est.quantidade;

                if (dao.UpdateEstoque(est))
                {
                    MessageBox.Show("Você atualizou um produto com sucesso", "Sucesso!");
                }
            }
            else 
            { 
            MessageBox.Show("Selecione um produto por favor", "Error!");
            }
            lbEstoque.Refresh();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var id = lbEstoque.CheckedItems[0].ToString().Split('-')[0].Trim();
            var est = estoque.Where(es => es.descricao == id).ToArray()[0];
            var dao = new EstoqueDAO();
            if (dao.DeleteEstoque(est))
            {
                MessageBox.Show("Estoque excluido com sucesso", "Sucesso");
            }
        }

        private void lbEstoque_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (lbEstoque.CheckedItems.Count > 0)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = 0; i < lbEstoque.Items.Count; i++)
                    {
                        if (i != e.Index)
                            lbEstoque.SetItemChecked(i, false);
                    }
                }
            }
            lbEstoque.ClearSelected();
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmUpdateEstoque_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmUpdateEstoque_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
