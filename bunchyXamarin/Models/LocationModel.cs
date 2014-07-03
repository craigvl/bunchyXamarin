using System;
using Newtonsoft.Json;

namespace bunchyXamarin.Models
{
	public class LocationModel
	{
		[JsonProperty("Name")]
		public string Location { get; set; }
	}
}

