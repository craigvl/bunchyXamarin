using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ByteSmith.WindowsAzure.Messaging;
using Gcm.Client;
using Xamarin.Forms.Platform.Android;
using Android.Preferences;
using bunchyXamarin.Android; 

namespace bunchyXamarin.Android
{
	[Activity (Label = "Bunchy", MainLauncher = true)]
	public class MainActivity : AndroidActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			Xamarin.Forms.Forms.Init (this, bundle);
			App.Init (new AndroidUserPreferences (), new RegisterAndriodUser());
			//RegisterWithGCM ();
			var username = App.UserPreferences.GetString("UserName");
			if (string.IsNullOrWhiteSpace (username)) {
				SetPage (App.GetLoginPage ());
			} else {
				SetPage (App.GetHomePage(username));
			}
		}

		public void RegisterWithGCMAndriod(Context c)
		{
			// Check to ensure everything's setup right
			GcmClient.CheckDevice(c);
			GcmClient.CheckManifest(c);

			// Register for push notifications
			System.Diagnostics.Debug.WriteLine("Registering...");
			GcmClient.Register(c, Constants.SenderID);
		}
	}
}