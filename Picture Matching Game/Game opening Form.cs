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
    public partial class openingForm : Form
    {
        public openingForm()
        {
            InitializeComponent();
        }
        FormCalling formCall = new FormCalling();

        private void signUpButton_Click(object sender, EventArgs e)
        {
            formCall.Call_SignupForm();
            this.Hide();
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            formCall.Call_LogingForm();
            this.Hide();
        }

        private void WinnerListbutton_Click(object sender, EventArgs e)
        {
            formCall.Call_WinnerlistForm();
            this.Hide();
        }
    }
}
