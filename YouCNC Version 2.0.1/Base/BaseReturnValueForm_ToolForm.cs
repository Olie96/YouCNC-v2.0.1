using Telerik.WinControls.UI;

namespace YouCNC_Version_2._0._1.Base
{
    public partial class BaseReturnValueForm_ToolForm : RadForm
    {
        public BaseReturnValueForm_ToolForm()
        {
            InitializeComponent();
        }

		public virtual object ObjectToReturn()
		{
			Close();
			return null;
		}

	}
}
