using OrderPizza.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPizza.Relatorio
{
    public partial class frmOption : Form
    {
        public frmOption()
        {
            InitializeComponent();
        }

        private void frmOption_Load(object sender, EventArgs e)
        {
            labelId.Hide();
            txbId.Hide();
            btnBuscar.Hide();
            cbOptions.Items.Add("geral");
            cbOptions.Items.Add("cliente");
            cbOptions.Items.Add("pedido");
        }

        private void SetList()
        {
            if (cbOptions.Text != "geral")
            {
                var opt = cbOptions.Text;
                var id = Convert.ToInt32(txbId.Text);
                var registros = RelatorioDAO.gerarRelatorio(opt, id);

                foreach (var item in registros)
                {
                    var field = "pedido " + item.idPedido.ToString() + " desc:" + item.descricao;
                    lbItems.Items.Add(field);
                }
                return;
            }

            var regs = RelatorioDAO.listRegistros();

            foreach (var item in regs)
            {
                var field = "pedido " + item.idPedido.ToString() + " desc:" + item.descricao;
                lbItems.Items.Add(field);
            }
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbItems.Items.Clear();
            if (cbOptions.Text == "geral")
            {
                labelId.Hide();
                txbId.Hide();
                btnBuscar.Hide();
                SetList();
            }
            else
            {
                labelId.Show();
                txbId.Show();
                btnBuscar.Show();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lbItems.Items.Clear();
            if (string.IsNullOrEmpty(txbId.Text))
            {
                MessageBox.Show("informe o id");
                return;
            }
            SetList();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.ShowNewFolderButton = true;
                folder.Description = "Selecione a pasta para salvar o arquivo";
                folder.ShowDialog();

                var today = DateTime.Now.ToString("dd-MM-yyyy");
                string path = folder.SelectedPath.Trim();

                StreamWriter sw = new StreamWriter(path + @"\Relatorio-" + today + "-OrderPizza.txt");
                foreach (var item in lbItems.Items)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Dispose();
                MessageBox.Show("Salvo com sucesso em " + path, "Relatorio Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
