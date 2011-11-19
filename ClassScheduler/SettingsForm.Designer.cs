namespace ClassScheduler
{
	partial class SettingsForm
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
			this.userTxt = new System.Windows.Forms.TextBox();
			this.passTxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.endSemesterPicker = new System.Windows.Forms.DateTimePicker();
			this.startSemesterPicker = new System.Windows.Forms.DateTimePicker();
			this.applyBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.calendarUrlTxt = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// userTxt
			// 
			this.userTxt.Location = new System.Drawing.Point(73, 19);
			this.userTxt.Name = "userTxt";
			this.userTxt.Size = new System.Drawing.Size(100, 20);
			this.userTxt.TabIndex = 1;
			// 
			// passTxt
			// 
			this.passTxt.Location = new System.Drawing.Point(73, 43);
			this.passTxt.Name = "passTxt";
			this.passTxt.PasswordChar = '*';
			this.passTxt.Size = new System.Drawing.Size(100, 20);
			this.passTxt.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Username:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Password:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.userTxt);
			this.groupBox1.Controls.Add(this.passTxt);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(13, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(199, 80);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Login Credentials";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.endSemesterPicker);
			this.groupBox2.Controls.Add(this.startSemesterPicker);
			this.groupBox2.Location = new System.Drawing.Point(230, 16);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(261, 80);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Semester Range";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "End:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Start:";
			// 
			// endSemesterPicker
			// 
			this.endSemesterPicker.Location = new System.Drawing.Point(49, 43);
			this.endSemesterPicker.Name = "endSemesterPicker";
			this.endSemesterPicker.Size = new System.Drawing.Size(200, 20);
			this.endSemesterPicker.TabIndex = 1;
			// 
			// startSemesterPicker
			// 
			this.startSemesterPicker.Location = new System.Drawing.Point(49, 19);
			this.startSemesterPicker.Name = "startSemesterPicker";
			this.startSemesterPicker.Size = new System.Drawing.Size(200, 20);
			this.startSemesterPicker.TabIndex = 0;
			// 
			// applyBtn
			// 
			this.applyBtn.Location = new System.Drawing.Point(335, 127);
			this.applyBtn.Name = "applyBtn";
			this.applyBtn.Size = new System.Drawing.Size(75, 23);
			this.applyBtn.TabIndex = 8;
			this.applyBtn.Text = "Apply";
			this.applyBtn.UseVisualStyleBackColor = true;
			this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(416, 127);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 9;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.calendarUrlTxt);
			this.groupBox3.Location = new System.Drawing.Point(13, 103);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(316, 47);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Calendar Information";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Calendar ID:";
			// 
			// calendarUrlTxt
			// 
			this.calendarUrlTxt.Location = new System.Drawing.Point(86, 19);
			this.calendarUrlTxt.Name = "calendarUrlTxt";
			this.calendarUrlTxt.Size = new System.Drawing.Size(224, 20);
			this.calendarUrlTxt.TabIndex = 0;
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 162);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.applyBtn);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(520, 200);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(520, 200);
			this.Name = "SettingsForm";
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox userTxt;
		private System.Windows.Forms.TextBox passTxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker endSemesterPicker;
		private System.Windows.Forms.DateTimePicker startSemesterPicker;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button applyBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox calendarUrlTxt;
	}
}