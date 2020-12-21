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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //"DELETE FROM Products WHERE ProductId=" + id;
            //SqlDataReader reader = dataAccess.GetData(sql);
            //reader.Read();
            //Category category = new Category();
            //category.CategoryId = (int)reader["CategoryId"];
            //category.CategoryName = reader["CategoryName"].ToString();
            //return category;
            //"SELECT * FROM Categories WHERE CategoryName='" + categoryName + "'"
            //"UPDATE Products SET ProductName='" + product.ProductName + "',Price=" + product.Price + ",Quantity=" + product.Quantity + ",CategoryId=" + product.CategoryId + " WHERE ProductId=" + product.ProductId;
            if(userNameTextBox.Text!=string.Empty && passwordTextBox.Text!=string.Empty)
            {
                string sql = "SELECT * FROM Users WHERE UserName='" + userNameTextBox.Text + "'AND Password='" + passwordTextBox.Text + "'";
                SqlDataReader sqlDataReader;
                try
                {
                    DataAccess dataAccess = new DataAccess();
                    sqlDataReader = dataAccess.GetData(sql);
                    sqlDataReader.Read();
                    int id = (int)sqlDataReader["id"];
                    User user = new User(id, sqlDataReader["Name"].ToString(), sqlDataReader["UserName"].ToString(), sqlDataReader["Email"].ToString(), sqlDataReader["Password"].ToString(), sqlDataReader["DOB"].ToString(), sqlDataReader["Gender"].ToString(), sqlDataReader["BloodGroup"].ToString());
                    DashBoard dashBoard = new DashBoard(user, this);
                    dashBoard.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    MessageBox.Show("Invalid UserName or Password!\nPlease Try Again...");
                }
            }
            else
            {
                MessageBox.Show("Fields Cannot be Empty!");
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp(this);
            signup.Show();
            this.Hide();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void signUpLebel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
