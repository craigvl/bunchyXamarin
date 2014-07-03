using System;
using System.ComponentModel;
using PropertyChanged;
using bunchyXamarin.Models;
using System.Threading.Tasks;

namespace bunchyXamarin
{
	[ImplementPropertyChanged]
	public class LandingPageViewModel 
	{
		public HomePageModel _HomePageModel { get; set;}
	
//		public async Task GetLandingPageModel ()
//		{
//			this._LandingPageModel  = await GetLandingPageDetails ();
//		}
//			
//		public LandingPageViewModel ()
//		{
//		}		
	}
}

