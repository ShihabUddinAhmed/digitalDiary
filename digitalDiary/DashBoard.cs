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
    public partial class DashBoard : Form
    {
        User user;
        Form back;
        public DashBoard(User user, Form back)
        {
            InitializeComponent();
            this.user = user;
            this.back = back;
            welcomeLabel.Text = "Welcome " + user.Name;
        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
