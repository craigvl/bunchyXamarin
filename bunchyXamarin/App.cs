using System;
using Xamarin.Forms;
using bunchyXamarin.Pages;

namespace bunchyXamarin
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new NavigationPage (new LoginPage ());
		}
	}
}