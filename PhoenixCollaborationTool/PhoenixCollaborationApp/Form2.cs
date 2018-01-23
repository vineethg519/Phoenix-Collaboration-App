using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PhoenixCollaborationApp
{
    public partial class forgotPassForm : Form
    {
        public forgotPassForm()
        {
            InitializeComponent();
            old_pwd.PasswordChar = '*';
            new_pwd.PasswordChar = '|';

        }
        //  Form1 login_page = new Form1();
        MainForm ob = new MainForm();
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void login_page_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
        private void change_pwd_Click(object sender, EventArgs e)
        {
            try
            {
                if (username2.Text == "" || new_pwd.Text == "" || old_pwd.Text == "")
                {
                    MessageBox.Show("Please enter all the fields, Thank you!");
                }
                else
                {
                    checkEmail();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception: {0}", ex.Message);
            }
        }
        public void checkEmail()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=vineeth.cblh3csuj0ih.us-east-2.rds.amazonaws.com;" +
            "Initial Catalog=Phoenix_Users;" +
            "User id=vineeth;" +
            "Password=vineethgajula;";
            conn.Open();
            SqlCommand q1 = new SqlCommand("select * from Users where NAME=@username and PASSWORD=@password", conn);
            q1.Parameters.AddWithValue("@username", username2.Text);
            q1.Parameters.AddWithValue("@password", old_pwd.Text);
            //sql.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(q1);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                // email exists and proceed to new password authentication/change here itself.
                //MessageBox.Show("user exists");
                checkPassword();
            }
            else
            {
                MessageBox.Show("Unable to change password. Please Check given credentials.");
            }
        }

        public void checkPassword()
        {
            // update password for the user
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=vineeth.cblh3csuj0ih.us-east-2.rds.amazonaws.com;" +
            "Initial Catalog=Phoenix_Users;" +
            "User id=vineeth;" +
            "Password=vineethgajula;";
            conn.Open();
            SqlCommand q1 = new SqlCommand("select password from Users where NAME=@username and PASSWORD=@password", conn);
            q1.Parameters.AddWithValue("@username", username2.Text);
            q1.Parameters.AddWithValue("@password", new_pwd.Text);
            //sql.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(q1);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                // email exists and proceed to new password authentication/change here itself.
                //MessageBox.Show("user exists");
                MessageBox.Show("ERROR: Passwords cannot be same");


            }
            else
            {
               // MessageBox.Show("ALL validations done....");
                changePassword();
            }
        }

        public void changePassword()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=vineeth.cblh3csuj0ih.us-east-2.rds.amazonaws.com;" +
            "Initial Catalog=Phoenix_Users;" +
            "User id=vineeth;" +
            "Password=vineethgajula;";
            conn.Open();
            SqlCommand q1 = new SqlCommand("update Users set password = @newpassword where NAME=@username and PASSWORD=@oldpassword", conn);
            q1.Parameters.AddWithValue("@username", username2.Text);
            q1.Parameters.AddWithValue("@oldpassword", old_pwd.Text);
            q1.Parameters.AddWithValue("@newpassword", new_pwd.Text);
            //sql.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(q1);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
               // email exists and proceed to new password authentication/change here itself.
                //MessageBox.Show("user exists");
                MessageBox.Show("Password Changed Successfully!");
            this.Hide();
            Form1 login = new Form1();
            login.Show();

        }
        private void username2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

