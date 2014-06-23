using System;
using Newtonsoft.Json;

namespace bunchyXamarin
{
	public class HomePageModel
	{

		[JsonProperty("Location")]
		public string Location { get; set; }

		public HomePageModel ()
		{



		}
	}
}

