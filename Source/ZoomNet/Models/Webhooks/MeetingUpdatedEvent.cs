using Newtonsoft.Json;

namespace ZoomNet.Models.Webhooks
{
	/// <summary>
	/// This event is triggered when a meeting is updated.
	/// </summary>
	public class MeetingUpdatedEvent : Event
	{
		/// <summary>
		/// Gets or sets the email address of the user who updated the meeting.
		/// </summary>
		[JsonProperty(PropertyName = "operator")]
		public string Operator { get; set; }

		/// <summary>
		/// Gets or sets the user ID of the operator who updated the meeting.
		/// </summary>
		[JsonProperty(PropertyName = "operator_id")]
		public string OperatorId { get; set; }

		/// <summary>
		/// Gets or sets the operation (allowed values: all, single).
		/// </summary>
		[JsonProperty(PropertyName = "operation")]
		public string Operation { get; set; }

		/// <summary>
		/// Gets or sets the fields that have been modified.
		/// </summary>
		public (string FieldName, object OldValue, object NewValue)[] ModifiedFields { get; set; }
	}
}
