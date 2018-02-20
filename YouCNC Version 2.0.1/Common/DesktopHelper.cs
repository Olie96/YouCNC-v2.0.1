using System.Drawing;
using System.Media;
using Telerik.WinControls.UI;

namespace YouCNC_Version_2._0._1.Common
{
	public static class DesktopHelper
	{
		private static readonly RadDesktopAlert DesktopAlert = new RadDesktopAlert();

		public static void ShowAlert(int alertType, string caption, string message)
		{
			DesktopHelper.DesktopAlert.PlaySound = UserSettings.PlayAlertSounds;
			switch(alertType)
			{
				case (int)GlobalValiables.enum_desktop_alert.Positive:
				{
					DesktopHelper.DesktopAlert.SoundToPlay = SystemSounds.Hand;
					break;
				}
				case (int)GlobalValiables.enum_desktop_alert.Warning:
				{
					DesktopHelper.DesktopAlert.SoundToPlay = SystemSounds.Asterisk;
					DesktopHelper.DesktopAlert.Popup.AlertElement.BackColor = Color.Bisque;
					DesktopHelper.DesktopAlert.Popup.AlertElement.CaptionElement.CaptionGrip.BackColor = Color.DarkKhaki;
					break;
				}
				case (int)GlobalValiables.enum_desktop_alert.Error:
				{
					DesktopHelper.DesktopAlert.Popup.AlertElement.BackColor = Color.LightCoral;
					DesktopHelper.DesktopAlert.Popup.AlertElement.CaptionElement.CaptionGrip.BackColor = Color.IndianRed;
					DesktopHelper.DesktopAlert.SoundToPlay = SystemSounds.Asterisk;
					break;
				}
			}
			DesktopHelper.DesktopAlert.AutoCloseDelay = 3;
			DesktopHelper.DesktopAlert.Popup.AlertElement.NumberOfColors = 1;
			DesktopHelper.DesktopAlert.Popup.AlertElement.CaptionElement.CaptionGrip.NumberOfColors = 1;
			DesktopHelper.DesktopAlert.CaptionText = caption;
			DesktopHelper.DesktopAlert.ContentText = message;
			DesktopHelper.DesktopAlert.Show();
		}
	}
}