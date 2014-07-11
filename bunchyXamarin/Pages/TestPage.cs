using System;
using Xamarin.Forms;
using bunchyXamarin.ViewModels;
using System.Threading.Tasks;
using bunchyXamarin.Helpers;

namespace bunchyXamarin.Pages
{
	public class TestPage : ContentPage
	{
		public TestPage ()
		{
			var TotalLayout = new StackLayout { Padding = new Thickness (10, 20, 10,10) };
			var FirstRow = new StackLayout { Padding = new Thickness (10, 20, 10, 10) };

			TotalLayout.BackgroundColor = Color.Aqua;

			TotalLayout.Children.Add(FirstRow);

			Content = new ScrollView { Content = TotalLayout };

		}
	}
}