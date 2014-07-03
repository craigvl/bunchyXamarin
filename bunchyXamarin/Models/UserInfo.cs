using System;
using Newtonsoft.Json;

namespace bunchyXamarin.Models
{
	public class UserInfo
	{
		[JsonProperty("Email")]
		public string AccessToken { get; set; }

		[JsonProperty("HasRegistered")]
		public bool HasRegistered { get; set; }

		[JsonProperty("LoginProvider")]
		public string LoginProvider { get; set; }

		[JsonProperty("LocationId")]
		public int LocationId { get; set; }
	}
}

