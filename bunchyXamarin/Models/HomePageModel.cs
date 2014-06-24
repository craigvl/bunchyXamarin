using System;
using Newtonsoft.Json;

namespace bunchyXamarin.Models
{
	public class HomePageModel
	{
		[JsonProperty("Name")]
		public string Location { get; set; }
	}
}

