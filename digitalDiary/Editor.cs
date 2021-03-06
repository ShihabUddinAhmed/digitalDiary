﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digitalDiary
{
    public partial class Editor : Form
    {
        string imageLocation=string.Empty, reference;
        Event eventU;
        User user;
        Form back;
        public Editor(User user, Form back)
        {
            InitializeComponent();
            eventU = null;
            this.user = user;
            this.back = back;
        }

        public Editor(Event eventU, User user, Form back, string reference)
        {
            InitializeComponent();
            this.eventU = eventU;
            this.user = user;
            this.back = back;
            this.reference = reference;
            eventTitleTextBox.Text = eventU.EventName;
            priorityComboBox.Text = eventU.Priority;
            descriptionRichTextBox.Text = eventU.EventDescription;
            if(eventU.Image==null)
            {
                pictureBox.Image = null;
            }
            else
            {
                MemoryStream memoryStream = new MemoryStream(eventU.Image);
                pictureBox.Image = Image.FromStream(memoryStream);
            }
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageOpenFileDialog.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult result = imageOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(imageOpenFileDialog.FileName);
                imageLocation = imageOpenFileDialog.FileName.ToString();
            }
            
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(eventTitleTextBox.Text!=string.Empty && priorityComboBox.Text!=string.Empty)
            {
                if (eventU == null)
                {
                    try
                    {
                        string sql = "INSERT INTO Events(EventName,EventDescription,Image,Priority,ModificationDate,userID) VALUES('" + eventTitleTextBox.Text + "','" + descriptionRichTextBox.Text + "',@image,'" + priorityComboBox.Text + "','" + DateTime.Today.ToString() + "'," + user.ID + ")";
                        FileStream fileStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader binaryReader = new BinaryReader(fileStream);
                        byte[] img = binaryReader.ReadBytes((int)fileStream.Length);
                        DataAccess dataAccess = new DataAccess();
                        SqlCommand sqlCommand = new SqlCommand(sql, dataAccess.Connection);
                        sqlCommand.Parameters.Add(new SqlParameter("@image", img));
                        int r = dataAccess.ExecuteQuery(sqlCommand);
                        if (r > 0)
                        {
                            MessageBox.Show("Event Created Succesfully!");
                            this.Hide();
                            back.Show();
                        }
                        dataAccess.CloseConnection();
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
                }
                else
                {
                    if(imageLocation==string.Empty)
                    {
                        try
                        {
                            string sql = "UPDATE Events SET EventName='" + eventTitleTextBox.Text + "',Priority='" + priorityComboBox.Text + "',EventDescription='" + descriptionRichTextBox.Text + "' WHERE EventName='"+this.reference+"' AND UserID="+user.ID;
                            
                            DataAccess dataAccessU = new DataAccess();
                            int r = dataAccessU.ExecuteQuery(sql);
                            if (r > 0)
                            {
                                MessageBox.Show("Event Updated Succesfully!");
                                this.Hide();
                                back.Show();
                            }
                            dataAccessU.CloseConnection();
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.ToString());
                        }
                    }
                    else
                    {
                        try
                        {
                            string sql = "UPDATE Events SET EventName='" + eventTitleTextBox.Text + "',Priority='" + priorityComboBox.Text + "',EventDescription='" + descriptionRichTextBox.Text + "',Image=@img WHERE EventName='" + this.reference + "' AND UserID=" + user.ID;
                            FileStream fileStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                            BinaryReader binaryReader = new BinaryReader(fileStream);
                            byte[] img = binaryReader.ReadBytes((int)fileStream.Length);
                            DataAccess dataAccess = new DataAccess();
                            SqlCommand sqlCommand = new SqlCommand(sql, dataAccess.Connection);
                            sqlCommand.Parameters.Add(new SqlParameter("@img", img));
                            int r = dataAccess.ExecuteQuery(sqlCommand);
                            if (r > 0)
                            {
                                MessageBox.Show("Event Updated Succesfully!");
                                this.Hide();
                                back.Show();
                            }
                            dataAccess.CloseConnection();
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.ToString());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Title & Priority Fields Cannot be Empty!");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            back.Show();
        }
    }
}
