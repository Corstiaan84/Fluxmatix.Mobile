using System;

namespace Fluxmatix.Mobile.Models
{
	public class TagItem
	{
		public string Key { get; private set; }
		public string Text { get; private set; }

		public TagItem (string key, string text)
		{
			Key = key;
			Text = text;
		}
	}
}

