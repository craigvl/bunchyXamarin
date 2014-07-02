using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace bunchyXamarin
{
	public interface IUserPreferences 
	{
		void SetString(string key, string value);
		string GetString(string key);
	}

	public interface IRegisterUser
	{
		void RegisterWithGCMAndriod();
	}
}