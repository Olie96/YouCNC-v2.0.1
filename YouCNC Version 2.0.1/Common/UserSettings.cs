using Telerik.WinControls;
using Telerik.WinControls.Themes;

namespace YouCNC_Version_2._0._1.Common
{
	internal static class UserSettings
	{
		public static bool PlayAlertSounds { get; set; } = true;

		public static string ThemeName { get; set; } = "Office2010Black";

		public static VisualStudio2012DarkTheme VisualStudio2012DarkTheme = new VisualStudio2012DarkTheme();

		public static Office2013DarkTheme Office2013DarkTheme = new Office2013DarkTheme();

		public static Office2010BlackTheme Office2010BlackTheme = new Office2010BlackTheme();

		#region Methods

		public static void SaveUserSettings() 
		{
		
		}

		public static void LoadUserSettings() 
		{
		
		}

		#endregion

	}
}
