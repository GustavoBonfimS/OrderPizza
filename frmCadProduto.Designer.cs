using System;

namespace OrderPizza
{
    partial class frmCadProduto
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMinimizar_1 = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.cbxTamanho = new System.Windows.Forms.ComboBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.btncCadProd = new System.Windows.Forms.Button();
            this.cbIngrediente = new System.Windows.Forms.CheckedListBox();
            this.cbPizza = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnMinimizar_1);
            this.panel2.Controls.Add(this.btn_Fechar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 43);
            this.panel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(169, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cadastro de produto";
            // 
            // btnMinimizar_1
            // 
            this.btnMinimizar_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btnMinimizar_1.FlatAppearance.BorderSize = 0;
            this.btnMinimizar_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMinimizar_1.Location = new System.Drawing.Point(483, 2);
            this.btnMinimizar_1.Name = "btnMinimizar_1";
            this.btnMinimizar_1.Size = new System.Drawing.Size(30, 40);
            this.btnMinimizar_1.TabIndex = 1;
            this.btnMinimizar_1.Text = "─";
            this.btnMinimizar_1.UseVisualStyleBackColor = false;
            this.btnMinimizar_1.Click += new System.EventHandler(this.btnMinimizar_1_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_Fechar.FlatAppearance.BorderSize = 0;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Fechar.Location = new System.Drawing.Point(514, 3);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(31, 39);
            this.btn_Fechar.TabIndex = 0;
            this.btn_Fechar.Text = "x";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(27, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(204, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(27, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(381, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tamanho:";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(31, 89);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(475, 20);
            this.txbNome.TabIndex = 6;
            // 
            // txbDescricao
            // 
            this.txbDescricao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescricao.Location = new System.Drawing.Point(31, 173);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(475, 20);
            this.txbDescricao.TabIndex = 7;
            // 
            // txbPreco
            // 
            this.txbPreco.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPreco.Location = new System.Drawing.Point(31, 249);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(121, 20);
            this.txbPreco.TabIndex = 8;
            this.txbPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPreco_KeyPress);
            // 
            // cbxTamanho
            // 
            this.cbxTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTamanho.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTamanho.FormattingEnabled = true;
            this.cbxTamanho.Items.AddRange(new object[] {
            "Tradicional",
            "Grande",
            "350 ML",
            "250 ML",
            "600 ML",
            "1 Litro",
            "2 Litros",
            "3 Litros"});
            this.cbxTamanho.Location = new System.Drawing.Point(385, 249);
            this.cbxTamanho.Name = "cbxTamanho";
            this.cbxTamanho.Size = new System.Drawing.Size(121, 22);
            this.cbxTamanho.TabIndex = 9;
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Tradicional",
            "Doce",
            "Bebida"});
            this.cbxTipo.Location = new System.Drawing.Point(208, 249);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 22);
            this.cbxTipo.TabIndex = 10;
            // 
            // btncCadProd
            // 
            this.btncCadProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btncCadProd.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncCadProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btncCadProd.Location = new System.Drawing.Point(208, 450);
            this.btncCadProd.Name = "btncCadProd";
            this.btncCadProd.Size = new System.Drawing.Size(121, 33);
            this.btncCadProd.TabIndex = 11;
            this.btncCadProd.Text = "Cadastrar";
            this.btncCadProd.UseVisualStyleBackColor = false;
            this.btncCadProd.Click += new System.EventHandler(this.btncCadProd_Click);
            // 
            // cbIngrediente
            // 
            this.cbIngrediente.CheckOnClick = true;
            this.cbIngrediente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIngrediente.FormattingEnabled = true;
            this.cbIngrediente.Location = new System.Drawing.Point(31, 309);
            this.cbIngrediente.Name = "cbIngrediente";
            this.cbIngrediente.Size = new System.Drawing.Size(474, 124);
            this.cbIngrediente.TabIndex = 12;
            this.cbIngrediente.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbIngrediente_ItemCheck);
            // 
            // cbPizza
            // 
            this.cbPizza.AutoSize = true;
            this.cbPizza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbPizza.Location = new System.Drawing.Point(31, 286);
            this.cbPizza.Name = "cbPizza";
            this.cbPizza.Size = new System.Drawing.Size(98, 18);
            this.cbPizza.TabIndex = 13;
            this.cbPizza.Text = "Produto Pizza?";
            this.cbPizza.UseVisualStyleBackColor = true;
            this.cbPizza.CheckedChanged += new System.EventHandler(this.cbPizza_CheckedChanged);
            // 
            // frmCadProduto
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(549, 495);
            this.Controls.Add(this.cbPizza);
            this.Controls.Add(this.cbIngrediente);
            this.Controls.Add(this.btncCadProd);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxTamanho);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCadProduto_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCadProduto_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCadProduto_MouseMove);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btnMinimizar_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.ComboBox cbxTamanho;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Button btncCadProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox cbIngrediente;
        private System.Windows.Forms.CheckBox cbPizza;
    }
}