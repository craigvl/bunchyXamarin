using System;
using Xamarin.Forms;

namespace bunchyXamarin.Pages
{
	public class BunchListCell : ViewCell
	{
		public BunchListCell ()
		{

			var label = new Label {
				YAlign = TextAlignment.Center
			};

			label.SetBinding (Label.TextProperty, "Name");

			var keenlabel = new Label {
				YAlign = TextAlignment.Center
			};

			keenlabel.SetBinding (Label.TextProperty, "KeenCount");

			var keentext = new Label{ YAlign = TextAlignment.Center, Text = "# of keen users:" };

			var layout = new StackLayout {
				Padding = new Thickness (20, 0, 0, 0),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.StartAndExpand,
				Children = {label, keentext, keenlabel  }
			};

			View = layout;
		}
	}
}

