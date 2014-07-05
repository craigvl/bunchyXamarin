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
		public int nextkeencount { get; set;}
		public string yourstatusfornext { get; set;}
		public string nextbunchday { get; set;}
		public int bunchcount { get; set;}

		public HomePageViewModel()
		{
			string username = App.UserPreferences.GetString("UserName");
			BunchyService _BunchyService = new BunchyService ();
			this._HomePageModel = _BunchyService.GetHomePageDetails(username);
			this.bunchname = this._HomePageModel.nextbunchname;
			this.nextkeencount = this._HomePageModel.nextkeencount;
			this.bunchcount = this._HomePageModel.bunchcount;
			this.nextbunchday = this._HomePageModel.nextbunchday;
		}
			
	}
}

