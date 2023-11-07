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
    public partial class WinnerFormList : Form
    {
        public WinnerFormList()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ConnectionString connectionStr = new ConnectionString();
            string connectionString = connectionStr.GetConnectionString();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string selectQuery = "SELECT Username, WinTimestamp FROM WinnerTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridViewWinners.DataSource = dataTable;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            openingForm form = new openingForm();
            form.Show();
            this.Hide();
        }
    }
}


