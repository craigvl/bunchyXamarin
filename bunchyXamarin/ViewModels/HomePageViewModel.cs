using System;
using System.ComponentModel;
using PropertyChanged;
using bunchyXamarin.Models;
using System.Threading.Tasks;
using bunchyXamarin.Services;

namespace bunchyXamarin
{
	[ImplementPropertyChanged]
	public class HomePageViewModel 
	{
		public HomePageModel _HomePageModel { get; set;}
		public string bunchname { get; set;}

		public HomePageViewModel()
		{
			string username = App.UserPreferences.GetString("UserName");
			BunchyService _BunchyService = new BunchyService ();
			this._HomePageModel = _BunchyService.GetHomePageDetails(username);
			this.bunchname = this._HomePageModel.nextbunchname;
		}
			
	}
}

