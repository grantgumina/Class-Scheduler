using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassScheduler
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void SettingsForm_Load(object sender, EventArgs e)
		{
		}

		private void applyBtn_Click(object sender, EventArgs e)
		{
			Form1.username = userTxt.Text;
			Form1.password = passTxt.Text;
			Form1.startOfSemester = startSemesterPicker.Value;
			Form1.endOfSemester = endSemesterPicker.Value;
			Form1.calendarTitle = calendarNameTxt.Text;

			this.Close();
		}
	}
}
