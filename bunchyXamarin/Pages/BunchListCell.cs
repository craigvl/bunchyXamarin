using System;
using Xamarin.Forms;

namespace bunchyXamarin.Pages
{
	public class BunchListCell : ViewCell
	{
		public BunchListCell ()
		{
						
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

			var keentext = new Label{ YAlign = TextAlignment.Center, Text = "Keen users" };

			var layout = new StackLayout {
				Padding = new Thickness (20, 0, 0, 0),
				Orientation = StackOrientation.Vertical,

				HorizontalOptions = LayoutOptions.StartAndExpand,
				Children = {label, keentext, keenlabel  }
			};

			View = layout;
		}
	}
}

