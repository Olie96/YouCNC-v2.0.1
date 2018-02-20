using System.Collections.Generic;
using System.IO.Ports;
using System.Reflection;
using Ninject;
using YouCNC_Serial;

namespace YouCNC.Service
{
    public class Service : IService
	{
		private readonly ISerial serial;
		public Service() 
		{
			var kernel = new StandardKernel(new YouCNC_Serial.DiModule.DiModule());
			kernel.Load(Assembly.GetExecutingAssembly());
			 this.serial = kernel.Get<ISerial>();
		}

		#region Methods

		public List<string> GetPortNames()
		{
			return this.serial.GetPortNames();
		}

		public SerialPort SerialPortConnect(string portName, int baudRate)
		{
			SerialPort serialport = this.serial.Connect(portName, baudRate);
			serialport.DataReceived += OnDataReceived;
			return serialport;
		}

		public bool SerialPortDisconnect(SerialPort serialPort)
		{
			serialPort.DataReceived -= OnDataReceived;
			return this.serial.Disconnect(serialPort);
		}

		public void SendMessage(string message) 
		{
		  this.serial.SendMessage(message);
		}

		#endregion

		#region Events

		private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			string message = ((SerialPort)sender).ReadExisting();

			if(Resolver.ResolveMessage(message) == GlobalVariables.enum_received_data_type.Alarm)
			{
				OnAlarmReceived(message);
			}
			if(Resolver.ResolveMessage(message) == GlobalVariables.enum_received_data_type.Positions)
			{
				OnPositionsReceived(message);
			}
			if(Resolver.ResolveMessage(message) == GlobalVariables.enum_received_data_type.Error)
			{
				OnErrorReceived(message);
			}
			if(Resolver.ResolveMessage(message) == GlobalVariables.enum_received_data_type.Idle)
			{
				OnIdleReceived(message);
			}
			else
			{
				OnUnknownMessageReceived(message);
			}
		}

		#region Positions Received

		
		public delegate void PositionsReceivedEventHandler(object source, string data);

		private event PositionsReceivedEventHandler PositionsReceived;
		
		protected virtual void OnPositionsReceived(string data)
		{
			PositionsReceived?.Invoke(this, data);
		}

		public void PositionsReceivedSubscribe(PositionsReceivedEventHandler eventHandler)
		{
			PositionsReceived += eventHandler;
		}

		public void PositionsReceivedUnsubscribe(PositionsReceivedEventHandler eventHandler)
		{
			PositionsReceived -= eventHandler;
		}

		#endregion

		#region Error Received
		
		public delegate void ErrorEventHandler(object source, string data);

		private event ErrorEventHandler ErrorReceived;
		
		protected virtual void OnErrorReceived(string data)
		{
			ErrorReceived?.Invoke(this, data);
		}

		public void ErrorReceivedSubscribe(ErrorEventHandler eventHandler)
		{
			ErrorReceived += eventHandler;
		}

		public void ErrorReceivedUnsubscribe(ErrorEventHandler eventHandler)
		{
			ErrorReceived -= eventHandler;
		}

		#endregion

		#region Idle

		public delegate void IdleEventHandler(object source, string data);

		private event IdleEventHandler IdleReceived;
		
		protected virtual void OnIdleReceived(string data)
		{
			IdleReceived?.Invoke(this, data);
		}

		public void IdleReceivedSubscribe(IdleEventHandler eventHandler)
		{
			IdleReceived += eventHandler;
		}

		public void IdleReceivedUnsubscribe(IdleEventHandler eventHandler)
		{
			IdleReceived -= eventHandler;
		}

		#endregion

		#region Idle

		public delegate void AlarmEventHandler(object source, string data);

		private event AlarmEventHandler AlarmReceived;
		
		protected virtual void OnAlarmReceived(string data)
		{
			AlarmReceived?.Invoke(this, data);
		}

		public void AlarmReceivedSubscribe(AlarmEventHandler eventHandler)
		{
			AlarmReceived += eventHandler;
		}

		public void AlarmReceivedUnsubscribe(AlarmEventHandler eventHandler)
		{
			AlarmReceived -= eventHandler;
		}

		#endregion

		#region Unknown message

		public delegate void UnknownMessageEventHandler(object source, string data);

		private event UnknownMessageEventHandler UnknownMessageReceived;
		
		protected virtual void OnUnknownMessageReceived(string data)
		{
			UnknownMessageReceived?.Invoke(this, data);
		}

		public void UnknownMessageReceivedSubscribe(UnknownMessageEventHandler eventHandler)
		{
			UnknownMessageReceived += eventHandler;
		}

		public void UnknownMessageReceivedUnsubscribe(UnknownMessageEventHandler eventHandler)
		{
			UnknownMessageReceived -= eventHandler;
		}

		#endregion

		#endregion

	}
}
