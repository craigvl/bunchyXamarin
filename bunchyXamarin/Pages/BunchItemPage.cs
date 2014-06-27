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

			var buttonOut = new Button {
				Text = "I'm out"
			};

			var buttonOnWay = new Button {
				Text = "I'm on my way"
			};




			buttonIn.SetBinding<BunchDetailViewModel> (Button.CommandProperty, vmm => vmm.AttendCommand);
			buttonIn.SetBinding<BunchDetailViewModel> (Button.CommandParameterProperty, );
			buttonIn.SetBinding<BunchDetailViewModel> (Button.CommandParameterProperty, vmm => vmm.Username);

			Content = new StackLayout {

				VerticalOptions = LayoutOptions.StartAndExpand,
				Padding = new Thickness (20),
				Children = {label, listview, buttonIn, buttonOut, buttonOnWay}
			};
		}
	}
}

