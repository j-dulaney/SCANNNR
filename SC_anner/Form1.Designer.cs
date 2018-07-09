namespace SC_anner
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
            this.btnRun = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.lblRKill = new System.Windows.Forms.Label();
            this.cbRKill = new System.Windows.Forms.CheckBox();
            this.lblMbam = new System.Windows.Forms.Label();
            this.cbMbam = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(334, 265);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(482, 265);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblRKill);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cbRKill);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblMbam);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cbMbam);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(285, 221);
            this.toolStripContainer1.Location = new System.Drawing.Point(13, 13);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(285, 246);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // lblRKill
            // 
            this.lblRKill.AutoSize = true;
            this.lblRKill.Location = new System.Drawing.Point(66, 35);
            this.lblRKill.Name = "lblRKill";
            this.lblRKill.Size = new System.Drawing.Size(28, 13);
            this.lblRKill.TabIndex = 4;
            this.lblRKill.Text = "RKill";
            // 
            // cbRKill
            // 
            this.cbRKill.AutoSize = true;
            this.cbRKill.Location = new System.Drawing.Point(24, 34);
            this.cbRKill.Name = "cbRKill";
            this.cbRKill.Size = new System.Drawing.Size(15, 14);
            this.cbRKill.TabIndex = 3;
            this.cbRKill.UseVisualStyleBackColor = true;
            // 
            // lblMbam
            // 
            this.lblMbam.AutoSize = true;
            this.lblMbam.Location = new System.Drawing.Point(66, 14);
            this.lblMbam.Name = "lblMbam";
            this.lblMbam.Size = new System.Drawing.Size(120, 13);
            this.lblMbam.TabIndex = 2;
            this.lblMbam.Text = "MalwareBytes Full Scan";
            // 
            // cbMbam
            // 
            this.cbMbam.AutoSize = true;
            this.cbMbam.Location = new System.Drawing.Point(24, 14);
            this.cbMbam.Name = "cbMbam";
            this.cbMbam.Size = new System.Drawing.Size(15, 14);
            this.cbMbam.TabIndex = 1;
            this.cbMbam.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Location = new System.Drawing.Point(4, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(539, 212);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(100, 20);
            this.tbOutput.TabIndex = 4;
            this.tbOutput.Text = "path";
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.AutoSize = true;
            this.lblOutputPath.Location = new System.Drawing.Point(334, 215);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(88, 13);
            this.lblOutputPath.TabIndex = 5;
            this.lblOutputPath.Text = "Save Report to : ";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(517, 213);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(16, 16);
            this.btnSelectPath.TabIndex = 6;
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 300);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.lblOutputPath);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRun);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "fixer";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label lblMbam;
        private System.Windows.Forms.CheckBox cbMbam;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblRKill;
        private System.Windows.Forms.CheckBox cbRKill;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label lblOutputPath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

