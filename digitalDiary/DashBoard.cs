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

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            back.Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(this.user, this);
            profile.Show();
            this.Hide();

        }

        private void createEventButton_Click(object sender, EventArgs e)
        {
            Editor editor = new Editor(user, this);
            editor.Show();
            this.Hide();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            string sqlH = "SELECT EventName FROM Events WHERE UserID=" + user.ID + " AND Priority='High'";
            string sqlM = "SELECT EventName FROM Events WHERE UserID=" + user.ID + " AND Priority='Moderate'";
            string sqlL = "SELECT EventName FROM Events WHERE UserID=" + user.ID + " AND Priority='Less Important'";
            DataAccess dataAccessH = new DataAccess();
            DataAccess dataAccessM = new DataAccess();
            DataAccess dataAccessL = new DataAccess();
            SqlDataReader sqlDataReaderH = dataAccessH.GetData(sqlH);
            SqlDataReader sqlDataReaderM = dataAccessM.GetData(sqlM);
            SqlDataReader sqlDataReaderL = dataAccessL.GetData(sqlL);
            List<string> eventsH = new List<string>();
            List<string> eventsM = new List<string>();
            List<string> eventsL = new List<string>();
            eventsH.Add("Event Names");
            while (sqlDataReaderH.Read())
            {
                eventsH.Add(sqlDataReaderH["EventName"].ToString());
            }
            while (sqlDataReaderM.Read())
            {
                eventsM.Add(sqlDataReaderM["EventName"].ToString());
            }
            while (sqlDataReaderL.Read())
            {
                eventsL.Add(sqlDataReaderL["EventName"].ToString());
            }
            highDataGridView.DataSource = eventsH.ToString();
            moderateDataGridView.DataSource = eventsM.ToString();
            lessDataGridView.DataSource = eventsL.ToString();
            dataAccessH.CloseConnection();
            dataAccessM.CloseConnection();
            dataAccessL.CloseConnection();
        }
    }
}
