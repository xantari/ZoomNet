using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace ZoomNet.Models
{
	/// <summary>
	/// Enumeration to indicate the type of phone number.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum UserPhoneType
	{
		/// <summary>Mobile.</summary>
		[EnumMember(Value = "Mobile")]
		Mobile,

		/// <summary>Office.</summary>
		[EnumMember(Value = "Office")]
		Office,

		/// <summary>Home.</summary>
		[EnumMember(Value = "Home")]
		Home,

		/// <summary>Fax.</summary>
		[EnumMember(Value = "Fax")]
		Fax,
	}
}
