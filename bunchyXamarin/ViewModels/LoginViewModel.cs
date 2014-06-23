using System;
using System.ComponentModel;
using Xamarin.Forms;
using bunchyXamarin.Services;
using bunchyXamarin.Pages;
using bunchyXamarin.Models;

namespace bunchyXamarin.ViewModels
{
	public class LoginViewModel  : INotifyPropertyChanged 
	{
		private TokenResponseModel _TokenResponse = new TokenResponseModel();

		private INavigation navigation;
		public LoginViewModel(INavigation navigation)
		{
			this.navigation = navigation;
		}

		private string username = string.Empty;
		private string errortext = string.Empty;

		public string Errortext {
			get { return errortext; }
			set { 
				if (errortext == value)
					return;

				errortext = value;
				OnPropertyChanged("Errortext");
			}
		}
			
		public string Username {
			get { return username; }
			set { 
				if (username == value)
					return;

				username = value;
				OnPropertyChanged("Username");
			}
		}

		private Command<string> loginCommand;
		public Command LoginCommand
		{
			get { return loginCommand ?? (loginCommand = new Command<string> (ExecuteLoginCommand, CanLogin));}
		}

		async private void ExecuteLoginCommand(string name)
		{
			if (string.IsNullOrWhiteSpace (name)) {
				Errortext = string.Empty;
				return;
			}
				
			LoginService service = new LoginService();
			_TokenResponse = await service.Login(name,"Blue12vl");

			if (!string.IsNullOrWhiteSpace (_TokenResponse.AccessToken)) {
				User _User = new User{ UserName = _TokenResponse.Username };
				await navigation.PushAsync (new HomePage(_User){ Title = "Home Page"});
			} else {
				Errortext = "Erroring logging in";
			}
		}

		private bool CanLogin(string name)
		{
			return !string.IsNullOrWhiteSpace (name);
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string name)
		{
			if (PropertyChanged == null) {
				return;
			}

			PropertyChanged (this, new PropertyChangedEventArgs (name));
		}
	}
}