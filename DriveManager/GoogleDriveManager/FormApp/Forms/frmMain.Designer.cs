﻿namespace PhoenixGoogleDriveManager
{
    partial class frmMain
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ofgFileToUpload = new System.Windows.Forms.OpenFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.btnUpload = new System.Windows.Forms.Button();
			this.button_browse = new System.Windows.Forms.Button();
			this.txtFilePath = new System.Windows.Forms.TextBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.pnlDragAndDrop = new System.Windows.Forms.Panel();
			this.pnlListBox = new System.Windows.Forms.Panel();
			this.lblBackUp = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.txtBackUpName = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.lbFilesToUpload = new System.Windows.Forms.ListBox();
			this.pnlSF = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMd5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btnDirToUpload = new System.Windows.Forms.Button();
			this.chbUploadMultiple = new System.Windows.Forms.CheckBox();
			this.chbCompress = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCreateBatch = new System.Windows.Forms.Button();
			this.txtParentID = new System.Windows.Forms.TextBox();
			this.pnlConnection = new System.Windows.Forms.Panel();
			this.chbAddUser = new System.Windows.Forms.CheckBox();
			this.pnlUser = new System.Windows.Forms.Panel();
			this.pnlClient = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtJsonPath = new System.Windows.Forms.TextBox();
			this.btnJsonBroswe = new System.Windows.Forms.Button();
			this.btnRemUser = new System.Windows.Forms.Button();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cbUser = new System.Windows.Forms.ComboBox();
			this.ofgJsonFile = new System.Windows.Forms.OpenFileDialog();
			this.label5 = new System.Windows.Forms.Label();
			this.lblPanel = new System.Windows.Forms.Label();
			this.fbdDirToUpload = new System.Windows.Forms.FolderBrowserDialog();
			this.dgvFilesFromDrive = new System.Windows.Forms.DataGridView();
			this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fileModifiedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MD5Checksum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.webContentLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmnuWebLink = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmnuOpenFileOnBrowser = new System.Windows.Forms.ToolStripMenuItem();
			this.cmnuCopyID = new System.Windows.Forms.ToolStripMenuItem();
			this.cmnuCopyHash = new System.Windows.Forms.ToolStripMenuItem();
			this.btnDownload = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.menuMain = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCreateTaskSchedule = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCalendar = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnu_About = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtCreateFolder = new System.Windows.Forms.TextBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.cbFileType = new System.Windows.Forms.ComboBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearchFile = new System.Windows.Forms.TextBox();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.lblProgress = new System.Windows.Forms.Label();
			this.pnlDragAndDrop.SuspendLayout();
			this.pnlListBox.SuspendLayout();
			this.pnlSF.SuspendLayout();
			this.pnlConnection.SuspendLayout();
			this.pnlUser.SuspendLayout();
			this.pnlClient.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFilesFromDrive)).BeginInit();
			this.cmnuWebLink.SuspendLayout();
			this.menuMain.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ofgFileToUpload
			// 
			this.ofgFileToUpload.FileOk += new System.ComponentModel.CancelEventHandler(this.ofgFileToUpload_FileOk);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label1.Location = new System.Drawing.Point(4, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "File name";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtFileName
			// 
			this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.txtFileName.Location = new System.Drawing.Point(71, 83);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(203, 20);
			this.txtFileName.TabIndex = 11;
			this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
			// 
			// btnUpload
			// 
			this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnUpload.BackColor = System.Drawing.Color.LightCyan;
			this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnUpload.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnUpload.Location = new System.Drawing.Point(3, 210);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(120, 25);
			this.btnUpload.TabIndex = 9;
			this.btnUpload.Text = "Upload File";
			this.btnUpload.UseVisualStyleBackColor = false;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// button_browse
			// 
			this.button_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.button_browse.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button_browse.Location = new System.Drawing.Point(186, 0);
			this.button_browse.Name = "button_browse";
			this.button_browse.Size = new System.Drawing.Size(88, 23);
			this.button_browse.TabIndex = 7;
			this.button_browse.Text = "Browse";
			this.button_browse.UseVisualStyleBackColor = true;
			this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
			// 
			// txtFilePath
			// 
			this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.txtFilePath.Location = new System.Drawing.Point(71, 57);
			this.txtFilePath.Name = "txtFilePath";
			this.txtFilePath.ReadOnly = true;
			this.txtFilePath.Size = new System.Drawing.Size(203, 20);
			this.txtFilePath.TabIndex = 8;
			this.txtFilePath.TextChanged += new System.EventHandler(this.textBox_path_TextChanged);
			// 
			// btnConnect
			// 
			this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnConnect.BackColor = System.Drawing.Color.Red;
			this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnConnect.Location = new System.Drawing.Point(3, 241);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(272, 40);
			this.btnConnect.TabIndex = 6;
			this.btnConnect.Text = "Connect to Drive";
			this.btnConnect.UseVisualStyleBackColor = false;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// pnlDragAndDrop
			// 
			this.pnlDragAndDrop.AllowDrop = true;
			this.pnlDragAndDrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlDragAndDrop.BackColor = System.Drawing.Color.DarkSlateGray;
			this.pnlDragAndDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlDragAndDrop.Controls.Add(this.pnlListBox);
			this.pnlDragAndDrop.Controls.Add(this.pnlSF);
			this.pnlDragAndDrop.Controls.Add(this.chbUploadMultiple);
			this.pnlDragAndDrop.Controls.Add(this.chbCompress);
			this.pnlDragAndDrop.Controls.Add(this.label2);
			this.pnlDragAndDrop.Controls.Add(this.btnCreateBatch);
			this.pnlDragAndDrop.Controls.Add(this.txtParentID);
			this.pnlDragAndDrop.Controls.Add(this.btnUpload);
			this.pnlDragAndDrop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.pnlDragAndDrop.Location = new System.Drawing.Point(7, 371);
			this.pnlDragAndDrop.Name = "pnlDragAndDrop";
			this.pnlDragAndDrop.Size = new System.Drawing.Size(282, 245);
			this.pnlDragAndDrop.TabIndex = 17;
			this.pnlDragAndDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDragAndDrop_DragDrop);
			this.pnlDragAndDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDragAndDrop_DragEnter);
			this.pnlDragAndDrop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDragAndDrop_Paint);
			// 
			// pnlListBox
			// 
			this.pnlListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlListBox.Controls.Add(this.lblBackUp);
			this.pnlListBox.Controls.Add(this.btnReset);
			this.pnlListBox.Controls.Add(this.txtBackUpName);
			this.pnlListBox.Controls.Add(this.label13);
			this.pnlListBox.Controls.Add(this.lbFilesToUpload);
			this.pnlListBox.Location = new System.Drawing.Point(1, 27);
			this.pnlListBox.Name = "pnlListBox";
			this.pnlListBox.Size = new System.Drawing.Size(277, 131);
			this.pnlListBox.TabIndex = 102;
			this.pnlListBox.Visible = false;
			this.pnlListBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlListBox_Paint);
			// 
			// lblBackUp
			// 
			this.lblBackUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblBackUp.AutoSize = true;
			this.lblBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.lblBackUp.Location = new System.Drawing.Point(5, 110);
			this.lblBackUp.Name = "lblBackUp";
			this.lblBackUp.Size = new System.Drawing.Size(60, 16);
			this.lblBackUp.TabIndex = 104;
			this.lblBackUp.Text = "BackUp ";
			this.lblBackUp.Click += new System.EventHandler(this.lblBackUp_Click);
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnReset.Location = new System.Drawing.Point(208, 1);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(66, 20);
			this.btnReset.TabIndex = 25;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// txtBackUpName
			// 
			this.txtBackUpName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtBackUpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.txtBackUpName.Location = new System.Drawing.Point(71, 109);
			this.txtBackUpName.Name = "txtBackUpName";
			this.txtBackUpName.Size = new System.Drawing.Size(203, 20);
			this.txtBackUpName.TabIndex = 103;
			this.txtBackUpName.TextChanged += new System.EventHandler(this.txtBackUpName_TextChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label13.Location = new System.Drawing.Point(5, 4);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(157, 16);
			this.label13.TabIndex = 101;
			this.label13.Text = "Drag and Drop files here!";
			this.label13.Click += new System.EventHandler(this.label13_Click);
			// 
			// lbFilesToUpload
			// 
			this.lbFilesToUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lbFilesToUpload.FormattingEnabled = true;
			this.lbFilesToUpload.HorizontalScrollbar = true;
			this.lbFilesToUpload.Location = new System.Drawing.Point(8, 22);
			this.lbFilesToUpload.Name = "lbFilesToUpload";
			this.lbFilesToUpload.Size = new System.Drawing.Size(266, 82);
			this.lbFilesToUpload.TabIndex = 0;
			this.lbFilesToUpload.SelectedIndexChanged += new System.EventHandler(this.lbFilesToUpload_SelectedIndexChanged);
			// 
			// pnlSF
			// 
			this.pnlSF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlSF.Controls.Add(this.label3);
			this.pnlSF.Controls.Add(this.txtMd5);
			this.pnlSF.Controls.Add(this.txtFileName);
			this.pnlSF.Controls.Add(this.label6);
			this.pnlSF.Controls.Add(this.label1);
			this.pnlSF.Controls.Add(this.button_browse);
			this.pnlSF.Controls.Add(this.txtFilePath);
			this.pnlSF.Controls.Add(this.label4);
			this.pnlSF.Controls.Add(this.label9);
			this.pnlSF.Controls.Add(this.btnDirToUpload);
			this.pnlSF.Location = new System.Drawing.Point(1, 27);
			this.pnlSF.Name = "pnlSF";
			this.pnlSF.Size = new System.Drawing.Size(277, 131);
			this.pnlSF.TabIndex = 101;
			this.pnlSF.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSF_Paint);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label3.Location = new System.Drawing.Point(3, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 16);
			this.label3.TabIndex = 13;
			this.label3.Text = "Select a File : ";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// txtMd5
			// 
			this.txtMd5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.txtMd5.ForeColor = System.Drawing.Color.OrangeRed;
			this.txtMd5.Location = new System.Drawing.Point(71, 109);
			this.txtMd5.Name = "txtMd5";
			this.txtMd5.ReadOnly = true;
			this.txtMd5.Size = new System.Drawing.Size(203, 20);
			this.txtMd5.TabIndex = 27;
			this.txtMd5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtMd5.TextChanged += new System.EventHandler(this.txtMd5_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(5, 112);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 13);
			this.label6.TabIndex = 26;
			this.label6.Text = "MD5 Hash:";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label4.Location = new System.Drawing.Point(4, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 16);
			this.label4.TabIndex = 14;
			this.label4.Text = "File path";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label9.Location = new System.Drawing.Point(3, 33);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(102, 16);
			this.label9.TabIndex = 16;
			this.label9.Text = "Select a Folder:";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// btnDirToUpload
			// 
			this.btnDirToUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnDirToUpload.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDirToUpload.Location = new System.Drawing.Point(186, 29);
			this.btnDirToUpload.Name = "btnDirToUpload";
			this.btnDirToUpload.Size = new System.Drawing.Size(88, 23);
			this.btnDirToUpload.TabIndex = 8;
			this.btnDirToUpload.Text = "Browse";
			this.btnDirToUpload.UseVisualStyleBackColor = true;
			this.btnDirToUpload.Click += new System.EventHandler(this.btnDirToUpload_Click);
			// 
			// chbUploadMultiple
			// 
			this.chbUploadMultiple.AutoSize = true;
			this.chbUploadMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.chbUploadMultiple.Location = new System.Drawing.Point(37, 4);
			this.chbUploadMultiple.Name = "chbUploadMultiple";
			this.chbUploadMultiple.Size = new System.Drawing.Size(196, 20);
			this.chbUploadMultiple.TabIndex = 28;
			this.chbUploadMultiple.Text = "Upload Multiple Files/Folder";
			this.chbUploadMultiple.UseVisualStyleBackColor = true;
			this.chbUploadMultiple.CheckedChanged += new System.EventHandler(this.chbUploadMultiple_CheckedChanged);
			// 
			// chbCompress
			// 
			this.chbCompress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chbCompress.AutoSize = true;
			this.chbCompress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.chbCompress.Location = new System.Drawing.Point(37, 188);
			this.chbCompress.Name = "chbCompress";
			this.chbCompress.Size = new System.Drawing.Size(208, 20);
			this.chbCompress.TabIndex = 24;
			this.chbCompress.Text = "Compress Files/Folders to .zip";
			this.chbCompress.UseVisualStyleBackColor = true;
			this.chbCompress.CheckedChanged += new System.EventHandler(this.chbCompress_CheckedChanged);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label2.Location = new System.Drawing.Point(6, 163);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 16);
			this.label2.TabIndex = 19;
			this.label2.Text = "Parent ID";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// btnCreateBatch
			// 
			this.btnCreateBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCreateBatch.BackColor = System.Drawing.Color.LightCyan;
			this.btnCreateBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnCreateBatch.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnCreateBatch.Location = new System.Drawing.Point(155, 210);
			this.btnCreateBatch.Name = "btnCreateBatch";
			this.btnCreateBatch.Size = new System.Drawing.Size(120, 25);
			this.btnCreateBatch.TabIndex = 17;
			this.btnCreateBatch.Text = "Create batch";
			this.btnCreateBatch.UseVisualStyleBackColor = false;
			this.btnCreateBatch.Click += new System.EventHandler(this.btnCreateBatch_Click);
			// 
			// txtParentID
			// 
			this.txtParentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtParentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.txtParentID.Location = new System.Drawing.Point(72, 162);
			this.txtParentID.Name = "txtParentID";
			this.txtParentID.Size = new System.Drawing.Size(203, 20);
			this.txtParentID.TabIndex = 18;
			this.txtParentID.TextChanged += new System.EventHandler(this.txtParentID_TextChanged);
			// 
			// pnlConnection
			// 
			this.pnlConnection.AllowDrop = true;
			this.pnlConnection.BackColor = System.Drawing.Color.DarkSlateGray;
			this.pnlConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlConnection.Controls.Add(this.chbAddUser);
			this.pnlConnection.Controls.Add(this.pnlUser);
			this.pnlConnection.Controls.Add(this.label11);
			this.pnlConnection.Controls.Add(this.cbUser);
			this.pnlConnection.Controls.Add(this.btnConnect);
			this.pnlConnection.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.pnlConnection.Location = new System.Drawing.Point(7, 46);
			this.pnlConnection.Name = "pnlConnection";
			this.pnlConnection.Size = new System.Drawing.Size(282, 290);
			this.pnlConnection.TabIndex = 18;
			this.pnlConnection.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlConnection_DragDrop);
			this.pnlConnection.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlConnection_DragDragEnter);
			this.pnlConnection.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlConnection_Paint);
			// 
			// chbAddUser
			// 
			this.chbAddUser.AutoSize = true;
			this.chbAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.chbAddUser.Location = new System.Drawing.Point(193, 14);
			this.chbAddUser.Name = "chbAddUser";
			this.chbAddUser.Size = new System.Drawing.Size(84, 20);
			this.chbAddUser.TabIndex = 1;
			this.chbAddUser.Text = "Add User";
			this.chbAddUser.UseVisualStyleBackColor = true;
			this.chbAddUser.CheckedChanged += new System.EventHandler(this.chbAddUser_CheckedChanged);
			// 
			// pnlUser
			// 
			this.pnlUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlUser.Controls.Add(this.pnlClient);
			this.pnlUser.Controls.Add(this.btnRemUser);
			this.pnlUser.Controls.Add(this.txtUserName);
			this.pnlUser.Controls.Add(this.btnAddUser);
			this.pnlUser.Controls.Add(this.label10);
			this.pnlUser.Location = new System.Drawing.Point(1, 48);
			this.pnlUser.Name = "pnlUser";
			this.pnlUser.Size = new System.Drawing.Size(277, 187);
			this.pnlUser.TabIndex = 23;
			this.pnlUser.Visible = false;
			this.pnlUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUser_Paint);
			// 
			// pnlClient
			// 
			this.pnlClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlClient.Controls.Add(this.label12);
			this.pnlClient.Controls.Add(this.label7);
			this.pnlClient.Controls.Add(this.label8);
			this.pnlClient.Controls.Add(this.txtJsonPath);
			this.pnlClient.Controls.Add(this.btnJsonBroswe);
			this.pnlClient.Location = new System.Drawing.Point(4, 42);
			this.pnlClient.Name = "pnlClient";
			this.pnlClient.Size = new System.Drawing.Size(265, 97);
			this.pnlClient.TabIndex = 24;
			this.pnlClient.Visible = false;
			this.pnlClient.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClient_Paint);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label12.ForeColor = System.Drawing.Color.LightSalmon;
			this.label12.Location = new System.Drawing.Point(35, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(183, 16);
			this.label12.TabIndex = 18;
			this.label12.Text = "Add your client (Optional)";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label12.Click += new System.EventHandler(this.label12_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label7.ForeColor = System.Drawing.Color.LightSalmon;
			this.label7.Location = new System.Drawing.Point(-1, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(165, 16);
			this.label7.TabIndex = 15;
			this.label7.Text = "Select client_secret.Json : ";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label8.ForeColor = System.Drawing.Color.LightSalmon;
			this.label8.Location = new System.Drawing.Point(-1, 47);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 16);
			this.label8.TabIndex = 17;
			this.label8.Text = "Json File path";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// txtJsonPath
			// 
			this.txtJsonPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.txtJsonPath.ForeColor = System.Drawing.Color.Salmon;
			this.txtJsonPath.Location = new System.Drawing.Point(2, 66);
			this.txtJsonPath.Name = "txtJsonPath";
			this.txtJsonPath.ReadOnly = true;
			this.txtJsonPath.Size = new System.Drawing.Size(257, 22);
			this.txtJsonPath.TabIndex = 3;
			this.txtJsonPath.TextChanged += new System.EventHandler(this.txtJsonPath_TextChanged);
			// 
			// btnJsonBroswe
			// 
			this.btnJsonBroswe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnJsonBroswe.ForeColor = System.Drawing.Color.LightSalmon;
			this.btnJsonBroswe.Location = new System.Drawing.Point(171, 21);
			this.btnJsonBroswe.Name = "btnJsonBroswe";
			this.btnJsonBroswe.Size = new System.Drawing.Size(88, 23);
			this.btnJsonBroswe.TabIndex = 3;
			this.btnJsonBroswe.Text = "Browse";
			this.btnJsonBroswe.UseVisualStyleBackColor = true;
			this.btnJsonBroswe.Click += new System.EventHandler(this.btnJsonBroswe_Click);
			// 
			// btnRemUser
			// 
			this.btnRemUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnRemUser.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnRemUser.Location = new System.Drawing.Point(4, 155);
			this.btnRemUser.Name = "btnRemUser";
			this.btnRemUser.Size = new System.Drawing.Size(106, 25);
			this.btnRemUser.TabIndex = 23;
			this.btnRemUser.Text = "Remove User";
			this.btnRemUser.UseVisualStyleBackColor = true;
			this.btnRemUser.Click += new System.EventHandler(this.btnRemUser_Click);
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.txtUserName.Location = new System.Drawing.Point(81, 7);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(194, 22);
			this.txtUserName.TabIndex = 2;
			this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
			// 
			// btnAddUser
			// 
			this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnAddUser.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnAddUser.Location = new System.Drawing.Point(187, 155);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(88, 25);
			this.btnAddUser.TabIndex = 5;
			this.btnAddUser.Text = "Save User";
			this.btnAddUser.UseVisualStyleBackColor = true;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label10.Location = new System.Drawing.Point(2, 10);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(77, 16);
			this.label10.TabIndex = 19;
			this.label10.Text = "User Name";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label11.Location = new System.Drawing.Point(4, 15);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(78, 16);
			this.label11.TabIndex = 21;
			this.label11.Text = "Select User";
			this.label11.Click += new System.EventHandler(this.label11_Click);
			// 
			// cbUser
			// 
			this.cbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.cbUser.FormattingEnabled = true;
			this.cbUser.Location = new System.Drawing.Point(83, 12);
			this.cbUser.Name = "cbUser";
			this.cbUser.Size = new System.Drawing.Size(104, 24);
			this.cbUser.TabIndex = 0;
			this.cbUser.SelectedIndexChanged += new System.EventHandler(this.cbUser_SelectedIndexChanged);
			// 
			// ofgJsonFile
			// 
			this.ofgJsonFile.Tag = ".Json";
			this.ofgJsonFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofgJsonFile_FileOk);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(4, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(177, 16);
			this.label5.TabIndex = 100;
			this.label5.Text = "Connect to Google Drive";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// lblPanel
			// 
			this.lblPanel.AutoSize = true;
			this.lblPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.lblPanel.ForeColor = System.Drawing.Color.White;
			this.lblPanel.Location = new System.Drawing.Point(4, 351);
			this.lblPanel.Name = "lblPanel";
			this.lblPanel.Size = new System.Drawing.Size(268, 16);
			this.lblPanel.TabIndex = 19;
			this.lblPanel.Text = "Upload Files/Folders to Google Drive";
			this.lblPanel.Click += new System.EventHandler(this.lblPanel_Click);
			// 
			// fbdDirToUpload
			// 
			this.fbdDirToUpload.HelpRequest += new System.EventHandler(this.fbdDirToUpload_HelpRequest);
			// 
			// dgvFilesFromDrive
			// 
			this.dgvFilesFromDrive.AllowDrop = true;
			this.dgvFilesFromDrive.AllowUserToAddRows = false;
			this.dgvFilesFromDrive.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.MintCream;
			this.dgvFilesFromDrive.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvFilesFromDrive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvFilesFromDrive.BackgroundColor = System.Drawing.Color.DarkSlateGray;
			this.dgvFilesFromDrive.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvFilesFromDrive.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFilesFromDrive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvFilesFromDrive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFilesFromDrive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.fileSize,
            this.fileModifiedTime,
            this.fileType,
            this.ID,
            this.MD5Checksum,
            this.webContentLink});
			this.dgvFilesFromDrive.ContextMenuStrip = this.cmnuWebLink;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.MintCream;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvFilesFromDrive.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvFilesFromDrive.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.dgvFilesFromDrive.Location = new System.Drawing.Point(295, 90);
			this.dgvFilesFromDrive.Name = "dgvFilesFromDrive";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.MintCream;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvFilesFromDrive.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvFilesFromDrive.RowTemplate.Height = 30;
			this.dgvFilesFromDrive.Size = new System.Drawing.Size(693, 480);
			this.dgvFilesFromDrive.TabIndex = 10;
			this.dgvFilesFromDrive.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilesFromDrive_CellClick);
			this.dgvFilesFromDrive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilesFromDrive_CellContentClick);
			this.dgvFilesFromDrive.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilesFromDrive_CellDoubleClick);
			this.dgvFilesFromDrive.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFilesFromDrive_CellMouseClick);
			this.dgvFilesFromDrive.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFilesFromDrive_CellMouseDown);
			this.dgvFilesFromDrive.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDragAndDrop_DragDrop);
			this.dgvFilesFromDrive.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDragAndDrop_DragEnter);
			// 
			// fileName
			// 
			this.fileName.DataPropertyName = "name";
			this.fileName.Frozen = true;
			this.fileName.HeaderText = "Name";
			this.fileName.Name = "fileName";
			this.fileName.ReadOnly = true;
			this.fileName.ToolTipText = "Google File Name";
			this.fileName.Width = 350;
			// 
			// fileSize
			// 
			this.fileSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.fileSize.DataPropertyName = "size";
			this.fileSize.HeaderText = "Size";
			this.fileSize.MinimumWidth = 100;
			this.fileSize.Name = "fileSize";
			this.fileSize.ReadOnly = true;
			this.fileSize.ToolTipText = "Size";
			// 
			// fileModifiedTime
			// 
			this.fileModifiedTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.fileModifiedTime.DataPropertyName = "lastModified";
			this.fileModifiedTime.HeaderText = "Last Modified";
			this.fileModifiedTime.MinimumWidth = 200;
			this.fileModifiedTime.Name = "fileModifiedTime";
			this.fileModifiedTime.ReadOnly = true;
			this.fileModifiedTime.ToolTipText = "Date of the last Modification";
			// 
			// fileType
			// 
			this.fileType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.fileType.DataPropertyName = "type";
			this.fileType.HeaderText = "Type";
			this.fileType.MinimumWidth = 300;
			this.fileType.Name = "fileType";
			this.fileType.ReadOnly = true;
			this.fileType.ToolTipText = "File Mime Type";
			// 
			// ID
			// 
			this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ID.DataPropertyName = "id";
			this.ID.HeaderText = "ID";
			this.ID.MinimumWidth = 420;
			this.ID.Name = "ID";
			this.ID.Visible = false;
			// 
			// MD5Checksum
			// 
			this.MD5Checksum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MD5Checksum.DataPropertyName = "hash";
			this.MD5Checksum.HeaderText = "MD5 Checksum";
			this.MD5Checksum.MinimumWidth = 300;
			this.MD5Checksum.Name = "MD5Checksum";
			this.MD5Checksum.Visible = false;
			// 
			// webContentLink
			// 
			this.webContentLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.webContentLink.DataPropertyName = "webContentLink";
			this.webContentLink.HeaderText = "Web Link";
			this.webContentLink.MinimumWidth = 300;
			this.webContentLink.Name = "webContentLink";
			this.webContentLink.Visible = false;
			// 
			// cmnuWebLink
			// 
			this.cmnuWebLink.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuOpenFileOnBrowser,
            this.cmnuCopyID,
            this.cmnuCopyHash});
			this.cmnuWebLink.Name = "cmnuWebLink";
			this.cmnuWebLink.Size = new System.Drawing.Size(185, 70);
			this.cmnuWebLink.Opening += new System.ComponentModel.CancelEventHandler(this.cmnuWebLink_Opening);
			// 
			// cmnuOpenFileOnBrowser
			// 
			this.cmnuOpenFileOnBrowser.Name = "cmnuOpenFileOnBrowser";
			this.cmnuOpenFileOnBrowser.Size = new System.Drawing.Size(184, 22);
			this.cmnuOpenFileOnBrowser.Text = "Open file on browser";
			this.cmnuOpenFileOnBrowser.Click += new System.EventHandler(this.cmnuOpenFileOnBrowser_Click);
			// 
			// cmnuCopyID
			// 
			this.cmnuCopyID.Name = "cmnuCopyID";
			this.cmnuCopyID.Size = new System.Drawing.Size(184, 22);
			this.cmnuCopyID.Text = "Copy ID";
			this.cmnuCopyID.Click += new System.EventHandler(this.cmnuCopyID_Click);
			// 
			// cmnuCopyHash
			// 
			this.cmnuCopyHash.Name = "cmnuCopyHash";
			this.cmnuCopyHash.Size = new System.Drawing.Size(184, 22);
			this.cmnuCopyHash.Text = "Copy Hash";
			this.cmnuCopyHash.Click += new System.EventHandler(this.cmnuCopyHash_Click);
			// 
			// btnDownload
			// 
			this.btnDownload.BackColor = System.Drawing.Color.LightCyan;
			this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnDownload.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDownload.Location = new System.Drawing.Point(6, 6);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(120, 25);
			this.btnDownload.TabIndex = 11;
			this.btnDownload.Text = "Download File";
			this.btnDownload.UseVisualStyleBackColor = false;
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.BackColor = System.Drawing.Color.LightCyan;
			this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnRemove.Location = new System.Drawing.Point(132, 6);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(120, 25);
			this.btnRemove.TabIndex = 12;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = false;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// menuMain
			// 
			this.menuMain.BackColor = System.Drawing.Color.DarkSlateGray;
			this.menuMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.mnuCalendar,
            this.aboutToolStripMenuItem});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new System.Drawing.Size(1000, 24);
			this.menuMain.TabIndex = 30;
			this.menuMain.Text = "Menu";
			this.menuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuMain_ItemClicked);
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateTaskSchedule});
			this.menuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.menuToolStripMenuItem.Text = "&Menu";
			this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
			// 
			// mnuCreateTaskSchedule
			// 
			this.mnuCreateTaskSchedule.Name = "mnuCreateTaskSchedule";
			this.mnuCreateTaskSchedule.Size = new System.Drawing.Size(230, 22);
			this.mnuCreateTaskSchedule.Text = "&Create Task Schedule";
			this.mnuCreateTaskSchedule.Click += new System.EventHandler(this.mnuCreateTaskSchedule_Click);
			// 
			// mnuCalendar
			// 
			this.mnuCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.mnuCalendar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.mnuCalendar.Name = "mnuCalendar";
			this.mnuCalendar.Size = new System.Drawing.Size(138, 20);
			this.mnuCalendar.Text = "Google Calendar";
			this.mnuCalendar.Click += new System.EventHandler(this.mnuCalendar_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_About,
            this.mnuHelp});
			this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.aboutToolStripMenuItem.Text = "&Help";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// mnu_About
			// 
			this.mnu_About.Name = "mnu_About";
			this.mnu_About.Size = new System.Drawing.Size(116, 22);
			this.mnu_About.Text = "A&bout";
			this.mnu_About.Click += new System.EventHandler(this.mnu_About_Click);
			// 
			// mnuHelp
			// 
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size(116, 22);
			this.mnuHelp.Text = "Help";
			this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtCreateFolder);
			this.panel1.Controls.Add(this.btnCreate);
			this.panel1.Controls.Add(this.btnDownload);
			this.panel1.Controls.Add(this.btnRemove);
			this.panel1.Location = new System.Drawing.Point(295, 576);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(693, 38);
			this.panel1.TabIndex = 31;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// txtCreateFolder
			// 
			this.txtCreateFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCreateFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.txtCreateFolder.Location = new System.Drawing.Point(328, 8);
			this.txtCreateFolder.Name = "txtCreateFolder";
			this.txtCreateFolder.Size = new System.Drawing.Size(232, 22);
			this.txtCreateFolder.TabIndex = 26;
			this.txtCreateFolder.TextChanged += new System.EventHandler(this.txtCreateFolder_TextChanged);
			// 
			// btnCreate
			// 
			this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreate.BackColor = System.Drawing.Color.LightCyan;
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnCreate.Location = new System.Drawing.Point(566, 6);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(120, 25);
			this.btnCreate.TabIndex = 14;
			this.btnCreate.Text = "Create Folder";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefresh.BackColor = System.Drawing.Color.LightCyan;
			this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnRefresh.Location = new System.Drawing.Point(566, 6);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(120, 25);
			this.btnRefresh.TabIndex = 13;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
			// 
			// tmrUpdate
			// 
			this.tmrUpdate.Enabled = true;
			this.tmrUpdate.Interval = 10;
			this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.cbFileType);
			this.panel2.Controls.Add(this.btnSearch);
			this.panel2.Controls.Add(this.txtSearchFile);
			this.panel2.Controls.Add(this.btnRefresh);
			this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.panel2.Location = new System.Drawing.Point(295, 46);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(693, 38);
			this.panel2.TabIndex = 32;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// cbFileType
			// 
			this.cbFileType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.cbFileType.FormattingEnabled = true;
			this.cbFileType.Location = new System.Drawing.Point(314, 7);
			this.cbFileType.Name = "cbFileType";
			this.cbFileType.Size = new System.Drawing.Size(120, 24);
			this.cbFileType.TabIndex = 24;
			this.cbFileType.SelectedIndexChanged += new System.EventHandler(this.cbFileType_SelectedIndexChanged);
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.BackColor = System.Drawing.Color.LightCyan;
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSearch.Location = new System.Drawing.Point(440, 6);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(120, 25);
			this.btnSearch.TabIndex = 26;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearchFile
			// 
			this.txtSearchFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearchFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.txtSearchFile.Location = new System.Drawing.Point(6, 8);
			this.txtSearchFile.Name = "txtSearchFile";
			this.txtSearchFile.Size = new System.Drawing.Size(302, 22);
			this.txtSearchFile.TabIndex = 25;
			this.txtSearchFile.TextChanged += new System.EventHandler(this.txtSearchFile_TextChanged);
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(736, 0);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(252, 23);
			this.progressBar.TabIndex = 101;
			this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
			// 
			// lblProgress
			// 
			this.lblProgress.AutoSize = true;
			this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.lblProgress.ForeColor = System.Drawing.Color.White;
			this.lblProgress.Location = new System.Drawing.Point(607, 4);
			this.lblProgress.Name = "lblProgress";
			this.lblProgress.Size = new System.Drawing.Size(120, 17);
			this.lblProgress.TabIndex = 102;
			this.lblProgress.Text = "DownLoading...";
			this.lblProgress.Click += new System.EventHandler(this.lblProgress_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkCyan;
			this.Controls.Add(this.lblProgress);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuMain);
			this.Controls.Add(this.dgvFilesFromDrive);
			this.Controls.Add(this.lblPanel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pnlConnection);
			this.Controls.Add(this.pnlDragAndDrop);
			this.MinimumSize = new System.Drawing.Size(750, 470);
			this.Name = "frmMain";
			this.Size = new System.Drawing.Size(1000, 622);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Resize += new System.EventHandler(this.frmMain_Resize);
			this.pnlDragAndDrop.ResumeLayout(false);
			this.pnlDragAndDrop.PerformLayout();
			this.pnlListBox.ResumeLayout(false);
			this.pnlListBox.PerformLayout();
			this.pnlSF.ResumeLayout(false);
			this.pnlSF.PerformLayout();
			this.pnlConnection.ResumeLayout(false);
			this.pnlConnection.PerformLayout();
			this.pnlUser.ResumeLayout(false);
			this.pnlUser.PerformLayout();
			this.pnlClient.ResumeLayout(false);
			this.pnlClient.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFilesFromDrive)).EndInit();
			this.cmnuWebLink.ResumeLayout(false);
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofgFileToUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel pnlDragAndDrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlConnection;
        private System.Windows.Forms.TextBox txtJsonPath;
        private System.Windows.Forms.Button btnJsonBroswe;
        private System.Windows.Forms.OpenFileDialog ofgJsonFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDirToUpload;
        private System.Windows.Forms.FolderBrowserDialog fbdDirToUpload;
        private System.Windows.Forms.DataGridView dgvFilesFromDrive;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.CheckBox chbAddUser;
        private System.Windows.Forms.Button btnRemUser;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_About;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateBatch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.CheckBox chbCompress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParentID;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearchFile;
        private System.Windows.Forms.TextBox txtCreateFolder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbFileType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMd5;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlSF;
        private System.Windows.Forms.CheckBox chbUploadMultiple;
        private System.Windows.Forms.Panel pnlListBox;
        private System.Windows.Forms.ListBox lbFilesToUpload;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblBackUp;
        private System.Windows.Forms.TextBox txtBackUpName;
        private System.Windows.Forms.ToolStripMenuItem mnuCalendar;
        private System.Windows.Forms.ContextMenuStrip cmnuWebLink;
        private System.Windows.Forms.ToolStripMenuItem cmnuOpenFileOnBrowser;
        private System.Windows.Forms.ToolStripMenuItem cmnuCopyID;
        private System.Windows.Forms.ToolStripMenuItem cmnuCopyHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileModifiedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MD5Checksum;
        private System.Windows.Forms.DataGridViewTextBoxColumn webContentLink;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateTaskSchedule;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblProgress;
    }
}

