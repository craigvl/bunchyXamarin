using bunchyXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace bunchyXamarin.Pages
{
	public class LoginPage : ContentPage
	{
		public LoginPage()
		{
			this.BindingContext = new LoginViewModel (Navigation);
			var entry = new Entry {
				Placeholder = "Enter Username"
			};

			entry.SetBinding<LoginViewModel> (Entry.TextProperty, vmm => vmm.Username, BindingMode.TwoWay);

			var button = new Button {
				Text = "Login"
			};

			var errorLabel = new Label ();
			errorLabel.SetBinding<LoginViewModel> (Label.TextProperty, vmm => vmm.Errortext);

			button.SetBinding<LoginViewModel> (Button.CommandProperty, vmm => vmm.LoginCommand);
			button.SetBinding<LoginViewModel> (Button.CommandParameterProperty, vmm => vmm.Username);

			Content = new StackLayout {
				Padding = 10,
				Spacing = 10,
				Children = { entry,button,errorLabel}
			};
		}
	}
}