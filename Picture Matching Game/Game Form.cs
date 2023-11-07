using System.Data.SqlClient;
using System.Globalization;

namespace Picture_Matching_Game
{
    public partial class gameForm : Form
    {

        public string username { get; set; }

        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string firstChoice;
        string secondChoice;
        int tries;
        List<PictureBox> pictures = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        int totalTime = 30;
        int countDownTime;
        bool gameOver = false;

        public gameForm()
        {
            InitializeComponent();
            loadPictures();
        }

        private void timerEvent(object sender, EventArgs e)
        {
            countDownTime--;
            lb_timeLeft.Text = "Time Left: " + countDownTime;

            if (countDownTime < 1)
            {
                GameOver("You Lose");

                foreach (PictureBox x in pictures)
                {
                    if (x.Tag != null)
                    {
                        x.Image = Image.FromFile("pics/" + (string)x.Tag + ".png");

                    }
                }
            }

        }

        private void RestartGameEvent(object sender, EventArgs e)
        {
            restartGame();

        }
        private void loadPictures()
        {
            int leftPos = 20;
            int topPos = 20;
            int rows = 0;

            for (int i = 0; i < 12; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 50;
                newPic.Width = 50;
                newPic.BackColor = Color.LightGray;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += NewPic_Click;
                pictures.Add(newPic);

                if (rows < 3)
                {
                    rows++;
                    newPic.Left = leftPos;
                    newPic.Top = topPos;
                    this.Controls.Add(newPic);
                    leftPos = leftPos + 60;
                }
                if (rows == 3)
                {
                    leftPos = 20;
                    topPos = topPos + 60;
                    rows = 0;
                }
            }
            restartGame();
        }

        private void NewPic_Click(object? sender, EventArgs e)
        {
            if (gameOver)
            {
                return;
                //don't register a click if the game is over
            }
            if (firstChoice == null)
            {
                picA = sender as PictureBox;
                if (picA.Tag != null && picA.Image == null)
                {
                    picA.Image = Image.FromFile("pics/" + (string)picA.Tag + ".png");
                    firstChoice = (string)picA.Tag;
                }
            }
            else if (secondChoice == null)
            {
                picB = sender as PictureBox;
                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = Image.FromFile("pics/" + (string)picB.Tag + ".png");
                    secondChoice = (string)picB.Tag;
                }
            }
            else
            {
                checkPictures(picA, picB);
            }
        }

        private void restartGame()
        {
            //randomise the orginal list
            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList();
            //assaign the random list to the orginal
            numbers = randomList;

            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = numbers[i].ToString();
            }
            tries = 0;
            labelStatus.Text = " Mismatched: " + tries + " times.";
            lb_timeLeft.Text = "Time Left: " + totalTime;
            gameOver = false;
            gameTimer.Start();
            countDownTime = totalTime;
        }

        private void checkPictures(PictureBox A, PictureBox B)
        {
            if (firstChoice == secondChoice)
            {
                A.Tag = null;
                B.Tag = null;
            }
            else
            {
                tries++;
                labelStatus.Text = "Mismatched: " + tries + " times.";
            }
            firstChoice = null;
            secondChoice = null;

            foreach (PictureBox pics in pictures.ToList())
            {
                if (pics.Tag != null)
                {
                    pics.Image = null;
                }
            }
            // now check if all of the items have been solved
            if (pictures.All(o => o.Tag == null))
            {
                gameTimer.Stop();
                gameOver = true;
                MessageBox.Show("Great Work, You Win!!","Wins");
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

        private void GameOver(string msg)
        {
            gameTimer.Stop();
            gameOver = true;
            MessageBox.Show(msg + " Times Up! Click Restart to Play Again.", "Restart");


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //For connecting exit button with next loaded form
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                FormCalling formCall = new FormCalling();
                formCall.Call_OpeningForm();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }
    }
}