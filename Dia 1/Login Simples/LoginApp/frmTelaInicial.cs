using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lbltexto.Text = "Dia 1 com C#";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lbltexto.Text = "o Texto foi Cancelado";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Page_Login login = new Page_Login();
            login.Show();
            this.Hide();
        }
    }
}
