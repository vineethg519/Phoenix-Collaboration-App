namespace PhoenixCollaborationApp
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.TitleBar = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.minimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
			this.maximizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
			this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.leftSideMenu = new System.Windows.Forms.Panel();
			this.taskManagementButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.googleSuiteButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.calendarButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.chatButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
			this.logo = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.bunifuVTrackbar1 = new Bunifu.Framework.UI.BunifuVTrackbar();
			this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.bunifuImageButton7 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton8 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton9 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton10 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.designation = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
			this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.displayViewPanel = new System.Windows.Forms.Panel();
			this.sidePanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.TitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maximizeBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
			this.leftSideMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// TitleBar
			// 
			this.TitleBar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.TitleBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.TitleBar.Controls.Add(this.panel4);
			this.TitleBar.Controls.Add(this.bunifuCustomLabel1);
			this.TitleBar.Controls.Add(this.minimizeBtn);
			this.TitleBar.Controls.Add(this.maximizeBtn);
			this.TitleBar.Controls.Add(this.closeBtn);
			this.sidePanelAnimator.SetDecoration(this.TitleBar, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.TitleBar, BunifuAnimatorNS.DecorationType.None);
			this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.TitleBar.Location = new System.Drawing.Point(0, 0);
			this.TitleBar.Margin = new System.Windows.Forms.Padding(2);
			this.TitleBar.Name = "TitleBar";
			this.TitleBar.Size = new System.Drawing.Size(1016, 32);
			this.TitleBar.TabIndex = 0;
			// 
			// panel4
			// 
			this.sidePanelAnimator.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
			this.panel4.Location = new System.Drawing.Point(243, 32);
			this.panel4.Margin = new System.Windows.Forms.Padding(2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(585, 492);
			this.panel4.TabIndex = 0;
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.logoAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(13, 6);
			this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(177, 17);
			this.bunifuCustomLabel1.TabIndex = 3;
			this.bunifuCustomLabel1.Text = "Phoenix Collaboration Tool";
			// 
			// minimizeBtn
			// 
			this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.minimizeBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.sidePanelAnimator.SetDecoration(this.minimizeBtn, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.minimizeBtn, BunifuAnimatorNS.DecorationType.None);
			this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
			this.minimizeBtn.ImageActive = null;
			this.minimizeBtn.Location = new System.Drawing.Point(925, 6);
			this.minimizeBtn.Margin = new System.Windows.Forms.Padding(2);
			this.minimizeBtn.Name = "minimizeBtn";
			this.minimizeBtn.Size = new System.Drawing.Size(18, 19);
			this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.minimizeBtn.TabIndex = 2;
			this.minimizeBtn.TabStop = false;
			this.minimizeBtn.Zoom = 10;
			this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
			// 
			// maximizeBtn
			// 
			this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.maximizeBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.sidePanelAnimator.SetDecoration(this.maximizeBtn, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.maximizeBtn, BunifuAnimatorNS.DecorationType.None);
			this.maximizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("maximizeBtn.Image")));
			this.maximizeBtn.ImageActive = null;
			this.maximizeBtn.Location = new System.Drawing.Point(958, 6);
			this.maximizeBtn.Margin = new System.Windows.Forms.Padding(2);
			this.maximizeBtn.Name = "maximizeBtn";
			this.maximizeBtn.Size = new System.Drawing.Size(18, 19);
			this.maximizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.maximizeBtn.TabIndex = 1;
			this.maximizeBtn.TabStop = false;
			this.maximizeBtn.Zoom = 10;
			this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
			// 
			// closeBtn
			// 
			this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.sidePanelAnimator.SetDecoration(this.closeBtn, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.closeBtn, BunifuAnimatorNS.DecorationType.None);
			this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
			this.closeBtn.ImageActive = null;
			this.closeBtn.Location = new System.Drawing.Point(989, 6);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(18, 19);
			this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.closeBtn.TabIndex = 0;
			this.closeBtn.TabStop = false;
			this.closeBtn.Zoom = 10;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.TitleBar;
			this.bunifuDragControl1.Vertical = true;
			// 
			// leftSideMenu
			// 
			this.leftSideMenu.AccessibleName = "leftSideMenu";
			this.leftSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.leftSideMenu.Controls.Add(this.taskManagementButton);
			this.leftSideMenu.Controls.Add(this.googleSuiteButton);
			this.leftSideMenu.Controls.Add(this.calendarButton);
			this.leftSideMenu.Controls.Add(this.chatButton);
			this.leftSideMenu.Controls.Add(this.bunifuImageButton5);
			this.leftSideMenu.Controls.Add(this.logo);
			this.sidePanelAnimator.SetDecoration(this.leftSideMenu, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.leftSideMenu, BunifuAnimatorNS.DecorationType.None);
			this.leftSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftSideMenu.Location = new System.Drawing.Point(0, 32);
			this.leftSideMenu.Margin = new System.Windows.Forms.Padding(2);
			this.leftSideMenu.Name = "leftSideMenu";
			this.leftSideMenu.Size = new System.Drawing.Size(243, 494);
			this.leftSideMenu.TabIndex = 1;
			// 
			// taskManagementButton
			// 
			this.taskManagementButton.AccessibleDescription = "Task Management Controller";
			this.taskManagementButton.AccessibleName = "taskManagementButton";
			this.taskManagementButton.Activecolor = System.Drawing.SystemColors.MenuHighlight;
			this.taskManagementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.taskManagementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.taskManagementButton.BorderRadius = 0;
			this.taskManagementButton.ButtonText = "     Task Management";
			this.taskManagementButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sidePanelAnimator.SetDecoration(this.taskManagementButton, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.taskManagementButton, BunifuAnimatorNS.DecorationType.None);
			this.taskManagementButton.DisabledColor = System.Drawing.Color.Gray;
			this.taskManagementButton.Iconcolor = System.Drawing.Color.Transparent;
			this.taskManagementButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("taskManagementButton.Iconimage")));
			this.taskManagementButton.Iconimage_right = null;
			this.taskManagementButton.Iconimage_right_Selected = null;
			this.taskManagementButton.Iconimage_Selected = null;
			this.taskManagementButton.IconMarginLeft = 0;
			this.taskManagementButton.IconMarginRight = 0;
			this.taskManagementButton.IconRightVisible = true;
			this.taskManagementButton.IconRightZoom = 0D;
			this.taskManagementButton.IconVisible = true;
			this.taskManagementButton.IconZoom = 35D;
			this.taskManagementButton.IsTab = true;
			this.taskManagementButton.Location = new System.Drawing.Point(0, 250);
			this.taskManagementButton.Name = "taskManagementButton";
			this.taskManagementButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.taskManagementButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.taskManagementButton.OnHoverTextColor = System.Drawing.SystemColors.MenuHighlight;
			this.taskManagementButton.selected = false;
			this.taskManagementButton.Size = new System.Drawing.Size(243, 48);
			this.taskManagementButton.TabIndex = 6;
			this.taskManagementButton.Text = "     Task Management";
			this.taskManagementButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.taskManagementButton.Textcolor = System.Drawing.Color.White;
			this.taskManagementButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.taskManagementButton.Click += new System.EventHandler(this.taskManagementButton_Click);
			// 
			// googleSuiteButton
			// 
			this.googleSuiteButton.AccessibleDescription = "Google Drive controller";
			this.googleSuiteButton.AccessibleName = "googleSuiteButton";
			this.googleSuiteButton.Activecolor = System.Drawing.SystemColors.MenuHighlight;
			this.googleSuiteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.googleSuiteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.googleSuiteButton.BorderRadius = 0;
			this.googleSuiteButton.ButtonText = "     Drive";
			this.googleSuiteButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sidePanelAnimator.SetDecoration(this.googleSuiteButton, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.googleSuiteButton, BunifuAnimatorNS.DecorationType.None);
			this.googleSuiteButton.DisabledColor = System.Drawing.Color.Gray;
			this.googleSuiteButton.Iconcolor = System.Drawing.Color.Transparent;
			this.googleSuiteButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("googleSuiteButton.Iconimage")));
			this.googleSuiteButton.Iconimage_right = null;
			this.googleSuiteButton.Iconimage_right_Selected = null;
			this.googleSuiteButton.Iconimage_Selected = null;
			this.googleSuiteButton.IconMarginLeft = 0;
			this.googleSuiteButton.IconMarginRight = 0;
			this.googleSuiteButton.IconRightVisible = true;
			this.googleSuiteButton.IconRightZoom = 0D;
			this.googleSuiteButton.IconVisible = true;
			this.googleSuiteButton.IconZoom = 35D;
			this.googleSuiteButton.IsTab = true;
			this.googleSuiteButton.Location = new System.Drawing.Point(0, 194);
			this.googleSuiteButton.Name = "googleSuiteButton";
			this.googleSuiteButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.googleSuiteButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.googleSuiteButton.OnHoverTextColor = System.Drawing.SystemColors.MenuHighlight;
			this.googleSuiteButton.selected = false;
			this.googleSuiteButton.Size = new System.Drawing.Size(243, 48);
			this.googleSuiteButton.TabIndex = 5;
			this.googleSuiteButton.Text = "     Drive";
			this.googleSuiteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.googleSuiteButton.Textcolor = System.Drawing.Color.White;
			this.googleSuiteButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.googleSuiteButton.Click += new System.EventHandler(this.googleSuiteButton_Click);
			// 
			// calendarButton
			// 
			this.calendarButton.AccessibleName = "calendarButton";
			this.calendarButton.Activecolor = System.Drawing.SystemColors.MenuHighlight;
			this.calendarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.calendarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.calendarButton.BorderRadius = 0;
			this.calendarButton.ButtonText = "      Calendar";
			this.calendarButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sidePanelAnimator.SetDecoration(this.calendarButton, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.calendarButton, BunifuAnimatorNS.DecorationType.None);
			this.calendarButton.DisabledColor = System.Drawing.Color.Gray;
			this.calendarButton.Iconcolor = System.Drawing.Color.Transparent;
			this.calendarButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("calendarButton.Iconimage")));
			this.calendarButton.Iconimage_right = null;
			this.calendarButton.Iconimage_right_Selected = null;
			this.calendarButton.Iconimage_Selected = null;
			this.calendarButton.IconMarginLeft = 0;
			this.calendarButton.IconMarginRight = 0;
			this.calendarButton.IconRightVisible = true;
			this.calendarButton.IconRightZoom = 0D;
			this.calendarButton.IconVisible = true;
			this.calendarButton.IconZoom = 35D;
			this.calendarButton.IsTab = true;
			this.calendarButton.Location = new System.Drawing.Point(0, 145);
			this.calendarButton.Name = "calendarButton";
			this.calendarButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.calendarButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.calendarButton.OnHoverTextColor = System.Drawing.SystemColors.MenuHighlight;
			this.calendarButton.selected = false;
			this.calendarButton.Size = new System.Drawing.Size(243, 48);
			this.calendarButton.TabIndex = 3;
			this.calendarButton.Text = "      Calendar";
			this.calendarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.calendarButton.Textcolor = System.Drawing.Color.White;
			this.calendarButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.calendarButton.Click += new System.EventHandler(this.calendarButton_Click);
			// 
			// chatButton
			// 
			this.chatButton.AccessibleDescription = "Control Chat Function";
			this.chatButton.AccessibleName = "chatButton";
			this.chatButton.Activecolor = System.Drawing.SystemColors.MenuHighlight;
			this.chatButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.chatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.chatButton.BorderRadius = 0;
			this.chatButton.ButtonText = "        Chat";
			this.chatButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sidePanelAnimator.SetDecoration(this.chatButton, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.chatButton, BunifuAnimatorNS.DecorationType.None);
			this.chatButton.DisabledColor = System.Drawing.Color.Gray;
			this.chatButton.Iconcolor = System.Drawing.Color.Transparent;
			this.chatButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("chatButton.Iconimage")));
			this.chatButton.Iconimage_right = null;
			this.chatButton.Iconimage_right_Selected = null;
			this.chatButton.Iconimage_Selected = null;
			this.chatButton.IconMarginLeft = 0;
			this.chatButton.IconMarginRight = 0;
			this.chatButton.IconRightVisible = true;
			this.chatButton.IconRightZoom = 0D;
			this.chatButton.IconVisible = true;
			this.chatButton.IconZoom = 35D;
			this.chatButton.IsTab = true;
			this.chatButton.Location = new System.Drawing.Point(0, 97);
			this.chatButton.Name = "chatButton";
			this.chatButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.chatButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.chatButton.OnHoverTextColor = System.Drawing.SystemColors.MenuHighlight;
			this.chatButton.selected = true;
			this.chatButton.Size = new System.Drawing.Size(243, 48);
			this.chatButton.TabIndex = 2;
			this.chatButton.Text = "        Chat";
			this.chatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chatButton.Textcolor = System.Drawing.Color.White;
			this.chatButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chatButton.Click += new System.EventHandler(this.chatButton_Click);
			// 
			// bunifuImageButton5
			// 
			this.bunifuImageButton5.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
			this.sidePanelAnimator.SetDecoration(this.bunifuImageButton5, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.bunifuImageButton5, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
			this.bunifuImageButton5.ImageActive = null;
			this.bunifuImageButton5.Location = new System.Drawing.Point(211, 16);
			this.bunifuImageButton5.Margin = new System.Windows.Forms.Padding(2);
			this.bunifuImageButton5.Name = "bunifuImageButton5";
			this.bunifuImageButton5.Size = new System.Drawing.Size(19, 20);
			this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton5.TabIndex = 1;
			this.bunifuImageButton5.TabStop = false;
			this.bunifuImageButton5.Zoom = 10;
			this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
			// 
			// logo
			// 
			this.logoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
			this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
			this.logo.Location = new System.Drawing.Point(64, 16);
			this.logo.Margin = new System.Windows.Forms.Padding(2);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(92, 43);
			this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logo.TabIndex = 0;
			this.logo.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.bunifuVTrackbar1);
			this.panel2.Controls.Add(this.bunifuCustomLabel10);
			this.panel2.Controls.Add(this.bunifuCustomLabel13);
			this.panel2.Controls.Add(this.bunifuCustomLabel12);
			this.panel2.Controls.Add(this.bunifuCustomLabel11);
			this.panel2.Controls.Add(this.bunifuCustomLabel6);
			this.panel2.Controls.Add(this.bunifuCustomLabel5);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.bunifuCustomLabel4);
			this.panel2.Controls.Add(this.bunifuImageButton6);
			this.panel2.Controls.Add(this.bunifuCustomLabel3);
			this.panel2.Controls.Add(this.designation);
			this.panel2.Controls.Add(this.bunifuImageButton4);
			this.sidePanelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(828, 32);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(188, 494);
			this.panel2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.logoAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(25, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 16);
			this.label1.TabIndex = 18;
			this.label1.Text = "Avasarala, Bhardwaj";
			// 
			// bunifuVTrackbar1
			// 
			this.bunifuVTrackbar1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuVTrackbar1.BackgroudColor = System.Drawing.Color.DarkGray;
			this.bunifuVTrackbar1.BorderRadius = 0;
			this.sidePanelAnimator.SetDecoration(this.bunifuVTrackbar1, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.bunifuVTrackbar1, BunifuAnimatorNS.DecorationType.None);
			this.bunifuVTrackbar1.IndicatorColor = System.Drawing.SystemColors.MenuHighlight;
			this.bunifuVTrackbar1.Location = new System.Drawing.Point(161, 184);
			this.bunifuVTrackbar1.MaximumValue = 100;
			this.bunifuVTrackbar1.Name = "bunifuVTrackbar1";
			this.bunifuVTrackbar1.Size = new System.Drawing.Size(30, 268);
			this.bunifuVTrackbar1.SliderRadius = 0;
			this.bunifuVTrackbar1.TabIndex = 7;
			this.bunifuVTrackbar1.Value = 0;
			// 
			// bunifuCustomLabel10
			// 
			this.bunifuCustomLabel10.AutoSize = true;
			this.logoAnimator.SetDecoration(this.bunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.bunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel10.Location = new System.Drawing.Point(8, 250);
			this.bunifuCustomLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
			this.bunifuCustomLabel10.Size = new System.Drawing.Size(142, 17);
			this.bunifuCustomLabel10.TabIndex = 14;
			this.bunifuCustomLabel10.Text = "Sudharshan Kankara";
			// 
			// bunifuCustomLabel13
			// 
			this.bunifuCustomLabel13.AutoSize = true;
			this.logoAnimator.SetDecoration(this.bunifuCustomLabel13, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.bunifuCustomLabel13, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel13.Location = new System.Drawing.Point(10, 343);
			this.bunifuCustomLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
			this.bunifuCustomLabel13.Size = new System.Drawing.Size(133, 17);
			this.bunifuCustomLabel13.TabIndex = 17;
			this.bunifuCustomLabel13.Text = "Bhardwaj Avasarala";
			// 
			// bunifuCustomLabel12
			// 
			this.bunifuCustomLabel12.AutoSize = true;
			this.logoAnimator.SetDecoration(this.bunifuCustomLabel12, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.bunifuCustomLabel12, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel12.Location = new System.Drawing.Point(10, 312);
			this.bunifuCustomLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
			this.bunifuCustomLabel12.Size = new System.Drawing.Size(107, 17);
			this.bunifuCustomLabel12.TabIndex = 16;
			this.bunifuCustomLabel12.Text = "Hemanth Nersu";
			// 
			// bunifuCustomLabel11
			// 
			this.bunifuCustomLabel11.AutoSize = true;
			this.logoAnimator.SetDecoration(this.bunifuCustomLabel11, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.bunifuCustomLabel11, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel11.Location = new System.Drawing.Point(10, 280);
			this.bunifuCustomLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
			this.bunifuCustomLabel11.Size = new System.Drawing.Size(124, 17);
			this.bunifuCustomLabel11.TabIndex = 15;
			this.bunifuCustomLabel11.Text = "Shravani Alampalli";
			// 
			// bunifuCustomLabel6
			// 
			this.bunifuCustomLabel6.AutoSize = true;
			this.logoAnimator.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel6.Location = new System.Drawing.Point(10, 223);
			this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
			this.bunifuCustomLabel6.Size = new System.Drawing.Size(120, 17);
			this.bunifuCustomLabel6.TabIndex = 10;
			this.bunifuCustomLabel6.Text = "Sanjay Bedudoori";
			// 
			// bunifuCustomLabel5
			// 
			this.bunifuCustomLabel5.AutoSize = true;
			this.logoAnimator.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel5.Location = new System.Drawing.Point(10, 194);
			this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
			this.bunifuCustomLabel5.Size = new System.Drawing.Size(110, 17);
			this.bunifuCustomLabel5.TabIndex = 9;
			this.bunifuCustomLabel5.Text = "Anudeep Reddy";
			this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel3.Controls.Add(this.bunifuImageButton7);
			this.panel3.Controls.Add(this.bunifuImageButton8);
			this.panel3.Controls.Add(this.bunifuImageButton9);
			this.panel3.Controls.Add(this.bunifuImageButton10);
			this.sidePanelAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 457);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(188, 37);
			this.panel3.TabIndex = 5;
			// 
			// bunifuImageButton7
			// 
			this.bunifuImageButton7.BackColor = System.Drawing.Color.Transparent;
			this.sidePanelAnimator.SetDecoration(this.bunifuImageButton7, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.bunifuImageButton7, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.Image")));
			this.bunifuImageButton7.ImageActive = null;
			this.bunifuImageButton7.Location = new System.Drawing.Point(59, 11);
			this.bunifuImageButton7.Margin = new System.Windows.Forms.Padding(2);
			this.bunifuImageButton7.Name = "bunifuImageButton7";
			this.bunifuImageButton7.Size = new System.Drawing.Size(19, 20);
			this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton7.TabIndex = 7;
			this.bunifuImageButton7.TabStop = false;
			this.bunifuImageButton7.Zoom = 10;
			// 
			// bunifuImageButton8
			// 
			this.bunifuImageButton8.BackColor = System.Drawing.Color.Transparent;
			this.sidePanelAnimator.SetDecoration(this.bunifuImageButton8, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.bunifuImageButton8, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton8.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton8.Image")));
			this.bunifuImageButton8.ImageActive = null;
			this.bunifuImageButton8.Location = new System.Drawing.Point(112, 11);
			this.bunifuImageButton8.Margin = new System.Windows.Forms.Padding(2);
			this.bunifuImageButton8.Name = "bunifuImageButton8";
			this.bunifuImageButton8.Size = new System.Drawing.Size(19, 20);
			this.bunifuImageButton8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton8.TabIndex = 6;
			this.bunifuImageButton8.TabStop = false;
			this.bunifuImageButton8.Zoom = 10;
			// 
			// bunifuImageButton9
			// 
			this.bunifuImageButton9.BackColor = System.Drawing.Color.Transparent;
			this.sidePanelAnimator.SetDecoration(this.bunifuImageButton9, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.bunifuImageButton9, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton9.Image")));
			this.bunifuImageButton9.ImageActive = null;
			this.bunifuImageButton9.Location = new System.Drawing.Point(160, 11);
			this.bunifuImageButton9.Margin = new System.Windows.Forms.Padding(2);
			this.bunifuImageButton9.Name = "bunifuImageButton9";
			this.bunifuImageButton9.Size = new System.Drawing.Size(19, 20);
			this.bunifuImageButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton9.TabIndex = 5;
			this.bunifuImageButton9.TabStop = false;
			this.bunifuImageButton9.Zoom = 10;
			// 
			// bunifuImageButton10
			// 
			this.bunifuImageButton10.BackColor = System.Drawing.Color.Transparent;
			this.sidePanelAnimator.SetDecoration(this.bunifuImageButton10, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.bunifuImageButton10, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton10.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton10.Image")));
			this.bunifuImageButton10.ImageActive = null;
			this.bunifuImageButton10.Location = new System.Drawing.Point(10, 11);
			this.bunifuImageButton10.Margin = new System.Windows.Forms.Padding(2);
			this.bunifuImageButton10.Name = "bunifuImageButton10";
			this.bunifuImageButton10.Size = new System.Drawing.Size(19, 20);
			this.bunifuImageButton10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton10.TabIndex = 4;
			this.bunifuImageButton10.TabStop = false;
			this.bunifuImageButton10.Zoom = 10;
			// 
			// bunifuCustomLabel4
			// 
			this.bunifuCustomLabel4.AutoSize = true;
			this.logoAnimator.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel4.Location = new System.Drawing.Point(79, 126);
			this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
			this.bunifuCustomLabel4.Size = new System.Drawing.Size(49, 17);
			this.bunifuCustomLabel4.TabIndex = 4;
			this.bunifuCustomLabel4.Text = "Online";
			this.bunifuCustomLabel4.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
			// 
			// bunifuImageButton6
			// 
			this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
			this.sidePanelAnimator.SetDecoration(this.bunifuImageButton6, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.bunifuImageButton6, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
			this.bunifuImageButton6.ImageActive = null;
			this.bunifuImageButton6.Location = new System.Drawing.Point(64, 120);
			this.bunifuImageButton6.Margin = new System.Windows.Forms.Padding(2);
			this.bunifuImageButton6.Name = "bunifuImageButton6";
			this.bunifuImageButton6.Size = new System.Drawing.Size(16, 30);
			this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton6.TabIndex = 3;
			this.bunifuImageButton6.TabStop = false;
			this.bunifuImageButton6.Zoom = 10;
			// 
			// bunifuCustomLabel3
			// 
			this.bunifuCustomLabel3.AutoSize = true;
			this.logoAnimator.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel3.Location = new System.Drawing.Point(56, 97);
			this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
			this.bunifuCustomLabel3.Size = new System.Drawing.Size(63, 13);
			this.bunifuCustomLabel3.TabIndex = 2;
			this.bunifuCustomLabel3.Text = "Designation";
			this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
			// 
			// designation
			// 
			this.designation.AutoSize = true;
			this.logoAnimator.SetDecoration(this.designation, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.designation, BunifuAnimatorNS.DecorationType.None);
			this.designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.designation.ForeColor = System.Drawing.Color.White;
			this.designation.Location = new System.Drawing.Point(16, 77);
			this.designation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.designation.Name = "designation";
			this.designation.Size = new System.Drawing.Size(12, 17);
			this.designation.TabIndex = 1;
			this.designation.Text = " ";
			this.designation.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
			// 
			// bunifuImageButton4
			// 
			this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
			this.sidePanelAnimator.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
			this.bunifuImageButton4.ImageActive = null;
			this.bunifuImageButton4.Location = new System.Drawing.Point(68, 16);
			this.bunifuImageButton4.Margin = new System.Windows.Forms.Padding(2);
			this.bunifuImageButton4.Name = "bunifuImageButton4";
			this.bunifuImageButton4.Size = new System.Drawing.Size(46, 49);
			this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton4.TabIndex = 0;
			this.bunifuImageButton4.TabStop = false;
			this.bunifuImageButton4.Zoom = 10;
			// 
			// logoAnimator
			// 
			this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
			this.logoAnimator.Cursor = null;
			animation7.AnimateOnlyDifferences = true;
			animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
			animation7.LeafCoeff = 0F;
			animation7.MaxTime = 1F;
			animation7.MinTime = 0F;
			animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
			animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
			animation7.MosaicSize = 0;
			animation7.Padding = new System.Windows.Forms.Padding(0);
			animation7.RotateCoeff = 0F;
			animation7.RotateLimit = 0F;
			animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
			animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
			animation7.TimeCoeff = 0F;
			animation7.TransparencyCoeff = 0F;
			this.logoAnimator.DefaultAnimation = animation7;
			// 
			// displayViewPanel
			// 
			this.displayViewPanel.AccessibleDescription = "Control the displays based on button click";
			this.displayViewPanel.AccessibleName = "displayViewPanel";
			this.displayViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.displayViewPanel.BackColor = System.Drawing.Color.White;
			this.sidePanelAnimator.SetDecoration(this.displayViewPanel, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.displayViewPanel, BunifuAnimatorNS.DecorationType.None);
			this.displayViewPanel.Location = new System.Drawing.Point(243, 32);
			this.displayViewPanel.Margin = new System.Windows.Forms.Padding(2);
			this.displayViewPanel.Name = "displayViewPanel";
			this.displayViewPanel.Size = new System.Drawing.Size(585, 495);
			this.displayViewPanel.TabIndex = 3;
			this.displayViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.displayViewPanel_Paint);
			// 
			// sidePanelAnimator
			// 
			this.sidePanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
			this.sidePanelAnimator.Cursor = null;
			animation8.AnimateOnlyDifferences = true;
			animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
			animation8.LeafCoeff = 0F;
			animation8.MaxTime = 1F;
			animation8.MinTime = 0F;
			animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
			animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
			animation8.MosaicSize = 0;
			animation8.Padding = new System.Windows.Forms.Padding(50);
			animation8.RotateCoeff = 1F;
			animation8.RotateLimit = 0F;
			animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
			animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
			animation8.TimeCoeff = 0F;
			animation8.TransparencyCoeff = 1F;
			this.sidePanelAnimator.DefaultAnimation = animation8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 526);
			this.Controls.Add(this.displayViewPanel);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.leftSideMenu);
			this.Controls.Add(this.TitleBar);
			this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.TitleBar.ResumeLayout(false);
			this.TitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maximizeBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
			this.leftSideMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Panel TitleBar;
		private Bunifu.Framework.UI.BunifuImageButton closeBtn;
		private Bunifu.Framework.UI.BunifuImageButton minimizeBtn;
		private Bunifu.Framework.UI.BunifuImageButton maximizeBtn;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private System.Windows.Forms.Panel leftSideMenu;
		private System.Windows.Forms.Panel panel2;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
		private Bunifu.Framework.UI.BunifuCustomLabel designation;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
		private System.Windows.Forms.PictureBox logo;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
		private Bunifu.Framework.UI.BunifuFlatButton chatButton;
		private Bunifu.Framework.UI.BunifuFlatButton taskManagementButton;
		private Bunifu.Framework.UI.BunifuFlatButton googleSuiteButton;
		private Bunifu.Framework.UI.BunifuFlatButton calendarButton;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
		private System.Windows.Forms.Panel panel3;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton7;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton8;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton9;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton10;
		private BunifuAnimatorNS.BunifuTransition sidePanelAnimator;
		private BunifuAnimatorNS.BunifuTransition logoAnimator;
		private System.Windows.Forms.Panel displayViewPanel;
		private Bunifu.Framework.UI.BunifuVTrackbar bunifuVTrackbar1;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
		private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}

