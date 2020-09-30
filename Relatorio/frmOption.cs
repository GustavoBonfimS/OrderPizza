using OrderPizza.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            labelId.Hide();
            txbId.Hide();
            cbOptions.Items.Add("geral");
            cbOptions.Items.Add("cliente");
            cbOptions.Items.Add("pedido");
        }

        private void frmOption_Load(object sender, EventArgs e)
        {

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
                    var field = "pedido" + item.idPedido + " desc:" + item.descricao;
                    lbItems.Items.Add(field);
                }
                return;
            }

            var regs = RelatorioDAO.listRegistros();

            foreach (var item in regs)
            {
                var field = "pedido" + item.idPedido + " desc:" + item.descricao;
                lbItems.Items.Add(field);
            }
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOptions.Text == "geral")
            {
                SetList();
            }
            else
            {
                labelId.Show();
                txbId.Show();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbId.Text))
            {
                MessageBox.Show("informe o id");
                return;
            }
            SetList();
        }
    }
}
