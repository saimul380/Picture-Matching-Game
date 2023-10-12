using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Matching_Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            //For connecting signup button with signup form
            DialogResult res;
            res = MessageBox.Show("Do you want to Sign up", "Sign up", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //form that neeed to load next(form 3 is signup form)

                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //For connecting signup button with signup form
            DialogResult res;
            res = MessageBox.Show("Do you want to Login", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //form that neeed to load next(form 3 is signup form)

                Login_Form form4 = new Login_Form();
                form4.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }
    }
}
