using System;
using YouCNC.Service;
using YouCNC_Version_2._0._1.Base;
using YouCNC_Version_2._0._1.Common;

namespace YouCNC_Version_2._0._1.Forms
{
	public partial class ComConnectionsForm : BaseToolForm
	{
		private readonly IService service;

		public ComConnectionsForm(IService service)
		{
			this.service = service;
			InitializeAll();
		}

		#region Initialization

		private void InitializeAll()
		{
			InitializeComponent();
			InitializeLookupData();
			InitializeButtons();
		}

		private void InitializeLookupData()
		{
			this.bsBaudRate.DataSource = GlobalValiables.GetBaudRates();
			this.bsComPorts.DataSource = Interpreter.ResolveComPorts(this.service.GetPortNames());
		}

		private void InitializeButtons()
		{
			if(GlobalValiables.SerialPort?.IsOpen ?? false)
			{
				this.rbConnect.Enabled = false;
				this.rbDisconnect.Enabled = true;
				this.rddlComPort.ReadOnly = true;
				this.rddlBaudRate.ReadOnly = true;
			}
			else
			{
				this.rbConnect.Enabled = true;
				this.rbDisconnect.Enabled = false;
				this.rddlComPort.ReadOnly = false;
				this.rddlBaudRate.ReadOnly = false;
			}
		}

		#endregion

		private void rbConnect_Click(object sender, EventArgs e)
		{
			GlobalValiables.SerialPort = this.service.SerialPortConnect((string)this.rddlComPort.SelectedValue, (int)this.rddlBaudRate.SelectedValue);
			DesktopHelper.ShowAlert((int)GlobalValiables.enum_desktop_alert.Positive, "Port opened", "Serial port successfully opened");
			InitializeButtons();
			Close();
		}

		private void rbDisconnect_Click(object sender, EventArgs e)
		{
			this.service.SerialPortDisconnect(GlobalValiables.SerialPort);
			DesktopHelper.ShowAlert((int)GlobalValiables.enum_desktop_alert.Warning, "Port closed", "Serial port successfully closed");
			InitializeButtons();
			Close();
		}
	}
}