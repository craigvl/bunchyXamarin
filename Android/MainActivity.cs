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


namespace bunchyXamarin.Android
{
	[Activity (Label = "Bunchy", MainLauncher = true)]
	public class MainActivity : AndroidActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			Xamarin.Forms.Forms.Init (this, bundle);
			//RegisterWithGCM ();
			var username = getUserName (this);
			if (string.IsNullOrWhiteSpace (username)) {
				SetPage (App.GeLoginPage ());
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

		public void saveUserName (string username, Context c)
		{
			var prefs = PreferenceManager.GetDefaultSharedPreferences(c);
			var edit = prefs.Edit();
			edit.PutString("UserName", username);
			edit.Commit();
		}
//
		public string getUserName(Context c)
		{
			var prefs = PreferenceManager.GetDefaultSharedPreferences(this);
			return prefs.GetString("UserName", string.Empty);
		}
//
		public void saveToken (string token, Context c)
		{
			var prefs = PreferenceManager.GetDefaultSharedPreferences(c);
			var edit = prefs.Edit();
			edit.PutString("Token", token);
			edit.Commit();
		}
//
		public string getToken(Context c)
		{
			var prefs = PreferenceManager.GetDefaultSharedPreferences(this);
			return prefs.GetString("Token", string.Empty);
		}

	}
}