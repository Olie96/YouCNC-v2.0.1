namespace YouCNC.Service
{
	internal static class Resolver
	{
		public static GlobalVariables.enum_received_data_type ResolveMessage(string message)
		{
			var messageType = GlobalVariables.enum_received_data_type.None;
			if(message.Contains("Alarm"))
			{
				messageType = GlobalVariables.enum_received_data_type.Alarm;
			}
			if (message.Contains("WPos"))
			{
				messageType = GlobalVariables.enum_received_data_type.Positions;
			}
			else if(message.Contains("Idle"))
			{
				messageType = GlobalVariables.enum_received_data_type.Idle;
			}
			else { }
			return messageType;
		}
	}
}
