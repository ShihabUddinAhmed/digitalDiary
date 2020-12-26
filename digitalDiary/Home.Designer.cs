
namespace digitalDiary
{
    partial class Home
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
            this.loginButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.signUpLebel = new System.Windows.Forms.Label();
            this.passwordLebel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameLebel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.digitalDiaryLebel = new System.Windows.Forms.Label();
            this.smallcommentLebel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(221, 417);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(520, 60);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "LOG IN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.signUpButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(554, 500);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(140, 32);
            this.signUpButton.TabIndex = 1;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // signUpLebel
            // 
            this.signUpLebel.AutoSize = true;
            this.signUpLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLebel.Location = new System.Drawing.Point(248, 504);
            this.signUpLebel.Name = "signUpLebel";
            this.signUpLebel.Size = new System.Drawing.Size(300, 24);
            this.signUpLebel.TabIndex = 2;
            this.signUpLebel.Text = "Don\'t have Account? Create new...";
            this.signUpLebel.Click += new System.EventHandler(this.signUpLebel_Click);
            // 
            // passwordLebel
            // 
            this.passwordLebel.AutoSize = true;
            this.passwordLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLebel.Location = new System.Drawing.Point(217, 351);
            this.passwordLebel.Name = "passwordLebel";
            this.passwordLebel.Size = new System.Drawing.Size(132, 24);
            this.passwordLebel.TabIndex = 3;
            this.passwordLebel.Text = "Password      : ";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(355, 353);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '⚫';
            this.passwordTextBox.Size = new System.Drawing.Size(386, 22);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // userNameLebel
            // 
            this.userNameLebel.AutoSize = true;
            this.userNameLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLebel.Location = new System.Drawing.Point(217, 295);
            this.userNameLebel.Name = "userNameLebel";
            this.userNameLebel.Size = new System.Drawing.Size(130, 24);
            this.userNameLebel.TabIndex = 5;
            this.userNameLebel.Text = "User Name   : ";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(355, 297);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(386, 22);
            this.userNameTextBox.TabIndex = 6;
            this.userNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userNameTextBox_KeyDown);
            // 
            // digitalDiaryLebel
            // 
            this.digitalDiaryLebel.AutoSize = true;
            this.digitalDiaryLebel.Font = new System.Drawing.Font("Stencil", 67.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalDiaryLebel.Location = new System.Drawing.Point(37, 36);
            this.digitalDiaryLebel.Name = "digitalDiaryLebel";
            this.digitalDiaryLebel.Size = new System.Drawing.Size(872, 136);
            this.digitalDiaryLebel.TabIndex = 7;
            this.digitalDiaryLebel.Text = "Digital Diary";
            // 
            // smallcommentLebel
            // 
            this.smallcommentLebel.AutoSize = true;
            this.smallcommentLebel.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallcommentLebel.Location = new System.Drawing.Point(573, 152);
            this.smallcommentLebel.Name = "smallcommentLebel";
            this.smallcommentLebel.Size = new System.Drawing.Size(336, 20);
            this.smallcommentLebel.TabIndex = 8;
            this.smallcommentLebel.Text = "A digital solution of Diary Writing.";
            this.smallcommentLebel.Click += new System.EventHandler(this.smallcommentLebel_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 553);
            this.Controls.Add(this.smallcommentLebel);
            this.Controls.Add(this.digitalDiaryLebel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userNameLebel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLebel);
            this.Controls.Add(this.signUpLebel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.loginButton);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Diary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label signUpLebel;
        private System.Windows.Forms.Label passwordLebel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label userNameLebel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label digitalDiaryLebel;
        private System.Windows.Forms.Label smallcommentLebel;
    }
}

