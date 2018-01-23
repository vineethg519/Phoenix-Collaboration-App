using System;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;
using CalendarDemo;
using PhoenixChatClient;
using PhoenixGoogleDriveManager;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
//using Amazon.WorkDocs;

namespace PhoenixCollaborationApp
{
	public partial class MainForm : Form
	{
		Chat c1;
		GoogleSuite g1;
		SharedCalendar sc1;
		TaskManagement tm1;
        //designation.Text = 
        public MainForm()
		{
			c1 = new Chat();
			g1 = new GoogleSuite();
			sc1 = new SharedCalendar();
			tm1 = new TaskManagement();
			InitializeComponent();
			
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
           
		
		}

		private void maximizeBtn_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				WindowState = FormWindowState.Maximized;
				
			}

			else if (WindowState == FormWindowState.Maximized)
			{
				WindowState = FormWindowState.Normal;
			}

		}

		private void minimizeBtn_Click(object sender, EventArgs e)
		{
			//this.WindowState = FormWindowState.Minimized;
			if (WindowState == FormWindowState.Normal)
			{
				WindowState = FormWindowState.Minimized;
			}

			else if (WindowState == FormWindowState.Maximized)
			{
				WindowState = FormWindowState.Normal;
			}

		}


		// Database Checking and Creation

		private void FrmServer_Load(object sender, EventArgs e)
		{
			if (!CheckDatabaseExist())
			{
				GenerateDatabase();
			}
		}

		private bool CheckDatabaseExist()
		{
			SqlConnection connection = new SqlConnection(@"Data Source=phoenix.cxrkvshmjrzo.us-west-2.rds.amazonaws.com;Initial Catalog=Phoenix_Users;User id=pctadmin;Password=WeAreATeam;");
			try
			{
				connection.Open();
				return true;
			}
			catch
			{
				return false;
			}
		}
		private void GenerateDatabase()
		{
			List<string> cmds = new List<string>();
			if (File.Exists(Application.StartupPath + "\\dbscript.sql"))
			{
				TextReader tr = new StreamReader(Application.StartupPath + "\\dbscript.sql");
				string line = "";
				string cmd = "";
				while ((line = tr.ReadLine()) != null)
				{
					if (line.Trim().ToUpper() == "GO")
					{
						cmds.Add(cmd);
						cmd = "";
					}
					else
					{
						cmd += line + "\r\n";
					}
				}
				if (cmd.Length > 0)
				{
					cmds.Add(cmd);
					cmd = "";
				}
				tr.Close();
			}
			if (cmds.Count > 0)
			{
				SqlCommand command = new SqlCommand();
				command.Connection = new SqlConnection(@"Data Source=phoenix.cxrkvshmjrzo.us-west-2.rds.amazonaws.com;Initial Catalog=Phoenix_Users;User id=pctadmin;Password=WeAreATeam;");
				command.CommandType = System.Data.CommandType.Text;
				command.Connection.Open();
				for (int i = 0; i < cmds.Count; i++)
				{
					command.CommandText = cmds[i];
					command.ExecuteNonQuery();
				}
			}
		}



		private void bunifuCustomLabel2_Click(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel3_Click(object sender, EventArgs e)
		{

		}

		private void bunifuFlatButton1_Click(object sender, EventArgs e)
		{

		}

		private void taskManagementButton_Click(object sender, EventArgs e)
		{
			
			if (!displayViewPanel.Controls.Contains(TaskManagement.Instance))
			{
				displayViewPanel.Controls.Add(TaskManagement.Instance);
				TaskManagement.Instance.Dock = DockStyle.Fill;
				TaskManagement.Instance.BringToFront();
			}
			else
				TaskManagement.Instance.BringToFront();

		}

		private void calendarButton_Click(object sender, EventArgs e)
		{


            if (!displayViewPanel.Controls.Contains(DemoForm.Instance))
            {
                
                displayViewPanel.Controls.Add(DemoForm.Instance);
                DemoForm.Instance.Dock = DockStyle.Fill;
                DemoForm.Instance.BringToFront();

            }
            else
            {
                DemoForm.Instance.BringToFront();
            }
		}

		private void bunifuCustomLabel4_Click(object sender, EventArgs e)
		{

		}

		private void bunifuImageButton5_Click(object sender, EventArgs e)
		{
			//Collapsed Left Side Menu
			if (leftSideMenu.Width == 50)
			{
				leftSideMenu.Visible = false;
				leftSideMenu.Width = 250;
				sidePanelAnimator.ShowSync(leftSideMenu);
				sidePanelAnimator.AnimationType= BunifuAnimatorNS.AnimationType.Rotate;
				logoAnimator.ShowSync(logo);
			}

			//Expanded Left Side Menu
			else
			{ 
				logoAnimator.Hide(logo);
				leftSideMenu.Visible = false;
				leftSideMenu.Width = 50;
				sidePanelAnimator.ShowSync(leftSideMenu);
				sidePanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
				
			}
		}
		
		private void chatButton_Click(object sender, EventArgs e)
		{	
			
			// Displays the view of Chat when the button is clicked
			if (!displayViewPanel.Controls.Contains(FrmChat.Instance))
			{
				displayViewPanel.Controls.Add(FrmChat.Instance);
				FrmChat.Instance.Dock = DockStyle.Fill;
				FrmChat.Instance.BringToFront();
			}
			else
				FrmChat.Instance.BringToFront();

		}

		private void bunifuFlatButton3_Click(object sender, EventArgs e)
		{

		}

		private void googleSuiteButton_Click(object sender, EventArgs e)
		{
			if (!displayViewPanel.Controls.Contains(frmMain.Instance))
			{
				displayViewPanel.Controls.Add(frmMain.Instance);
				frmMain.Instance.Dock = DockStyle.Fill;
				frmMain.Instance.BringToFront();
			}
			else
			{
				frmMain.Instance.BringToFront();
				//AmazonWorkDocsConfig config = new AmazonWorkDocsConfig();
				//config.AuthenticationServiceName = "";
				//config.ServiceURL = "";
			
			}
		}

		private void bunifuCustomLabel5_Click(object sender, EventArgs e)
		{

		}

		private void displayViewPanel_Paint(object sender, PaintEventArgs e)
		{
			
		}
    }
}
