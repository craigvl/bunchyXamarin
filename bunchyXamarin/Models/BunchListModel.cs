using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.ComponentModel;
using bunchyXamarin.Services;

namespace bunchyXamarin.Models
{
	public class BunchListModel  : INotifyPropertyChanged 
	{
		[JsonProperty("Name")]
		public string Name { get; set; }
		[JsonProperty("KeenCount")]
		public string KeenCount { get; set;}
		[JsonProperty("NextRideId")]
		public int NextRideId { get; set;}

		//private Command<string> attendCommand;
		//public Command AttendCommand
		//{
		//	get { return attendCommand ?? (attendCommand = new Command<string> (ExecuteAttendCommand));}
		//}

		//async private void ExecuteAttendCommand(string name, string status, int rideid)
		//{
	//		BunchyService service = new BunchyService();
	//		var test = await service.attend("frog","In",123);
	//	}

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

