using System;
using System.Collections.Generic;

namespace Fluxmatix.Mobile
{
	public static class SimpleTimeZones
	{
		private static List<SimpleTimeZone> _zones = new List<SimpleTimeZone> ()
		{
			new SimpleTimeZone() { Abbreviation = "AB", Description = "Alberta"},
			new SimpleTimeZone() { Abbreviation = "AB", Description = "Alberta"},
			new SimpleTimeZone() { Abbreviation = "AB", Description = "Alberta"},
			new SimpleTimeZone() { Abbreviation = "AB", Description = "Alberta"}
		};

		public static List<SimpleTimeZone> List 
		{ 
			get
			{ 
				return _zones;
			}
		} 
	}

	public class SimpleTimeZone
	{
		public string Abbreviation { get; set; }
		public string Description { get; set; }
		public float UtcOfsset { get; set; }

		public SimpleTimeZone () {	}

		public override string ToString ()
		{
			return Description.ToString ();
		}
	}
}

