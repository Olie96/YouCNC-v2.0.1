using System.Collections.Generic;
using System.Linq;
using YouCNC_Version_2._0._1.Models;

namespace YouCNC_Version_2._0._1.Common
{
	internal static class Interpreter
	{

		private enum Constants
		{
			// ReSharper disable once UnusedMember.Local
			NumberSeven = 7,
			// ReSharper disable once UnusedMember.Local
			NumberTwo = 2,
			NumberOne = 1,
			Colon = ':',
			// ReSharper disable once UnusedMember.Local
			ArrowRight = '>',
			// ReSharper disable once UnusedMember.Local
			ArrowLeft = '<',
			// ReSharper disable once UnusedMember.Local
			Zero = 0,
			// ReSharper disable once UnusedMember.Local
			EndOfMessage = '\0',
			Comma = ','
		}

		public static PositionModel ResolvePositions(string message)
		{
		   var receivedPositionData = new PositionModel();
			if (!string.IsNullOrEmpty(message))
			{
				try
				{
					string cutMessage =
						message.Substring(message.IndexOf((char) Constants.Colon) + (int) Constants.NumberOne);
					cutMessage = cutMessage.Substring(0, cutMessage.IndexOf('>'));
					string[] positions = cutMessage.Split((char) Constants.Comma);
					receivedPositionData.XPosition = positions[0];
					receivedPositionData.YPosition = positions[1];
					receivedPositionData.ZPosition = positions[2];
				}
				catch 
				{}
			}
			else
			{}

			return receivedPositionData;
		}

		public static List<ComPort> ResolveComPorts(List<string> availablePorts)
		{
			return availablePorts.Select(port => new ComPort {DisplayMember = port, ValueMamber = port}).ToList();
		}

	}
}
