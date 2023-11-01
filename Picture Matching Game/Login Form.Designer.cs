namespace Picture_Matching_Game
{
    partial class Login_Form
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            UserNametextBox = new TextBox();
            PasswordTextBox = new TextBox();
            loginButton = new Button();
            signUpButton = new Button();
            label4 = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(180, 22);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(110, 109);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(110, 160);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // UserNametextBox
            // 
            UserNametextBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            UserNametextBox.Location = new Point(226, 109);
            UserNametextBox.Name = "UserNametextBox";
            UserNametextBox.Size = new Size(148, 25);
            UserNametextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(226, 154);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(148, 25);
            PasswordTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(299, 197);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 35);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // signUpButton
            // 
            signUpButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            signUpButton.Location = new Point(288, 275);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(86, 35);
            signUpButton.TabIndex = 5;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(110, 244);
            label4.Name = "label4";
            label4.Size = new Size(152, 19);
            label4.TabIndex = 3;
            label4.Text = "You have no account?";
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.Control;
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.ForeColor = SystemColors.ActiveCaptionText;
            exitButton.Location = new Point(47, 275);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(80, 35);
            exitButton.TabIndex = 9;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login_image;
            ClientSize = new Size(474, 331);
            Controls.Add(exitButton);
            Controls.Add(signUpButton);
            Controls.Add(loginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNametextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login_Form";
            Text = "Login_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UserNametextBox;
        private TextBox PasswordTextBox;
        private Button loginButton;
        private Button signUpButton;
        private Label label4;
        private Button exitButton;
    }
}