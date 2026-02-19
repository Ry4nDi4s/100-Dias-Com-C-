using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_média_de_3_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool valida1 = double.TryParse(txtnum1.Text, out double num1);
            bool valida2 = double.TryParse(txtnum2.Text, out double num2);
            bool valida3 = double.TryParse(txtnum3.Text, out double num3);

            if (!valida1 || !valida2 || !valida3)
            {
                MessageBox.Show("Digite algo ou que seja válido!");
                return;
            }

            double media = (num1 + num2 + num3) / 3;

            MessageBox.Show("A média é: " + media.ToString());
        }
    }
}
