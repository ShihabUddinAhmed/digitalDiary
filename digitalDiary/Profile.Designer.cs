
using System;

namespace digitalDiary
{
    partial class Profile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.bloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.bloodGroupLebel = new System.Windows.Forms.Label();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.dateOFBirthabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.userNameLebel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLebel = new System.Windows.Forms.Label();
            this.personalInformationLabel = new System.Windows.Forms.Label();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.changePassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.bloodGroupComboBox);
            this.panel1.Controls.Add(this.bloodGroupLebel);
            this.panel1.Controls.Add(this.otherRadioButton);
            this.panel1.Controls.Add(this.femaleRadioButton);
            this.panel1.Controls.Add(this.maleRadioButton);
            this.panel1.Controls.Add(this.dOBDateTimePicker);
            this.panel1.Controls.Add(this.userNameTextBox);
            this.panel1.Controls.Add(this.dateOFBirthabel);
            this.panel1.Controls.Add(this.genderLabel);
            this.panel1.Controls.Add(this.userNameLebel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.nameLebel);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(87, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 356);
            this.panel1.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(367, 137);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(425, 22);
            this.emailTextBox.TabIndex = 64;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(13, 135);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(98, 24);
            this.emailLabel.TabIndex = 63;
            this.emailLabel.Text = "E-mail     : ";
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
            this.bloodGroupComboBox.Location = new System.Drawing.Point(367, 269);
            this.bloodGroupComboBox.Name = "bloodGroupComboBox";
            this.bloodGroupComboBox.Size = new System.Drawing.Size(425, 24);
            this.bloodGroupComboBox.TabIndex = 62;
            // 
            // bloodGroupLebel
            // 
            this.bloodGroupLebel.AutoSize = true;
            this.bloodGroupLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodGroupLebel.Location = new System.Drawing.Point(13, 267);
            this.bloodGroupLebel.Name = "bloodGroupLebel";
            this.bloodGroupLebel.Size = new System.Drawing.Size(122, 24);
            this.bloodGroupLebel.TabIndex = 61;
            this.bloodGroupLebel.Text = "Blood Group:";
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Location = new System.Drawing.Point(565, 225);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(72, 21);
            this.otherRadioButton.TabIndex = 60;
            this.otherRadioButton.TabStop = true;
            this.otherRadioButton.Text = "Others";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(455, 225);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(75, 21);
            this.femaleRadioButton.TabIndex = 59;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(367, 225);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(59, 21);
            this.maleRadioButton.TabIndex = 58;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.Location = new System.Drawing.Point(367, 181);
            this.dOBDateTimePicker.MaxDate = new System.DateTime(2020, 12, 20, 0, 0, 0, 0);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(425, 22);
            this.dOBDateTimePicker.TabIndex = 57;
            this.dOBDateTimePicker.Value = new System.DateTime(2020, 12, 20, 0, 0, 0, 0);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(367, 98);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(425, 22);
            this.userNameTextBox.TabIndex = 56;
            // 
            // dateOFBirthabel
            // 
            this.dateOFBirthabel.AutoSize = true;
            this.dateOFBirthabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOFBirthabel.Location = new System.Drawing.Point(13, 179);
            this.dateOFBirthabel.Name = "dateOFBirthabel";
            this.dateOFBirthabel.Size = new System.Drawing.Size(115, 24);
            this.dateOFBirthabel.TabIndex = 54;
            this.dateOFBirthabel.Text = "Date of Birth:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(13, 222);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(79, 24);
            this.genderLabel.TabIndex = 53;
            this.genderLabel.Text = "Gender:";
            // 
            // userNameLebel
            // 
            this.userNameLebel.AutoSize = true;
            this.userNameLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLebel.ForeColor = System.Drawing.Color.White;
            this.userNameLebel.Location = new System.Drawing.Point(13, 96);
            this.userNameLebel.Name = "userNameLebel";
            this.userNameLebel.Size = new System.Drawing.Size(130, 24);
            this.userNameLebel.TabIndex = 52;
            this.userNameLebel.Text = "User Name   : ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(367, 56);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(425, 22);
            this.nameTextBox.TabIndex = 50;
            // 
            // nameLebel
            // 
            this.nameLebel.AutoSize = true;
            this.nameLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLebel.ForeColor = System.Drawing.Color.White;
            this.nameLebel.Location = new System.Drawing.Point(13, 54);
            this.nameLebel.Name = "nameLebel";
            this.nameLebel.Size = new System.Drawing.Size(86, 24);
            this.nameLebel.TabIndex = 49;
            this.nameLebel.Text = "Name   : ";
            // 
            // personalInformationLabel
            // 
            this.personalInformationLabel.AutoSize = true;
            this.personalInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInformationLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.personalInformationLabel.Location = new System.Drawing.Point(82, 45);
            this.personalInformationLabel.Name = "personalInformationLabel";
            this.personalInformationLabel.Size = new System.Drawing.Size(261, 29);
            this.personalInformationLabel.TabIndex = 1;
            this.personalInformationLabel.Text = "Personal Information:";
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.ForeColor = System.Drawing.Color.White;
            this.saveChangesButton.Location = new System.Drawing.Point(746, 476);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(146, 38);
            this.saveChangesButton.TabIndex = 3;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(594, 476);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(146, 38);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // changePassword
            // 
            this.changePassword.BackColor = System.Drawing.SystemColors.Highlight;
            this.changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassword.ForeColor = System.Drawing.Color.White;
            this.changePassword.Location = new System.Drawing.Point(87, 476);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(256, 38);
            this.changePassword.TabIndex = 5;
            this.changePassword.Text = "Change Password";
            this.changePassword.UseVisualStyleBackColor = false;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 553);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.personalInformationLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Profile_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.ComboBox bloodGroupComboBox;
        private System.Windows.Forms.Label bloodGroupLebel;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label dateOFBirthabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label userNameLebel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLebel;
        private System.Windows.Forms.Label personalInformationLabel;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button changePassword;
    }
}