using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace bunchyXamarin.ViewModels
{
	public class BunchDetailViewModel  : INotifyPropertyChanged 
	{
		private INavigation navigation;
		public BunchDetailViewModel(INavigation navigation)
		{
			this.navigation = navigation;
		}

		private Command<string> attendCommand;
		public Command AttendCommand
		{
			get { return (attendCommand = new Command<string> (ExecuteAttendCommand));}
		}

		async private void ExecuteAttendCommand(string name)
		{

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

