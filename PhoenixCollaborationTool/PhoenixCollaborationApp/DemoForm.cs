using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;
using System.Xml.Serialization;
using System.IO;
using System.Data.SqlClient;
using PhoenixCollaborationApp;
using System.Linq;

namespace CalendarDemo
{
    public partial class DemoForm : UserControl
    {
        List<CalendarItem> _items = new List<CalendarItem>();
        List<CalendarItem> _items1 = new List<CalendarItem>();
        CalendarItem contextItem = null;

        public static string a = "";
       
        private static DemoForm _instance;

        
        public static DemoForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DemoForm();
                return _instance;
            }
        }
        public DemoForm()
        {

            InitializeComponent();
           
            //Monthview colors
            monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            monthView1.DaySelectedTextColor = monthView1.ForeColor;

        }

       

        public FileInfo ItemsFile
        {
            get 
            {
                return new FileInfo(Path.Combine(Application.StartupPath, "items.xml"));
            }
        }

      
        
        public void callOnLoad()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=phoenix.cxrkvshmjrzo.us-west-2.rds.amazonaws.com;" +
            "Initial Catalog=Phoenix_Users;" +
            "User id=pctadmin;" +
            "Password=WeAreATeam;";
            conn.Open();
            a = Form1.user;
            SqlCommand t1 = new SqlCommand("Select * from taskmanagement where AssignedTo = @assign", conn);
            t1.Parameters.AddWithValue("@assign", a);

            String query = "Select * from taskmanagement";
            SqlDataAdapter sd = new SqlDataAdapter(t1);

            DataSet ds = new DataSet();
            sd.Fill(ds);
            Console.WriteLine("I am " + a);
            Console.WriteLine("Before " + _items.Count);
            if (1 == 1)
            {
                
                List<ItemInfo> lst = new List<ItemInfo>();
                String taskDesc;
                DateTime de;
                foreach (DataRow row in ds.Tables[0].Rows)
                {

                    taskDesc = row["TaskDescription"].ToString();
                    de = DateTime.Parse(row["Deadline"].ToString());

                    ItemInfo newItem = new ItemInfo(de, de + TimeSpan.Parse("01:00:00"), taskDesc, Color.AliceBlue);

                    lst.Add(newItem);
                }
                int cou = _items.Count;
                foreach (ItemInfo item in lst)
                {
                    
                    CalendarItem cal = new CalendarItem(calendar1, item.StartTime, item.EndTime, item.Text);

                    if (!(item.R == 0 && item.G == 0 && item.B == 0))
                    {
                        cal.ApplyColor(Color.FromArgb(item.A, item.R, item.G, item.B));
                    }
                    Boolean found = false;
                    foreach (CalendarItem ca in _items)
                    {
                        if (cal.Text.Equals(ca.Text))
                        {
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        _items.Add(cal);
                    }
                   
                    
                }
                
                if (cou!=_items.Count)
                {
                    calendar1.Items.Clear();
                    PlaceItems();
                }
                
            }
            else
            {

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            callOnLoad();
        }

        private void calendar1_LoadItems(object sender, CalendarLoadEventArgs e)
        {
            PlaceItems();
        }

        private void PlaceItems()
        {

           
                foreach (CalendarItem item in _items)
                {
                    if (calendar1.ViewIntersects(item))
                    {
                        calendar1.Items.Add(item);
                    }
                }
         
            
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            
            Form1_Load(this,e);
        }
        private void calendar1_ItemCreated(object sender, CalendarItemCancelEventArgs e)
        {
            _items.Add(e.Item);
        }

        private void calendar1_ItemMouseHover(object sender, CalendarItemEventArgs e)
        {
            Text = e.Item.Text;
        }

        private void calendar1_ItemClick(object sender, CalendarItemEventArgs e)
        {
            //MessageBox.Show(e.Item.Text);
        }

        private void hourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.SixtyMinutes;
        }

        private void minutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.ThirtyMinutes;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.FifteenMinutes;
        }

        private void minutesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.SixMinutes;
        }

        private void minutesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.TenMinutes;
        }

        private void minutesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.FiveMinutes;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextItem = calendar1.ItemAt(contextMenuStrip1.Bounds.Location);
        }

        private void redTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Red);
                calendar1.Invalidate(item);
            }
        }

        private void yellowTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Gold);
                calendar1.Invalidate(item);
            }
        }

        private void greenTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Green);
                calendar1.Invalidate(item);
            }
        }

        private void blueTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.DarkBlue);
                calendar1.Invalidate(item);
            }
        }

        
        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar1.ActivateEditMode();
        }

        private void DemoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<ItemInfo> lst = new List<ItemInfo>();

            foreach (CalendarItem item in _items)
            {
                lst.Add(new ItemInfo(item.StartDate, item.EndDate, item.Text, item.BackgroundColor));
            }

            XmlSerializer xmls = new XmlSerializer(lst.GetType());

            if (ItemsFile.Exists)
            {
                ItemsFile.Delete();
            }

            using (Stream s = ItemsFile.OpenWrite())
            {
                xmls.Serialize(s, lst);
                s.Close();
            }
        }

        private void otherColorTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (CalendarItem item in calendar1.GetSelectedItems())
                    {
                        item.ApplyColor(dlg.Color);
                        calendar1.Invalidate(item);
                    }
                }
            }
        }

        private void calendar1_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            //MessageBox.Show("Double click: " + e.Item.Text);
        }

        private void calendar1_ItemDeleted(object sender, CalendarItemEventArgs e)
        {
            _items.Remove(e.Item);
        }

        private void calendar1_DayHeaderClick(object sender, CalendarDayEventArgs e)
        {
            calendar1.SetViewRange(e.CalendarDay.Date, e.CalendarDay.Date);
        }

        private void diagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
            }
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.Vertical;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
            }
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.Horizontal;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
            }
        }

        private void hatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.DiagonalCross;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
            }
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.DiagonalCross;
                item.PatternColor = Color.Empty;
                calendar1.Invalidate(item);
            }
        }

        private void monthView1_SelectionChanged(object sender, EventArgs e)
        {
            calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
        }

        private void northToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ImageAlign = CalendarItemImageAlign.North;
                calendar1.Invalidate(item);
            }
        }

        private void eastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ImageAlign = CalendarItemImageAlign.East;
                calendar1.Invalidate(item);
            }
        }

        private void southToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ImageAlign = CalendarItemImageAlign.South;
                calendar1.Invalidate(item);
            }
        }

        private void westToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ImageAlign = CalendarItemImageAlign.West;
                calendar1.Invalidate(item);
            }
        }

        private void selectImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "*.gif|*.gif|*.png|*.png|*.jpg|*.jpg";

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    Image img = Image.FromFile(dlg.FileName);

                    foreach (CalendarItem item in calendar1.GetSelectedItems())
                    {
                        item.Image = img;
                        calendar1.Invalidate(item);
                    }
                }
            }

            
        }

        

       

    }
}