using OrderPizza.DAO;
using OrderPizza.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class frmFecharCaixa : Form
    {
        List<Pedido> dailyRequests;
        PedidoDAO dao;
        double valorTotal = 0;
        int X = 0;
        int Y = 0;
        public frmFecharCaixa()
        {
            InitializeComponent();
            this.dailyRequests = new List<Pedido>();
            this.dao = new PedidoDAO();
        }

        private void frmFecharCaixa_Load(object sender, EventArgs e)
        {
            dailyRequests = dao.ListPedidosDoDia(Funcionario.id);
            dailyRequests.ForEach(ped =>
            {
                valorTotal += ped.valor;

                lbnRequests.Items.Add(
                        "Hora: " + ped.hora.ToString("HH:mm") + " valor: " + ped.valor.ToString("C2")
                    );
            });

            lblValorTotal.Text = valorTotal.ToString("C2");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void frmFecharCaixa_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void frmFecharCaixa_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }
    }
  
}
