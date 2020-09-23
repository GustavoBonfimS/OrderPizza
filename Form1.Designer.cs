namespace frmCadCliente
{
    partial class Form1
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
            this.labelCliente = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelEnder = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxEndereco = new System.Windows.Forms.TextBox();
            this.tbxTelefone = new System.Windows.Forms.TextBox();
            this.btnProxCadastro = new System.Windows.Forms.Button();
            this.labelFormaPag = new System.Windows.Forms.Label();
            this.ckBoxDinheiro = new System.Windows.Forms.CheckBox();
            this.ckBoxCartao = new System.Windows.Forms.CheckBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMinimizar);
            this.panel3.Controls.Add(this.labelCliente);
            this.panel3.Controls.Add(this.btnMaximizar);
            this.panel3.Controls.Add(this.btnFechar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(1184, 60);
            this.panel3.TabIndex = 12;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(1100, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(27, 54);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.Text = "─";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // labelCliente
            // 
            this.labelCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCliente.Font = new System.Drawing.Font("Arial", 18F);
            this.labelCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelCliente.Location = new System.Drawing.Point(-44, 3);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(1179, 54);
            this.labelCliente.TabIndex = 3;
            this.labelCliente.Text = "Cadastro do cliente";
            this.labelCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.btnMaximizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMaximizar.Location = new System.Drawing.Point(1127, 3);
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
            this.btnFechar.Location = new System.Drawing.Point(1154, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(27, 54);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "x";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelNome.Location = new System.Drawing.Point(38, 111);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(60, 19);
            this.labelNome.TabIndex = 14;
            this.labelNome.Text = "Nome:";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelTel.Location = new System.Drawing.Point(38, 166);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(80, 19);
            this.labelTel.TabIndex = 15;
            this.labelTel.Text = "Telefone:";
            // 
            // labelEnder
            // 
            this.labelEnder.AutoSize = true;
            this.labelEnder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelEnder.Location = new System.Drawing.Point(38, 214);
            this.labelEnder.Name = "labelEnder";
            this.labelEnder.Size = new System.Drawing.Size(89, 19);
            this.labelEnder.TabIndex = 16;
            this.labelEnder.Text = "Endereço:";
            // 
            // tbxNome
            // 
            this.tbxNome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxNome.Location = new System.Drawing.Point(137, 115);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(192, 13);
            this.tbxNome.TabIndex = 17;
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxEndereco.Location = new System.Drawing.Point(137, 215);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(371, 13);
            this.tbxEndereco.TabIndex = 18;
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTelefone.Location = new System.Drawing.Point(137, 165);
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(192, 13);
            this.tbxTelefone.TabIndex = 19;
            this.tbxTelefone.TextChanged += new System.EventHandler(this.tbxTelefone_TextChanged);
            // 
            // btnProxCadastro
            // 
            this.btnProxCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnProxCadastro.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProxCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btnProxCadastro.Location = new System.Drawing.Point(1015, 577);
            this.btnProxCadastro.Name = "btnProxCadastro";
            this.btnProxCadastro.Size = new System.Drawing.Size(120, 35);
            this.btnProxCadastro.TabIndex = 32;
            this.btnProxCadastro.Text = "Próximo";
            this.btnProxCadastro.UseVisualStyleBackColor = false;
            // 
            // labelFormaPag
            // 
            this.labelFormaPag.AutoSize = true;
            this.labelFormaPag.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormaPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelFormaPag.Location = new System.Drawing.Point(392, 349);
            this.labelFormaPag.Name = "labelFormaPag";
            this.labelFormaPag.Size = new System.Drawing.Size(243, 27);
            this.labelFormaPag.TabIndex = 33;
            this.labelFormaPag.Text = "Forma de pagamento";
            this.labelFormaPag.Click += new System.EventHandler(this.label4_Click);
            // 
            // ckBoxDinheiro
            // 
            this.ckBoxDinheiro.AutoSize = true;
            this.ckBoxDinheiro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxDinheiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ckBoxDinheiro.Location = new System.Drawing.Point(42, 440);
            this.ckBoxDinheiro.Name = "ckBoxDinheiro";
            this.ckBoxDinheiro.Size = new System.Drawing.Size(108, 26);
            this.ckBoxDinheiro.TabIndex = 34;
            this.ckBoxDinheiro.Text = "Dinheiro";
            this.ckBoxDinheiro.UseVisualStyleBackColor = true;
            // 
            // ckBoxCartao
            // 
            this.ckBoxCartao.AutoSize = true;
            this.ckBoxCartao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxCartao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ckBoxCartao.Location = new System.Drawing.Point(42, 507);
            this.ckBoxCartao.Name = "ckBoxCartao";
            this.ckBoxCartao.Size = new System.Drawing.Size(91, 26);
            this.ckBoxCartao.TabIndex = 35;
            this.ckBoxCartao.Text = "Cartão";
            this.ckBoxCartao.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1184, 633);
            this.Controls.Add(this.ckBoxCartao);
            this.Controls.Add(this.ckBoxDinheiro);
            this.Controls.Add(this.labelFormaPag);
            this.Controls.Add(this.btnProxCadastro);
            this.Controls.Add(this.tbxTelefone);
            this.Controls.Add(this.tbxEndereco);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.labelEnder);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelEnder;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxEndereco;
        private System.Windows.Forms.TextBox tbxTelefone;
        private System.Windows.Forms.Button btnProxCadastro;
        private System.Windows.Forms.Label labelFormaPag;
        private System.Windows.Forms.CheckBox ckBoxDinheiro;
        private System.Windows.Forms.CheckBox ckBoxCartao;
    }
}

