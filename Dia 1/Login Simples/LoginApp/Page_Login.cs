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
    public partial class Page_Login : Form
    {
        public Page_Login()
        {
            InitializeComponent();
        }

        private void Page_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;

            if (nome == "Ryan" && senha == "12345")
            {
                Form1 tela = new Form1();
                tela.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERRO NO LOGIN");
            }
        }
    }
}
