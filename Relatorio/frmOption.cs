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

            labelTelefone.Hide();
            txbTelefone.Hide();

            cbOptions.Items.Add("geral");
            cbOptions.Items.Add("cliente");
            cbOptions.Items.Add("pedido");
        }

        private void SetList()
        {
            var opt = cbOptions.Text;
            var id = Convert.ToInt32(string.IsNullOrEmpty(txbId.Text) ? "0" : txbId.Text);
            var telefone = string.IsNullOrEmpty(txbTelefone.Text) ? string.Empty : txbTelefone.Text;
            var registros = RelatorioDAO.gerarRelatorio(opt, telefone, id);

            registros.ForEach(item =>
            {
                var field = "pedido n° " + item.idPedido.ToString() + " desc:" + item.descricao;
                lbItems.Items.Add(field);
            });
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbItems.Items.Clear();
            switch (cbOptions.Text)
            {
                case "geral":
                    labelId.Hide();
                    txbId.Hide();
                    txbId.Enabled = false;

                    labelTelefone.Hide();
                    txbTelefone.Hide();
                    txbTelefone.Enabled = false;

                    btnBuscar.Hide();
                    SetList();
                    break;
                case "cliente":
                    labelTelefone.Show();
                    txbTelefone.Show();
                    txbTelefone.Enabled = true;

                    btnBuscar.Show();

                    labelId.Hide();
                    txbId.Hide();
                    txbId.Enabled = false;
                        break;
                default:
                    labelId.Show();
                    txbId.Show();
                    txbId.Enabled = true;

                    labelTelefone.Hide();
                    txbTelefone.Hide();
                    txbTelefone.Enabled = false;
                    btnBuscar.Show();
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lbItems.Items.Clear();
            if (txbId.Enabled == Enabled && string.IsNullOrEmpty(txbId.Text))
            {
                MessageBox.Show("informe o id");
                return;
            }

            if (txbTelefone.Enabled == Enabled && string.IsNullOrEmpty(txbTelefone.Text))
            {
                MessageBox.Show("informe o telefone");
                return;
            }
            SetList();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lbItems.Items.Count == 0)
            {
                MessageBox.Show("Nenhum na lista de registros para ser salvo."
                    ,"Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
