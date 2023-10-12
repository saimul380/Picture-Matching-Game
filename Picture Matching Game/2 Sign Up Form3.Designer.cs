namespace Picture_Matching_Game
{
    partial class Form3
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
            UserNameLabel = new Label();
            matricIDlabel = new Label();
            Passwordlabel = new Label();
            UserNametextBox = new TextBox();
            passwordTextBox = new TextBox();
            matricIDtextBox = new TextBox();
            submitButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(234, 20);
            label1.Name = "label1";
            label1.Size = new Size(130, 33);
            label1.TabIndex = 0;
            label1.Text = "Signing Up";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseCompatibleTextRendering = true;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLabel.ForeColor = Color.Black;
            UserNameLabel.Location = new Point(167, 158);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(116, 28);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "User Name";
            // 
            // matricIDlabel
            // 
            matricIDlabel.AutoSize = true;
            matricIDlabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            matricIDlabel.ForeColor = SystemColors.ActiveCaptionText;
            matricIDlabel.Location = new Point(167, 209);
            matricIDlabel.Name = "matricIDlabel";
            matricIDlabel.Size = new Size(101, 28);
            matricIDlabel.TabIndex = 3;
            matricIDlabel.Text = "Matric ID";
            // 
            // Passwordlabel
            // 
            Passwordlabel.AutoSize = true;
            Passwordlabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Passwordlabel.ForeColor = SystemColors.ActiveCaptionText;
            Passwordlabel.Location = new Point(167, 267);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(101, 28);
            Passwordlabel.TabIndex = 5;
            Passwordlabel.Text = "Password";
            // 
            // UserNametextBox
            // 
            UserNametextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UserNametextBox.Location = new Point(304, 157);
            UserNametextBox.Name = "UserNametextBox";
            UserNametextBox.Size = new Size(182, 29);
            UserNametextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(304, 266);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(182, 29);
            passwordTextBox.TabIndex = 6;
            // 
            // matricIDtextBox
            // 
            matricIDtextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            matricIDtextBox.Location = new Point(304, 209);
            matricIDtextBox.Name = "matricIDtextBox";
            matricIDtextBox.Size = new Size(182, 29);
            matricIDtextBox.TabIndex = 4;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(255, 192, 192);
            submitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submitButton.ForeColor = SystemColors.ActiveCaptionText;
            submitButton.Location = new Point(406, 340);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(80, 35);
            submitButton.TabIndex = 7;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(255, 192, 192);
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.ForeColor = SystemColors.ActiveCaptionText;
            exitButton.Location = new Point(203, 340);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(80, 35);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Form3
            // 
            AcceptButton = submitButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.imagw21;
            ClientSize = new Size(618, 403);
            Controls.Add(exitButton);
            Controls.Add(submitButton);
            Controls.Add(matricIDtextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(UserNametextBox);
            Controls.Add(Passwordlabel);
            Controls.Add(matricIDlabel);
            Controls.Add(UserNameLabel);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            Name = "Form3";
            Text = "Sign Up form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label UserNameLabel;
        private Label matricIDlabel;
        private Label Passwordlabel;
        private TextBox UserNametextBox;
        private TextBox passwordTextBox;
        private TextBox matricIDtextBox;
        private Button submitButton;
        private Button exitButton;
    }
}