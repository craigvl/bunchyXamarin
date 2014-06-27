using System;
using bunchyXamarin.Models;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace bunchyXamarin.Services
{
	public class BunchyService
	{
		public HomePageModel GetLocation(string username)
		{
			//var request = HttpWebRequest.Create(string.Format(@"http://localhost:1524/api/location/get/{0}", username));
			var request = HttpWebRequest.Create(string.Format(@"http://bunchyapi.azurewebsites.net/api/location/get/{0}", username));
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

		public List<BunchListModel> GetBunches(string username)
		{
			var request = HttpWebRequest.Create(string.Format(@"http://bunchyapi.azurewebsites.net/api/bunch/get/{0}", "townsville"));
			//var request = HttpWebRequest.Create(string.Format(@"http://192.168.56.1:1524/api/bunch/get/{0}", "townsville"));
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
						List<BunchListModel> _HomePageModel = JsonConvert.DeserializeObject<List<BunchListModel>>(content);
						return _HomePageModel;
					}
				}
			}
		}

		public List<KeenRidersModel> GetRiders(int rideid)
		{
			//var request = HttpWebRequest.Create(string.Format(@"http://localhost:1524/api/location/getriders/{0}", username));
			var request = HttpWebRequest.Create(string.Format(@"http://bunchyapi.azurewebsites.net/api/bunch/getriders/{0}", rideid.ToString()));
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
						List<KeenRidersModel> _KeenRidersModel = JsonConvert.DeserializeObject<List<KeenRidersModel>>(content);
						return _KeenRidersModel;
					}
				}
			}
		}

		public async Task<string> attend(string status, string username, int rideid)
		{
			//HttpWebRequest request = new HttpWebRequest(new Uri("http://192.168.56.1:1524/token"));
			HttpWebRequest request = new HttpWebRequest(new Uri("http://bunchyapi.azurewebsites.net/token"));
			request.Method = "POST";

			string postString = String.Format("Name={0}&Status={1}&RideID={2}", 
				HttpUtility.HtmlEncode(username), 
				HttpUtility.HtmlEncode(status),
				HttpUtility.HtmlEncode(rideid));
			//Log.Info("bunchy",postString);
			byte[] bytes = Encoding.UTF8.GetBytes(postString);
			string _result;
			using (Stream requestStream = await request.GetRequestStreamAsync())
			{
				requestStream.Write(bytes, 0, bytes.Length);
			}
				
			try
			{
				HttpWebResponse httpResponse =  (HttpWebResponse)(await request.GetResponseAsync());

				using (Stream responseStream = httpResponse.GetResponseStream())
				{
					_result = new StreamReader(responseStream).ReadToEnd();
				}
				_result = "true";
				return _result;
			}
			catch (Exception ex)
			{
				_result = "false";
				return _result;
			}	
		}
	}
}