using System;
using System.IO;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using bunchyXamarin.Models;
using System.Web;
using Android.Util; 

namespace bunchyXamarin.Services
{
	class LoginService
	{
		public async Task<TokenResponseModel> Login(string username, string password)
		{
			//HttpWebRequest request = new HttpWebRequest(new Uri("http://192.168.56.1:1524/token"));
			HttpWebRequest request = new HttpWebRequest(new Uri("http://bunchyapi.azurewebsites.net/token"));
			request.Method = "POST";

			string postString = String.Format("username={0}&password={1}&grant_type=password", HttpUtility.HtmlEncode(username), HttpUtility.HtmlEncode("Blue12vl"));
			//Log.Info("bunchy",postString);
			byte[] bytes = Encoding.UTF8.GetBytes(postString);
			using (Stream requestStream = await request.GetRequestStreamAsync())
			{
				requestStream.Write(bytes, 0, bytes.Length);
			}

			try
			{
				HttpWebResponse httpResponse =  (HttpWebResponse)(await request.GetResponseAsync());
				string json;
				using (Stream responseStream = httpResponse.GetResponseStream())
				{
					json = new StreamReader(responseStream).ReadToEnd();
				}
				TokenResponseModel tokenResponse = JsonConvert.DeserializeObject<TokenResponseModel>(json);
				return tokenResponse;
			}
			catch (Exception ex)
			{
				//throw new SecurityException("Bad credentials", ex);
				return null;
			}	
		}
	}
}