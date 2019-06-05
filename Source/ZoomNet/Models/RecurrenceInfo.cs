using Newtonsoft.Json;
using System;

namespace ZoomNet.Models
{
	/// <summary>
	/// Recurrence.
	/// </summary>
	public class RecurrenceInfo
	{
		/// <summary>
		/// Gets or sets the recurrence type.
		/// </summary>
		[JsonProperty(PropertyName = "type")]
		public int? Type { get; set; }

		/// <summary>
		/// Gets or sets the interval should the meeting repeat.
		/// For a daily meeting, max of 90 days.
		/// For a weekly meeting, max of 12 weeks.
		/// For a monthly meeting, max of 3 months.
		/// </summary>
		[JsonProperty(PropertyName = "repeat_interval")]
		public int? RepeatInterval { get; set; }

		/// <summary>
		/// Gets or sets the days of the week the meeting should repeat, multiple values separated by comma.
		/// </summary>
		[JsonProperty(PropertyName = "weekly_days")]
		public int? WeeklyDays { get; set; }

		/// <summary>
		/// Gets or sets the day of the month for the meeting to be scheduled.
		/// The value range is from 1 to 31.
		/// </summary>
		[JsonProperty(PropertyName = "monthly_day")]
		public int? MonthlyDay { get; set; }

		/// <summary>
		/// Gets or sets the week for which the meeting should recur each month.
		/// </summary>
		[JsonProperty(PropertyName = "monthly_week")]
		public int? MonthlyWeek { get; set; }

		/// <summary>
		/// Gets or sets the day for which the meeting should recur each month.
		/// </summary>
		[JsonProperty(PropertyName = "monthly_week_day")]
		public int? MonthlyWeekDay { get; set; }

		/// <summary>
		/// Gets or sets the select how many times the meeting will occur before it is canceled.
		/// Cannot be used with "end_date_time".
		/// </summary>
		[JsonProperty(PropertyName = "end_times")]
		public int? EndTimes { get; set; }

		/// <summary>
		/// Gets or sets the date the meeting will canceled.
		/// Cannot be used with "end_times".
		/// </summary>
		[JsonProperty(PropertyName = "end_date_time")]
		public DateTime? EndDateTime { get; set; }
	}
}
