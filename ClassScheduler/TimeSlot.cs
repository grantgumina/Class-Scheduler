using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassScheduler
{
	class TimeSlot
	{
		private DateTime start;
		private DateTime end;

		public TimeSlot()
		{
		}

		public TimeSlot(DateTime s, DateTime e)
		{
			this.start = s;
			this.end = e;
		}

		public DateTime getStartTime()
		{
			return start;
		}

		public DateTime getEndTime()
		{
			return end;
		}
	}
}
