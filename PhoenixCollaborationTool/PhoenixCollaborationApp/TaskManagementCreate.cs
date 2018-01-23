using System;
using System.Net;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using Amazon.S3.Model;
using Amazon.S3;
using Newtonsoft.Json;
using System.Text;
//using Amazon.WorkDocs;

namespace PhoenixCollaborationApp
{
    public partial class TaskManagementCreate : UserControl
    {
        private static TaskManagementCreate _instance;
        public static TaskManagementCreate Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TaskManagementCreate();
                return _instance;
            }
        }
		string hashSecret = "pct@nwmsu#2017";
		string jsonURL = "https://aws-phoenix.s3-us-west-2.amazonaws.com/Data.json?AWSAccessKeyId=AKIAIMD627FG7CHA6SYQ&Expires=1514786340&Signature=DbrgDMcW6DiUNQO5fJXVtsHM6s0%3D";
		public TaskManagementCreate()
        {
            InitializeComponent();
            Fillcombo();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
             
        }

        private void TaskManagementCreate_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=phoenix.cxrkvshmjrzo.us-west-2.rds.amazonaws.com;" +
            "Initial Catalog=Phoenix_Users;" +
            "User id=pctadmin;" +
            "Password=WeAreATeam;";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast (TaskId as int)), 0) + 1 from taskmanagement", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TaskId.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (TaskDesc.Text == "" || AssignTo.Text == ""||Priority.Text==""||Status.Text=="")
                {
                    MessageBox.Show("Please enter all the fields, Thank you!");
                }

                else
                {
					//This piece of code creates a new webclient and downloads the JSON file from the specif URL.
					WebClient wc = new WebClient();
					var json = wc.DownloadString(jsonURL);
					
					SecData connect = JsonConvert.DeserializeObject<SecData>(json);

					SqlConnection conn = new SqlConnection();
					conn.ConnectionString = "Data Source=" + connect.DataSource + "Initial Catalog=" + connect.InitialCatalog + "User id=" + connect.UserName + "Password=" + connect.Password;
					conn.Open();
                    //SqlCommand q2 = new SqlCommand("Insert into users(TaskDescription, Date) values ('@TD','@DT');",conn);
                    //q2.Parameters.AddWithValue("@TD", taskDesc.Text);
                    //q2.Parameters.AddWithValue("@DT", date.Text);
                    SqlCommand t1 = new SqlCommand("Insert into  taskmanagement(TaskId,TaskDescription,StartDate,Deadline,AssignedTo,Priority,Status,EndDate) values(@TI,@TD,@SD,@TDD,@AT,@PR,@ST,@ED); ", conn);
                    t1.Parameters.AddWithValue("@TI", TaskId.Text);
                    t1.Parameters.AddWithValue("@TD", TaskDesc.Text);
                    t1.Parameters.AddWithValue("@SD", StartDate.Text);
                    t1.Parameters.AddWithValue("@TDD", TaskDeadline.Text);
                    t1.Parameters.AddWithValue("@AT", AssignTo.Text);
                    t1.Parameters.AddWithValue("@PR", Priority.Text);
                    t1.Parameters.AddWithValue("@ST", Status.Text);
                    t1.Parameters.AddWithValue("@ED", EndDate.Text);
                    //sql.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(t1);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    MessageBox.Show("Thankyou for entering the task details");
                    ClearData();
                    SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast (TaskId as int)), 0) + 1 from taskmanagement", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    TaskId.Text = dt.Rows[0][0].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: {0}", ex.Message);
            }
            //bunifuMetroTextBox1;
            //string taskDesc = bunifuMetroTextbox1.Text;
            //string date = dateTimePicker1.Text;
            //Console.WriteLine(date);

        }
        void ClearData()
        {
            TaskDesc.Text = "";
            StartDate.Value = DateTime.Now;
            TaskDeadline.Value = DateTime.Now;
            EndDate.Value = DateTime.Now;
            
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearData();
        }

		void Fillcombo()
		{
			//This piece of code creates a new webclient and downloads the JSON file from the specif URL.
			WebClient wc = new WebClient();
			var json = wc.DownloadString(jsonURL);
			
			SecData connect = JsonConvert.DeserializeObject<SecData>(json);

			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = "Data Source=" + connect.DataSource + "Initial Catalog=" + connect.InitialCatalog + "User id=" + connect.UserName + "Password=" + connect.Password;
			string query = "select name from Users;";
			SqlCommand cmddatabase = new SqlCommand(query, conn);
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmddatabase);
			da.Fill(dt);
			foreach (DataRow dr in dt.Rows)
			{
					AssignTo.Items.Add(dr["name"].ToString());
				

			}
		}
        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AssignTo_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void AssignTo_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Status_onItemSelected(object sender, EventArgs e)
        {

        }

        private void EndDate_ValueChanged(object sender, EventArgs e)
        {

        }

		private void AssignTo_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
    }
}
