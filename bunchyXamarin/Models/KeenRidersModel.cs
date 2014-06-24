using System;
using Newtonsoft.Json;

namespace bunchyXamarin
{
	public class KeenRidersModel
	{
		[JsonProperty("Name")]
		public string Name { get; set; }

		public KeenRidersModel ()
		{
		}
	}
}