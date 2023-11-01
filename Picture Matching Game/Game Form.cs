namespace Picture_Matching_Game
{
    public partial class gameForm : Form
    {
        List<int> list = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
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

        }

        private void RestartGameEvent(object sender, EventArgs e)
        {

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


        }
        private void checkPictures(PictureBox A, PictureBox B)
        {


        }
        private void GameOver()
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //For connecting exit button with next loaded form
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                openingForm form2 = new openingForm();
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