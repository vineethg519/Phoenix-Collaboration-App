using System.Windows.Forms;

namespace PhoenixChatClient
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/alentor/Moew-Chat");
        }

		private void label1_Click(object sender, System.EventArgs e)
		{

		}
	}
}