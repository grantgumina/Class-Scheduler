﻿namespace ClassScheduler
{
    partial class ClassGroupBox
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
			this.endHrCmb = new System.Windows.Forms.ComboBox();
			this.startHrCmb = new System.Windows.Forms.ComboBox();
			this.startMinCmb = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.endMinCmb = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.creditHrsTxt = new System.Windows.Forms.TextBox();
			this.moCkBx = new System.Windows.Forms.CheckBox();
			this.tuCkBx = new System.Windows.Forms.CheckBox();
			this.weCkBx = new System.Windows.Forms.CheckBox();
			this.thCkBx = new System.Windows.Forms.CheckBox();
			this.friCkBx = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.courseNameTxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// endHrCmb
			// 
			this.endHrCmb.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
			this.endHrCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.endHrCmb.FormattingEnabled = true;
			this.endHrCmb.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
			this.endHrCmb.Location = new System.Drawing.Point(129, 31);
			this.endHrCmb.Name = "endHrCmb";
			this.endHrCmb.Size = new System.Drawing.Size(40, 21);
			this.endHrCmb.TabIndex = 3;
			this.endHrCmb.SelectedIndexChanged += new System.EventHandler(this.endHrCmb_SelectedIndexChanged);
			// 
			// startHrCmb
			// 
			this.startHrCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.startHrCmb.FormattingEnabled = true;
			this.startHrCmb.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
			this.startHrCmb.Location = new System.Drawing.Point(12, 31);
			this.startHrCmb.Name = "startHrCmb";
			this.startHrCmb.Size = new System.Drawing.Size(40, 21);
			this.startHrCmb.TabIndex = 0;
			this.startHrCmb.SelectedValueChanged += new System.EventHandler(this.startHrCmb_SelectedValueChanged);
			// 
			// startMinCmb
			// 
			this.startMinCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.startMinCmb.FormattingEnabled = true;
			this.startMinCmb.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
			this.startMinCmb.Location = new System.Drawing.Point(58, 31);
			this.startMinCmb.Name = "startMinCmb";
			this.startMinCmb.Size = new System.Drawing.Size(40, 21);
			this.startMinCmb.TabIndex = 1;
			this.startMinCmb.SelectedIndexChanged += new System.EventHandler(this.startMinCmb_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(107, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "to";
			// 
			// endMinCmb
			// 
			this.endMinCmb.AutoCompleteCustomSource.AddRange(new string[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
			this.endMinCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.endMinCmb.FormattingEnabled = true;
			this.endMinCmb.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
			this.endMinCmb.Location = new System.Drawing.Point(175, 31);
			this.endMinCmb.Name = "endMinCmb";
			this.endMinCmb.Size = new System.Drawing.Size(40, 21);
			this.endMinCmb.TabIndex = 4;
			this.endMinCmb.SelectedIndexChanged += new System.EventHandler(this.endMinCmb_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(118, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Credit Hours:";
			// 
			// creditHrsTxt
			// 
			this.creditHrsTxt.Location = new System.Drawing.Point(186, 5);
			this.creditHrsTxt.Name = "creditHrsTxt";
			this.creditHrsTxt.Size = new System.Drawing.Size(29, 20);
			this.creditHrsTxt.TabIndex = 6;
			this.creditHrsTxt.TextChanged += new System.EventHandler(this.creditHrsTxt_TextChanged);
			// 
			// moCkBx
			// 
			this.moCkBx.AutoSize = true;
			this.moCkBx.Location = new System.Drawing.Point(5, 68);
			this.moCkBx.Name = "moCkBx";
			this.moCkBx.Size = new System.Drawing.Size(41, 17);
			this.moCkBx.TabIndex = 7;
			this.moCkBx.Text = "Mo";
			this.moCkBx.UseVisualStyleBackColor = true;
			this.moCkBx.CheckedChanged += new System.EventHandler(this.moCkBx_CheckedChanged);
			// 
			// tuCkBx
			// 
			this.tuCkBx.AutoSize = true;
			this.tuCkBx.Location = new System.Drawing.Point(49, 68);
			this.tuCkBx.Name = "tuCkBx";
			this.tuCkBx.Size = new System.Drawing.Size(39, 17);
			this.tuCkBx.TabIndex = 8;
			this.tuCkBx.Text = "Tu";
			this.tuCkBx.UseVisualStyleBackColor = true;
			this.tuCkBx.CheckedChanged += new System.EventHandler(this.tuCkBx_CheckedChanged);
			// 
			// weCkBx
			// 
			this.weCkBx.AutoSize = true;
			this.weCkBx.Location = new System.Drawing.Point(96, 68);
			this.weCkBx.Name = "weCkBx";
			this.weCkBx.Size = new System.Drawing.Size(43, 17);
			this.weCkBx.TabIndex = 9;
			this.weCkBx.Text = "We";
			this.weCkBx.UseVisualStyleBackColor = true;
			this.weCkBx.CheckedChanged += new System.EventHandler(this.weCkBx_CheckedChanged);
			// 
			// thCkBx
			// 
			this.thCkBx.AutoSize = true;
			this.thCkBx.Location = new System.Drawing.Point(141, 68);
			this.thCkBx.Name = "thCkBx";
			this.thCkBx.Size = new System.Drawing.Size(39, 17);
			this.thCkBx.TabIndex = 10;
			this.thCkBx.Text = "Th";
			this.thCkBx.UseVisualStyleBackColor = true;
			this.thCkBx.CheckedChanged += new System.EventHandler(this.thCkBx_CheckedChanged);
			// 
			// friCkBx
			// 
			this.friCkBx.AutoSize = true;
			this.friCkBx.Location = new System.Drawing.Point(182, 68);
			this.friCkBx.Name = "friCkBx";
			this.friCkBx.Size = new System.Drawing.Size(37, 17);
			this.friCkBx.TabIndex = 11;
			this.friCkBx.Text = "Fri";
			this.friCkBx.UseVisualStyleBackColor = true;
			this.friCkBx.CheckedChanged += new System.EventHandler(this.friCkBx_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Name:";
			// 
			// courseNameTxt
			// 
			this.courseNameTxt.Location = new System.Drawing.Point(53, 5);
			this.courseNameTxt.Name = "courseNameTxt";
			this.courseNameTxt.Size = new System.Drawing.Size(59, 20);
			this.courseNameTxt.TabIndex = 13;
			this.courseNameTxt.TextChanged += new System.EventHandler(this.courseNameTxt_TextChanged);
			// 
			// ClassGroupBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.courseNameTxt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.friCkBx);
			this.Controls.Add(this.endHrCmb);
			this.Controls.Add(this.thCkBx);
			this.Controls.Add(this.startHrCmb);
			this.Controls.Add(this.weCkBx);
			this.Controls.Add(this.startMinCmb);
			this.Controls.Add(this.tuCkBx);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.moCkBx);
			this.Controls.Add(this.endMinCmb);
			this.Controls.Add(this.creditHrsTxt);
			this.Controls.Add(this.label2);
			this.Name = "ClassGroupBox";
			this.Size = new System.Drawing.Size(223, 93);
			this.Load += new System.EventHandler(this.ClassGroupBox_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox endHrCmb;
        private System.Windows.Forms.ComboBox startHrCmb;
        private System.Windows.Forms.ComboBox startMinCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox endMinCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox creditHrsTxt;
        private System.Windows.Forms.CheckBox moCkBx;
        private System.Windows.Forms.CheckBox tuCkBx;
        private System.Windows.Forms.CheckBox weCkBx;
        private System.Windows.Forms.CheckBox thCkBx;
        private System.Windows.Forms.CheckBox friCkBx;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox courseNameTxt;
    }
}