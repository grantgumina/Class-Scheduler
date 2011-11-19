using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassScheduler
{
    public partial class ClassGroupBox : UserControl
    {
        public ClassGroupBox()
        {
            InitializeComponent();
        }

        private String startHour;
        private String startMin;

        private String endHour;
		private String endMin;

		private String courseName;
		private String recursionString;
		private double creditHours;

		private CheckBox[] boxes;

        private void ClassGroupBox_Load(object sender, EventArgs e)
        {
			boxes = new CheckBox[]{ moCkBx, tuCkBx, weCkBx, thCkBx, friCkBx };
        }

        // getters
		public String getStartHour()
        {
            return startHour;
        }

        public String getStartMin()
        {
            return startMin;
        }

        public String getEndHour()
        {
            return endHour;
        }

        public String getEndMin()
        {
            return endMin;
        }

		public List<String> getDays()
		{
			List<String> selectedDays = new List<String>();
			foreach (CheckBox b in boxes)
			{
				if (b.Checked)
				{
					selectedDays.Add(b.Text);
				}
			}
			return selectedDays;
		}

		public String getCourseName()
		{
			return courseName;
		}

		public double getCreditHours() 
		{
			return creditHours;
		}

		// events
        private void startHrCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            startHour = startHrCmb.Text;
        }

        private void startMinCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            startMin = startMinCmb.Text;
        }

        private void endHrCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            endHour = endHrCmb.Text;
        }

        private void endMinCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            endMin = endMinCmb.Text;
        }

		// checkboxes
		private void moCkBx_CheckedChanged(object sender, EventArgs e)
		{
			recursionString = "Mo";
		}

		private void tuCkBx_CheckedChanged(object sender, EventArgs e)
		{
			recursionString = "Tu";
		}

		private void weCkBx_CheckedChanged(object sender, EventArgs e)
		{
			recursionString = "We";
		}

		private void thCkBx_CheckedChanged(object sender, EventArgs e)
		{
			recursionString = "Th";
		}

		private void friCkBx_CheckedChanged(object sender, EventArgs e)
		{
			recursionString = "Fri";
		}

		// textboxes
		private void courseNameTxt_TextChanged(object sender, EventArgs e)
		{
			courseName = courseNameTxt.Text;
		}

		private void creditHrsTxt_TextChanged(object sender, EventArgs e)
		{
			creditHours = double.Parse(creditHrsTxt.Text);
		}
    }
}