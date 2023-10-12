namespace Picture_Matching_Game
{
    partial class Form2
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
            SignUpButton = new Button();
            loginButton = new Button();
            salamLabel = new Label();
            welcomeLabel = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // openingPageLebel
            // 
            openingPageLebel.AutoSize = true;
            openingPageLebel.BackColor = SystemColors.ActiveCaption;
            openingPageLebel.BorderStyle = BorderStyle.FixedSingle;
            openingPageLebel.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            openingPageLebel.ForeColor = Color.Brown;
            openingPageLebel.Location = new Point(174, 131);
            openingPageLebel.Name = "openingPageLebel";
            openingPageLebel.Size = new Size(245, 30);
            openingPageLebel.TabIndex = 0;
            openingPageLebel.Text = "Picture Matching Game";
            openingPageLebel.TextAlign = ContentAlignment.TopCenter;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = SystemColors.ActiveCaption;
            SignUpButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpButton.Location = new Point(157, 283);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(75, 33);
            SignUpButton.TabIndex = 1;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ActiveCaption;
            loginButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(396, 282);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 34);
            loginButton.TabIndex = 1;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // salamLabel
            // 
            salamLabel.AutoSize = true;
            salamLabel.BackColor = SystemColors.ActiveCaption;
            salamLabel.BorderStyle = BorderStyle.FixedSingle;
            salamLabel.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            salamLabel.ForeColor = Color.Brown;
            salamLabel.Location = new Point(206, 9);
            salamLabel.Name = "salamLabel";
            salamLabel.Size = new Size(187, 30);
            salamLabel.TabIndex = 0;
            salamLabel.Text = "Assalamualaikum";
            salamLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = SystemColors.ActiveCaption;
            welcomeLabel.BorderStyle = BorderStyle.FixedSingle;
            welcomeLabel.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeLabel.ForeColor = Color.Brown;
            welcomeLabel.Location = new Point(243, 49);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(105, 30);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome";
            welcomeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(269, 88);
            label3.Name = "label3";
            label3.Size = new Size(40, 30);
            label3.TabIndex = 0;
            label3.Text = "To";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.opening;
            ClientSize = new Size(613, 387);
            Controls.Add(loginButton);
            Controls.Add(SignUpButton);
            Controls.Add(salamLabel);
            Controls.Add(label3);
            Controls.Add(welcomeLabel);
            Controls.Add(openingPageLebel);
            ForeColor = SystemColors.ControlText;
            Name = "Form2";
            Text = "Game Opening Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label openingPageLebel;
        private Button SignUpButton;
        private Button loginButton;
        private Label salamLabel;
        private Label welcomeLabel;
        private Label label3;
    }
}