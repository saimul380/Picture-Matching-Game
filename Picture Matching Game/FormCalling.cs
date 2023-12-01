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
            gameForm gform = new gameForm();
            gform.Show();
        }
        public void Call_OpeningForm()
        {
            openingForm oform = new openingForm();
            oform.Show();
        }
        public void Call_LogingForm()
        {
            Login_Form lForm = new Login_Form();
            lForm.Show();
        }
        public void Call_SignupForm()
        {
            signUpForm sform = new signUpForm();
            sform.Show();
        }
        public void Call_WinnerlistForm()
        {
            WinnerFormList wForm = new WinnerFormList();
            wForm.Show();
        }
    }
}
