using System;
using Xamarin.Forms;
using bunchyXamarin.ViewModels;
using System.Threading.Tasks;

namespace bunchyXamarin
{
	public class HomePage : ContentPage
	{
		public HomePage ()
		{

			//BindingContext = new HomePageViewModel(Navigation);
			BindingContext = new HomePageViewModel ();
			var layout = new StackLayout { Padding = 10 };

			var label = new Label
			{
				Font = Font.BoldSystemFontOfSize(NamedSize.Large),
				TextColor = Color.White,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				XAlign = TextAlignment.Center, // Center the text in the blue box.
				YAlign = TextAlignment.Center, // Center the text in the blue box.
			};

			label.SetBinding (Label.TextProperty, "bunchname" );

			layout.Children.Add(label);

			Content = new ScrollView { Content = layout };

		}


	}
}

