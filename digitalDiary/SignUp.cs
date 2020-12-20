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
    public partial class SignUp : Form
    {
        Form back;
        public SignUp(Form back)
        {
            InitializeComponent();
            this.back = back;
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            //string message = "Are you sure want to EXIT?";
            //string title = "Close Window";
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            //if (result == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else if (result == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {

            this.back.Show();
            this.Hide();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (nameTextBox.Text != "" && userNameTextBox.Text != "" && passwordTextBox.Text != "" && confirmPasswordTextBox.Text != "" &&
               emailTextBox.Text != "" && (maleRadioButton.Checked || femaleRadioButton.Checked ||
               otherRadioButton.Checked) && bloodGroupComboBox.Text != "" && agreementCheckBox.Checked)
            {
                if (passwordTextBox.Text == confirmPasswordTextBox.Text)
                {
                    string email = emailTextBox.Text;
                    string word = ".com";
                    if (email.Contains(word))
                    {
                        if (maleRadioButton.Checked)
                        {
                            sql = "INSERT INTO Users(Name,UserName,Email,DOB,Password,Gender,BloodGroup) VALUES('" + nameTextBox.Text + "','" + userNameTextBox.Text + "','" + emailTextBox.Text + "','" + dOBDateTimePicker.Text + "','" + passwordTextBox.Text + "','" + maleRadioButton.Text + "','" + bloodGroupComboBox.Text + "')";
                            
                        }
                        else if (femaleRadioButton.Checked)
                        {
                            sql = "INSERT INTO Users(Name,UserName,Email,DOB,Password,Gender,BloodGroup) VALUES('" + nameTextBox.Text + "','" + userNameTextBox.Text + "','" + emailTextBox.Text + "','" + dOBDateTimePicker.Text + "','" + passwordTextBox.Text + "','" + femaleRadioButton.Text + "','" + bloodGroupComboBox.Text + "')";

                        }
                        else
                        {
                            sql = "INSERT INTO Users(Name,UserName,Email,DOB,Password,Gender,BloodGroup) VALUES('" + nameTextBox.Text + "','" + userNameTextBox.Text + "','" + emailTextBox.Text + "','" + dOBDateTimePicker.Text + "','" + passwordTextBox.Text + "','" + otherRadioButton.Text + "','" + bloodGroupComboBox.Text + "')";

                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email!");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Password Again!");
                }
            }
            else
            {
                MessageBox.Show("Please fill up the form and check the agreement!");
            }
            DataAccess dataaccess = new DataAccess();
            int result = dataaccess.ExecuteQuery(sql);
            if(result>0)
            {
                MessageBox.Show("Registered Successfully...!");
            }
            else
            {
                MessageBox.Show("Unsuccessful operation...");
            }

        }
    }
}
