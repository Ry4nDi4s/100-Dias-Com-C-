using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_12___Conversão_Kilos_em_Dias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrande_Click(object sender, EventArgs e)
        {
            decimal consumo = decimal.Parse(txtconsumo.Text);
            int dia = 0;

            for (decimal marmita_grande = 1100; 0 < marmita_grande; marmita_grande = marmita_grande - consumo)
            {
                dia++;
            }
            MessageBox.Show($"A Marmita grande durou {dia} dias");
        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            decimal consumo = decimal.Parse(txtconsumo.Text);
            int dia = 0;

            for (decimal marmita_media = 750; 0 < marmita_media; marmita_media = marmita_media - consumo){
                dia++;
            }
            MessageBox.Show($"A Marmita média durou {dia} dias");
        }

        private void btnpequena_Click(object sender, EventArgs e)
        {
            decimal consumo = decimal.Parse(txtconsumo.Text);
            int dia = 0;

            for (decimal marmita_pequena = 500; 0 < marmita_pequena; marmita_pequena = marmita_pequena - consumo)
            {
                dia++;
            }
            MessageBox.Show($"A Marmita pequena durou {dia} dias");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
