using System;
using Android.Content;
using Android.Preferences;
using Android.App;
using Gcm.Client;
using bunchyXamarin.Helpers;

namespace bunchyXamarin.Android
{
	public class AndroidUserPreferences : IUserPreferences
	{
		public void SetString(string key, string value)
		{
			var prefs = Application.Context.GetSharedPreferences("MySharedPrefs", FileCreationMode.Private);
			var prefsEditor = prefs.Edit();
			prefsEditor.PutString(key, value);
			prefsEditor.Commit();
		}

		public string GetString(string key)
		{
			var prefs = Application.Context.GetSharedPreferences("MySharedPrefs", FileCreationMode.Private);
			return prefs.GetString(key, string.Empty);
		}
	}

	public class RegisterAndriodUser : IRegisterUser
	{
		public void RegisterWithGCMAndriod()
		{
			// Check to ensure everything's setup right
			GcmClient.CheckDevice(Application.Context);
			GcmClient.CheckManifest(Application.Context);

			// Register for push notifications
			System.Diagnostics.Debug.WriteLine("Registering...");
			GcmClient.Register(Application.Context, Constants.SenderID);
		}
	}
}