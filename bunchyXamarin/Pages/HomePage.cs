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
		ListView listview;
		HomePageModel _HomePageModel;
		BunchyService service;
		ActivityIndicator activity;

		public HomePage (User _User)
		{
			BindingContext = _User;
			Title = "Home Page";
			service = new BunchyService();
			_HomePageModel = new HomePageModel ();
			_HomePageModel = service.GetLocation(_User.UserName);
			NavigationPage.SetHasNavigationBar (this, false);

			activity = new ActivityIndicator {
				//Color = Helpers.Color.DarkBlue.ToFormsColor(),
				IsEnabled = true
			};
					
			var userName = new Label ();
			//userName.SetBinding<User> (Label.TextProperty, vmm => vmm.UserName);
			userName.Text = "Welcome " + _User.UserName + _HomePageModel.Location ;

			listview = new ListView();
			listview.ItemTemplate = new DataTemplate (typeof(BunchListCell));
			//listview.ItemsSource = new string [] { "Buy pears", "Buy oranges", "Buy mangos", "Buy apples", "Buy bananas" };
			listview.ItemsSource = service.GetBunches(_HomePageModel.Location);
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

		protected override void OnAppearing()
		{
			base.OnAppearing ();
			listview.ItemsSource = service.GetBunches(_HomePageModel.Location);
		}
	}
}