﻿using OrderPizza.DAO;
using OrderPizza.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class frmLogin : Form
    {
        int X = 0;
        int Y = 0;

        public frmLogin()
        {
            InitializeComponent();
            //this.Icon = new Icon("pizza.ico");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txbLogin.LostFocus += TxbLogin_LostFocus;
            txbSenha.LostFocus += TxbSenha_LostFocus;
            //txbLogin.Focus();
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
            if (txbLogin.Text == "usuario")
            {
                txbLogin.Text = null;
            }
            if (txbSenha.Text == "senha")
            {
                txbSenha.Text = null;
            }
            if (ValidaCampos())
            {
                if (new FuncionarioDAO().Logar(txbLogin.Text, txbSenha.Text))
                {
                    if (Funcionario.tipo == "admin")
                    {
                        new frmAdmin().Show();
                    }
                    else
                    {
                        new frmCardapio().Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("login ou senha incorretos.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidaCampos()
        {
            if (String.IsNullOrEmpty(txbLogin.Text))
            {
                MessageBox.Show("Campo *login obrigatório", "Erro de login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
