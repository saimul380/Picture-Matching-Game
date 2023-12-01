namespace Picture_Matching_Game
{
    partial class WinnerFormList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_winnerList = new Label();
            dataGridViewWinners = new DataGridView();
            showButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWinners).BeginInit();
            SuspendLayout();
            // 
            // lb_winnerList
            // 
            lb_winnerList.AutoSize = true;
            lb_winnerList.BackColor = Color.IndianRed;
            lb_winnerList.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lb_winnerList.ForeColor = SystemColors.ActiveCaptionText;
            lb_winnerList.Location = new Point(159, 9);
            lb_winnerList.Name = "lb_winnerList";
            lb_winnerList.Size = new Size(137, 31);
            lb_winnerList.TabIndex = 2;
            lb_winnerList.Text = "Winner List";
            // 
            // dataGridViewWinners
            // 
            dataGridViewWinners.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewWinners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWinners.Location = new Point(118, 82);
            dataGridViewWinners.Name = "dataGridViewWinners";
            dataGridViewWinners.RowTemplate.Height = 25;
            dataGridViewWinners.Size = new Size(247, 150);
            dataGridViewWinners.TabIndex = 3;
            // 
            // showButton
            // 
            showButton.BackColor = Color.FromArgb(192, 255, 192);
            showButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            showButton.ForeColor = SystemColors.ActiveCaptionText;
            showButton.Location = new Point(51, 259);
            showButton.Name = "showButton";
            showButton.Size = new Size(80, 35);
            showButton.TabIndex = 10;
            showButton.Text = "Show";
            showButton.UseVisualStyleBackColor = false;
            showButton.Click += showButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(255, 192, 192);
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.ForeColor = SystemColors.ActiveCaptionText;
            exitButton.Location = new Point(364, 259);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(80, 35);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // WinnerFormList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.image4;
            ClientSize = new Size(474, 331);
            Controls.Add(exitButton);
            Controls.Add(showButton);
            Controls.Add(dataGridViewWinners);
            Controls.Add(lb_winnerList);
            Name = "WinnerFormList";
            Text = "WinnerFormList";
            ((System.ComponentModel.ISupportInitialize)dataGridViewWinners).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_winnerList;
        private DataGridView dataGridViewWinners;
        private Button showButton;
        private Button exitButton;
    }
}