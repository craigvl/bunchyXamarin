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
			bunchyXamarin.Android.prefs pre	= new bunchyXamarin.Android.prefs(Forms.Context);
			#if __ANDROID__
			if (!string.IsNullOrWhiteSpace(pre.geToken())) {
				User _User = new User{ UserName = pre.getUserName() };
				return new NavigationPage (new HomePage(_User){ Title = "Home Page"});
			}
			else
			{
				return new NavigationPage (new LoginPage ());
			}
			#endif
		}
	}
}