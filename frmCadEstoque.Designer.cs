﻿namespace OrderPizza
{
    partial class frmCadEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadEstoque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.txbMedida = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPizza = new System.Windows.Forms.CheckBox();
            this.lbPizzas = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btnMinimizar_1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadEstoque
            // 
            this.btnCadEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCadEstoque.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btnCadEstoque.Location = new System.Drawing.Point(228, 405);
            this.btnCadEstoque.Name = "btnCadEstoque";
            this.btnCadEstoque.Size = new System.Drawing.Size(121, 33);
            this.btnCadEstoque.TabIndex = 0;
            this.btnCadEstoque.Text = "Cadastrar";
            this.btnCadEstoque.UseVisualStyleBackColor = false;
            this.btnCadEstoque.Click += new System.EventHandler(this.btnCadEstoque_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(25, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição:";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(29, 97);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(531, 20);
            this.txbDescricao.TabIndex = 2;
            // 
            // txbMedida
            // 
            this.txbMedida.Location = new System.Drawing.Point(29, 204);
            this.txbMedida.Name = "txbMedida";
            this.txbMedida.Size = new System.Drawing.Size(531, 20);
            this.txbMedida.TabIndex = 3;
            this.txbMedida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMedida_KeyPress);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(29, 150);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(531, 20);
            this.txbQuantidade.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(25, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(25, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Medida:";
            // 
            // cbPizza
            // 
            this.cbPizza.AutoSize = true;
            this.cbPizza.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPizza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbPizza.Location = new System.Drawing.Point(29, 243);
            this.cbPizza.Name = "cbPizza";
            this.cbPizza.Size = new System.Drawing.Size(407, 23);
            this.cbPizza.TabIndex = 7;
            this.cbPizza.Text = "Clique aqui caso for estoque usado em uma pizza";
            this.cbPizza.UseVisualStyleBackColor = true;
            // 
            // lbPizzas
            // 
            this.lbPizzas.FormattingEnabled = true;
            this.lbPizzas.Location = new System.Drawing.Point(29, 294);
            this.lbPizzas.Name = "lbPizzas";
            this.lbPizzas.Size = new System.Drawing.Size(531, 94);
            this.lbPizzas.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMinimizar_1);
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 43);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(175, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cadastro de estoque";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_Fechar.FlatAppearance.BorderSize = 0;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Fechar.Location = new System.Drawing.Point(556, 3);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(31, 39);
            this.btn_Fechar.TabIndex = 1;
            this.btn_Fechar.Text = "x";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btnMinimizar_1
            // 
            this.btnMinimizar_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btnMinimizar_1.FlatAppearance.BorderSize = 0;
            this.btnMinimizar_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMinimizar_1.Location = new System.Drawing.Point(525, 2);
            this.btnMinimizar_1.Name = "btnMinimizar_1";
            this.btnMinimizar_1.Size = new System.Drawing.Size(30, 40);
            this.btnMinimizar_1.TabIndex = 2;
            this.btnMinimizar_1.Text = "─";
            this.btnMinimizar_1.UseVisualStyleBackColor = false;
            this.btnMinimizar_1.Click += new System.EventHandler(this.btnMinimizar_1_Click);
            // 
            // frmCadEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbPizzas);
            this.Controls.Add(this.cbPizza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.txbMedida);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadEstoque";
            this.Text = "frmCadEstoque";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.TextBox txbMedida;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbPizza;
        private System.Windows.Forms.CheckedListBox lbPizzas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btnMinimizar_1;
    }
}