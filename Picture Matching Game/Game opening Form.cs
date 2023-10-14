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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            signUpForm signupform = new signUpForm();
            signupform.Show();
            this.Hide();
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            Login_Form logInForm = new Login_Form();
            logInForm.Show();
            this.Hide();
        }
    }
}
