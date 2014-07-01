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
			_editor.PutString("UserName", username);
			_editor.Commit();
		}
			
		public string getUserName()
		{
			return _prefs.GetString("UserName", string.Empty);
		}

		public void saveToken (string token)
		{
			ISharedPreferencesEditor _editor = _prefs.Edit();
			_editor.PutString("Token", token);
			_editor.Commit();
		}

		public string geToken()
		{
			return _prefs.GetString("Token", string.Empty);
		}
	}
}

