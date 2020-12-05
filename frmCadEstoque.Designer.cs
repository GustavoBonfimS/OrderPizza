namespace OrderPizza
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
            this.SuspendLayout();
            // 
            // btnCadEstoque
            // 
            this.btnCadEstoque.Location = new System.Drawing.Point(27, 153);
            this.btnCadEstoque.Name = "btnCadEstoque";
            this.btnCadEstoque.Size = new System.Drawing.Size(75, 23);
            this.btnCadEstoque.TabIndex = 0;
            this.btnCadEstoque.Text = "Cadastrar";
            this.btnCadEstoque.UseVisualStyleBackColor = true;
            this.btnCadEstoque.Click += new System.EventHandler(this.btnCadEstoque_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(27, 25);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(100, 20);
            this.txbDescricao.TabIndex = 2;
            // 
            // txbMedida
            // 
            this.txbMedida.Location = new System.Drawing.Point(27, 117);
            this.txbMedida.Name = "txbMedida";
            this.txbMedida.Size = new System.Drawing.Size(100, 20);
            this.txbMedida.TabIndex = 3;
            this.txbMedida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMedida_KeyPress);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(27, 71);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txbQuantidade.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Medida";
            // 
            // frmCadEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.txbMedida);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadEstoque);
            this.Name = "frmCadEstoque";
            this.Text = "frmCadEstoque";
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
    }
}