using System;
using Xamarin.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace bunchyXamarin.ViewModels
{
	public class HomePageViewModel : INotifyPropertyChanged
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
			
		#region INotifyPropertyChanged implementation
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion

		public void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged == null)
				return;

			PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
		}

		public HomePageViewModel ()
		{

		}
	}
}