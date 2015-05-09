using System;

namespace Fluxmatix.Mobile.Cache
{
	public class CacheItem<T>
	{
		public string Key { get; set; }
		public T Value { get; set; }
	}
}

