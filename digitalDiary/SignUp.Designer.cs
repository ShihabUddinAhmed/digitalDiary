
using System;

namespace digitalDiary
{
    partial class SignUp
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLebel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLebel = new System.Windows.Forms.Label();
            this.userNameLebel = new System.Windows.Forms.Label();
            this.confirmPasswordLebel = new System.Windows.Forms.Label();
            this.dateOFBirthabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.bloodGroupLebel = new System.Windows.Forms.Label();
            this.bloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.agreementCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(484, 83);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(425, 22);
            this.nameTextBox.TabIndex = 10;
            // 
            // nameLebel
            // 
            this.nameLebel.AutoSize = true;
            this.nameLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLebel.Location = new System.Drawing.Point(130, 81);
            this.nameLebel.Name = "nameLebel";
            this.nameLebel.Size = new System.Drawing.Size(86, 24);
            this.nameLebel.TabIndex = 9;
            this.nameLebel.Text = "Name   : ";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(484, 208);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '⚫';
            this.passwordTextBox.Size = new System.Drawing.Size(425, 22);
            this.passwordTextBox.TabIndex = 8;
            // 
            // passwordLebel
            // 
            this.passwordLebel.AutoSize = true;
            this.passwordLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLebel.Location = new System.Drawing.Point(130, 206);
            this.passwordLebel.Name = "passwordLebel";
            this.passwordLebel.Size = new System.Drawing.Size(132, 24);
            this.passwordLebel.TabIndex = 7;
            this.passwordLebel.Text = "Password      : ";
            // 
            // userNameLebel
            // 
            this.userNameLebel.AutoSize = true;
            this.userNameLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLebel.Location = new System.Drawing.Point(130, 123);
            this.userNameLebel.Name = "userNameLebel";
            this.userNameLebel.Size = new System.Drawing.Size(130, 24);
            this.userNameLebel.TabIndex = 12;
            this.userNameLebel.Text = "User Name   : ";
            // 
            // confirmPasswordLebel
            // 
            this.confirmPasswordLebel.AutoSize = true;
            this.confirmPasswordLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLebel.Location = new System.Drawing.Point(130, 255);
            this.confirmPasswordLebel.Name = "confirmPasswordLebel";
            this.confirmPasswordLebel.Size = new System.Drawing.Size(202, 24);
            this.confirmPasswordLebel.TabIndex = 11;
            this.confirmPasswordLebel.Text = "Confirm Password      : ";
            // 
            // dateOFBirthabel
            // 
            this.dateOFBirthabel.AutoSize = true;
            this.dateOFBirthabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOFBirthabel.Location = new System.Drawing.Point(130, 304);
            this.dateOFBirthabel.Name = "dateOFBirthabel";
            this.dateOFBirthabel.Size = new System.Drawing.Size(115, 24);
            this.dateOFBirthabel.TabIndex = 14;
            this.dateOFBirthabel.Text = "Date of Birth:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(130, 356);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(79, 24);
            this.genderLabel.TabIndex = 13;
            this.genderLabel.Text = "Gender:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(484, 257);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '⚫';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(425, 22);
            this.confirmPasswordTextBox.TabIndex = 15;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(484, 125);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(425, 22);
            this.userNameTextBox.TabIndex = 16;
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.Location = new System.Drawing.Point(484, 306);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(425, 22);
            this.dOBDateTimePicker.TabIndex = 19;
            this.dOBDateTimePicker.MaxDate = DateTime.Today.AddDays(-1);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(484, 359);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(59, 21);
            this.maleRadioButton.TabIndex = 20;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(572, 359);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(75, 21);
            this.femaleRadioButton.TabIndex = 21;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Location = new System.Drawing.Point(682, 359);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(72, 21);
            this.otherRadioButton.TabIndex = 22;
            this.otherRadioButton.TabStop = true;
            this.otherRadioButton.Text = "Others";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            // 
            // bloodGroupLebel
            // 
            this.bloodGroupLebel.AutoSize = true;
            this.bloodGroupLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodGroupLebel.Location = new System.Drawing.Point(130, 401);
            this.bloodGroupLebel.Name = "bloodGroupLebel";
            this.bloodGroupLebel.Size = new System.Drawing.Size(122, 24);
            this.bloodGroupLebel.TabIndex = 23;
            this.bloodGroupLebel.Text = "Blood Group:";
            // 
            // bloodGroupComboBox
            // 
            this.bloodGroupComboBox.FormattingEnabled = true;
            this.bloodGroupComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.bloodGroupComboBox.Location = new System.Drawing.Point(484, 403);
            this.bloodGroupComboBox.Name = "bloodGroupComboBox";
            this.bloodGroupComboBox.Size = new System.Drawing.Size(425, 24);
            this.bloodGroupComboBox.TabIndex = 24;
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(769, 484);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(140, 32);
            this.signUpButton.TabIndex = 25;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(614, 484);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(140, 32);
            this.backButton.TabIndex = 26;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(130, 162);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(98, 24);
            this.emailLabel.TabIndex = 27;
            this.emailLabel.Text = "E-mail     : ";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(484, 164);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(425, 22);
            this.emailTextBox.TabIndex = 28;
            // 
            // agreementCheckBox
            // 
            this.agreementCheckBox.AutoSize = true;
            this.agreementCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreementCheckBox.ForeColor = System.Drawing.Color.Red;
            this.agreementCheckBox.Location = new System.Drawing.Point(90, 446);
            this.agreementCheckBox.Name = "agreementCheckBox";
            this.agreementCheckBox.Size = new System.Drawing.Size(453, 22);
            this.agreementCheckBox.TabIndex = 29;
            this.agreementCheckBox.Text = "*I agree to the License Terms & Services as well as Privacy Policy";
            this.agreementCheckBox.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 553);
            this.Controls.Add(this.agreementCheckBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.bloodGroupComboBox);
            this.Controls.Add(this.bloodGroupLebel);
            this.Controls.Add(this.otherRadioButton);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.dOBDateTimePicker);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.dateOFBirthabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.userNameLebel);
            this.Controls.Add(this.confirmPasswordLebel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLebel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLebel);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUp_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLebel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLebel;
        private System.Windows.Forms.Label userNameLebel;
        private System.Windows.Forms.Label confirmPasswordLebel;
        private System.Windows.Forms.Label dateOFBirthabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.Label bloodGroupLebel;
        private System.Windows.Forms.ComboBox bloodGroupComboBox;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox agreementCheckBox;
    }
}