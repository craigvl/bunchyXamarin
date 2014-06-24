using System;
using Newtonsoft.Json;

namespace bunchyXamarin
{
	public class HomePageModel
	{
		[JsonProperty("Name")]
		public string Location { get; set; }
	}
}

