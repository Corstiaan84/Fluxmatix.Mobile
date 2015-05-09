using System;

namespace Fluxmatix.Mobile.Cache
{
	public interface IMobileCacheStore
	{
		string Get(string key);
		void Put(string key, string value);
		object Get<T>(string key);
		void Put<T>(string key, T value);
		bool ContainsKey (string key);
		void Clear();
	}
}

