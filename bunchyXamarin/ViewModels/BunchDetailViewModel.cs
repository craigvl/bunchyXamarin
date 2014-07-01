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

		//private Command<string> attendCommand;
		//public Command AttendCommand
		//{
	//		get { return (attendCommand = new Command<string> (ExecuteAttendCommand));}
//		}

//		async private void ExecuteAttendCommand(string name)
//		{

//		}

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

		private string name = string.Empty;
		public string Name {
		get { return name; }
		set { 
			if (name == value)
				return;

			name = value;
			OnPropertyChanged("Name");
		}
	}
		private string keencount = string.Empty;
		public string KeenCount{
			get { return keencount; }
			set { 
				if (keencount == value)
					return;

				keencount = value;
				OnPropertyChanged("KeenCount");
			}
		}

		private int nextrideid = -1;
		public int NextRideId{
			get { return nextrideid; }
			set { 
				if (nextrideid == value)
					return;

				nextrideid = value;
				OnPropertyChanged("NextRideId");
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

