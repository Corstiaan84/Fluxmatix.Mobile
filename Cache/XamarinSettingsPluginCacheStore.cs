using System;
using Refractored.Xam.Settings;
using Refractored.Xam.Settings.Abstractions;

namespace Fluxmatix.Mobile.Cache
{
	public class XamarinSettingsPluginCacheStore : IMobileCacheStore
	{
		public XamarinSettingsPluginCacheStore () 
		{
		}

		public static ISettings AppSettings
		{ 
			get
			{
				return CrossSettings.Current;
			}
		}

		#region IMobileCacheStore implementation

		public string Get (string key)
		{
			return AppSettings.GetValueOrDefault<string>(key, "defaultValue");
		}

		public void Put (string key, string value)
		{
			AppSettings.AddOrUpdateValue<string>(key, value);
		}

		public T Get<T> (string key)
		{
			return AppSettings.GetValueOrDefault<T>(key);
		}

		public void Put<T> (string key, T value)
		{
			AppSettings.AddOrUpdateValue<T>(key, value);
		}

		public bool ContainsKey (string key)
		{
			throw new NotImplementedException ();
		}

		public void Clear ()
		{
			throw new NotImplementedException ();
		}

		public void RemoveKey (string key)
		{
			AppSettings.Remove (key);
		}
		#endregion
	}
}

