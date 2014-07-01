using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace bunchyXamarin
{
	public class UserHelper
	{
	
		public UserHelper()
		{


		}

		public void SaveUserName (string username)
		{
			#if __ANDROID__
			bunchyXamarin.Android.prefs pre	= new bunchyXamarin.Android.prefs(Forms.Context);
			pre.saveUserName(username);
			//await Task.Run(() => { pre.saveUserName(username);});
			#endif
		}

		public string GetUserName()
		{
			#if __ANDROID__
			bunchyXamarin.Android.prefs pre	= new bunchyXamarin.Android.prefs(Forms.Context);
			return pre.getUserName ();
			#endif
		}

		public void RegisterUserForNotifications(string username)
		{
			#if __ANDROID__
			bunchyXamarin.Android.MainActivity ii = new bunchyXamarin.Android.MainActivity();
			ii.RegisterWithGCMAndriod(Forms.Context);
			//await Task.Run(() => {ii.RegisterWithGCMAndriod(Forms.Context);});
			#endif
		}

		public void SaveToken (string accesstoken)
		{
			#if __ANDROID__
			bunchyXamarin.Android.prefs pre	= new bunchyXamarin.Android.prefs(Forms.Context);
			pre.saveToken(accesstoken);
			//await Task.Run(() => {pre.saveToken(accesstoken);});
			#endif
		}

		public string GetToken()
		{
			#if __ANDROID__
			bunchyXamarin.Android.prefs pre	= new bunchyXamarin.Android.prefs(Forms.Context);
			return pre.GetHashCode().ToString();
			#endif
		}
	}

}

