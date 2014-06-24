using System;
using Newtonsoft.Json;

namespace bunchyXamarin.Models
{
	public class BunchListModel
	{
		[JsonProperty("Name")]
		public string Name { get; set; }
		[JsonProperty("KeenCount")]
		public string KeenCount { get; set;}
		[JsonProperty("NextRideId")]
		public int NextRideId { get; set;}
	}
}

