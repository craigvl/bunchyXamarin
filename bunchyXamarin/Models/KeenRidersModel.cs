using System;
using Newtonsoft.Json;

namespace bunchyXamarin
{
	public class KeenRidersModel
	{
		[JsonProperty("Name")]
		public string Name { get; set; }

		[JsonProperty("Status")]
		public string Status { get; set; }

		public KeenRidersModel ()
		{
		}
	}
}