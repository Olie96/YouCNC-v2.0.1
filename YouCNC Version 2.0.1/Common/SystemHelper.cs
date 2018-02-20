using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace YouCNC_Version_2._0._1.Common
{
	public static class SystemHelper
	{
		public static void InvokeMethod(RadForm form,MethodInvoker invoker)
		{
			var methodInvoker = new MethodInvoker(invoker);
			form.Invoke(methodInvoker);
		}

		public static void InvokeMethod(RadRibbonForm form,MethodInvoker invoker)
		{
			var methodInvoker = new MethodInvoker(invoker);
			form.Invoke(methodInvoker);
		}

		private delegate void SetTextCallback(Form f, Control ctrl, string text);
		public static void SetControlText(Form form, Control ctrl, string text)
		{
			if (ctrl.InvokeRequired)
			{
				var textCallback = new SetTextCallback(SetControlText);
				form.Invoke(textCallback, new object[] { form, ctrl, text });
			}
			else
			{
				ctrl.Text = text;
			}
		}

	}
}
