namespace OrderPizza
{
    partial class frmAdmin
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
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnContas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(27, 29);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(235, 48);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastros (produto/funcionario)";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Location = new System.Drawing.Point(318, 29);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(123, 48);
            this.btnCaixa.TabIndex = 1;
            this.btnCaixa.Text = "Gerenciade caixas";
            this.btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(509, 29);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(123, 48);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "Gerencia de estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(27, 131);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(123, 48);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.Text = "Gerar relatorios";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnContas
            // 
            this.btnContas.Location = new System.Drawing.Point(188, 131);
            this.btnContas.Name = "btnContas";
            this.btnContas.Size = new System.Drawing.Size(123, 48);
            this.btnContas.TabIndex = 4;
            this.btnContas.Text = "Contas a pagar/receber";
            this.btnContas.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContas);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnCadastro);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnContas;
    }
}