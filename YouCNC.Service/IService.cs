using System.Collections.Generic;
using System.IO.Ports;


namespace YouCNC.Service
{
	public interface IService
	{
		List<string> GetPortNames();

		SerialPort SerialPortConnect(string portName, int baudRate);

		bool SerialPortDisconnect(SerialPort serialPort);

		void SendMessage(string message);

		#region Events

		void ErrorReceivedSubscribe(Service.ErrorEventHandler eventHandler);

		void ErrorReceivedUnsubscribe(Service.ErrorEventHandler eventHandler);

		void PositionsReceivedSubscribe(Service.PositionsReceivedEventHandler eventHandler);

		void PositionsReceivedUnsubscribe(Service.PositionsReceivedEventHandler eventHandler);

		void UnknownMessageReceivedSubscribe(Service.UnknownMessageEventHandler eventHandler);

		void UnknownMessageReceivedUnsubscribe(Service.UnknownMessageEventHandler eventHandler);

		void IdleReceivedSubscribe(Service.IdleEventHandler eventHandler);

		void IdleReceivedUnsubscribe(Service.IdleEventHandler eventHandler);

		void AlarmReceivedSubscribe(Service.AlarmEventHandler eventHandler);

		void AlarmReceivedUnsubscribe(Service.AlarmEventHandler eventHandler);

		#endregion
		
	}
}
