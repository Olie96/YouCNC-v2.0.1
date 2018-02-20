using Telerik.WinControls;
using Telerik.WinControls.UI.Data;
using YouCNC_Version_2._0._1.Base;
using YouCNC_Version_2._0._1.Common;

namespace YouCNC_Version_2._0._1.Forms
{
    public partial class SystemSettingsForm : BaseToolForm
    {
        public SystemSettingsForm()
        {
	        InitializeAll(); 
        }

	    #region Initialization

	    private void InitializeAll()
	    {
		    InitializeComponent();
			InitializeThemeChooser();
		    InitializeLookup();
	    }

	    private void InitializeLookup()
	    {
			this.rtsAlertSound.Value = UserSettings.PlayAlertSounds;
	    }

	    #endregion

		private void radToggleSwitch1_ValueChanged(object sender, System.EventArgs e)
		{
			UserSettings.PlayAlertSounds = this.rtsAlertSound.Value;
		}

		#region Theme

		private void InitializeThemeChooser()
		{
			InitializeThemeItems();
			this.rddlTheme.SelectedIndexChanged += rddleTheme_SelectedIndexChanged;
			this.rddlTheme.SelectedText = UserSettings.ThemeName;
		}

		private void InitializeThemeItems()
		{
			this.rddlTheme.Items.Add("Default Control");
			this.rddlTheme.Items.Add(UserSettings.VisualStudio2012DarkTheme.ThemeName);
			this.rddlTheme.Items.Add(UserSettings.Office2010BlackTheme.ThemeName);
			this.rddlTheme.Items.Add(UserSettings.Office2013DarkTheme.ThemeName);
			
		}

		private void rddleTheme_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
		{
			ThemeResolutionService.ApplicationThemeName = this.rddlTheme.Text;
			UserSettings.ThemeName = this.rddlTheme.Text;
		}

		#endregion
	}
}
