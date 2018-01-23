using System;
using System.Net;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Amazon.S3.Model;
using Amazon.S3;
using Newtonsoft.Json;
using Amazon;
using System.IO;
using System.Text;
//using Amazon.WorkDocs;
using System.Security.Cryptography;


namespace PhoenixCollaborationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

		forgotPassForm fm = new forgotPassForm();
		MainForm ob = new MainForm();
		static string bucketName = "aws-phoenix";
		static string keyName = "Data.json";
        public static string user = "";
		
        
		// Generating Presigned URL for getting the credentials.
		public string GenerateAwsUrl()
		{

			//Creating A presigned URL
			//Create a client
			 AmazonS3Client clientaws = new AmazonS3Client("AKIAIY4VF4ADVQOWSQRQ", "wDuRCTYnhQ65EmDhNDCW9T75O+AUrq6xRmk4O+i8", Amazon.RegionEndpoint.USWest2);

			// Create a CopyObject request
			 GetPreSignedUrlRequest request = new GetPreSignedUrlRequest
			{
				BucketName = bucketName,
				Key = keyName,
				Expires = DateTime.Now.AddMinutes(1)
			};


		// Get path for request
		string paths = clientaws.GetPreSignedURL(request);
			Console.WriteLine("Path is : " + paths);
		// Test by getting contents
		string contents = GetContents(paths);
			return paths;
	}
	
		// Validates the HTTP response from presigned URL and gets the content if the file is readable.
	public static string GetContents(string path)
		{
			HttpWebRequest request = HttpWebRequest.Create(path) as HttpWebRequest;
			HttpWebResponse response = request.GetResponse() as HttpWebResponse;

			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				return reader.ReadToEnd();
			}
			
		}
		private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

          
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }
		
		private void userName_OnValueChanged(object sender, EventArgs e)
		{

		}

		private void secureLogBtn_Click(object sender, EventArgs e)
		{
			// Stores the generated presigned URL and is valid for limited time.

				string jsonURL = GenerateAwsUrl();
				
			//This piece of code creates a new webclient and downloads the JSON file from the specif URL.
				WebClient wc = new WebClient();
				var json = wc.DownloadString(jsonURL);
				
				SecData connect = JsonConvert.DeserializeObject<SecData>(json);
			try
			{
				if (userName.Text == "" && pwdBtn.Text == "")
				{
					MessageBox.Show("Please enter Username and Password, Thank you!");
				}
				else
				{
					// Hashing the current password
					string passEncrypted = ShaEncryption.ComputeHash(pwdBtn.Text, Supported_HA.SHA512, null);
					bool passCheck = (ShaEncryption.CheckHash(pwdBtn.Text, passEncrypted, Supported_HA.SHA512));
					
					
					// Connecting to database and fetching values.
					SqlConnection conn = new SqlConnection();
					conn.ConnectionString = "Data Source=" + connect.DataSource + "Initial Catalog=" + connect.InitialCatalog + "User id=" + connect.UserName + "Password=" + connect.Password;
					conn.Open();
					//Getting username from database
					SqlCommand q1 = new SqlCommand("select * from Users where NAME=@username", conn);
                    user = userName.Text;
					q1.Parameters.AddWithValue("@username", userName.Text);
					SqlDataAdapter adpt = new SqlDataAdapter(q1);
					DataSet ds = new DataSet();
					adpt.Fill(ds);
					//Getting the stored password
					SqlCommand q2 = new SqlCommand("select password from users where Name = @username", conn);
					q2.Parameters.AddWithValue("@username", userName.Text);
					string storedHash = Convert.ToString(q2.ExecuteScalar());
					//Closing the database connection
					conn.Close();
					// Checking the stored hashed value 
					bool storedPassCheck = (ShaEncryption.CheckHash(pwdBtn.Text, storedHash, Supported_HA.SHA512));
					//Evaluating the password 
					int count = ds.Tables[0].Rows.Count;
					if (count == 1 && (storedPassCheck && passCheck))
					{
						
						
						{
							MessageBox.Show("Successfully Logged-in");
							this.Hide();
							ob.Show();
						}
					}
					else
					{
						MessageBox.Show("Login Unsuccessful, Please Try Again!");
					}


				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception: {0}", ex.Message);
			}
		}
		//Custom Minimize Button Function
		private void minimizeBtn_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				WindowState = FormWindowState.Minimized;
			}

			else if (WindowState == FormWindowState.Maximized)
			{
				WindowState = FormWindowState.Normal;
			}
		}
		//Custom Maximize Button Function
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
		//Custom Close Button Function
		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pwdBtn_OnValueChanged(object sender, EventArgs e)
		{

		}

		private void leftSideMenu_Paint(object sender, PaintEventArgs e)
		{

		}

		private void bunifuTileButton1_Click(object sender, EventArgs e)
		{

		}
		//Controlling the Forgot password Window.
		private void forgotPass_Click(object sender, EventArgs e)
		{
			this.Hide();
			fm.Show();
		}

		private void logo_Click(object sender, EventArgs e)
		{
			
		}
	}
}
