namespace PhoenixCollaborationApp
{
    partial class TaskManagementIndividualTaskDetails
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
            this.TMCTaskDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ViewTaskDesc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ViewStartDate = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ViewEndDate = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Update = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.ViewTaskDeadline = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TMEditView = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.SearchText = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ViewStatus = new System.Windows.Forms.ComboBox();
            this.ViewPriority = new System.Windows.Forms.ComboBox();
            this.ViewAssignTo = new System.Windows.Forms.ComboBox();
            this.ViewTaskId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TMEditView)).BeginInit();
            this.SuspendLayout();
            // 
            // TMCTaskDescription
            // 
            this.TMCTaskDescription.AutoSize = true;
            this.TMCTaskDescription.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TMCTaskDescription.Location = new System.Drawing.Point(3, 21);
            this.TMCTaskDescription.Name = "TMCTaskDescription";
            this.TMCTaskDescription.Size = new System.Drawing.Size(87, 13);
            this.TMCTaskDescription.TabIndex = 2;
            this.TMCTaskDescription.Text = "Task Description";
            // 
            // ViewTaskDesc
            // 
            this.ViewTaskDesc.AccessibleName = "ViewTaskDesc";
            this.ViewTaskDesc.AutoScroll = true;
            this.ViewTaskDesc.BorderColorFocused = System.Drawing.Color.Blue;
            this.ViewTaskDesc.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ViewTaskDesc.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.ViewTaskDesc.BorderThickness = 1;
            this.ViewTaskDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ViewTaskDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ViewTaskDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ViewTaskDesc.isPassword = false;
            this.ViewTaskDesc.Location = new System.Drawing.Point(97, 4);
            this.ViewTaskDesc.Margin = new System.Windows.Forms.Padding(4);
            this.ViewTaskDesc.Name = "ViewTaskDesc";
            this.ViewTaskDesc.Size = new System.Drawing.Size(179, 42);
            this.ViewTaskDesc.TabIndex = 3;
            this.ViewTaskDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(2, 69);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(88, 13);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Actual Start Date";
            // 
            // ViewStartDate
            // 
            this.ViewStartDate.AccessibleName = "ViewStartDate";
            this.ViewStartDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.ViewStartDate.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.ViewStartDate.CustomFormat = "mm/dd/yyyy";
            this.ViewStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ViewStartDate.Location = new System.Drawing.Point(97, 63);
            this.ViewStartDate.Name = "ViewStartDate";
            this.ViewStartDate.Size = new System.Drawing.Size(117, 20);
            this.ViewStartDate.TabIndex = 5;
            this.ViewStartDate.ValueChanged += new System.EventHandler(this.ViewStartDate_ValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 139);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(76, 13);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Task Deadline";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(2, 105);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(85, 13);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Actual End Date";
            // 
            // ViewEndDate
            // 
            this.ViewEndDate.AccessibleName = "ViewEndDate";
            this.ViewEndDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.ViewEndDate.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.ViewEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ViewEndDate.Location = new System.Drawing.Point(97, 98);
            this.ViewEndDate.Name = "ViewEndDate";
            this.ViewEndDate.Size = new System.Drawing.Size(117, 20);
            this.ViewEndDate.TabIndex = 9;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(312, 98);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(38, 13);
            this.bunifuCustomLabel4.TabIndex = 10;
            this.bunifuCustomLabel4.Text = "Priority";
            this.bunifuCustomLabel4.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(312, 132);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(66, 13);
            this.bunifuCustomLabel5.TabIndex = 11;
            this.bunifuCustomLabel5.Text = "Assigned To";
            // 
            // Update
            // 
            this.Update.AccessibleName = "Update";
            this.Update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Update.Location = new System.Drawing.Point(56, 173);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 17;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.button1_Click);
            // 
            // View
            // 
            this.View.AccessibleName = "View";
            this.View.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.View.Location = new System.Drawing.Point(272, 173);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 18;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewTaskDeadline
            // 
            this.ViewTaskDeadline.AccessibleName = "ViewTaskDeadline";
            this.ViewTaskDeadline.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.ViewTaskDeadline.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.ViewTaskDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ViewTaskDeadline.Location = new System.Drawing.Point(97, 132);
            this.ViewTaskDeadline.Name = "ViewTaskDeadline";
            this.ViewTaskDeadline.Size = new System.Drawing.Size(117, 20);
            this.ViewTaskDeadline.TabIndex = 19;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(310, 63);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(37, 13);
            this.bunifuCustomLabel6.TabIndex = 29;
            this.bunifuCustomLabel6.Text = "Status";
            this.bunifuCustomLabel6.Click += new System.EventHandler(this.bunifuCustomLabel6_Click);
            // 
            // TMEditView
            // 
            this.TMEditView.AccessibleName = "TMEditView";
            this.TMEditView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TMEditView.Location = new System.Drawing.Point(6, 217);
            this.TMEditView.Name = "TMEditView";
            this.TMEditView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TMEditView.Size = new System.Drawing.Size(568, 150);
            this.TMEditView.TabIndex = 33;
            this.TMEditView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TMEditView_MouseDoubleClick);
            // 
            // Delete
            // 
            this.Delete.AccessibleName = "Delete";
            this.Delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Delete.Location = new System.Drawing.Point(163, 173);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 34;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Search
            // 
            this.Search.AccessibleName = "Search";
            this.Search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Search.Location = new System.Drawing.Point(500, 170);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 35;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchText
            // 
            this.SearchText.AccessibleName = "SearchText";
            this.SearchText.BorderColorFocused = System.Drawing.Color.Blue;
            this.SearchText.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchText.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.SearchText.BorderThickness = 1;
            this.SearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SearchText.ForeColor = System.Drawing.Color.Silver;
            this.SearchText.isPassword = false;
            this.SearchText.Location = new System.Drawing.Point(388, 170);
            this.SearchText.Margin = new System.Windows.Forms.Padding(4);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(105, 23);
            this.SearchText.TabIndex = 36;
            this.SearchText.Text = "Search Text";
            this.SearchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchText.OnValueChanged += new System.EventHandler(this.SearchText_OnValueChanged);
            this.SearchText.Enter += new System.EventHandler(this.SearchText_Enter);
            this.SearchText.Leave += new System.EventHandler(this.SearchText_Leave);
            // 
            // ViewStatus
            // 
            this.ViewStatus.AccessibleName = "ViewStatus";
            this.ViewStatus.FormattingEnabled = true;
            this.ViewStatus.Items.AddRange(new object[] {
            "In Progress",
            "On Hold",
            "Completed"});
            this.ViewStatus.Location = new System.Drawing.Point(388, 55);
            this.ViewStatus.Name = "ViewStatus";
            this.ViewStatus.Size = new System.Drawing.Size(121, 21);
            this.ViewStatus.TabIndex = 37;
            // 
            // ViewPriority
            // 
            this.ViewPriority.AccessibleName = "ViewPriority";
            this.ViewPriority.FormattingEnabled = true;
            this.ViewPriority.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.ViewPriority.Location = new System.Drawing.Point(388, 90);
            this.ViewPriority.Name = "ViewPriority";
            this.ViewPriority.Size = new System.Drawing.Size(121, 21);
            this.ViewPriority.TabIndex = 38;
            // 
            // ViewAssignTo
            // 
            this.ViewAssignTo.AccessibleName = "ViewAssignTo";
            this.ViewAssignTo.FormattingEnabled = true;
            this.ViewAssignTo.Location = new System.Drawing.Point(388, 124);
            this.ViewAssignTo.Name = "ViewAssignTo";
            this.ViewAssignTo.Size = new System.Drawing.Size(121, 21);
            this.ViewAssignTo.TabIndex = 39;
            // 
            // ViewTaskId
            // 
            this.ViewTaskId.AccessibleName = "ViewTaskId";
            this.ViewTaskId.BorderColorFocused = System.Drawing.Color.Blue;
            this.ViewTaskId.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ViewTaskId.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.ViewTaskId.BorderThickness = 1;
            this.ViewTaskId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ViewTaskId.Enabled = false;
            this.ViewTaskId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ViewTaskId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ViewTaskId.isPassword = false;
            this.ViewTaskId.Location = new System.Drawing.Point(388, 11);
            this.ViewTaskId.Margin = new System.Windows.Forms.Padding(4);
            this.ViewTaskId.Name = "ViewTaskId";
            this.ViewTaskId.Size = new System.Drawing.Size(91, 23);
            this.ViewTaskId.TabIndex = 41;
            this.ViewTaskId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(312, 21);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(42, 13);
            this.bunifuCustomLabel9.TabIndex = 40;
            this.bunifuCustomLabel9.Text = "TaskID";
            // 
            // TaskManagementIndividualTaskDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewTaskId);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.ViewAssignTo);
            this.Controls.Add(this.ViewPriority);
            this.Controls.Add(this.ViewStatus);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.TMEditView);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.ViewTaskDeadline);
            this.Controls.Add(this.View);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.ViewEndDate);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.ViewStartDate);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.ViewTaskDesc);
            this.Controls.Add(this.TMCTaskDescription);
            this.Name = "TaskManagementIndividualTaskDetails";
            this.Size = new System.Drawing.Size(578, 378);
            this.Load += new System.EventHandler(this.TaskManagementIndividualTaskDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TMEditView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel TMCTaskDescription;
        private Bunifu.Framework.UI.BunifuMetroTextbox ViewTaskDesc;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.DateTimePicker ViewStartDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.DateTimePicker ViewEndDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.DateTimePicker ViewTaskDeadline;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.DataGridView TMEditView;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Search;
        private Bunifu.Framework.UI.BunifuMetroTextbox SearchText;
        private System.Windows.Forms.ComboBox ViewStatus;
        private System.Windows.Forms.ComboBox ViewPriority;
        private System.Windows.Forms.ComboBox ViewAssignTo;
        private Bunifu.Framework.UI.BunifuMetroTextbox ViewTaskId;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
    }
}
