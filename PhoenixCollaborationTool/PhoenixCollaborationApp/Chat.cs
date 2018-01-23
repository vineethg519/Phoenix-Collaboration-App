using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoenixCollaborationApp
{
	public partial class Chat : UserControl
	{
		private static Chat _instance;
		public static Chat Instance
		{
				get
			{
				if (_instance == null)
					_instance = new Chat();
				return _instance;
			}
		}
		public Chat()
		{
				InitializeComponent();
		}

		private void Chat_Load(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
