using System;
using Xamarin.Forms;
using bunchyXamarin.Models;
using bunchyXamarin.Services;

namespace bunchyXamarin.Pages
{
	public class BunchItemPage : ContentPage
	{
		public BunchItemPage (BunchListModel _BuchListModel)
		{
			this.SetBinding (ContentPage.TitleProperty, "Name");
			BunchyService service = new BunchyService();

			var label = new Label ();
			label.Text = "Keen Users:" + _BuchListModel.KeenCount;

			ListView listview = new ListView();
			listview.ItemTemplate = new DataTemplate (typeof(BunchRidersCell));
			listview.ItemsSource = service.GetRiders(_BuchListModel.NextRideId);

			Content = new StackLayout {

				VerticalOptions = LayoutOptions.StartAndExpand,
				Padding = new Thickness (20),
				Children = {label}
			};
		}
	}
}

