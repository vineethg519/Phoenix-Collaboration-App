using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.Calendar;

namespace PhoenixCollaborationApp
{
	public partial class TaskManagement : UserControl
	{
		private static TaskManagement _instance;
		public static TaskManagement Instance
		{
			get
			{
				if (_instance == null)
					_instance = new TaskManagement();
				return _instance;
			}
		}
		public TaskManagement()
		{
			InitializeComponent();
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{

		}

        private void TaskManagement_Load(object sender, EventArgs e)
        {

        }

        private void createTask_Click(object sender, EventArgs e)

        {
            //TaskManagementCreate
            if (!taskCreateViewPanel.Controls.Contains(TaskManagementCreate.Instance))
            {
                taskCreateViewPanel.Controls.Add(TaskManagementCreate.Instance);
                TaskManagementCreate.Instance.Dock = DockStyle.Fill;
                TaskManagementCreate.Instance.BringToFront();
            }
            else
                TaskManagementCreate.Instance.BringToFront();



        }

        private void viewTask_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString =
            //"Data Source=phoenix.cxrkvshmjrzo.us-west-2.rds.amazonaws.com;" +
            //"Initial Catalog=Phoenix_Users;" +
            //"User id=pctadmin;" +
            //"Password=WeAreATeam;";
            //conn.Open();
            //String query = "Select * from taskmanagement";
            //SqlDataAdapter sd = new SqlDataAdapter(query, conn);
            //DataTable dt = new DataTable();
            //sd.Fill(dt);
            //TMView.DataSource = dt;
            //TMView.BringToFront();
            //conn.Close();
            if (!taskCreateViewPanel.Controls.Contains(TaskManagementIndividualTaskDetails.Instance))
            {
                taskCreateViewPanel.Controls.Add(TaskManagementIndividualTaskDetails.Instance);
                TaskManagementIndividualTaskDetails.Instance.Dock = DockStyle.Fill;
                TaskManagementIndividualTaskDetails.Instance.BringToFront();
            }
            else
                TaskManagementIndividualTaskDetails.Instance.BringToFront();



        }
    }

        //private void taskCreateViewPanel_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void TMView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
