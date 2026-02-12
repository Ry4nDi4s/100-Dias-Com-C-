using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMais_Click(object sender, EventArgs e)
        {
            lblSimbolos.Text = "+";

            bool valida1 = double.TryParse(txtnum1.Text, out double valor1);
            bool valida2 = double.TryParse(txtnum2.Text, out double valor2);

            if (!valida1 || !valida2)
            {
                MessageBox.Show("Digite algo ou que seja válido!");
                return;
            }

            double resultado = valor1 + valor2;

            lblResultados.Text = resultado.ToString();
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            lblSimbolos.Text = "/";

            bool valida1 = double.TryParse(txtnum1.Text, out double valor1);
            bool valida2 = double.TryParse(txtnum2.Text, out double valor2);

            if (!valida1 || !valida2)
            {
                MessageBox.Show("Digite algo ou que seja válido!");
                return;
            }
            double resultado = valor1 / valor2;

            lblResultados.Text = resultado.ToString();
        }

        private void btnMenos_Click_1(object sender, EventArgs e)
        {
            lblSimbolos.Text = "-";

            bool valida1 = double.TryParse(txtnum1.Text, out double valor1);
            bool valida2 = double.TryParse(txtnum2.Text, out double valor2);

            if (!valida1 || !valida2)
            {
                MessageBox.Show("Digite algo ou que seja válido!");
                return;
            }

            double resultado = valor1 - valor2;

            lblResultados.Text = resultado.ToString();
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            lblSimbolos.Text = "*";

            bool valida1 = double.TryParse(txtnum1.Text, out double valor1);
            bool valida2 = double.TryParse(txtnum2.Text, out double valor2);

            if (!valida1 || !valida2)
            {
                MessageBox.Show("Digite algo ou que seja válido!");
                return;
            }

            double resultado = valor1 * valor2;

            lblResultados.Text = resultado.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lblSimbolos.Text = "";
            lblResultados.Text = "?";
            txtnum1.Clear();
            txtnum2.Clear();
        }
    }
}
