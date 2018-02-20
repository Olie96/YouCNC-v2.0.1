namespace YouCNC.Service
{
	internal static class GlobalVariables
	{
	   #region Enums

		public enum enum_received_data_type
		{
			None = 0,
			Positions = 1,
			Error = 2,
			Idle = 3,
			Alarm = 4
		}

		#endregion
	}
}
