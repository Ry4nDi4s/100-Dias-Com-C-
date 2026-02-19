using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter_Celsius_para_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool valida = double.TryParse(txtNum.Text, out double celsius);
            if (!valida)
            {
                MessageBox.Show("Digite algo ou que seja válido!");
                return;
            }
            double fahrenheit = (celsius * 1.8) + 32;
            MessageBox.Show($"O valor em Fahrenheit é: {fahrenheit}");
        }
    }
}
