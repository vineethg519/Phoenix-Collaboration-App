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
	public partial class GoogleSuite : UserControl
	{
		private static GoogleSuite _instance;
		public static GoogleSuite Instance
		{
			get
			{
				if (_instance == null)
					_instance = new GoogleSuite();
				return _instance;
			}
		}
		public GoogleSuite()
		{
			InitializeComponent();
		}

		private void GoogleSuite_Load(object sender, EventArgs e)
		{

		}

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
