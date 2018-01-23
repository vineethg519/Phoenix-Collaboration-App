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

namespace PhoenixCollaborationApp
{
    public partial class TaskViewForm : UserControl
    {
        private static TaskViewForm _instance;
        public static TaskViewForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TaskViewForm();
                return _instance;
            }
        }

        public TaskViewForm()
        {
            InitializeComponent();
        }

        private void TMGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            TMGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
