using Newtonsoft.Json;

namespace ZoomNet.Models
{
	/// <summary>
	/// Information about a live stream.
	/// </summary>
	public class LiveStreamingInfo
	{
		/// <summary>
		/// Gets or sets the name of the live streaming service.
		/// </summary>
		[JsonProperty(PropertyName = "service")]
		public string ServiceName { get; set; }

		/// <summary>
		/// Gets or sets the meeting id, also known as the meeting number.
		/// </summary>
		[JsonProperty(PropertyName = "custom_live_streaming_settings")]
		public LiveStreamingSettings Settings { get; set; }
	}
}
