using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
