using System;
using Xamarin.Forms;

namespace bunchyXamarin.Pages
{
	public class BunchListCell : ViewCell
	{
		public BunchListCell ()
		{

			Grid grid = new Grid {
				Padding = new Thickness (5, 5, 5, 5),
				HorizontalOptions = LayoutOptions.FillAndExpand,
				ColumnDefinitions = 
				{
					new ColumnDefinition { Width = new GridLength(250, GridUnitType.Absolute) }
				},
				RowDefinitions = 
				{   new RowDefinition { Height = new GridLength (35, GridUnitType.Absolute)},
					new RowDefinition { Height = new GridLength (35, GridUnitType.Absolute)}
				}
			};
				
			var label = new Label {
				YAlign = TextAlignment.Center,
				Font = Font.BoldSystemFontOfSize(20),
				BackgroundColor = Xamarin.Forms.Color.Green
			};

			label.SetBinding (Label.TextProperty, "Name");

			var keenlabel = new Label {
				YAlign = TextAlignment.Center
			};

			keenlabel.SetBinding (Label.TextProperty, "KeenCount");

			var keentext = new Label{ YAlign = TextAlignment.Center, Text = "Keen users:" };

			grid.Children.Add (label, 0, 1, 0, 2);
			grid.Children.Add (keentext, 1, 3, 0, 1);

			View = grid;

			//var layout = new StackLayout {
			//	Padding = new Thickness (20, 0, 0, 0),
			//	Orientation = StackOrientation.Vertical,

			//	HorizontalOptions = LayoutOptions.StartAndExpand,
			//	Children = {label, keentext, keenlabel  }
			//};

			//View = layout;







		}
	}
}

