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

namespace PhoenixCollaborationApp
{
    public partial class TaskManagementIndividualTaskDetails : UserControl
    {
        private static TaskManagementIndividualTaskDetails _instance;
        public static TaskManagementIndividualTaskDetails Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TaskManagementIndividualTaskDetails();
                return _instance;
            }
        }
        string hashSecret = "pct@nwmsu#2017";
        string jsonURL = "https://aws-phoenix.s3-us-west-2.amazonaws.com/Data.json?AWSAccessKeyId=AKIAIMD627FG7CHA6SYQ&Expires=1514786340&Signature=DbrgDMcW6DiUNQO5fJXVtsHM6s0%3D";
        public TaskManagementIndividualTaskDetails()
        {
            InitializeComponent();
            Fillcombo();
        }

        
        private void TaskManagementIndividualTaskDetails_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ViewTaskDesc.Text == "" || ViewAssignTo.Text == "" || ViewPriority.Text == "" || ViewStatus.Text == "")
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
                    //SqlCommand t1 = new SqlCommand("Update taskmanagement SET TaskDescription = '@TD',StartDate = '@SD' ,Deadline =  '@TDD' ,AssignedTo = '@AT' ,Priority = '@PR' ,Status = '@ST' ,EndDate = '@ED' where AssignedTo = '@AT'; ", conn);
                    //t1.Parameters.AddWithValue("@TD", ViewTaskDesc.Text);
                    //t1.Parameters.AddWithValue("@SD", ViewStartDate.Text);
                    //t1.Parameters.AddWithValue("@TDD", ViewTaskDeadline.Text);
                    //t1.Parameters.AddWithValue("@AT", ViewAssignTo.Text);
                    //t1.Parameters.AddWithValue("@PR", ViewPriority.Text);
                    //t1.Parameters.AddWithValue("@ST", ViewStatus.Text);
                    //t1.Parameters.AddWithValue("@ED", ViewEndDate.Text);

                    SqlCommand t1 = new SqlCommand("Update taskmanagement Set TaskDescription = '" + ViewTaskDesc.Text + "',StartDate = '" + ViewStartDate.Text + "',Deadline = '" + ViewTaskDeadline.Text + "',AssignedTo = '" + ViewAssignTo.Text + "',Priority = '" + ViewPriority.Text + "',Status = '" + ViewStatus.Text + "',EndDate = '" + ViewEndDate.Text + "' Where TaskId = '" + ViewTaskId.Text + "';", conn);
                    //sql.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(t1);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    MessageBox.Show("Updated Successfully!!");
                    ClearData();

                    //DataGridViewRow newdatarow = TMEditView.Rows[indexRow];
                    //newdatarow.Cells[0].Value = ViewTaskDesc.Text;
                    //newdatarow.Cells[1].Value = ViewStartDate.Text;
                    //newdatarow.Cells[2].Value = ViewTaskDeadline.Text;
                    //newdatarow.Cells[3].Value = ViewAssignTo.Text;
                    //newdatarow.Cells[4].Value = ViewPriority.Text;
                    //newdatarow.Cells[5].Value = ViewStatus.Text;
                    //newdatarow.Cells[6].Value = ViewEndDate.Text;
                    //MessageBox.Show("Updated Successfully!!");
                    //ClearData();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: {0}", ex.Message);
            }
        }

        void ClearData()
        {
            ViewTaskDesc.Text = "";
            ViewStartDate.Text = "";
            ViewTaskDeadline.Text = "";
            ViewEndDate.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=phoenix.cxrkvshmjrzo.us-west-2.rds.amazonaws.com;" +
            "Initial Catalog=Phoenix_Users;" +
            "User id=pctadmin;" +
            "Password=WeAreATeam;";
            conn.Open();
            String query = "Select * from taskmanagement";
            SqlDataAdapter sd = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            TMEditView.DataSource = dt;
            TMEditView.BringToFront();
            conn.Close();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

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
                ViewAssignTo.Items.Add(dr["name"].ToString());
                
            }
        }

        private void ViewAssignTo_onItemSelected(object sender, EventArgs e)
        {

        }

        private void TMEditView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ViewTaskId.Text = TMEditView.SelectedRows[0].Cells[0].Value.ToString();
            ViewTaskDesc.Text = TMEditView.SelectedRows[0].Cells[1].Value.ToString();
            ViewStartDate.Text = TMEditView.SelectedRows[0].Cells[2].Value.ToString();
            ViewEndDate.Text = TMEditView.SelectedRows[0].Cells[3].Value.ToString();
            ViewTaskDeadline.Text = TMEditView.SelectedRows[0].Cells[4].Value.ToString();
            ViewAssignTo.Text = TMEditView.SelectedRows[0].Cells[5].Value.ToString();
            ViewPriority.Text = TMEditView.SelectedRows[0].Cells[6].Value.ToString();
            ViewStatus.Text = TMEditView.SelectedRows[0].Cells[7].Value.ToString();
            
        }

        //private void TMEditView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void ViewStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=phoenix.cxrkvshmjrzo.us-west-2.rds.amazonaws.com;" +
            "Initial Catalog=Phoenix_Users;" +
            "User id=pctadmin;" +
            "Password=WeAreATeam;";
            conn.Open();
            SqlCommand d1 = new SqlCommand("Delete from taskmanagement Where TaskId = '" + ViewTaskId.Text + "';", conn);
            //sql.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(d1);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            MessageBox.Show("Deleted Successfully!!");
            ClearData();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=phoenix.cxrkvshmjrzo.us-west-2.rds.amazonaws.com;" +
            "Initial Catalog=Phoenix_Users;" +
            "User id=pctadmin;" +
            "Password=WeAreATeam;";
            conn.Open();
            String query = "Select * from taskmanagement where AssignedTo Like '"+ SearchText.Text + '%' + "' or TaskDescription like '" + '%' + SearchText.Text + '%' +"' ";
            //String query = "Select * from taskmanagement where concat('AssignedTo', 'TaskDescription', 'Priority','Status') like '" + '%'  + SearchText.Text +  '%' +"' ";
            SqlDataAdapter sd = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            TMEditView.DataSource = dt;
            TMEditView.BringToFront();
            conn.Close();
        }

        private void SearchText_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchText_Enter(object sender, EventArgs e)
        {
            if (SearchText.Text == "Search Text")
            {
                SearchText.Text = "";
                SearchText.ForeColor = Color.Black;
            }
        }

        private void SearchText_Leave(object sender, EventArgs e)
        {
            if (SearchText.Text == "")
            {
                SearchText.Text = "Search Text";
                SearchText.ForeColor = Color.Silver;
            }
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }


        //int indexRow;
        //private void TMEditView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    indexRow = e.RowIndex;

        //}
    }
}
