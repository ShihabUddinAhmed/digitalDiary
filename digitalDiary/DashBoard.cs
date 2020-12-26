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
        string ev;
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
            DataTable dataTableH = new DataTable();
            dataTableH.Columns.Add("EventName High Priority", typeof(string));
            foreach(string str in eventsH)
            {
                DataRow rowH = dataTableH.NewRow();
                rowH["EventName High Priority"] = str;
                dataTableH.Rows.Add(rowH);
            }
            DataTable dataTableM = new DataTable();
            dataTableM.Columns.Add("EventName Moderate Priority", typeof(string));
            foreach (string str in eventsM)
            {
                DataRow rowM = dataTableM.NewRow();
                rowM["EventName Moderate Priority"] = str;
                dataTableM.Rows.Add(rowM);
            }
            DataTable dataTableL = new DataTable();
            dataTableL.Columns.Add("EventName Less Priority", typeof(string));
            foreach (string str in eventsL)
            {
                DataRow rowL = dataTableL.NewRow();
                rowL["EventName Less Priority"] = str;
                dataTableL.Rows.Add(rowL);
            }
            highDataGridView.DataSource = dataTableH;
            moderateDataGridView.DataSource = dataTableM;
            lessDataGridView.DataSource = dataTableL;
            dataAccessH.CloseConnection();
            dataAccessM.CloseConnection();
            dataAccessL.CloseConnection();
        }

        private void highDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string eventName = (string)highDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                updateTextBox.Text = eventName;
                ev = eventName;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void moderateDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string eventName = (string)moderateDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                updateTextBox.Text = eventName;
                ev = eventName;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void lessDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string eventName = (string)lessDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                updateTextBox.Text = eventName;
                ev = eventName;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void updateEventButton_Click(object sender, EventArgs e)
        {
            string sss="";
            try
            {
                string sql1 = "SELECT * FROM Events WHERE EventName='" + updateTextBox.Text + "'";sss = sql1;
                DataAccess dataAccess1 = new DataAccess();
                SqlDataReader sqlDataReader1 = dataAccess1.GetData(sql1);
                sqlDataReader1.Read();
                Event @event = new Event((int)sqlDataReader1["ID"], sqlDataReader1["EventName"].ToString(), sqlDataReader1["EventDescription"].ToString(), (byte[])sqlDataReader1["Image"], sqlDataReader1["Priority"].ToString(), sqlDataReader1["ModificationDate"].ToString(), user);
                Editor editor = new Editor(@event, user, this, updateTextBox.Text);
                dataAccess1.CloseConnection();
                editor.Show();
                this.Hide();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string sqlD = "DELETE FROM Events WHERE EventName='" + updateTextBox.Text+"'";
            try
            {
                DataAccess dataAccess = new DataAccess();
                int resD = dataAccess.ExecuteQuery(sqlD);
                if(resD>0)
                {
                    MessageBox.Show("Successfuly Deleted!");
                }
                else
                {
                    MessageBox.Show("Unsuccess! Please try again...");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshButton.Click += this.DashBoard_Load;
        }
    }
}
