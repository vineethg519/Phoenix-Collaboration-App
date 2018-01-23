namespace PhoenixCollaborationApp
{
	partial class Chat
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
			this.panel2 = new System.Windows.Forms.Panel();
			this.bottom = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonsend = new Bunifu.Framework.UI.BunifuImageButton();
			this.txtmessage = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bottom)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.buttonsend)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.bottom);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1101, 506);
			this.panel2.TabIndex = 3;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// bottom
			// 
			this.bottom.Location = new System.Drawing.Point(41, 201);
			this.bottom.Margin = new System.Windows.Forms.Padding(4);
			this.bottom.Name = "bottom";
			this.bottom.Size = new System.Drawing.Size(133, 62);
			this.bottom.TabIndex = 1;
			this.bottom.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.buttonsend);
			this.panel1.Controls.Add(this.txtmessage);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 506);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1101, 108);
			this.panel1.TabIndex = 2;
			// 
			// buttonsend
			// 
			this.buttonsend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonsend.BackColor = System.Drawing.Color.Transparent;
			this.buttonsend.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonsend.Image = ((System.Drawing.Image)(resources.GetObject("buttonsend.Image")));
			this.buttonsend.ImageActive = null;
			this.buttonsend.Location = new System.Drawing.Point(1029, 36);
			this.buttonsend.Margin = new System.Windows.Forms.Padding(4);
			this.buttonsend.Name = "buttonsend";
			this.buttonsend.Size = new System.Drawing.Size(39, 44);
			this.buttonsend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.buttonsend.TabIndex = 1;
			this.buttonsend.TabStop = false;
			this.buttonsend.Zoom = 10;
			// 
			// txtmessage
			// 
			this.txtmessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtmessage.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtmessage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtmessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtmessage.HintForeColor = System.Drawing.Color.Black;
			this.txtmessage.HintText = "";
			this.txtmessage.isPassword = false;
			this.txtmessage.LineFocusedColor = System.Drawing.SystemColors.Highlight;
			this.txtmessage.LineIdleColor = System.Drawing.Color.DimGray;
			this.txtmessage.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
			this.txtmessage.LineThickness = 3;
			this.txtmessage.Location = new System.Drawing.Point(19, 9);
			this.txtmessage.Margin = new System.Windows.Forms.Padding(5);
			this.txtmessage.Name = "txtmessage";
			this.txtmessage.Size = new System.Drawing.Size(969, 84);
			this.txtmessage.TabIndex = 0;
			this.txtmessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// panel3
			// 
			this.panel3.Location = new System.Drawing.Point(19, 39);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(591, 40);
			this.panel3.TabIndex = 2;
			// 
			// Chat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Chat";
			this.Size = new System.Drawing.Size(1101, 614);
			this.Load += new System.EventHandler(this.Chat_Load);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bottom)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.buttonsend)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox bottom;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuImageButton buttonsend;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtmessage;
		private System.Windows.Forms.Panel panel3;
	}
}
