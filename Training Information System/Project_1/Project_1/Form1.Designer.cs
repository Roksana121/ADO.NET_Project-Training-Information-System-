
namespace Project_1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainerInsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainerInsertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trainerEditDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectWiseTrainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Project_1.Properties.Resources.background4;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.subjectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(717, 32);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pageToolStripMenuItem
            // 
            this.pageToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainerInsertToolStripMenuItem,
            this.trainerInsertToolStripMenuItem1,
            this.trainerEditDeleteToolStripMenuItem});
            this.pageToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            this.pageToolStripMenuItem.Size = new System.Drawing.Size(77, 30);
            this.pageToolStripMenuItem.Text = "Page";
            // 
            // trainerInsertToolStripMenuItem
            // 
            this.trainerInsertToolStripMenuItem.Name = "trainerInsertToolStripMenuItem";
            this.trainerInsertToolStripMenuItem.Size = new System.Drawing.Size(269, 30);
            this.trainerInsertToolStripMenuItem.Text = "Trainer View";
            this.trainerInsertToolStripMenuItem.Click += new System.EventHandler(this.trainerInsertToolStripMenuItem_Click);
            // 
            // trainerInsertToolStripMenuItem1
            // 
            this.trainerInsertToolStripMenuItem1.Name = "trainerInsertToolStripMenuItem1";
            this.trainerInsertToolStripMenuItem1.Size = new System.Drawing.Size(269, 30);
            this.trainerInsertToolStripMenuItem1.Text = "Trainer Insert";
            this.trainerInsertToolStripMenuItem1.Click += new System.EventHandler(this.trainerInsertToolStripMenuItem1_Click);
            // 
            // trainerEditDeleteToolStripMenuItem
            // 
            this.trainerEditDeleteToolStripMenuItem.Name = "trainerEditDeleteToolStripMenuItem";
            this.trainerEditDeleteToolStripMenuItem.Size = new System.Drawing.Size(269, 30);
            this.trainerEditDeleteToolStripMenuItem.Text = "Trainer Edit/Delete";
            this.trainerEditDeleteToolStripMenuItem.Click += new System.EventHandler(this.trainerEditDeleteToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainerInfoToolStripMenuItem,
            this.subjectWiseTrainerToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.reportsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(98, 30);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // trainerInfoToolStripMenuItem
            // 
            this.trainerInfoToolStripMenuItem.Name = "trainerInfoToolStripMenuItem";
            this.trainerInfoToolStripMenuItem.Size = new System.Drawing.Size(389, 30);
            this.trainerInfoToolStripMenuItem.Text = "Trainer Information";
            this.trainerInfoToolStripMenuItem.Click += new System.EventHandler(this.trainerInfoToolStripMenuItem_Click);
            // 
            // subjectWiseTrainerToolStripMenuItem
            // 
            this.subjectWiseTrainerToolStripMenuItem.Name = "subjectWiseTrainerToolStripMenuItem";
            this.subjectWiseTrainerToolStripMenuItem.Size = new System.Drawing.Size(389, 30);
            this.subjectWiseTrainerToolStripMenuItem.Text = "SubjectWiseTrainerInformation";
            this.subjectWiseTrainerToolStripMenuItem.Click += new System.EventHandler(this.subjectWiseTrainerToolStripMenuItem_Click);
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.subjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSubjectToolStripMenuItem});
            this.subjectToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(104, 30);
            this.subjectToolStripMenuItem.Text = "Subject";
            // 
            // addNewSubjectToolStripMenuItem
            // 
            this.addNewSubjectToolStripMenuItem.Name = "addNewSubjectToolStripMenuItem";
            this.addNewSubjectToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.addNewSubjectToolStripMenuItem.Text = "Add New Subject";
            this.addNewSubjectToolStripMenuItem.Click += new System.EventHandler(this.addNewSubjectToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_1.Properties.Resources.background4;
            this.ClientSize = new System.Drawing.Size(717, 417);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainerInsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainerInsertToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trainerEditDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectWiseTrainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSubjectToolStripMenuItem;
    }
}

