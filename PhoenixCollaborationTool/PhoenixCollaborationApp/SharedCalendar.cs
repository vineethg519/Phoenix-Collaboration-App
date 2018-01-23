using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;
using CalendarDemo;


namespace PhoenixCollaborationApp
{
	public partial class SharedCalendar : UserControl
	{
		List<CalendarItem> _items = new List<CalendarItem>();
		CalendarItem contextItem = null;
		private static SharedCalendar _instance;
		public static SharedCalendar Instance
		{
			get
			{
				if (_instance == null)
					_instance = new SharedCalendar();
				return _instance;
			}
		}
		public SharedCalendar()
		{
			InitializeComponent();
			//monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
			//monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
			//monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
			//monthView1.DaySelectedTextColor = monthView1.ForeColor;

		}



		private void SharedCalendar_Load(object sender, EventArgs e)
		{

		}
	}
}
