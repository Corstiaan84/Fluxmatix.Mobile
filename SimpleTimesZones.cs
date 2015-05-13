using System;
using System.Collections.Generic;

namespace Fluxmatix.Mobile
{
	public static class SimpleTimeZones
	{
		private static List<SimpleTimeZone> _zones = new List<SimpleTimeZone> ()
		{
			new SimpleTimeZone() { UtcOffset = -12, Name = "(GMT -12:00) Eniwetok, Kwajalein" },
			new SimpleTimeZone() { UtcOffset = -11, Name = "(GMT -11:00) Midway Island, Samoa" },
			new SimpleTimeZone() { UtcOffset = -10, Name = "(GMT -10:00) Hawaii" },
			new SimpleTimeZone() { UtcOffset = -9, Name = "(GMT -9:00) Alaska" },
			new SimpleTimeZone() { UtcOffset = -8, Name = "(GMT -8:00) Pacific Time (US & Canada)" },
			new SimpleTimeZone() { UtcOffset = -7, Name = "(GMT -7:00) Mountain Time (US & Canada)" },
			new SimpleTimeZone() { UtcOffset = -6, Name = "(GMT -6:00) Central Time (US &amp; Canada), Mexico City" },
			new SimpleTimeZone() { UtcOffset = -5, Name = "(GMT -5:00) Eastern Time (US &amp; Canada), Bogota, Lima" },
			new SimpleTimeZone() { UtcOffset = -4.5, Name = "(GMT -4:30) Caracas" },
			new SimpleTimeZone() { UtcOffset = -4, Name = "(GMT -4:00) Atlantic Time (Canada), La Paz, Santiago" },
			new SimpleTimeZone() { UtcOffset = -3.5, Name = "(GMT -3:30) Newfoundland" },
			new SimpleTimeZone() { UtcOffset = -3, Name = "(GMT -3:00) Brazil, Buenos Aires, Georgetown" },
			new SimpleTimeZone() { UtcOffset = -2, Name = "(GMT -2:00) Mid-Atlantic" },
			new SimpleTimeZone() { UtcOffset = -1, Name = "(GMT -1:00) Azores, Cape Verde Islands" },
			new SimpleTimeZone() { UtcOffset = 0, Name = "(GMT 0:00) Western Europe Time, London, Lisbon, Casablanca, Greenwich" },
			new SimpleTimeZone() { UtcOffset = 1, Name = "(GMT +1:00) Amsterdam, Brussels, Copenhagen, Madrid, Paris" },
			new SimpleTimeZone() { UtcOffset = 2, Name = "(GMT +2:00) Kaliningrad, South Africa, Cairo" },
			new SimpleTimeZone() { UtcOffset = 3, Name = "(GMT +3:00) Baghdad, Riyadh, Moscow, St. Petersburg" },
			new SimpleTimeZone() { UtcOffset = 3.5, Name = "(GMT +3:30) Tehran" },
			new SimpleTimeZone() { UtcOffset = 4, Name = "(GMT +4:00) Abu Dhabi, Muscat, Yerevan, Baku, Tbilisi" },
			new SimpleTimeZone() { UtcOffset = 4.5, Name = "(GMT +4:30) Kabul" },
			new SimpleTimeZone() { UtcOffset = 5, Name = "(GMT +5:00) Ekaterinburg, Islamabad, Karachi, Tashkent" },
			new SimpleTimeZone() { UtcOffset = 5.5, Name = "(GMT +5:30) Mumbai, Kolkata, Chennai, New Delhi" },
			new SimpleTimeZone() { UtcOffset = 5.75, Name = "(GMT +5:45) Kathmandu" },
			new SimpleTimeZone() { UtcOffset = 6, Name = "(GMT +6:00) Almaty, Dhaka, Colombo" },
			new SimpleTimeZone() { UtcOffset = 6.5, Name = "(GMT +6:30) Yangon, Cocos Islands" },
			new SimpleTimeZone() { UtcOffset = 7, Name = "(GMT +7:00) Bangkok, Hanoi, Jakarta" },
			new SimpleTimeZone() { UtcOffset = 8, Name = "(GMT +8:00) Beijing, Perth, Singapore, Hong Kong" },
			new SimpleTimeZone() { UtcOffset = 9, Name = "(GMT +9:00) Tokyo, Seoul, Osaka, Sapporo, Yakutsk" },
			new SimpleTimeZone() { UtcOffset = 9.5, Name = "(GMT +9:30) Adelaide, Darwin" },
			new SimpleTimeZone() { UtcOffset = 10, Name = "(GMT +10:00) Eastern Australia, Guam, Vladivostok" },
			new SimpleTimeZone() { UtcOffset = 11, Name = "(GMT +11:00) Magadan, Solomon Islands, New Caledonia" },
			new SimpleTimeZone() { UtcOffset = 12, Name = "(GMT +12:00) Auckland, Wellington, Fiji, Kamchatka" }
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
		public string Name { get; set; }
		public double UtcOffset { get; set; }

		public SimpleTimeZone () {	}

		public override string ToString ()
		{
			return Name;
		}
	}
}

