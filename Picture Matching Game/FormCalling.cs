using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture_Matching_Game
{
    internal class FormCalling
    {
        public void Call_GamingForm()
        {
            gameForm form = new gameForm();
            form.Show();
        }
        public void Call_OpeningForm()
        {
            openingForm form = new openingForm();
            form.Show();
        }
        public void Call_LogingForm()
        {
            Login_Form logInForm = new Login_Form();
            logInForm.Show();
        }
        public void Call_SignupForm()
        {
            signUpForm signupform = new signUpForm();
            signupform.Show();
        }
        public void Call_WinnerlistForm()
        {
            WinnerFormList winnerListForm = new WinnerFormList();
            winnerListForm.Show();
        }
    }
}
