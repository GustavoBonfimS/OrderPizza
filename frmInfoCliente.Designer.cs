namespace OrderPizza
{
    partial class frmInfoCliente
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
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbFormaPag = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbVlrTotal = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.labelInfoCli = new System.Windows.Forms.Label();
            this.rbDinheiro = new System.Windows.Forms.RadioButton();
            this.rbCartao = new System.Windows.Forms.RadioButton();
            this.lbTroco = new System.Windows.Forms.Label();
            this.txbTroco = new System.Windows.Forms.TextBox();
            this.lbVlrTroco = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbTelefone.Location = new System.Drawing.Point(38, 222);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(89, 22);
            this.lbTelefone.TabIndex = 0;
            this.lbTelefone.Text = "Telefone:";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbEndereco.Location = new System.Drawing.Point(38, 151);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(98, 22);
            this.lbEndereco.TabIndex = 1;
            this.lbEndereco.Text = "Endereco:";
            // 
            // lbFormaPag
            // 
            this.lbFormaPag.AutoSize = true;
            this.lbFormaPag.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormaPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbFormaPag.Location = new System.Drawing.Point(454, 77);
            this.lbFormaPag.Name = "lbFormaPag";
            this.lbFormaPag.Size = new System.Drawing.Size(197, 22);
            this.lbFormaPag.TabIndex = 2;
            this.lbFormaPag.Text = "Forma de pagamento:";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(42, 249);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(168, 20);
            this.txbTelefone.TabIndex = 3;
            this.txbTelefone.TextChanged += new System.EventHandler(this.txbTelefone_TextChanged);
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(42, 178);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(316, 20);
            this.txbEndereco.TabIndex = 4;
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.ItemHeight = 24;
            this.lbResultado.Location = new System.Drawing.Point(42, 328);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(774, 100);
            this.lbResultado.TabIndex = 6;
            this.lbResultado.SelectedIndexChanged += new System.EventHandler(this.lbResultado_SelectedIndexChanged);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btnFinalizar.Location = new System.Drawing.Point(711, 448);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(105, 36);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(42, 104);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(316, 20);
            this.txbNome.TabIndex = 8;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbNome.Location = new System.Drawing.Point(38, 77);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(66, 22);
            this.lbNome.TabIndex = 9;
            this.lbNome.Text = "Nome:";
            // 
            // lbVlrTotal
            // 
            this.lbVlrTotal.AutoSize = true;
            this.lbVlrTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVlrTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbVlrTotal.Location = new System.Drawing.Point(579, 290);
            this.lbVlrTotal.Name = "lbVlrTotal";
            this.lbVlrTotal.Size = new System.Drawing.Size(102, 24);
            this.lbVlrTotal.TabIndex = 10;
            this.lbVlrTotal.Text = "Valor total: ";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(707, 290);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(0, 24);
            this.lblValor.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelInfoCli);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 42);
            this.panel1.TabIndex = 12;
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFechar.Location = new System.Drawing.Point(814, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(27, 42);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "x";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.btnMaximizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMaximizar.Location = new System.Drawing.Point(787, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(27, 42);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.Text = "❐";
            this.btnMaximizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(760, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(27, 42);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.Text = "─";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // labelInfoCli
            // 
            this.labelInfoCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInfoCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelInfoCli.Font = new System.Drawing.Font("Arial", 18F);
            this.labelInfoCli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelInfoCli.Location = new System.Drawing.Point(3, 0);
            this.labelInfoCli.Name = "labelInfoCli";
            this.labelInfoCli.Size = new System.Drawing.Size(760, 42);
            this.labelInfoCli.TabIndex = 6;
            this.labelInfoCli.Text = "Informações do cliente";
            this.labelInfoCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbDinheiro
            // 
            this.rbDinheiro.AutoSize = true;
            this.rbDinheiro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDinheiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rbDinheiro.Location = new System.Drawing.Point(458, 113);
            this.rbDinheiro.Name = "rbDinheiro";
            this.rbDinheiro.Size = new System.Drawing.Size(85, 22);
            this.rbDinheiro.TabIndex = 13;
            this.rbDinheiro.TabStop = true;
            this.rbDinheiro.Text = "Dinheiro";
            this.rbDinheiro.UseVisualStyleBackColor = true;
            // 
            // rbCartao
            // 
            this.rbCartao.AutoSize = true;
            this.rbCartao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCartao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rbCartao.Location = new System.Drawing.Point(458, 152);
            this.rbCartao.Name = "rbCartao";
            this.rbCartao.Size = new System.Drawing.Size(74, 22);
            this.rbCartao.TabIndex = 14;
            this.rbCartao.TabStop = true;
            this.rbCartao.Text = "Cartão";
            this.rbCartao.UseVisualStyleBackColor = true;
            // 
            // lbTroco
            // 
            this.lbTroco.AutoSize = true;
            this.lbTroco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTroco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbTroco.Location = new System.Drawing.Point(556, 116);
            this.lbTroco.Name = "lbTroco";
            this.lbTroco.Size = new System.Drawing.Size(60, 18);
            this.lbTroco.TabIndex = 15;
            this.lbTroco.Text = "Troco ?";
            // 
            // txbTroco
            // 
            this.txbTroco.Location = new System.Drawing.Point(622, 113);
            this.txbTroco.Name = "txbTroco";
            this.txbTroco.Size = new System.Drawing.Size(85, 20);
            this.txbTroco.TabIndex = 16;
            this.txbTroco.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbVlrTroco
            // 
            this.lbVlrTroco.AutoSize = true;
            this.lbVlrTroco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVlrTroco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbVlrTroco.Location = new System.Drawing.Point(723, 113);
            this.lbVlrTroco.Name = "lbVlrTroco";
            this.lbVlrTroco.Size = new System.Drawing.Size(66, 18);
            this.lbVlrTroco.TabIndex = 17;
            this.lbVlrTroco.Text = "VlrTroco";
            // 
            // frmInfoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(844, 496);
            this.Controls.Add(this.lbVlrTroco);
            this.Controls.Add(this.txbTroco);
            this.Controls.Add(this.lbTroco);
            this.Controls.Add(this.rbCartao);
            this.Controls.Add(this.rbDinheiro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lbVlrTotal);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.lbFormaPag);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbTelefone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInfoCliente";
            this.Text = "frmInfoCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInfoCliente_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbFormaPag;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.ListBox lbResultado;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbVlrTotal;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label labelInfoCli;
        private System.Windows.Forms.RadioButton rbDinheiro;
        private System.Windows.Forms.RadioButton rbCartao;
        private System.Windows.Forms.Label lbTroco;
        private System.Windows.Forms.TextBox txbTroco;
        private System.Windows.Forms.Label lbVlrTroco;
    }
}