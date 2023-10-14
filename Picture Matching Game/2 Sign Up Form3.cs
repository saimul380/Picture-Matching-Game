﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
//using System.Data.SqlClient;

namespace Picture_Matching_Game
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            //for must be fill username and password
            if (UserNametextBox.Text.Trim() == "")       //trim for not accepting space as a string in username
            {
                MessageBox.Show("Please! Enter your Username", "Username", MessageBoxButtons.OK);
                UserNametextBox.Focus();
                return;
            }
            if (passwordTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please! Enter a Unique Password", "Password", MessageBoxButtons.OK);
                passwordTextBox.Focus();
                return;
            }
            //connecting submit button
            try
            {
                var connectionString = "Data Source=LAPTOP-Q7KTNQDN\\SQLEXPRESS;Initial Catalog=\"Picture Matching Game Database\";Integrated Security=True";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                var insertQuery = "insert into Login_table values(@Username, @MatricID, @Password)";

                SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Username", UserNametextBox.Text);
                sqlCommand.Parameters.AddWithValue("@MatricID", matricIDtextBox.Text);
                sqlCommand.Parameters.AddWithValue("@Password", passwordTextBox.Text);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Signing up Succesfully!!","Good Job",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing went wrong","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            UserNametextBox.Clear();
            matricIDtextBox.Clear();
            passwordTextBox.Clear();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //For connecting exit button with next loaded form
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }
    }
}
