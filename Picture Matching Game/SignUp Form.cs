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

namespace Picture_Matching_Game
{
    public partial class signUpForm : Form
    {
        public signUpForm()
        {
            InitializeComponent();
        }
        FormCalling formCall = new FormCalling();
        

        private void submitButton_Click(object sender, EventArgs e)
        {
            //for must be fill username and password
            if (UserNametextBox.Text.Trim() == "")       //trim for not accepting space as a string in username
            {
                MessageBox.Show("Please! Enter your Username", "Username", MessageBoxButtons.OK);
                UserNametextBox.Focus();
                return;
            }
            if (PasswordTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please! Enter a Unique Password", "Password", MessageBoxButtons.OK);
                PasswordTextBox.Focus();
                return;
            }

            //connecting submit button with sql server
            try
            {   
                ConnectionString connectionStr = new ConnectionString(); //connecting connectionstring with class's object
                SqlConnection sqlConnection = new SqlConnection(connectionStr.connectionString);
                sqlConnection.Open();

                var insertQuery = "insert into Login_table values(@Username, @MatricID, @Password)";
                SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Username", UserNametextBox.Text);
                sqlCommand.Parameters.AddWithValue("@MatricID", matricIDtextBox.Text);
                sqlCommand.Parameters.AddWithValue("@Password", PasswordTextBox.Text);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Signing up Succesfully!!", "Good Job", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing went wrong", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            UserNametextBox.Clear();
            matricIDtextBox.Clear();
            PasswordTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //For connecting exit button with next loaded form with FormCalling class

            formCall.Call_OpeningForm();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            formCall.Call_LogingForm();
            this.Hide();
        }
    }
}
