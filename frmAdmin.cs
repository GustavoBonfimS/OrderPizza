﻿using OrderPizza.DAO;
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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
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
                MessageBox.Show("Um dos Campos exigidos está vazio!!");
            }
            else { 
            nome = txbNome.Text;
            descricao = txbDescricao.Text;
            preco = Convert.ToDouble(txbPreco.Text);
            tipo = txbTipo.Text;
            tamanho = txbTamanho.Text;
            var dao = new ProdutoDAO();
            dao.InsertProduto(nome, descricao, preco, tipo, tamanho);
                MessageBox.Show("Produto cadastrado com sucesso");
            }
        }
    }
}
