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
    public partial class FormLogin : Form { 
       // Dim attempts as Integer = 0 ;
    
        public FormLogin()
        {
            InitializeComponent();
        }
        

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "User" && textBoxPassword.Text == "123")

            {
                FormElectricityBill frmbill = new FormElectricityBill();
                frmbill.Show();
            }
           

            else if (textBoxUsername.Text != "User")

            {
                MessageBox.Show("User name is not correct!");
            }

            else if (textBoxPassword.Text != "123")
            {
                MessageBox.Show("User password is not correct");
            }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
