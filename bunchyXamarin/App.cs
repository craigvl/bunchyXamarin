using System;
using Xamarin.Forms;
using bunchyXamarin.Pages;
using bunchyXamarin.Models;

namespace bunchyXamarin
{
	public class App
	{
		public static Page GeLoginPage ()
		{	
			return new NavigationPage (new LoginPage ());		
		}

		public static Page GetHomePage (string username)
		{	
			User _User = new User{ UserName = username};
			return new NavigationPage (new HomePage (_User){ Title = "Home Page" });
		}
	}
}