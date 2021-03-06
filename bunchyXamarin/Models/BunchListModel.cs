﻿using System;
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
		[JsonProperty("DayOfWeek")]
		public string DayOfWeek { get; set;}
		[JsonProperty("CommentCount")]
		public string CommentCount { get; set;}

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

