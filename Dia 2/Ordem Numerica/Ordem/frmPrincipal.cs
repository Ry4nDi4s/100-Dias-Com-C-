using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordem
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            decimal num1 = decimal.Parse(txtcaixa1.Text);
            decimal num2 = decimal.Parse(txtcaixa2.Text);
            decimal num3 = decimal.Parse(txtcaixa3.Text);

            if(num1 > num2){
                if (num2 > num3)
                {
                    lbl1.Text = num1.ToString(); lbl2.Text = num2.ToString(); lbl3.Text = num3.ToString(); lbl4.Text = num3.ToString(); lbl5.Text = num2.ToString(); lbl6.Text = num1.ToString();
                }
                else
                {
                    lbl1.Text = num1.ToString(); lbl3.Text = num2.ToString(); lbl2.Text = num3.ToString(); lbl5.Text = num3.ToString(); lbl4.Text = num2.ToString(); lbl6.Text = num1.ToString();
                }
            }
            else if (num2 > num3)
            {
                if (num3 > num1)
                {
                    lbl1.Text = num2.ToString(); lbl2.Text = num3.ToString(); lbl3.Text = num1.ToString(); lbl4.Text = num1.ToString(); lbl5.Text = num3.ToString(); lbl6.Text = num2.ToString();
                }
                else
                {
                    lbl1.Text = num2.ToString(); lbl2.Text = num1.ToString(); lbl3.Text = num3.ToString(); lbl4.Text = num3.ToString(); lbl5.Text = num1.ToString(); lbl6.Text = num2.ToString();
                }
            }
            else if(num3 > num1)
            {
                if (num1 > num2)
                {
                    lbl1.Text = num3.ToString(); lbl2.Text = num1.ToString(); lbl3.Text = num2.ToString(); lbl4.Text = num2.ToString(); lbl5.Text = num1.ToString(); lbl6.Text = num3.ToString();
                }
                else
                {
                    lbl1.Text = num3.ToString(); lbl2.Text = num2.ToString(); lbl3.Text = num1.ToString(); lbl4.Text = num1.ToString(); lbl5.Text = num2.ToString(); lbl6.Text = num3.ToString();
                }
            }
        }
    }
}
