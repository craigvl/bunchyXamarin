using System;
using Xamarin.Forms;
using bunchyXamarin.ViewModels;
using System.Threading.Tasks;
using bunchyXamarin.Helpers;

namespace bunchyXamarin
{
	public class HomePage : ContentPage
	{
		public HomePage ()
		{
			//BindingContext = new HomePageViewModel(Navigation);
			BindingContext = new HomePageViewModel ();
			var layout = new StackLayout { Padding = new Thickness (10, 20, 10,10) };

			var nextbunchtext = new Label
			{
				Font = Font.BoldSystemFontOfSize(NamedSize.Large),			    
				//VerticalOptions = LayoutOptions.CenterAndExpand,
				XAlign = TextAlignment.Center, // Center the text in the blue box.
				YAlign = TextAlignment.Center, // Center the text in the blue box.
				Text = "Your next Bunch"
			};

			var nextbunchnamelabel = new Label
			{
				Font = Font.BoldSystemFontOfSize(NamedSize.Large),
				//VerticalOptions = LayoutOptions.CenterAndExpand,
				XAlign = TextAlignment.Start, // Center the text in the blue box.
				YAlign = TextAlignment.Start, // Center the text in the blue box.
			};

			nextbunchnamelabel.SetBinding (Label.TextProperty, "bunchname" );

			var nextbunchday = new Label
			{
			    WidthRequest = 20,
				HeightRequest = 50,

				XAlign = TextAlignment.Start,
				YAlign = TextAlignment.Center,
				Font = Font.BoldSystemFontOfSize(NamedSize.Large),
				BackgroundColor = Color.FromHex(Helpers.CustomColour.DarkGrey),
				TextColor = Color.FromHex(Helpers.CustomColour.Black),
				//VerticalOptions = LayoutOptions.CenterAndExpand,
			};

			nextbunchday.SetBinding (Label.TextProperty, "nextbunchday" );

			if (Label.TextProperty != null) {
				layout.Children.Add(nextbunchtext);
				layout.Children.Add(nextbunchnamelabel);
				layout.Children.Add(nextbunchday);
			}



			Content = new ScrollView { Content = layout };

		}


	}
}

