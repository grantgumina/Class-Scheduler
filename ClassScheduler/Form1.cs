using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Google.GData.Calendar;
using Google.GData.Client;
using Google.GData.Extensions;

namespace ClassScheduler
{
	public partial class Form1 : Form
	{
		public static String username = "";
		public static String password = "";
		public static String calendarUrl = "";

		public static DateTime startOfSemester;
		public static DateTime endOfSemester;
		public static int firstDayOfClass;

		public Form1()
		{
			InitializeComponent();
		}

		int noOfClass = 1;

		List<ClassGroupBox> groupBoxList = new List<ClassGroupBox>();
		List<TimeSlot> timeSlots = new List<TimeSlot>();

		private void Form1_Load(object sender, EventArgs e)
		{
			startOfSemester = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
					DateTime.Now.Day, 0, 0, 0);
			endOfSemester = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
					DateTime.Now.Day, 0, 0, 0);

			ClassGroupBox classOne = new ClassGroupBox();
			groupBoxList.Add(classOne);
			myClassPanel.Controls.Add(groupBoxList[0]);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// worst code I've ever written in my life is below. Too tired to write creative algorithm....
		private int assignClassStartDay(String day, DateTime semesterStart)
		{
			DateTime d = new DateTime();
			if (day.Equals("Mo"))
			{
				d = new DateTime(2011, 11, 7, 00, 00, 00, 00);
			}
			else if (day.Equals("Tu"))
			{
				d = new DateTime(2011, 11, 8, 00, 00, 00, 00);
			}
			else if (day.Equals("We"))
			{
				d = new DateTime(2011, 11, 9, 00, 00, 00, 00);
			}
			else if (day.Equals("Th"))
			{
				d = new DateTime(2011, 11, 10, 00, 00, 00, 00);
			}
			else if (day.Equals("Fr"))
			{
				d = new DateTime(2011, 11, 11, 00, 00, 00, 00);
			}

			TimeSpan t = semesterStart - d;
			double diff = Math.Floor(t.TotalDays) % 7;
			int daysUntil = Convert.ToInt32(7 - diff); // days from start of semester that first class occurs

			return semesterStart.Day + daysUntil;
		}

		// TODO: dynamically generate study time based on credit hours of each class
		private void generateBtn_Click(object sender, EventArgs e)
		{
			timeSlots.Clear();

			String report = "";

			if (username == "" || password == "" || calendarUrl == "")
			{
				MessageBox.Show("Please add Google login and password information.");
			} 
			else 
			{
				foreach (ClassGroupBox g in groupBoxList)
				{
					firstDayOfClass = assignClassStartDay(g.getDays()[0], startOfSemester);

					String recursionString = "DTSTART;TZID=US/Eastern:" + startOfSemester.Year
						+ startOfSemester.Month.ToString("00") + firstDayOfClass.ToString()
						+ "T" + g.getStartHour() + g.getStartMin()
						+ "00" + "\r\nDTEND;TZID=US/Eastern:" + startOfSemester.Year
						+ startOfSemester.Month.ToString("00") + startOfSemester.Day.ToString("00")
						+ "T" + g.getEndHour() + g.getEndMin() + "00"
						+ "\r\n" + "RRULE:FREQ=WEEKLY;BYDAY=" + buildDayString(g.getDays()) + ";UNTIL="
						+ endOfSemester.Year + endOfSemester.Month.ToString("00")
						+ endOfSemester.Day.ToString("00") + "\r\n";

					Recurrence recurrence = new Recurrence();
					recurrence.Value = recursionString;
					Console.Out.WriteLine(recursionString);

					CalendarService service = new CalendarService("ggco-purdueScheduler-0.01");
					Uri postUri = new Uri("https://www.google.com/calendar/feeds/" + calendarUrl + "/private/full");

					service.setUserCredentials(username, password);
					EventEntry calendarEntry = new EventEntry();
					calendarEntry.Title.Text = g.getCourseName();
					calendarEntry.Recurrence = recurrence;

					report += buildDayReport(g);

					try
					{
						AtomEntry insertedEntry = service.Insert(postUri, calendarEntry);
						resultLbl.Text = "SUCCESS";
						resultLbl.ForeColor = Color.White;
						resultLbl.BackColor = Color.Green;
					}
					catch
					{
						resultLbl.Text = "FAILURE";
						resultLbl.ForeColor = Color.White;
						resultLbl.BackColor = Color.Red;
					}

					//// BASELINE - used to ensure no overlap in a given day
					//DateTime start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 
					//    DateTime.Now.Day, int.Parse(g.getStartHour()), int.Parse(g.getStartMin()), 0);
					//DateTime end = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 
					//    DateTime.Now.Day, int.Parse(g.getEndHour()), int.Parse(g.getEndMin()), 0);

					//if (groupBoxList.Count == 0)
					//{
					//    timeSlots.Add(new TimeSlot(start, end));
					//}
					//else
					//{
					//    foreach (TimeSlot t in timeSlots)
					//    {
					//        if (start <= t.getStartTime() && end > t.getStartTime())
					//        {
					//            MessageBox.Show("Classes overlap - one ends after another starts.");
					//        }
					//        else if (start >= t.getStartTime() && start < t.getEndTime())
					//        {
					//            MessageBox.Show("Classes overlap - one starts before another ends.");
					//        }
					//        else
					//        {
					//            MessageBox.Show("No errors");
					//        }
					//    }
					//    timeSlots.Add(new TimeSlot(start, end));
					//}
				}
			}
			reportRichTxt.Text = report;
		}

