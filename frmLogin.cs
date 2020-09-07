using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


      /*  protected override void OnPaint(PaintEventArgs e)
        {
            /* Cria um objeto do tipo GraphicsPath que modifica a forma
            do botão em questão*/
     //       GraphicsPath forma = new GraphicsPath();
            /* Define como uma elipse o formato do objeto criado
             atribuindo valores para os parâmetros de posição e tamanho*/
       //     forma.AddEllipse(0, 0, buttonLogar.Width, buttonLogar.Height);
            /* Define a região do botão a ser arredondado, ou seja,
            o botão em si*/
         //   buttonLogar.Region = new Region(forma);
      //  }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxSenha_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxUsuario_Click(object sender, EventArgs e)
        {

        }

        private void iconelogin_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            new frmCardapio().Show();
            this.Hide();
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
