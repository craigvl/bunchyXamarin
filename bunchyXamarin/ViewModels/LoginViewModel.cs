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
		private bool showloading = false;

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

		public bool ShowLoading {
			get { return showloading; }
			set { 
				if (showloading == value)
					return;
				showloading = value;
				OnPropertyChanged("ShowLoading");
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
			ShowLoading = true;	
			LoginService loginservice = new LoginService();
			_TokenResponse = await loginservice.Login(name,"Blue12vl");

			//Example on how to get userinfo from API
			//BunchyService bunchyservice = new BunchyService ();
			//UserInfo _UserInfo = bunchyservice.GetUserInfo (_TokenResponse.AccessToken);

			if (!string.IsNullOrWhiteSpace (_TokenResponse.AccessToken)) {
				User _User = new User{ UserName = _TokenResponse.Username };
				await navigation.PushAsync (new BunchListPage(_User){ Title = "Bunch List"});
				ShowLoading = false;
			} else {
				Errortext = "Erroring logging in";
				ShowLoading = false;
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