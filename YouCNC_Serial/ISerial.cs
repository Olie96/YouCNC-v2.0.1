using System.Collections.Generic;
using System.IO.Ports;

namespace YouCNC_Serial
{
	public interface ISerial
	{
		List<string> GetPortNames();

	    SerialPort Connect(string portName, int baudRate);

		bool Disconnect(SerialPort serialPort);

		void SendMessage(string message);
	}
}