		private void redrawBtn_Click(object sender, EventArgs e)
		{
			int[][] classData = { };
			if (noClassTxt.Text == "")
			{
				MessageBox.Show("Please enter a number of classes");
			}
			else
			{
				noOfClass = int.Parse(noClassTxt.Text);

				myClassPanel.Controls.Clear();
				groupBoxList.Clear();

				// TODO: save/store values when adding a class
				for (int i = 0; i < noOfClass; i++)
				{
					ClassGroupBox tempBox = new ClassGroupBox();
					groupBoxList.Add(tempBox);
					myClassPanel.Controls.Add(groupBoxList[i]);
				}

				myClassPanel.Refresh();
			}

		}

		private String[] findDays(Boolean[] dayArray)
		{
			String[] days = new String[4];
			for (int i = 0; i <= dayArray.Length; i++)
			{
				if (dayArray[0])
				{
					days[i] = "Monday";
				}
				else if (dayArray[1])
				{
					days[i] = "Tuesday";
				}
				else if (dayArray[2])
				{
					days[i] = "Wednesday";
				}
				else if (dayArray[3])
				{
					days[i] = "Thursday";
				}
				else if (dayArray[4])
				{
					days[i] = "Friday";
				}
			}
			return days;
		}

		private String buildDayString(List<String> days)
		{
			String dayString = "";
			foreach (String d in days)
			{
				if (days.Last() == d)
				{
					dayString += d;
				}
				else
				{
					dayString += d + ",";
				}
			}
			return dayString;
		}

		private String buildDayReport(ClassGroupBox classGroupBox)
		{
			String report = classGroupBox.getCourseName() + " \n" 
				+ classGroupBox.getStartHour() + ":"  + classGroupBox.getStartMin() + " - " + classGroupBox.getEndHour()
				+ ":" + classGroupBox.getEndMin() + "\n" + buildDayString(classGroupBox.getDays()) 
				+ "\n-----------------------\n\n";
			return report;
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SettingsForm settingsForm = new SettingsForm();
			settingsForm.Show();
		}

		private void uploadBtn_Click(object sender, EventArgs e)
		{
			foreach (TimeSlot slot in timeSlots)
			{
			}
		}

	}
}