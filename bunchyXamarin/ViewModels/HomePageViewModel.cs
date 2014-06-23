using System;
using Xamarin.Forms;
using System.ComponentModel;

namespace bunchyXamarin.ViewModels
{
	public class HomePageViewModel
	{
		private int bunchcount = 0;
		public int Bunchcount{
			get { return bunchcount; }
			set { 
				if (bunchcount == value)
					return;
				bunchcount = value;
				OnPropertyChanged("Bunchcount");
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

		public HomePageViewModel ()
		{
		
		}
	}
}