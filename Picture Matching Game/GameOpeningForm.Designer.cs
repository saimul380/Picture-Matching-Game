namespace Picture_Matching_Game
{
    partial class openingForm
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
            openingPageLebel = new Label();
            signUpButton = new Button();
            loginButton = new Button();
            WinnerListbutton = new Button();
            SuspendLayout();
            // 
            // openingPageLebel
            // 
            openingPageLebel.AutoSize = true;
            openingPageLebel.BackColor = SystemColors.ActiveCaption;
            openingPageLebel.BorderStyle = BorderStyle.FixedSingle;
            openingPageLebel.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            openingPageLebel.ForeColor = Color.Brown;
            openingPageLebel.Location = new Point(122, 30);
            openingPageLebel.Name = "openingPageLebel";
            openingPageLebel.Size = new Size(245, 30);
            openingPageLebel.TabIndex = 4;
            openingPageLebel.Text = "Picture Matching Game";
            openingPageLebel.TextAlign = ContentAlignment.TopCenter;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = SystemColors.ActiveCaption;
            signUpButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            signUpButton.Location = new Point(95, 181);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(75, 33);
            signUpButton.TabIndex = 5;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ActiveCaption;
            loginButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(292, 181);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 34);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click_1;
            // 
            // WinnerListbutton
            // 
            WinnerListbutton.BackColor = Color.Lime;
            WinnerListbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            WinnerListbutton.Location = new Point(292, 255);
            WinnerListbutton.Name = "WinnerListbutton";
            WinnerListbutton.Size = new Size(116, 46);
            WinnerListbutton.TabIndex = 11;
            WinnerListbutton.Text = "Winner List";
            WinnerListbutton.UseVisualStyleBackColor = false;
            WinnerListbutton.Click += WinnerListbutton_Click;
            // 
            // openingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.opening;
            ClientSize = new Size(474, 331);
            Controls.Add(WinnerListbutton);
            Controls.Add(loginButton);
            Controls.Add(signUpButton);
            Controls.Add(openingPageLebel);
            Name = "openingForm";
            Text = "Game Opening Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label openingPageLebel;
        private Button signUpButton;
        private Button loginButton;
        private Button WinnerListbutton;
    }
}