using System;
using Xamarin.Forms;
using bunchyXamarin.Models;
using bunchyXamarin.Services;
using bunchyXamarin.Pages;
using bunchyXamarin.ViewModels;

namespace bunchyXamarin.Pages
{
	public class BunchItemPage : ContentPage
	{
		public BunchItemPage (BunchListModel _BuchListModel)
		{
			this.BindingContext = new BunchDetailViewModel (Navigation);
			this.SetBinding (ContentPage.TitleProperty, "Name");
			BunchyService service = new BunchyService();

			var label = new Label ();
			label.Text = "Keen Users:" + _BuchListModel.KeenCount;

			ListView listview = new ListView{ RowHeight = 40};
			listview.ItemTemplate = new DataTemplate (typeof(BunchRidersCell));
			listview.ItemsSource = service.GetRiders(_BuchListModel.NextRideId);
			var buttonIn = new Button {
				Text = "I'm in"
			};

			buttonIn.Clicked += async(sender, e) => {
				BunchItem _BunchItem = new BunchItem { name = "frog", status = "In", rideid = _BuchListModel.NextRideId.ToString() };
				BunchyService _Service = new BunchyService();
				_Service.attend(_BunchItem);
				await this.Navigation.PopAsync();
			};

			var buttonOut = new Button {
				Text = "I'm out"
			};

			buttonOut.Clicked += (sender, e) => {
						BunchItem _BunchItem = new BunchItem { name = "frog", status = "Out", rideid = _BuchListModel.NextRideId.ToString() };
				BunchyService _Service = new BunchyService();
				_Service.attend(_BunchItem);
				this.Navigation.PopAsync();
			};

			var buttonOnWay = new Button {
				Text = "I'm on my way"
			};

			buttonOnWay.Clicked += (sender, e) => {
						BunchItem _BunchItem = new BunchItem { name = "frog", status = "OnWay", rideid = _BuchListModel.NextRideId.ToString() };
				BunchyService _Service = new BunchyService();
				_Service.attend(_BunchItem);
				this.Navigation.PopAsync();
			};
					
			Content = new StackLayout {

				VerticalOptions = LayoutOptions.StartAndExpand,
				Padding = new Thickness (20),
				Children = {label, listview, buttonIn, buttonOut, buttonOnWay}
			};
		}
	}
}

