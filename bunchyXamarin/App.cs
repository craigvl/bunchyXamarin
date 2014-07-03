using System;
using Xamarin.Forms;
using bunchyXamarin.Pages;
using bunchyXamarin.Models;

namespace bunchyXamarin
{
	public class App
	{
		public static IUserPreferences UserPreferences { get; private set; }
		public static IRegisterUser RegisterUser { get; private set;}

		public static void Init(IUserPreferences userPreferencesImpl, IRegisterUser registerUserImp1) 
		{
			App.UserPreferences = userPreferencesImpl;
			App.RegisterUser = registerUserImp1;
		}

		public static Page GetLoginPage ()
		{	
			return new NavigationPage (new LoginPage ());		
		}

		public static Page GetHomePage (string username)
		{	
			User _User = new User{ UserName = username};
			return new NavigationPage (new BunchListPage (_User){ Title = "Bunch List" });
		}
	}
}