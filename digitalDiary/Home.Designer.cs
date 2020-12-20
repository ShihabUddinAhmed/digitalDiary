
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
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(221, 417);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(520, 60);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "LOG IN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(554, 500);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(140, 32);
            this.signUpButton.TabIndex = 1;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
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
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 553);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userNameLebel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLebel);
            this.Controls.Add(this.signUpLebel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.loginButton);
            this.Name = "Home";
            this.Text = "Form1";
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
    }
}

