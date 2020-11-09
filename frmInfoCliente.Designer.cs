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
            this.lbTel = new System.Windows.Forms.Label();
            this.lbEnd = new System.Windows.Forms.Label();
            this.lbFormaPag = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lbDin = new System.Windows.Forms.Label();
            this.lbCartao = new System.Windows.Forms.Label();
            this.txbDin = new System.Windows.Forms.TextBox();
            this.txbCartao = new System.Windows.Forms.TextBox();
            this.labelPedido = new System.Windows.Forms.Label();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbTel.Location = new System.Drawing.Point(23, 191);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(89, 22);
            this.lbTel.TabIndex = 0;
            this.lbTel.Text = "Telefone:";
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbEnd.Location = new System.Drawing.Point(23, 127);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(98, 22);
            this.lbEnd.TabIndex = 1;
            this.lbEnd.Text = "Endereco:";
            // 
            // lbFormaPag
            // 
            this.lbFormaPag.AutoSize = true;
            this.lbFormaPag.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormaPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbFormaPag.Location = new System.Drawing.Point(478, 76);
            this.lbFormaPag.Name = "lbFormaPag";
            this.lbFormaPag.Size = new System.Drawing.Size(197, 22);
            this.lbFormaPag.TabIndex = 2;
            this.lbFormaPag.Text = "Forma de pagamento:";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(27, 218);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(168, 20);
            this.txbTelefone.TabIndex = 3;
            this.txbTelefone.TextChanged += new System.EventHandler(this.txbTelefone_TextChanged);
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(27, 154);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(277, 20);
            this.txbEndereco.TabIndex = 4;
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.ItemHeight = 24;
            this.lbResultado.Location = new System.Drawing.Point(27, 370);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(770, 100);
            this.lbResultado.TabIndex = 6;
            this.lbResultado.SelectedIndexChanged += new System.EventHandler(this.lbResultado_SelectedIndexChanged);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFinalizar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btnFinalizar.Location = new System.Drawing.Point(692, 494);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(105, 36);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(27, 89);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(277, 20);
            this.txbNome.TabIndex = 8;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbNome.Location = new System.Drawing.Point(23, 62);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(66, 22);
            this.lbNome.TabIndex = 9;
            this.lbNome.Text = "Nome:";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbValor.Location = new System.Drawing.Point(481, 241);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(115, 22);
            this.lbValor.TabIndex = 10;
            this.lbValor.Text = "Valor total: ";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(675, 343);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(0, 24);
            this.lblValor.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.labelPedido);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 40);
            this.panel1.TabIndex = 12;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(768, -1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(27, 40);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.Text = "─";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lbDin
            // 
            this.lbDin.AutoSize = true;
            this.lbDin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDin.Location = new System.Drawing.Point(482, 127);
            this.lbDin.Name = "lbDin";
            this.lbDin.Size = new System.Drawing.Size(71, 18);
            this.lbDin.TabIndex = 13;
            this.lbDin.Text = "Dinheiro:";
            // 
            // lbCartao
            // 
            this.lbCartao.AutoSize = true;
            this.lbCartao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCartao.Location = new System.Drawing.Point(482, 159);
            this.lbCartao.Name = "lbCartao";
            this.lbCartao.Size = new System.Drawing.Size(60, 18);
            this.lbCartao.TabIndex = 14;
            this.lbCartao.Text = "Cartão:";
            // 
            // txbDin
            // 
            this.txbDin.Location = new System.Drawing.Point(560, 124);
            this.txbDin.Name = "txbDin";
            this.txbDin.Size = new System.Drawing.Size(74, 20);
            this.txbDin.TabIndex = 15;
            // 
            // txbCartao
            // 
            this.txbCartao.Location = new System.Drawing.Point(560, 160);
            this.txbCartao.Name = "txbCartao";
            this.txbCartao.Size = new System.Drawing.Size(74, 20);
            this.txbCartao.TabIndex = 16;
            // 
            // labelPedido
            // 
            this.labelPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPedido.Font = new System.Drawing.Font("Arial", 18F);
            this.labelPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelPedido.Location = new System.Drawing.Point(3, -3);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(759, 39);
            this.labelPedido.TabIndex = 4;
            this.labelPedido.Text = "Informações do cliente";
            this.labelPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotal.Location = new System.Drawing.Point(602, 245);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(88, 18);
            this.lbValorTotal.TabIndex = 17;
            this.lbValorTotal.Text = "lbValorTotal";
            this.lbValorTotal.Click += new System.EventHandler(this.lbValorTotal_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar.Location = new System.Drawing.Point(790, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(27, 37);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "x";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // frmInfoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(820, 542);
            this.Controls.Add(this.lbValorTotal);
            this.Controls.Add(this.txbCartao);
            this.Controls.Add(this.txbDin);
            this.Controls.Add(this.lbCartao);
            this.Controls.Add(this.lbDin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.lbFormaPag);
            this.Controls.Add(this.lbEnd);
            this.Controls.Add(this.lbTel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInfoCliente";
            this.Text = "frmInfoCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInfoCliente_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.Label lbFormaPag;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.ListBox lbResultado;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lbDin;
        private System.Windows.Forms.Label lbCartao;
        private System.Windows.Forms.TextBox txbDin;
        private System.Windows.Forms.TextBox txbCartao;
        private System.Windows.Forms.Label labelPedido;
        private System.Windows.Forms.Label lbValorTotal;
        private System.Windows.Forms.Button btnFechar;
    }
}