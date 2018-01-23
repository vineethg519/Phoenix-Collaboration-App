namespace PhoenixCollaborationApp
{
	partial class TaskManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewTask = new Bunifu.Framework.UI.BunifuThinButton2();
            this.createTask = new Bunifu.Framework.UI.BunifuThinButton2();
            this.taskCreateViewPanel = new System.Windows.Forms.Panel();
            this.TMView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.taskCreateViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TMView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viewTask);
            this.panel1.Controls.Add(this.createTask);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 60);
            this.panel1.TabIndex = 0;
            // 
            // viewTask
            // 
            this.viewTask.ActiveBorderThickness = 1;
            this.viewTask.ActiveCornerRadius = 20;
            this.viewTask.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.viewTask.ActiveForecolor = System.Drawing.Color.White;
            this.viewTask.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.viewTask.BackColor = System.Drawing.SystemColors.Control;
            this.viewTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewTask.BackgroundImage")));
            this.viewTask.ButtonText = "Edit";
            this.viewTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTask.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTask.ForeColor = System.Drawing.Color.SeaGreen;
            this.viewTask.IdleBorderThickness = 1;
            this.viewTask.IdleCornerRadius = 20;
            this.viewTask.IdleFillColor = System.Drawing.Color.White;
            this.viewTask.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.viewTask.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.viewTask.Location = new System.Drawing.Point(275, 14);
            this.viewTask.Margin = new System.Windows.Forms.Padding(5);
            this.viewTask.Name = "viewTask";
            this.viewTask.Size = new System.Drawing.Size(263, 41);
            this.viewTask.TabIndex = 2;
            this.viewTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewTask.Click += new System.EventHandler(this.viewTask_Click);
            // 
            // createTask
            // 
            this.createTask.ActiveBorderThickness = 1;
            this.createTask.ActiveCornerRadius = 20;
            this.createTask.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.createTask.ActiveForecolor = System.Drawing.Color.White;
            this.createTask.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.createTask.BackColor = System.Drawing.SystemColors.Control;
            this.createTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createTask.BackgroundImage")));
            this.createTask.ButtonText = "Create";
            this.createTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTask.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTask.ForeColor = System.Drawing.Color.SeaGreen;
            this.createTask.IdleBorderThickness = 1;
            this.createTask.IdleCornerRadius = 20;
            this.createTask.IdleFillColor = System.Drawing.Color.White;
            this.createTask.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.createTask.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.createTask.Location = new System.Drawing.Point(5, 14);
            this.createTask.Margin = new System.Windows.Forms.Padding(5);
            this.createTask.Name = "createTask";
            this.createTask.Size = new System.Drawing.Size(263, 41);
            this.createTask.TabIndex = 1;
            this.createTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createTask.Click += new System.EventHandler(this.createTask_Click);
            // 
            // taskCreateViewPanel
            // 
            this.taskCreateViewPanel.AccessibleName = "taskCreateViewPanel";
            this.taskCreateViewPanel.Controls.Add(this.TMView);
            this.taskCreateViewPanel.Location = new System.Drawing.Point(3, 69);
            this.taskCreateViewPanel.Name = "taskCreateViewPanel";
            this.taskCreateViewPanel.Size = new System.Drawing.Size(588, 371);
            this.taskCreateViewPanel.TabIndex = 1;
            // 
            // TMView
            // 
            this.TMView.AccessibleName = "TMView";
            this.TMView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TMView.Location = new System.Drawing.Point(5, 19);
            this.TMView.Name = "TMView";
            this.TMView.Size = new System.Drawing.Size(566, 269);
            this.TMView.TabIndex = 0;
            // 
            // TaskManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.taskCreateViewPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskManagement";
            this.Size = new System.Drawing.Size(594, 443);
            this.Load += new System.EventHandler(this.TaskManagement_Load);
            this.panel1.ResumeLayout(false);
            this.taskCreateViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TMView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuThinButton2 createTask;
		private Bunifu.Framework.UI.BunifuThinButton2 viewTask;
        private System.Windows.Forms.Panel taskCreateViewPanel;
        private System.Windows.Forms.DataGridView TMView;
    }
}
