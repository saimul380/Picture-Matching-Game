namespace Picture_Matching_Game
{
    partial class gameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lb_timeLeft = new Label();
            button_Restart = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 101);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Match or MisMatch";
            // 
            // lb_timeLeft
            // 
            lb_timeLeft.AutoSize = true;
            lb_timeLeft.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_timeLeft.Location = new Point(256, 150);
            lb_timeLeft.Name = "lb_timeLeft";
            lb_timeLeft.Size = new Size(107, 21);
            lb_timeLeft.TabIndex = 0;
            lb_timeLeft.Text = "TimeLeft : 30";
            // 
            // button_Restart
            // 
            button_Restart.BackColor = Color.DarkRed;
            button_Restart.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Restart.ForeColor = SystemColors.ActiveCaption;
            button_Restart.Location = new Point(256, 24);
            button_Restart.Name = "button_Restart";
            button_Restart.Size = new Size(107, 45);
            button_Restart.TabIndex = 1;
            button_Restart.Text = "Restart";
            button_Restart.UseVisualStyleBackColor = false;
            button_Restart.Click += RestartGameEvent;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 1000;
            gameTimer.Tick += timerEvent;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(255, 192, 192);
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.ForeColor = SystemColors.ActiveCaptionText;
            exitButton.Location = new Point(256, 231);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(80, 35);
            exitButton.TabIndex = 9;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // gameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 341);
            Controls.Add(exitButton);
            Controls.Add(button_Restart);
            Controls.Add(lb_timeLeft);
            Controls.Add(label1);
            Name = "gameForm";
            Text = "Picture Matching Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_timeLeft;
        private Button button_Restart;
        private System.Windows.Forms.Timer gameTimer;
        private Button exitButton;
    }
}