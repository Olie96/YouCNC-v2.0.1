using YouCNC_Version_2._0._1.Base;
using YouCNC_Version_2._0._1.Common;

namespace YouCNC_Version_2._0._1.Forms
{
    public partial class Scheduler_ToolForm : BaseToolForm
    {
        public Scheduler_ToolForm()
		{
			InitializeAll();
		}

		#region Initialization

		private void InitializeAll() 
		{
			InitializeComponent();
		}

		#endregion

		private void radButton1_Click(object sender, System.EventArgs e)
		{
			DesktopHelper.ShowAlert((int)GlobalValiables.enum_desktop_alert.Warning, "Work Sceduled", "Your work will start at " + this.radTimePicker1.Text);
			Close();
		}
	}
}
