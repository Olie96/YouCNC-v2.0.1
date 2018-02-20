using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using YouCNC.Service;
using YouCNC_Version_2._0._1.Business;
using YouCNC_Version_2._0._1.Common;

namespace YouCNC_Version_2._0._1.Forms
{
	public partial class MainForm : RadRibbonForm
	{
		#region Constants

		private const string OPENFILEFILTER = "Text Files (TXT)|*.txt|All files|*.*";
		private readonly IService service;

		#endregion

		public MainForm(IService service)
		{
			this.service = service;
			Focus();
			InitializeAll();
		}

		#region Initialization

		private void InitializeAll()
		{
			InitializeComponent();
			InitializeStartingTheme();

			InitializeLookupData();
			InitializeThreads();
			ShowSplashScreen();
		}

		private static void ShowSplashScreen()
		{
			var splash = new SplashScreen();
			splash.Show();
			Thread.Sleep(2000);
			splash.Close();
		}

		private static void InitializeLookupData() { }

		private static void RtbOneLineGCode_ToolTipTextNeeded(object sender, ToolTipTextNeededEventArgs e)
		{
			e.ToolTipText = "Press F12 to append";
		}

		private void InitializeThreads()
		{
			GlobalValiables.PositionThread.DoWork += PositionThread;
		}

		public static void InitializeStartingTheme()
		{
			ThemeResolutionService.ApplicationThemeName = UserSettings.ThemeName;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			InitializeEvents();
		}

		private void InitializeEvents()
		{
			this.rtbOneLineGCode.ToolTipTextNeeded += RtbOneLineGCode_ToolTipTextNeeded;
			this.service.PositionsReceivedSubscribe(OnPositionsReceived);
			this.service.IdleReceivedSubscribe(OnIdleReceived);
			this.service.AlarmReceivedSubscribe(OnAlarmReceived);
		}

		#endregion

		#region Buttons - Toolbar

		private void rbeOpenFile_Click(object sender, EventArgs e)
		{
			this.openFileDialog.Filter = MainForm.OPENFILEFILTER;
			this.openFileDialog.Title = "Select JOPPD file";
			this.openFileDialog.FileName = "";

			if(this.openFileDialog.ShowDialog() == DialogResult.OK)
			{
				GlobalValiables.GCode = File.ReadAllLines(this.openFileDialog.FileName).ToList();
				this.rlvGCode.Items.AddRange(GlobalValiables.GCode.ToArray());
				//this.rlvGCode.SelectedIndex = 158;
			}
			else { }
		}

		private void rbeSaveFile_Click(object sender, EventArgs e) { }

		#region Open form

		private void rbeComPorts_Click(object sender, EventArgs e)
		{
			ControllerForm.ShowModalForm(new ComConnectionsForm(this.service));
		}

		private void rbeFindButton_Click(object sender, EventArgs e)
		{
			ControllerForm.ShowModalForm(new Find());
		}

		private void rbeFindAndReplace_Click(object sender, EventArgs e)
		{
			ControllerForm.ShowModalForm(new FindAndReplace());
		}

		private void rbeSystemSettings_Click(object sender, EventArgs e)
		{
			ControllerForm.ShowModalForm(new SystemSettingsForm());
		}

		private void rbeScheduler_Click(object sender, EventArgs e)
		{
			ControllerForm.ShowModalForm(new Scheduler_ToolForm());
		}

		private void rbeConfigureGRBL_Click(object sender, EventArgs e)
		{
			ControllerForm.ShowModalForm(new ConfigureGrbl());
		}

		#endregion

		#endregion

		#region Buttons - CNC

		private void radButton16_Click(object sender, EventArgs e)
		{
			GlobalValiables.PositionThread.RunWorkerAsync();
		}

		private void rbUnlock_Click(object sender, EventArgs e)
		{
			this.service.SendMessage(GlobalValiables.GrblKeywords.UNLOCK);
			GlobalValiables.AlarmErrorThrown = false;
		}

		#endregion

		#region Threads - GRBL

		private void PositionThread(object sender, DoWorkEventArgs e)
		{
			while(true)
			{
				this.service.SendMessage("?");
				Thread.Sleep(80);
			}
		}

		#endregion

		#region Events - GRBL

		private static void OnPositionsReceived(object source, string data) { }

		private static void OnIdleReceived(object source, string data) { }

		private void OnAlarmReceived(object source, string data)
		{
			if(GlobalValiables.AlarmErrorThrown == false)
			{
				SystemHelper.InvokeMethod(this,
										delegate { DesktopHelper.ShowAlert((int)GlobalValiables.enum_desktop_alert.Error, "Alert", "GRBL has thrown alarm alert, plesa handle this error to proced with your project"); });
				GlobalValiables.AlarmErrorThrown = true;
			}
			else { }
		}

		#endregion

		#region Append One Line GCode

		private void rtbOneLineGCode_KeyDown(object sender, KeyEventArgs e)
		{
			switch(e.KeyValue)
			{
				case (int)Keys.F12:
				{
					this.rtbOneLineGCode.Text += (string)ControllerForm.ShowModalForm_ReturnValue(new AppendGCode_ToolForm());
					break;
				}
				case (int)Keys.Enter:
				{
					this.service.SendMessage(this.rtbOneLineGCode.Text);
					break;
				}
			}
		}

		#endregion

		
	}
}