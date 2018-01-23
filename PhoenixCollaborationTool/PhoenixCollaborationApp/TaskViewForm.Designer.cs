namespace PhoenixCollaborationApp
{
    partial class TaskViewForm
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
            this.TMGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TMGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TMGridView1
            // 
            this.TMGridView1.AccessibleName = "TMGridView1";
            this.TMGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TMGridView1.Location = new System.Drawing.Point(21, 18);
            this.TMGridView1.Name = "TMGridView1";
            this.TMGridView1.Size = new System.Drawing.Size(450, 238);
            this.TMGridView1.TabIndex = 0;
            this.TMGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TMGridView1_CellContentClick);
            // 
            // ViewBack
            // 
            this.ViewBack.AccessibleName = "ViewBack";
            this.ViewBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ViewBack.Location = new System.Drawing.Point(210, 262);
            this.ViewBack.Name = "ViewBack";
            this.ViewBack.Size = new System.Drawing.Size(75, 23);
            this.ViewBack.TabIndex = 18;
            this.ViewBack.Text = "Back";
            this.ViewBack.UseVisualStyleBackColor = false;
            // 
            // TaskViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewBack);
            this.Controls.Add(this.TMGridView1);
            this.Name = "TaskViewForm";
            this.Size = new System.Drawing.Size(508, 321);
            ((System.ComponentModel.ISupportInitialize)(this.TMGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TMGridView1;
        private System.Windows.Forms.Button ViewBack;
    }
}
