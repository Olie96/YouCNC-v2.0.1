using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;

namespace YouCNC_Serial
{
	public class Serial : ISerial
	{

		private readonly SerialPort serialport;

		public Serial()
		{
			this.serialport = new SerialPort();
		}

		public List<string> GetPortNames()
		{
			return SerialPort.GetPortNames().ToList();
		}
		
		public SerialPort Connect(string portName, int baudRate)
		{
			try 
			{
				this.serialport.PortName = portName;
				this.serialport.BaudRate = baudRate;
				this.serialport.Open();

				return this.serialport.IsOpen
							? this.serialport
							: null;
			}
			catch
			{
				return null;
			}
		}

		public bool Disconnect(SerialPort serialPort) 
		{
			try 
			{
				if(serialPort.IsOpen)
				{
					serialPort.Close();		
				}
				else { }
				return serialPort.IsOpen == false;
			}
			catch
			{
				return false;
			}
		}

		public void SendMessage(string message) 
		{
			if(this.serialport.IsOpen) 
			{
			  this.serialport.Write(message);
			}
			else { }
		}
	}
}
