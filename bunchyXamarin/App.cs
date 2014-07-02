using System;
using Xamarin.Forms;
using bunchyXamarin.Pages;
using bunchyXamarin.Models;

namespace bunchyXamarin
{
	public class App
	{
		public static Page GetMainPage ()
		{	

			return new NavigationPage (new LoginPage ());


//			UserHelper _UserHelper = new UserHelper();
//
//			if (!string.IsNullOrWhiteSpace(_UserHelper.GetToken ()) && !string.IsNullOrWhiteSpace(_UserHelper.GetUserName()) ) {
//				User _User = new User{ UserName = _UserHelper.GetUserName()};
//				return new NavigationPage (new HomePage (_User){ Title = "Home Page" });
//			} else {
//				return new NavigationPage (new LoginPage ());
//			}

			//bunchyXamarin.Android.prefs pre	= new bunchyXamarin.Android.prefs(Forms.Context);
			//#if __ANDROID__
			//if (!string.IsNullOrWhiteSpace(pre.geToken())) {
			//	User _User = new User{ UserName = pre.getUserName() };
			//		return new NavigationPage (new HomePage(_User){ Title = "Home Page"});
			//}
			//else
			//{
			//	return new NavigationPage (new LoginPage ());
			//}
			//#endif
		}
	}
}