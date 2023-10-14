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
            String username, password;
            username = usernameTextBox.Text;
            password = passwordTextBox.Text;

            try
            {
                String querry = "SELECT * FROM Login_table WHERE username ='"+usernameTextBox.Text+"' AND password = '" +passwordTextBox.Text+ "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querry, sqlConnection);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if(dataTable.Rows.Count > 0)
                {
                    username = usernameTextBox.Text;
                    password = passwordTextBox.Text;

                    //for load to next form
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                    usernameTextBox.Focus();
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
            /*DialogResult res;
            res = MessageBox.Show("Do you want to exit & Sign up", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }*/
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

        }
    }
}
