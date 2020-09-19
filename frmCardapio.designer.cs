namespace OrderPizza
{
    partial class frmCardapio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.labelPedido = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedPizzas = new System.Windows.Forms.CheckedListBox();
            this.pizzaSabor = new System.Windows.Forms.Label();
            this.pizzaDoce = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedDoces = new System.Windows.Forms.CheckedListBox();
            this.checkedBebidaas = new System.Windows.Forms.CheckedListBox();
            this.buttonProxCardapio = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbPesquisar = new System.Windows.Forms.ComboBox();
            this.btnBackdoor = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMinimizar);
            this.panel3.Controls.Add(this.labelPedido);
            this.panel3.Controls.Add(this.btnMaximizar);
            this.panel3.Controls.Add(this.btnFechar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(1266, 60);
            this.panel3.TabIndex = 11;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(1182, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(27, 54);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.Text = "─";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // labelPedido
            // 
            this.labelPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPedido.Font = new System.Drawing.Font("Arial", 18F);
            this.labelPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelPedido.Location = new System.Drawing.Point(-3, 3);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(1179, 54);
            this.labelPedido.TabIndex = 3;
            this.labelPedido.Text = "Pedido do cliente";
            this.labelPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.btnMaximizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMaximizar.Location = new System.Drawing.Point(1209, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(27, 54);
            this.btnMaximizar.TabIndex = 0;
            this.btnMaximizar.Text = "❐";
            this.btnMaximizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFechar.Location = new System.Drawing.Point(1236, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(27, 54);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "x";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(69, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pesquisar:";
            // 
            // checkedPizzas
            // 
            this.checkedPizzas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedPizzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.checkedPizzas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedPizzas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedPizzas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkedPizzas.FormattingEnabled = true;
            this.checkedPizzas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkedPizzas.Items.AddRange(new object[] {
            "produto1",
            "produto2",
            "produto3"});
            this.checkedPizzas.Location = new System.Drawing.Point(76, 293);
            this.checkedPizzas.Name = "checkedPizzas";
            this.checkedPizzas.Size = new System.Drawing.Size(229, 270);
            this.checkedPizzas.TabIndex = 24;
            // 
            // pizzaSabor
            // 
            this.pizzaSabor.AutoSize = true;
            this.pizzaSabor.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaSabor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pizzaSabor.Location = new System.Drawing.Point(70, 213);
            this.pizzaSabor.Name = "pizzaSabor";
            this.pizzaSabor.Size = new System.Drawing.Size(123, 32);
            this.pizzaSabor.TabIndex = 25;
            this.pizzaSabor.Text = "Sabores";
            // 
            // pizzaDoce
            // 
            this.pizzaDoce.AutoSize = true;
            this.pizzaDoce.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaDoce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pizzaDoce.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pizzaDoce.Location = new System.Drawing.Point(442, 213);
            this.pizzaDoce.Name = "pizzaDoce";
            this.pizzaDoce.Size = new System.Drawing.Size(97, 32);
            this.pizzaDoce.TabIndex = 27;
            this.pizzaDoce.Text = "Doces";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(872, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "Bebidas";
            // 
            // checkedDoces
            // 
            this.checkedDoces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedDoces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.checkedDoces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedDoces.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedDoces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkedDoces.FormattingEnabled = true;
            this.checkedDoces.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkedDoces.Items.AddRange(new object[] {
            "produto1",
            "produto2",
            "produto3"});
            this.checkedDoces.Location = new System.Drawing.Point(448, 293);
            this.checkedDoces.Name = "checkedDoces";
            this.checkedDoces.Size = new System.Drawing.Size(229, 216);
            this.checkedDoces.TabIndex = 29;
            // 
            // checkedBebidaas
            // 
            this.checkedBebidaas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedBebidaas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.checkedBebidaas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedBebidaas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedBebidaas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkedBebidaas.FormattingEnabled = true;
            this.checkedBebidaas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkedBebidaas.Items.AddRange(new object[] {
            "bebida1",
            "bebida2",
            "bebida3"});
            this.checkedBebidaas.Location = new System.Drawing.Point(878, 293);
            this.checkedBebidaas.Name = "checkedBebidaas";
            this.checkedBebidaas.Size = new System.Drawing.Size(324, 216);
            this.checkedBebidaas.TabIndex = 30;
            // 
            // buttonProxCardapio
            // 
            this.buttonProxCardapio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonProxCardapio.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProxCardapio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.buttonProxCardapio.Location = new System.Drawing.Point(1089, 622);
            this.buttonProxCardapio.Name = "buttonProxCardapio";
            this.buttonProxCardapio.Size = new System.Drawing.Size(120, 35);
            this.buttonProxCardapio.TabIndex = 31;
            this.buttonProxCardapio.Text = "Próximo";
            this.buttonProxCardapio.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btnPesquisar.Location = new System.Drawing.Point(450, 92);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 26);
            this.btnPesquisar.TabIndex = 32;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // cbPesquisar
            // 
            this.cbPesquisar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPesquisar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPesquisar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbPesquisar.FormattingEnabled = true;
            this.cbPesquisar.Location = new System.Drawing.Point(185, 94);
            this.cbPesquisar.Name = "cbPesquisar";
            this.cbPesquisar.Size = new System.Drawing.Size(227, 21);
            this.cbPesquisar.TabIndex = 33;
            // 
            // btnBackdoor
            // 
            this.btnBackdoor.Location = new System.Drawing.Point(21, 504);
            this.btnBackdoor.Name = "btnBackdoor";
            this.btnBackdoor.Size = new System.Drawing.Size(75, 23);
            this.btnBackdoor.TabIndex = 34;
            this.btnBackdoor.Text = "ADMIN";
            this.btnBackdoor.UseVisualStyleBackColor = true;
            this.btnBackdoor.Click += new System.EventHandler(this.btnBackdoor_Click);
            // 
            // frmCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1266, 681);
            this.Controls.Add(this.btnBackdoor);
            this.Controls.Add(this.cbPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.buttonProxCardapio);
            this.Controls.Add(this.checkedBebidaas);
            this.Controls.Add(this.checkedDoces);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pizzaDoce);
            this.Controls.Add(this.pizzaSabor);
            this.Controls.Add(this.checkedPizzas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCardapio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCardapio_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Label labelPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedPizzas;
        private System.Windows.Forms.Label pizzaSabor;
        private System.Windows.Forms.Label pizzaDoce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedDoces;
        private System.Windows.Forms.CheckedListBox checkedBebidaas;
        private System.Windows.Forms.Button buttonProxCardapio;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbPesquisar;
        private System.Windows.Forms.Button btnBackdoor;
    }
}

