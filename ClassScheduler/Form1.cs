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
		public static String calendarTitle = "";

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
		private int assignClassStartDay(String day)
		{
			int firstDay = 0;

				if (day.Equals("Mo"))
				{
					Console.Write(startOfSemester.DayOfWeek);
					if (startOfSemester.DayOfWeek == DayOfWeek.Monday)
					{
						firstDay = startOfSemester.Day;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Tuesday)
					{
						firstDay = startOfSemester.Day + 6;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Wednesday)
					{
						firstDay = startOfSemester.Day + 5;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Thursday)
					{
						firstDay = startOfSemester.Day + 4;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Friday)
					{
						firstDay = startOfSemester.Day + 3;
					}
				} else if (day.Equals("Tu"))
				{
					if (startOfSemester.DayOfWeek == DayOfWeek.Monday)
					{
						firstDay = startOfSemester.Day  + 1;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Tuesday)
					{
						firstDay = startOfSemester.Day;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Wednesday)
					{
						firstDay = startOfSemester.Day + 6;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Thursday)
					{
						firstDay = startOfSemester.Day + 5;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Friday)
					{
						firstDay = startOfSemester.Day + 4;
					} 
				}
				else if (day.Equals("We"))
				{
					if (startOfSemester.DayOfWeek == DayOfWeek.Monday)
					{
						firstDay = startOfSemester.Day  + 2;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Tuesday)
					{
						firstDay = startOfSemester.Day + 1;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Wednesday)
					{
						firstDay = startOfSemester.Day;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Thursday)
					{
						firstDay = startOfSemester.Day + 5;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Friday)
					{
						firstDay = startOfSemester.Day + 4;
					}		
				}
				else if (day.Equals("Th"))
				{
					if (startOfSemester.DayOfWeek == DayOfWeek.Monday)
					{
						firstDay = startOfSemester.Day  + 3;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Tuesday)
					{
						firstDay = startOfSemester.Day + 2;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Wednesday)
					{
						firstDay = startOfSemester.Day + 1;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Thursday)
					{
						firstDay = startOfSemester.Day;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Friday)
					{
						firstDay = startOfSemester.Day + 6;
					}		
				}
				else if (day.Equals("Fri"))
				{
					if (startOfSemester.DayOfWeek == DayOfWeek.Monday)
					{
						firstDay = startOfSemester.Day + 4;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Tuesday)
					{
						firstDay = startOfSemester.Day + 3;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Wednesday)
					{
						firstDay = startOfSemester.Day + 2;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Thursday)
					{
						firstDay = startOfSemester.Day + 1;
					}
					else if (startOfSemester.DayOfWeek == DayOfWeek.Friday)
					{
						firstDay = startOfSemester.Day;
					}		
				}
				Console.WriteLine("First Day: " + firstDay);
			return firstDay;
		}

		// TODO: dynamically generate study time based on credit hours of each class
		private void generateBtn_Click(object sender, EventArgs e)
		{
			timeSlots.Clear();

			String report = "";
			foreach (ClassGroupBox g in groupBoxList)
			{
				firstDayOfClass = assignClassStartDay(g.getDays());

				// TODO: calculate day(s) of week
				// DTSTART and DTEND must be same day
				String recursionString = "DTSTART;VALUE=DATE:" + startOfSemester.Year
				    + startOfSemester.Month.ToString("00") + firstDayOfClass.ToString()
					+ "T" + g.getStartHour() + g.getStartMin()
					+ "00" + "\r\nDTEND;VALUE=DATE:" + startOfSemester.Year 
				    + startOfSemester.Month.ToString("00") + startOfSemester.Day.ToString("00") 
				    + "T" + g.getEndHour() + g.getEndMin() + "00" 
				    + "\r\n" + "RRULE:FREQ=WEEKLY;BYDAY=" + g.getDays() + ";UNTIL=" 
				    + endOfSemester.Year + endOfSemester.Month.ToString("00") 
				    + endOfSemester.Day.ToString("00") + "\r\n";

				Recurrence recurrence = new Recurrence();
				recurrence.Value = recursionString;

				CalendarService service = new CalendarService("ggco-purdueScheduler-0.01");
				Uri postUri = new Uri("https://www.google.com/calendar/feeds/s1nnpqt9ido2trquh6itlftvas%40group.calendar.google.com/private/full");
				service.setUserCredentials("EMAIL", "PASSWORD");
	
				EventEntry calendarEntry = new EventEntry();
				calendarEntry.Recurrence = recurrence;

				report += buildDayReport(g);

				Console.Out.WriteLine(calendarEntry.Recurrence.Value);
				AtomEntry insertedEntry = service.Insert(postUri, calendarEntry);

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

		private String buildDayReport(ClassGroupBox classGroupBox)
		{
			String report = classGroupBox.getCourseName() + " " + classGroupBox.getCreditHours() + " \n" 
				+ classGroupBox.getStartHour() + ":"  + classGroupBox.getStartMin() + " - " + classGroupBox.getEndHour() 
				+ ":" + classGroupBox.getEndMin() + "\n\n";
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