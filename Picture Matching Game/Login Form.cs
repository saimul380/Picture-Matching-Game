using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Matching_Game
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-Q7KTNQDN\SQLEXPRESS;Initial Catalog=""Picture Matching Game Database"";Integrated Security=True");

        private void loginButton_Click(object sender, EventArgs e)
        {
            //for must be fill username and password
            if (UserNametextBox.Text.Trim() == "")       //trim for not accepting space as a string in username
            {
                MessageBox.Show("Enter your Username", "Username", MessageBoxButtons.OK);
                UserNametextBox.Focus();
                return;
            }
            if (PasswordTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Enter Your Password", "Password", MessageBoxButtons.OK);
                PasswordTextBox.Focus();
                return;
            }
            String username, password;
            username = UserNametextBox.Text;
            password = PasswordTextBox.Text;

            try
            {
                String querry = "SELECT * FROM Login_table WHERE username ='" + UserNametextBox.Text + "' AND password = '" + PasswordTextBox.Text + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querry, sqlConnection);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    username = UserNametextBox.Text;
                    password = PasswordTextBox.Text;

                    //for load to next form
                    gameForm form = new gameForm();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserNametextBox.Clear();
                    PasswordTextBox.Clear();
                    UserNametextBox.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            //For connecting signup(exit) button with next loaded form
            signUpForm signupform = new signUpForm();
            signupform.Show();
            this.Hide();

        }
    }
}
