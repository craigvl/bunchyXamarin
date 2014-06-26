using System;
using Android.Content;
using Android.Preferences;

namespace bunchyXamarin.Android
{
	public class prefs
	{

		ISharedPreferences _prefs;

		public prefs (Context c)
		{
			 _prefs = PreferenceManager.GetDefaultSharedPreferences(c);
		}

		public void saveUserName (string username)
		{
			ISharedPreferencesEditor _editor = _prefs.Edit();
			_editor.PutString("myString", username);
			_editor.Commit();
		}
			
		public string getUserName()
		{
			return _prefs.GetString("myString", "Can't find string");
		}
	}
}

