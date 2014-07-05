using System;
using Newtonsoft.Json;

namespace bunchyXamarin.Models
{
	public class HomePageModel
	{
		[JsonProperty("nextbunchname")]
		public string nextbunchname { get; set; }

		[JsonProperty("nextkeencount")]
		public int nextkeencount { get; set; }

		[JsonProperty("yourstatusfornext")]
		public string yourstatusfornext { get; set; }

		[JsonProperty("bunchcount")]
		public int bunchcount { get; set; }

		[JsonProperty("nextbunchday")]
		public string nextbunchday { get; set; }

		public HomePageModel ()
		{



		}
	}
}

