using System;
using System.ComponentModel;
using Xamarin.Forms;
using bunchyXamarin.Services;


namespace bunchyXamarin.ViewModels
{
	public class LoginViewModel  : INotifyPropertyChanged 
	{

		private string _accessToken = "";

		private INavigation navigation;
		public LoginViewModel(INavigation navigation)
		{
			this.navigation = navigation;
		}

		private string username = string.Empty;

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
			if (string.IsNullOrWhiteSpace (name))
				return;

			LoginService service = new LoginService();
			_accessToken = await service.Login(name,"Blue12vl");

			if (!string.IsNullOrWhiteSpace(_accessToken)) {
				await navigation.PushAsync (new ContentPage ());
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