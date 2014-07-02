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
				Font = Font.BoldSystemFontOfSize(20)
//				BackgroundColor = Xamarin.Forms.Color.Green
			};
					
			label.SetBinding (Label.TextProperty, "Name");

			var daylabel = new Label {
				YAlign = TextAlignment.Center
			};

			daylabel.SetBinding (Label.TextProperty, "DayOfWeek");


			var keenlabel = new Label {
				YAlign = TextAlignment.Center
			};

			keenlabel.SetBinding (Label.TextProperty, "KeenCount");

			var commentlabel = new Label {
				YAlign = TextAlignment.Center
			};

			commentlabel.SetBinding (Label.TextProperty, "CommentCount");

			var keentext = new Label{ YAlign = TextAlignment.Center, Text = "Keen users" };
			var commenttext = new Label{ YAlign = TextAlignment.Center, Text = "Comments" };

			var layout = new StackLayout {
				Padding = new Thickness (20, 0, 0, 0),
				Orientation = StackOrientation.Vertical,

				HorizontalOptions = LayoutOptions.StartAndExpand,
				Children = {label, daylabel, keentext, keenlabel, commenttext, commentlabel }
			};

			View = layout;
		}

		protected override void OnBindingContextChanged ()
		{
			// Fixme : this is happening because the View.Parent is getting 
			// set after the Cell gets the binding context set on it. Then it is inheriting
			// the parents binding context.
			View.BindingContext = BindingContext;
			base.OnBindingContextChanged ();
		}
	}
}

