using System;
using bunchyXamarin.ViewModels;
using Xamarin.Forms;
using bunchyXamarin.Models;

namespace bunchyXamarin.Pages
{
	public class HomePage : ContentPage
	{
		public HomePage (User _User)
		{
			var userName = new Label ();
			//userName.SetBinding<User> (Label.TextProperty, vmm => vmm.UserName);
			userName.Text = "Welcome " + _User.UserName;
			Content = new StackLayout {
				Padding = 10,
				Spacing = 10,
				Children = {userName}
			};

		}
	}
}

