using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace Picture_Matching_Game
{
    internal class WinnerListClass
    {
        
        
        public WinnerListClass(string username)
        {
            try
            {
                string usernameOfTheWinner = username; // Replace with the actual username
                DateTime winTimestamp = DateTime.Now;

                ConnectionString connectionStr = new ConnectionString();
                var connectionString = connectionStr.GetConnectionString(); //for use connectingSting Class
                SqlConnection sqlConnection = new SqlConnection(connectionString);


                sqlConnection.Open();
                var checkPreviousWinQuery = "SELECT COUNT(*) FROM WinnerTable WHERE Username = @Username";
                SqlCommand checkWinCommand = new SqlCommand(checkPreviousWinQuery, sqlConnection);
                checkWinCommand.Parameters.AddWithValue("@Username", usernameOfTheWinner);

                int previousWins = (int)checkWinCommand.ExecuteScalar();

                if (previousWins == 0)
                {
                    // Insert a new record only if the user hasn't won before
                    var insertQuery = "INSERT INTO WinnerTable VALUES (@Username, @WinTimestamp)";
                    SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Username", usernameOfTheWinner);
                    sqlCommand.Parameters.AddWithValue("@WinTimestamp", winTimestamp);
                    sqlCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing went wrong to insert High Scorer List");
            }
        }
    }
}
