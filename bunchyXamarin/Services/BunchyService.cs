using System;
using bunchyXamarin.Models;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace bunchyXamarin.Services
{
	public class BunchyService
	{
		public HomePageModel GetLocation(string username)
		{
			//var request = HttpWebRequest.Create(string.Format(@"http://localhost:1524/api/location/{0}", username));
			var request = HttpWebRequest.Create(string.Format(@"http://192.168.56.1:1524/api/location/{0}", username));
			request.ContentType = "application/json";
			request.Method = "GET";

			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
			{
				if (response.StatusCode != HttpStatusCode.OK)
					Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
				using (StreamReader reader = new StreamReader(response.GetResponseStream()))
				{
					var content = reader.ReadToEnd();
					if(string.IsNullOrWhiteSpace(content)) {
						Console.Out.WriteLine("Response contained empty body...");
						return null;
					}
					else {
						Console.Out.WriteLine("Response Body: \r\n {0}", content);
						HomePageModel _HomePageModel = JsonConvert.DeserializeObject<HomePageModel>(content);
						return _HomePageModel;
					}
				}
			}
		}

		public HomePageModel GetBunches(string username)
		{
			//var request = HttpWebRequest.Create(string.Format(@"http://localhost:1524/api/location/{0}", username));
			var request = HttpWebRequest.Create(string.Format(@"http://192.168.56.1:1524/api/bunch/{0}", "townsville"));
			request.ContentType = "application/json";
			request.Method = "GET";

			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
			{
				if (response.StatusCode != HttpStatusCode.OK)
					Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
				using (StreamReader reader = new StreamReader(response.GetResponseStream()))
				{
					var content = reader.ReadToEnd();
					if(string.IsNullOrWhiteSpace(content)) {
						Console.Out.WriteLine("Response contained empty body...");
						return null;
					}
					else {
						Console.Out.WriteLine("Response Body: \r\n {0}", content);
						HomePageModel _HomePageModel = JsonConvert.DeserializeObject<HomePageModel>(content);
						return _HomePageModel;
					}
				}
			}
		}
	}
}