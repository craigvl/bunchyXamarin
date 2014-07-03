using System;
using bunchyXamarin.ViewModels;
using Xamarin.Forms;
using bunchyXamarin.Models;
using bunchyXamarin.Services;
using bunchyXamarin.Pages;

namespace bunchyXamarin.Pages
{
	public class BunchListPage : ContentPage
	{
		ListView listview;
		LocationModel _LocationModel;
		BunchyService service;
		ActivityIndicator activity;

		public BunchListPage (User _User)
		{
			//BindingContext = _HomePageModel;
			Title = "Home Page";
			service = new BunchyService();
			_LocationModel = new LocationModel ();
			_LocationModel = service.GetLocation(_User.UserName);
			NavigationPage.SetHasNavigationBar (this, false);

			activity = new ActivityIndicator {
				IsEnabled = true
			};
					
			var userName = new Label ();
			userName.Text = "Welcome " + _User.UserName + " " + _LocationModel.Location + " Bunches" ;
			listview = new ListView{ RowHeight = 200 };
			listview.ItemTemplate = new DataTemplate (typeof(BunchListCell));
			listview.ItemsSource = service.GetBunches(_LocationModel.Location);
			listview.ItemSelected += async(sender, e) => {
				activity.IsRunning = true;
				if (e.SelectedItem == null)
					return;
				var bunchItem = (BunchListModel)e.SelectedItem;
				var bunchPage = new BunchItemPage (bunchItem);
				bunchPage.SetValue(Page.TitleProperty, e.SelectedItem.ToString());
				bunchPage.BindingContext = bunchItem;
				await Navigation.PushAsync(bunchPage);
				listview.SelectedItem = null;
				activity.IsRunning = false;
			};

			Content = new StackLayout {
				Padding = 10,
				Spacing = 10,  	 
				Children = {userName, listview,activity}
			};
		}
	}
}