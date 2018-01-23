namespace PhoenixCollaborationApp
{
    partial class TaskManagementCreate
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
            this.TaskDesc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TMCTaskDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TaskDeadline = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.Status = new System.Windows.Forms.ComboBox();
            this.AssignTo = new System.Windows.Forms.ComboBox();
            this.Priority = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TaskId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // TaskDesc
            // 
            this.TaskDesc.AccessibleName = "TaskDesc";
            this.TaskDesc.AutoScroll = true;
            this.TaskDesc.BorderColorFocused = System.Drawing.Color.Blue;
            this.TaskDesc.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TaskDesc.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TaskDesc.BorderThickness = 1;
            this.TaskDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TaskDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TaskDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TaskDesc.isPassword = false;
            this.TaskDesc.Location = new System.Drawing.Point(99, 46);
            this.TaskDesc.Margin = new System.Windows.Forms.Padding(4);
            this.TaskDesc.Name = "TaskDesc";
            this.TaskDesc.Size = new System.Drawing.Size(179, 60);
            this.TaskDesc.TabIndex = 0;
            this.TaskDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TaskDesc.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            // 
            // TMCTaskDescription
            // 
            this.TMCTaskDescription.AutoSize = true;
            this.TMCTaskDescription.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TMCTaskDescription.Location = new System.Drawing.Point(5, 69);
            this.TMCTaskDescription.Name = "TMCTaskDescription";
            this.TMCTaskDescription.Size = new System.Drawing.Size(87, 13);
            this.TMCTaskDescription.TabIndex = 1;
            this.TMCTaskDescription.Text = "Task Description";
            this.TMCTaskDescription.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(294, 131);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(76, 13);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Task Deadline";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // TaskDeadline
            // 
            this.TaskDeadline.AccessibleName = "TaskDeadline";
            this.TaskDeadline.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.TaskDeadline.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.TaskDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TaskDeadline.Location = new System.Drawing.Point(376, 125);
            this.TaskDeadline.Name = "TaskDeadline";
            this.TaskDeadline.Size = new System.Drawing.Size(111, 20);
            this.TaskDeadline.TabIndex = 3;
            this.TaskDeadline.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(8, 219);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(66, 13);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Assigned To";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(170, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(306, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(322, 219);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(38, 13);
            this.bunifuCustomLabel4.TabIndex = 20;
            this.bunifuCustomLabel4.Text = "Priority";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(5, 131);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(88, 13);
            this.bunifuCustomLabel1.TabIndex = 23;
            this.bunifuCustomLabel1.Text = "Actual Start Date";
            // 
            // StartDate
            // 
            this.StartDate.AccessibleName = "StartDate";
            this.StartDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.StartDate.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(99, 131);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(122, 20);
            this.StartDate.TabIndex = 24;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AccessibleName = "";
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(322, 170);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(37, 13);
            this.bunifuCustomLabel5.TabIndex = 26;
            this.bunifuCustomLabel5.Text = "Status";
            this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(8, 170);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(85, 13);
            this.bunifuCustomLabel6.TabIndex = 28;
            this.bunifuCustomLabel6.Text = "Actual End Date";
            // 
            // EndDate
            // 
            this.EndDate.AccessibleName = "EndDate";
            this.EndDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.EndDate.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate.Location = new System.Drawing.Point(99, 170);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(122, 20);
            this.EndDate.TabIndex = 29;
            this.EndDate.ValueChanged += new System.EventHandler(this.EndDate_ValueChanged);
            // 
            // Status
            // 
            this.Status.AccessibleName = "Status";
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "In Progress",
            "On Hold",
            "Completed"});
            this.Status.Location = new System.Drawing.Point(376, 169);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(121, 21);
            this.Status.TabIndex = 30;
            // 
            // AssignTo
            // 
            this.AssignTo.AccessibleName = "AssignTo";
            this.AssignTo.FormattingEnabled = true;
            this.AssignTo.Location = new System.Drawing.Point(99, 216);
            this.AssignTo.Name = "AssignTo";
            this.AssignTo.Size = new System.Drawing.Size(121, 21);
            this.AssignTo.TabIndex = 31;
            this.AssignTo.SelectedIndexChanged += new System.EventHandler(this.AssignTo_SelectedIndexChanged);
            // 
            // Priority
            // 
            this.Priority.AccessibleName = "Priority";
            this.Priority.FormattingEnabled = true;
            this.Priority.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.Priority.Location = new System.Drawing.Point(376, 216);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(121, 21);
            this.Priority.TabIndex = 32;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(317, 79);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(42, 13);
            this.bunifuCustomLabel7.TabIndex = 33;
            this.bunifuCustomLabel7.Text = "TaskID";
            // 
            // TaskId
            // 
            this.TaskId.AccessibleName = "TaskId";
            this.TaskId.BorderColorFocused = System.Drawing.Color.Blue;
            this.TaskId.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TaskId.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TaskId.BorderThickness = 1;
            this.TaskId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TaskId.Enabled = false;
            this.TaskId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TaskId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TaskId.isPassword = false;
            this.TaskId.Location = new System.Drawing.Point(376, 69);
            this.TaskId.Margin = new System.Windows.Forms.Padding(4);
            this.TaskId.Name = "TaskId";
            this.TaskId.Size = new System.Drawing.Size(91, 23);
            this.TaskId.TabIndex = 34;
            this.TaskId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TaskManagementCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TaskId);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.Priority);
            this.Controls.Add(this.AssignTo);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.TaskDeadline);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.TMCTaskDescription);
            this.Controls.Add(this.TaskDesc);
            this.Name = "TaskManagementCreate";
            this.Size = new System.Drawing.Size(604, 349);
            this.Load += new System.EventHandler(this.TaskManagementCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox TaskDesc;
        private Bunifu.Framework.UI.BunifuCustomLabel TMCTaskDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.DateTimePicker TaskDeadline;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DateTimePicker StartDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.ComboBox AssignTo;
        private System.Windows.Forms.ComboBox Priority;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMetroTextbox TaskId;
    }
}
