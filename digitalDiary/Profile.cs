using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digitalDiary
{
    public partial class Profile : Form
    {
        User user;
        Form back;
        public Profile(User user, Form back)
        {
            InitializeComponent();
            this.user = user;
            this.back = back;
            this.nameTextBox.Text = user.Name;
            this.userNameTextBox.Text = user.UserName;
            this.emailTextBox.Text = user.Email;
            this.dOBDateTimePicker.Text = user.Dob;
            this.bloodGroupComboBox.Text = user.BloodGroup;
            if(user.Gender=="Male")
            {
                this.maleRadioButton.Checked = true;
            }
            else if(user.Gender=="Female")
            {
                this.femaleRadioButton.Checked = true;
            }
            else
            {
                this.otherRadioButton.Checked = true;
            }
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text!=string.Empty && userNameTextBox.Text!=string.Empty && emailTextBox.Text!=string.Empty && bloodGroupComboBox.Text!=string.Empty)
            {
                this.user.Name = nameTextBox.Text;
                this.user.UserName = userNameTextBox.Text;
                this.user.Email = emailTextBox.Text;
                this.user.Dob = dOBDateTimePicker.Text;
                this.user.BloodGroup = bloodGroupComboBox.Text;
                if (maleRadioButton.Checked)
                {
                    this.user.Gender = maleRadioButton.Text;
                }
                else if (femaleRadioButton.Checked)
                {
                    this.user.Gender = femaleRadioButton.Text;
                }
                else
                {
                    this.user.Gender = otherRadioButton.Text;
                }
                string sql = "UPDATE Users SET Name='" + this.user.Name + "',UserName='" + this.user.UserName + "',Email='" + this.user.Email + "',DOB='" + this.user.Dob + "',Password='" + this.user.Password + "',Gender='" + this.user.Gender + "',BloodGroup='" + this.user.BloodGroup + "' WHERE id=" + this.user.ID;
                try
                {
                    DataAccess dataAccess = new DataAccess();
                    int result = dataAccess.ExecuteQuery(sql);
                    if (result > 0)
                    {
                        MessageBox.Show("Profile Updated Successfully...!");
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful operation...");
                    }
                    dataAccess.CloseConnection();
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    MessageBox.Show("Invalid Update Request!\nPlease Try Again...");
                }
            }
            else
            {
                MessageBox.Show("Fields cannot be Empty...!");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            back.Show();
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            string myvalue = Interaction.InputBox("Change Password", "Enter Current Password:", "Enter password...");
            if(myvalue==user.Password)
            {
                string newPass = Interaction.InputBox("Change Password", "Enter New Password:", "Enter New password...");
                string confPass  = Interaction.InputBox("Change Password", "Confirm Password:", "Enter password...");
                if(newPass==confPass)
                {
                    user.Password = newPass;
                }
                else
                {
                    MessageBox.Show("Password Confirmation Error!");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
