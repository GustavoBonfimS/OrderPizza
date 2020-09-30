namespace OrderPizza.Relatorio
{
    partial class frmOption
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
            this.lbItems = new System.Windows.Forms.ListBox();
            this.cbOptions = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txbId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(67, 94);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(490, 303);
            this.lbItems.TabIndex = 0;
            // 
            // cbOptions
            // 
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Location = new System.Drawing.Point(67, 46);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(121, 21);
            this.cbOptions.TabIndex = 1;
            this.cbOptions.SelectedIndexChanged += new System.EventHandler(this.cbOptions_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(482, 437);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar (.txt)";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(327, 47);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 20);
            this.txbId.TabIndex = 3;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(300, 50);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 13);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "ID:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(446, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 472);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbOptions);
            this.Controls.Add(this.lbItems);
            this.Name = "frmOption";
            this.Text = "frmOption";
            this.Load += new System.EventHandler(this.frmOption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.ComboBox cbOptions;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button btnBuscar;
    }
}