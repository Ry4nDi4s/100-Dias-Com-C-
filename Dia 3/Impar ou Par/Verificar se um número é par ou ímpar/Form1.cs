using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verificar_se_um_número_é_par_ou_ímpar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valida1 = double.TryParse(txtnum.Text, out double Number);

            if (!valida1)
            {
                MessageBox.Show("Digite algo ou que seja válido!");
                return;
            }

            if (Number % 2 == 0)
            {
                MessageBox.Show("O número é par!");
            }
            else
            {
                MessageBox.Show("O número é ímpar!");
            }
        }
    }
}
