using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment_01
{
    public partial class FormElectricityBill : Form
    {
        public FormElectricityBill()
        {
            InitializeComponent();
        }
        double udata = 0;
        String mont = "";
        int date = 0;
        double result = 0;
    

        private void buttonCheckBill_Click(object sender, EventArgs e)
        {
            if (textBoxInputdata.Text.Length == 0)
            {
                MessageBox.Show("text box is empty ");
            }

            else
            {

                udata = double.Parse(textBoxInputdata.Text);
                mont = textBoxMonth.Text;


                //______________________

                if ((mont == "january") || (mont == "march") || (mont == "may") ||(mont=="july") || (mont == "august") || (mont == "october") || (mont == "december"))
                {
                    date = 31;
                }
                else if (mont == "february")
                {
                    date = 28;
                }
                else if ((mont == "april") || (mont == "june") || (mont == "september") || (mont == "november"))
                {
                    date = 30;
                }
                else
                {
                    textBoxMonth.Text = " month error";
                }

                //_____________________________
                result = 0;

                if (udata <= 30)
                {
                    result = 2.5 * udata + 30.00;
                    textBoxAmount.Text = result.ToString();
                    textBoxNumberofUnits.Text = udata.ToString();
                }
                else if (udata <= 60)
                {
                    result = 2.5 * 30;
                    result = (udata - 30) * 4.85 + 60.00 + result;
                    textBoxAmount.Text = result.ToString();
                    textBoxNumberofUnits.Text = udata.ToString();
                }
                else if (udata <= 90)
                {
                    result = 7.85 * 60;
                    result = (udata - 60) * 10 + 90.00 + result;
                    textBoxAmount.Text = result.ToString();
                    textBoxNumberofUnits.Text = udata.ToString();
                }
                else if (udata <= 120)
                {
                    result = 7.85 * 60;
                    result = 30 * 10 + result;
                    result = (udata - 90) * 27.75 + 480.00 + result;
                    textBoxAmount.Text = result.ToString();
                    textBoxNumberofUnits.Text = udata.ToString();
                }

                else if (udata <= 180)
                {
                    result = 32 * 60;
                    result = 30 * 10 + result;
                    result = (udata - 90) * 27.75 + 480.00 + result;
                    textBoxAmount.Text = result.ToString();
                    textBoxNumberofUnits.Text = udata.ToString();
                }


                else
                {
                    textBoxAmount.Text = "error";
                }

            }















        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumberofUnits_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
