namespace OrderPizza
{
    partial class frmCadastro
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
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_panel_cadFunc = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCadFunc_Click = new System.Windows.Forms.Button();
            this.cbxTipoUsu = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(109, 200);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(127, 20);
            this.txbSenha.TabIndex = 23;
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(109, 138);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(127, 20);
            this.txbLogin.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(150, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(143, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(143, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_panel_cadFunc);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 37);
            this.panel1.TabIndex = 25;
            // 
            // lb_panel_cadFunc
            // 
            this.lb_panel_cadFunc.AutoSize = true;
            this.lb_panel_cadFunc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_panel_cadFunc.Location = new System.Drawing.Point(40, 8);
            this.lb_panel_cadFunc.Name = "lb_panel_cadFunc";
            this.lb_panel_cadFunc.Size = new System.Drawing.Size(234, 24);
            this.lb_panel_cadFunc.TabIndex = 8;
            this.lb_panel_cadFunc.Text = "Cadastro de funcionário";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(291, -3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 40);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.Text = "─";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar.Location = new System.Drawing.Point(311, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(34, 37);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "x";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCadFunc_Click
            // 
            this.btnCadFunc_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCadFunc_Click.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadFunc_Click.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btnCadFunc_Click.Location = new System.Drawing.Point(109, 314);
            this.btnCadFunc_Click.Name = "btnCadFunc_Click";
            this.btnCadFunc_Click.Size = new System.Drawing.Size(127, 33);
            this.btnCadFunc_Click.TabIndex = 26;
            this.btnCadFunc_Click.Text = "Cadastrar";
            this.btnCadFunc_Click.UseVisualStyleBackColor = false;
            this.btnCadFunc_Click.Click += new System.EventHandler(this.btnCadFunc_Click_Click);
            // 
            // cbxTipoUsu
            // 
            this.cbxTipoUsu.FormattingEnabled = true;
            this.cbxTipoUsu.Items.AddRange(new object[] {
            "funcionario",
            "admin"});
            this.cbxTipoUsu.Location = new System.Drawing.Point(109, 261);
            this.cbxTipoUsu.Name = "cbxTipoUsu";
            this.cbxTipoUsu.Size = new System.Drawing.Size(127, 21);
            this.cbxTipoUsu.TabIndex = 27;
            this.cbxTipoUsu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.cbxTipoUsu);
            this.Controls.Add(this.btnCadFunc_Click);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCadFunc_Click;
        private System.Windows.Forms.Label lb_panel_cadFunc;
        private System.Windows.Forms.ComboBox cbxTipoUsu;
    }
}