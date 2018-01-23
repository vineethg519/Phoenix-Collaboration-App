namespace PhoenixCollaborationApp
{
    partial class forgotPassForm
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
			BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotPassForm));
			BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
			this.sidePanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.username2 = new System.Windows.Forms.TextBox();
			this.logo = new System.Windows.Forms.PictureBox();
			this.minimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
			this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			this.TitleBar = new System.Windows.Forms.Panel();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.leftSideMenu = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.change_pwd = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.old_pwd = new System.Windows.Forms.TextBox();
			this.new_pwd = new System.Windows.Forms.TextBox();
			this.login_page = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			this.TitleBar.SuspendLayout();
			this.leftSideMenu.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// sidePanelAnimator
			// 
			this.sidePanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
			this.sidePanelAnimator.Cursor = null;
			animation1.AnimateOnlyDifferences = true;
			animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
			animation1.LeafCoeff = 0F;
			animation1.MaxTime = 1F;
			animation1.MinTime = 0F;
			animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
			animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
			animation1.MosaicSize = 0;
			animation1.Padding = new System.Windows.Forms.Padding(50);
			animation1.RotateCoeff = 1F;
			animation1.RotateLimit = 0F;
			animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
			animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
			animation1.TimeCoeff = 0F;
			animation1.TransparencyCoeff = 1F;
			this.sidePanelAnimator.DefaultAnimation = animation1;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.sidePanelAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(41, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Email:";
			// 
			// username2
			// 
			this.username2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sidePanelAnimator.SetDecoration(this.username2, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.username2, BunifuAnimatorNS.DecorationType.None);
			this.username2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username2.Location = new System.Drawing.Point(192, 49);
			this.username2.Name = "username2";
			this.username2.Size = new System.Drawing.Size(201, 22);
			this.username2.TabIndex = 2;
			this.username2.TextChanged += new System.EventHandler(this.username2_TextChanged);
			// 
			// logo
			// 
			this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.sidePanelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
			this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
			this.logo.Location = new System.Drawing.Point(338, 15);
			this.logo.Margin = new System.Windows.Forms.Padding(2);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(205, 73);
			this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logo.TabIndex = 0;
			this.logo.TabStop = false;
			// 
			// minimizeBtn
			// 
			this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.minimizeBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.logoAnimator.SetDecoration(this.minimizeBtn, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.minimizeBtn, BunifuAnimatorNS.DecorationType.None);
			this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
			this.minimizeBtn.ImageActive = null;
			this.minimizeBtn.Location = new System.Drawing.Point(838, 9);
			this.minimizeBtn.Margin = new System.Windows.Forms.Padding(2);
			this.minimizeBtn.Name = "minimizeBtn";
			this.minimizeBtn.Size = new System.Drawing.Size(18, 19);
			this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.minimizeBtn.TabIndex = 5;
			this.minimizeBtn.TabStop = false;
			this.minimizeBtn.Zoom = 10;
			// 
			// closeBtn
			// 
			this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.logoAnimator.SetDecoration(this.closeBtn, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.closeBtn, BunifuAnimatorNS.DecorationType.None);
			this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
			this.closeBtn.ImageActive = null;
			this.closeBtn.Location = new System.Drawing.Point(860, 9);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(18, 19);
			this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.closeBtn.TabIndex = 3;
			this.closeBtn.TabStop = false;
			this.closeBtn.Zoom = 10;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// bunifuImageButton3
			// 
			this.bunifuImageButton3.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.logoAnimator.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
			this.bunifuImageButton3.ImageActive = null;
			this.bunifuImageButton3.Location = new System.Drawing.Point(925, 6);
			this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(2);
			this.bunifuImageButton3.Name = "bunifuImageButton3";
			this.bunifuImageButton3.Size = new System.Drawing.Size(18, 19);
			this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton3.TabIndex = 2;
			this.bunifuImageButton3.TabStop = false;
			this.bunifuImageButton3.Zoom = 10;
			// 
			// bunifuImageButton2
			// 
			this.bunifuImageButton2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.logoAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
			this.bunifuImageButton2.ImageActive = null;
			this.bunifuImageButton2.Location = new System.Drawing.Point(958, 6);
			this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(2);
			this.bunifuImageButton2.Name = "bunifuImageButton2";
			this.bunifuImageButton2.Size = new System.Drawing.Size(18, 19);
			this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton2.TabIndex = 1;
			this.bunifuImageButton2.TabStop = false;
			this.bunifuImageButton2.Zoom = 10;
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.logoAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(989, 6);
			this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(18, 19);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 0;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			// 
			// TitleBar
			// 
			this.TitleBar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.TitleBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.TitleBar.Controls.Add(this.bunifuCustomLabel1);
			this.TitleBar.Controls.Add(this.minimizeBtn);
			this.TitleBar.Controls.Add(this.closeBtn);
			this.TitleBar.Controls.Add(this.bunifuImageButton3);
			this.TitleBar.Controls.Add(this.bunifuImageButton2);
			this.TitleBar.Controls.Add(this.bunifuImageButton1);
			this.logoAnimator.SetDecoration(this.TitleBar, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.TitleBar, BunifuAnimatorNS.DecorationType.None);
			this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.TitleBar.Location = new System.Drawing.Point(0, 0);
			this.TitleBar.Margin = new System.Windows.Forms.Padding(2);
			this.TitleBar.Name = "TitleBar";
			this.TitleBar.Size = new System.Drawing.Size(885, 32);
			this.TitleBar.TabIndex = 12;
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.sidePanelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(11, 6);
			this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(177, 17);
			this.bunifuCustomLabel1.TabIndex = 6;
			this.bunifuCustomLabel1.Text = "Phoenix Collaboration Tool";
			// 
			// leftSideMenu
			// 
			this.leftSideMenu.AccessibleName = "leftSideMenu";
			this.leftSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.leftSideMenu.Controls.Add(this.groupBox1);
			this.leftSideMenu.Controls.Add(this.logo);
			this.logoAnimator.SetDecoration(this.leftSideMenu, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.leftSideMenu, BunifuAnimatorNS.DecorationType.None);
			this.leftSideMenu.Location = new System.Drawing.Point(0, 32);
			this.leftSideMenu.Margin = new System.Windows.Forms.Padding(2);
			this.leftSideMenu.Name = "leftSideMenu";
			this.leftSideMenu.Size = new System.Drawing.Size(885, 439);
			this.leftSideMenu.TabIndex = 13;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.change_pwd);
			this.groupBox1.Controls.Add(this.username2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.old_pwd);
			this.groupBox1.Controls.Add(this.new_pwd);
			this.groupBox1.Controls.Add(this.login_page);
			this.groupBox1.Controls.Add(this.label1);
			this.logoAnimator.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
			this.sidePanelAnimator.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.groupBox1.Location = new System.Drawing.Point(268, 114);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(427, 295);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Update Password";
			// 
			// change_pwd
			// 
			this.change_pwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.change_pwd.AutoSize = true;
			this.change_pwd.BackColor = System.Drawing.Color.ForestGreen;
			this.sidePanelAnimator.SetDecoration(this.change_pwd, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.change_pwd, BunifuAnimatorNS.DecorationType.None);
			this.change_pwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.change_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.change_pwd.ForeColor = System.Drawing.SystemColors.Window;
			this.change_pwd.Location = new System.Drawing.Point(192, 165);
			this.change_pwd.Name = "change_pwd";
			this.change_pwd.Size = new System.Drawing.Size(201, 32);
			this.change_pwd.TabIndex = 12;
			this.change_pwd.Text = "Change Password";
			this.change_pwd.UseVisualStyleBackColor = false;
			this.change_pwd.Click += new System.EventHandler(this.change_pwd_Click);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.sidePanelAnimator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label4.Location = new System.Drawing.Point(41, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Old Password:";
			// 
			// old_pwd
			// 
			this.old_pwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sidePanelAnimator.SetDecoration(this.old_pwd, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.old_pwd, BunifuAnimatorNS.DecorationType.None);
			this.old_pwd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.old_pwd.Location = new System.Drawing.Point(192, 88);
			this.old_pwd.Multiline = true;
			this.old_pwd.Name = "old_pwd";
			this.old_pwd.Size = new System.Drawing.Size(201, 20);
			this.old_pwd.TabIndex = 10;
			// 
			// new_pwd
			// 
			this.new_pwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sidePanelAnimator.SetDecoration(this.new_pwd, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.new_pwd, BunifuAnimatorNS.DecorationType.None);
			this.new_pwd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.new_pwd.Location = new System.Drawing.Point(192, 128);
			this.new_pwd.Multiline = true;
			this.new_pwd.Name = "new_pwd";
			this.new_pwd.Size = new System.Drawing.Size(201, 20);
			this.new_pwd.TabIndex = 7;
			// 
			// login_page
			// 
			this.login_page.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.login_page.AutoSize = true;
			this.login_page.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.sidePanelAnimator.SetDecoration(this.login_page, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.login_page, BunifuAnimatorNS.DecorationType.None);
			this.login_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.login_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_page.ForeColor = System.Drawing.SystemColors.Window;
			this.login_page.Location = new System.Drawing.Point(192, 219);
			this.login_page.Name = "login_page";
			this.login_page.Size = new System.Drawing.Size(201, 32);
			this.login_page.TabIndex = 9;
			this.login_page.Text = "< Back to Login";
			this.login_page.UseVisualStyleBackColor = false;
			this.login_page.Click += new System.EventHandler(this.login_page_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.sidePanelAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(41, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "New Password:";
			// 
			// logoAnimator
			// 
			this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
			this.logoAnimator.Cursor = null;
			animation2.AnimateOnlyDifferences = true;
			animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
			animation2.LeafCoeff = 0F;
			animation2.MaxTime = 1F;
			animation2.MinTime = 0F;
			animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
			animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
			animation2.MosaicSize = 0;
			animation2.Padding = new System.Windows.Forms.Padding(0);
			animation2.RotateCoeff = 0F;
			animation2.RotateLimit = 0F;
			animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
			animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
			animation2.TimeCoeff = 0F;
			animation2.TransparencyCoeff = 0F;
			this.logoAnimator.DefaultAnimation = animation2;
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.TitleBar;
			this.bunifuDragControl1.Vertical = true;
			// 
			// forgotPassForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(885, 470);
			this.Controls.Add(this.TitleBar);
			this.Controls.Add(this.leftSideMenu);
			this.sidePanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "forgotPassForm";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			this.TitleBar.ResumeLayout(false);
			this.TitleBar.PerformLayout();
			this.leftSideMenu.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition sidePanelAnimator;
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username2;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuImageButton minimizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Panel leftSideMenu;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox new_pwd;
        private System.Windows.Forms.Button login_page;
        private System.Windows.Forms.Button change_pwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox old_pwd;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}