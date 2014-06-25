using System;
using Xamarin.Forms;

namespace bunchyXamarin.Pages
{
	public class BunchRidersCell : ViewCell
	{
		public BunchRidersCell ()
		{
			var label = new Label {
				YAlign = TextAlignment.Center
			};

			label.SetBinding (Label.TextProperty, "Name");

			var keenlabel = new Label {
				YAlign = TextAlignment.Center
			};
				
			keenlabel.SetBinding (Label.TextProperty, "Status");

			var layout = new StackLayout {
				Padding = new Thickness (20, 0, 0, 0),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.StartAndExpand,
				Children = {label, keenlabel}
			};

			View = layout;
		}
	}
}

