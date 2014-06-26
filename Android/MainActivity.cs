﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ByteSmith.WindowsAzure.Messaging;
using Gcm.Client;

using Xamarin.Forms.Platform.Android;


namespace bunchyXamarin.Android
{
	[Activity (Label = "Bunchy", MainLauncher = true)]
	public class MainActivity : AndroidActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			Xamarin.Forms.Forms.Init (this, bundle);
			RegisterWithGCM ();
			SetPage (App.GetMainPage ());
		}

		private void RegisterWithGCM()
		{
			// Check to ensure everything's setup right
			GcmClient.CheckDevice(this);
			GcmClient.CheckManifest(this);

			// Register for push notifications
			System.Diagnostics.Debug.WriteLine("Registering...");
			GcmClient.Register(this, Constants.SenderID);
		}

	}
}

