namespace ClassScheduler
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
			this.generateBtn = new System.Windows.Forms.Button();
			this.reportRichTxt = new System.Windows.Forms.RichTextBox();
			this.noClassTxt = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.redrawBtn = new System.Windows.Forms.Button();
			this.myClassPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.resultLbl = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// generateBtn
			// 
			this.generateBtn.Location = new System.Drawing.Point(12, 566);
			this.generateBtn.Name = "generateBtn";
			this.generateBtn.Size = new System.Drawing.Size(260, 29);
			this.generateBtn.TabIndex = 3;
			this.generateBtn.Text = "Generate and Upload";
			this.generateBtn.UseVisualStyleBackColor = true;
			this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
			// 
			// reportRichTxt
			// 
			this.reportRichTxt.Location = new System.Drawing.Point(278, 55);
			this.reportRichTxt.Name = "reportRichTxt";
			this.reportRichTxt.ReadOnly = true;
			this.reportRichTxt.Size = new System.Drawing.Size(267, 470);
			this.reportRichTxt.TabIndex = 4;
			this.reportRichTxt.Text = "";
			// 
			// noClassTxt
			// 
			this.noClassTxt.Location = new System.Drawing.Point(109, 28);
			this.noClassTxt.Name = "noClassTxt";
			this.noClassTxt.Size = new System.Drawing.Size(23, 20);
			this.noClassTxt.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Number of Classes: ";
			// 
			// redrawBtn
			// 
			this.redrawBtn.Location = new System.Drawing.Point(139, 26);
			this.redrawBtn.Name = "redrawBtn";
			this.redrawBtn.Size = new System.Drawing.Size(57, 23);
			this.redrawBtn.TabIndex = 10;
			this.redrawBtn.Text = "Redraw";
			this.redrawBtn.UseVisualStyleBackColor = true;
			this.redrawBtn.Click += new System.EventHandler(this.redrawBtn_Click);
			// 
			// myClassPanel
			// 
			this.myClassPanel.AutoScroll = true;
			this.myClassPanel.Location = new System.Drawing.Point(12, 55);
			this.myClassPanel.Name = "myClassPanel";
			this.myClassPanel.Size = new System.Drawing.Size(260, 505);
			this.myClassPanel.TabIndex = 11;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(558, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(275, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Text Output:";
			// 
			// resultLbl
			// 
			this.resultLbl.AutoSize = true;
			this.resultLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.resultLbl.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultLbl.Location = new System.Drawing.Point(314, 551);
			this.resultLbl.Name = "resultLbl";
			this.resultLbl.Size = new System.Drawing.Size(227, 34);
			this.resultLbl.TabIndex = 15;
			this.resultLbl.Text = "--------------";
			this.resultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(558, 607);
			this.Controls.Add(this.resultLbl);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.myClassPanel);
			this.Controls.Add(this.redrawBtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.noClassTxt);
			this.Controls.Add(this.reportRichTxt);
			this.Controls.Add(this.generateBtn);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(574, 645);
			this.MinimumSize = new System.Drawing.Size(574, 645);
			this.Name = "Form1";
			this.Text = "Google Calendar Class Syncer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Button generateBtn;
		private System.Windows.Forms.RichTextBox reportRichTxt;
        private System.Windows.Forms.TextBox noClassTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button redrawBtn;
        private System.Windows.Forms.FlowLayoutPanel myClassPanel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label resultLbl;
    }
}

