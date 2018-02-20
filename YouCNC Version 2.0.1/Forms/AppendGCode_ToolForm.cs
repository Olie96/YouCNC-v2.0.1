using YouCNC_Version_2._0._1.Base;

namespace YouCNC_Version_2._0._1.Forms
{
    public partial class AppendGCode_ToolForm : BaseReturnValueForm_ToolForm
	{
        public AppendGCode_ToolForm()
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
			ObjectToReturn();		    
		}

		public override object ObjectToReturn()
		{
			Close();
			return (string)this.rcddCalculator.Value;	
		}

	}
}
