using System;
using bunchyXamarin.ViewModels;
using Xamarin.Forms;
using bunchyXamarin.Models;
using bunchyXamarin.Services;

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
			listview.ItemsSource = new string [] { "Buy pears", "Buy oranges", "Buy mangos", "Buy apples", "Buy bananas" };
			//listview.ItemsSource = service.GetBunches("ss");



			//			listView.ItemSource = new TodoItem [] { 
			//				new TodoItem {Name = "Buy pears`"}, 
			//				new TodoItem {Name = "Buy oranges`", Done=true},
			//				new TodoItem {Name = "Buy mangos`"}, 
			//				new TodoItem {Name = "Buy apples`", Done=true},
			//				new TodoItem {Name = "Buy bananas`", Done=true}
			//			};


			Content = new StackLayout {
				Padding = 10,
				Spacing = 10,
				Children = {userName, listview}
			};


		}
	}
}

