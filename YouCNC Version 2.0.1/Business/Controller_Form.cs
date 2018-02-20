using Telerik.WinControls.UI;
using YouCNC_Version_2._0._1.Base;

namespace YouCNC_Version_2._0._1.Business
{
	internal static class ControllerForm
	{
		public static void ShowModalForm(RadForm form)
		{
			form.ShowDialog();
		}

		public static object ShowModalForm_ReturnValue(BaseReturnValueForm_ToolForm form)
		{
			form.ShowDialog();
		   	return form.ObjectToReturn();
		}

	}
}
