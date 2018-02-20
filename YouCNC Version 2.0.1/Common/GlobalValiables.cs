using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;

namespace YouCNC_Version_2._0._1.Common
{
	internal static class GlobalValiables
	{
		public static BackgroundWorker PositionThread { get; set; } = new BackgroundWorker();

		public static SerialPort SerialPort { get; set; }

		public static List<BaudRate> GetBaudRates()
		{
			return new List<BaudRate>
			{
				new BaudRate { ValueMamber = 9600,   DisplayMember = "9600"}, 
				new BaudRate { ValueMamber = 14400,  DisplayMember = "14400"}, 
				new BaudRate { ValueMamber = 19200,  DisplayMember = "19200"}, 
				new BaudRate { ValueMamber = 28800,  DisplayMember = "28800"},
				new BaudRate { ValueMamber = 38400,  DisplayMember = "38400"},
				new BaudRate { ValueMamber = 57600,  DisplayMember = "57600"},
				new BaudRate { ValueMamber = 115200, DisplayMember = "115200"} 
			};
		}

		public enum enum_desktop_alert
		{
			Warning = 0,
			Positive = 1,
			Error = 2
		}

		public static List<string> GCode = new List<string>();

		public static bool AlarmErrorThrown { get; set; } = false;


		public static class GrblKeywords
		{
			public const string UNLOCK = "$X";
		}

	}

	public class ComPort
	{
		public string DisplayMember { get; set; }
		public string ValueMamber { get; set; }
	}

	public class BaudRate
	{
		public string DisplayMember { get; set; }
		public int ValueMamber { get; set; }
	}


}
