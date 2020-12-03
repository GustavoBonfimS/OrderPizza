namespace OrderPizza
{
    partial class frmUpdateEstoque
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lbEstoque = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(31, 286);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(6, 68);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txbQuantidade.TabIndex = 1;
            // 
            // lbEstoque
            // 
            this.lbEstoque.FormattingEnabled = true;
            this.lbEstoque.Location = new System.Drawing.Point(3, 96);
            this.lbEstoque.Name = "lbEstoque";
            this.lbEstoque.Size = new System.Drawing.Size(353, 184);
            this.lbEstoque.TabIndex = 9;
            this.lbEstoque.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lbEstoque_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quantidade à adicionar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbQuantidade);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbEstoque);
            this.panel1.Location = new System.Drawing.Point(154, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 343);
            this.panel1.TabIndex = 13;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(243, 286);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Adicionar";
            // 
            // frmUpdateEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmUpdateEstoque";
            this.Text = "frmUpdateEstoque";
            this.Load += new System.EventHandler(this.frmUpdateEstoque_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.CheckedListBox lbEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExcluir;
    }
}