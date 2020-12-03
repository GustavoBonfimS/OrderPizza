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
                    lbEstoque.Items.Add(item.descricao + " - " + item.quantidade);
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
                if (Math.Abs(quanti % 1) <= (Double.Epsilon * 100))
                {
                    MessageBox.Show("Represente virgula ao inves de ponto para representar" +
                        "as casas decimais!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbQuantidade.Focus();
                    return;
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
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

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
    }
}