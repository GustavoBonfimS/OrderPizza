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
            this.buttonMinimizarC = new System.Windows.Forms.Button();
            this.labelPedido = new System.Windows.Forms.Label();
            this.buttonMaximizarC = new System.Windows.Forms.Button();
            this.buttonFecharC = new System.Windows.Forms.Button();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedPizzas = new System.Windows.Forms.CheckedListBox();
            this.pizzaSabor = new System.Windows.Forms.Label();
            this.pizzaDoce = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedDoces = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonProxCardapio = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonMinimizarC);
            this.panel3.Controls.Add(this.labelPedido);
            this.panel3.Controls.Add(this.buttonMaximizarC);
            this.panel3.Controls.Add(this.buttonFecharC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(1266, 60);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonMinimizarC
            // 
            this.buttonMinimizarC.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimizarC.FlatAppearance.BorderSize = 0;
            this.buttonMinimizarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizarC.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.buttonMinimizarC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonMinimizarC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinimizarC.Location = new System.Drawing.Point(1182, 3);
            this.buttonMinimizarC.Name = "buttonMinimizarC";
            this.buttonMinimizarC.Size = new System.Drawing.Size(27, 54);
            this.buttonMinimizarC.TabIndex = 4;
            this.buttonMinimizarC.Text = "─";
            this.buttonMinimizarC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinimizarC.UseVisualStyleBackColor = true;
            this.buttonMinimizarC.Click += new System.EventHandler(this.buttonMinimizarC_Click);
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
            this.labelPedido.Click += new System.EventHandler(this.labelPedido_Click);
            // 
            // buttonMaximizarC
            // 
            this.buttonMaximizarC.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMaximizarC.FlatAppearance.BorderSize = 0;
            this.buttonMaximizarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximizarC.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.buttonMaximizarC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonMaximizarC.Location = new System.Drawing.Point(1209, 3);
            this.buttonMaximizarC.Name = "buttonMaximizarC";
            this.buttonMaximizarC.Size = new System.Drawing.Size(27, 54);
            this.buttonMaximizarC.TabIndex = 0;
            this.buttonMaximizarC.Text = "❐";
            this.buttonMaximizarC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMaximizarC.UseVisualStyleBackColor = true;
            this.buttonMaximizarC.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFecharC
            // 
            this.buttonFecharC.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonFecharC.FlatAppearance.BorderSize = 0;
            this.buttonFecharC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFecharC.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.buttonFecharC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonFecharC.Location = new System.Drawing.Point(1236, 3);
            this.buttonFecharC.Name = "buttonFecharC";
            this.buttonFecharC.Size = new System.Drawing.Size(27, 54);
            this.buttonFecharC.TabIndex = 0;
            this.buttonFecharC.Text = "x";
            this.buttonFecharC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFecharC.UseVisualStyleBackColor = true;
            this.buttonFecharC.Click += new System.EventHandler(this.buttonFecharC_Click);
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBoxPesquisar.BackColor = System.Drawing.Color.Silver;
            this.textBoxPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPesquisar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisar.Location = new System.Drawing.Point(185, 94);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(259, 22);
            this.textBoxPesquisar.TabIndex = 12;
            this.textBoxPesquisar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            "4 Queijos",
            "Calabacon\t",
            "Calabresa  ",
            "Frango com catupiry",
            "Marguerita",
            "Moda da casa",
            "Napolitana",
            "Peperona",
            "Portuguesa",
            "Strogonoff"});
            this.checkedPizzas.Location = new System.Drawing.Point(76, 293);
            this.checkedPizzas.Name = "checkedPizzas";
            this.checkedPizzas.Size = new System.Drawing.Size(229, 270);
            this.checkedPizzas.TabIndex = 24;
            this.checkedPizzas.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
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
            this.pizzaSabor.Click += new System.EventHandler(this.label2_Click);
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
            this.pizzaDoce.Click += new System.EventHandler(this.pizzaDoce_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
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
            "Brigadeiro",
            "Beijinho",
            "Morango c/ chocolate",
            "Banana c/ chocolate",
            "Coco c/ chocolate",
            "Prestígio"});
            this.checkedDoces.Location = new System.Drawing.Point(448, 293);
            this.checkedDoces.Name = "checkedDoces";
            this.checkedDoces.Size = new System.Drawing.Size(229, 216);
            this.checkedDoces.TabIndex = 29;
            this.checkedDoces.SelectedIndexChanged += new System.EventHandler(this.checkedDoces_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Água 500ml",
            "Coca cola 600ml",
            "Coco cola 2L",
            "Guaraná antártica 600 ml",
            "Guaraná antártica 2L",
            "Heinekeen long neck",
            "Skol lata ",
            "Sucos (laranja, limão, abacaxi)"});
            this.checkedListBox1.Location = new System.Drawing.Point(878, 293);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(324, 216);
            this.checkedListBox1.TabIndex = 30;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_2);
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
            // telaCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1266, 681);
            this.Controls.Add(this.buttonProxCardapio);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.checkedDoces);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pizzaDoce);
            this.Controls.Add(this.pizzaSabor);
            this.Controls.Add(this.checkedPizzas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPesquisar);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaCardapio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.telaCardapio_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonFecharC;
        private System.Windows.Forms.Button buttonMaximizarC;
        private System.Windows.Forms.Label labelPedido;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedPizzas;
        private System.Windows.Forms.Label pizzaSabor;
        private System.Windows.Forms.Label pizzaDoce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedDoces;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonProxCardapio;
        private System.Windows.Forms.Button buttonMinimizarC;
    }
}

