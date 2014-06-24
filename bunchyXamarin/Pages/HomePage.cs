using System;
using bunchyXamarin.ViewModels;
using Xamarin.Forms;
using bunchyXamarin.Models;
using bunchyXamarin.Services;
using bunchyXamarin.Pages;

namespace bunchyXamarin.Pages
{
	public class HomePage : ContentPage
	{
		public HomePage (User _User)
		{
			BunchyService service = new BunchyService();
			HomePageModel _HomePageModel = new HomePageModel ();
			_HomePageModel = service.GetLocation(_User.UserName);

			var userName = new Label ();
			//userName.SetBinding<User> (Label.TextProperty, vmm => vmm.UserName);
			userName.Text = "Welcome " + _User.UserName + _HomePageModel.Location ;

			ListView listview = new ListView();
			listview.ItemTemplate = new DataTemplate (typeof(BunchListCell));
			//listview.ItemsSource = new string [] { "Buy pears", "Buy oranges", "Buy mangos", "Buy apples", "Buy bananas" };
			listview.ItemsSource = service.GetBunches(_HomePageModel.Location);
			listview.ItemSelected += (sender, e) => {

				var bunchItem = (BunchListModel)e.SelectedItem;
				var bunchPage = new BunchItemPage (bunchItem);
				bunchPage.BindingContext = bunchItem;
				Navigation.PushAsync (bunchPage);

			};

			Content = new StackLayout {
				Padding = 10,
				Spacing = 10,
				Children = {userName, listview}
			};
		}
	}
}