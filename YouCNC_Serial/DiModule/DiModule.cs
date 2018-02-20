using Ninject;
using Ninject.Modules;

namespace YouCNC_Serial.DiModule
{
	public class DiModule : NinjectModule
	{
		public override void Load() 
		{
			IKernel kernel = this.Kernel;

			kernel?.Bind<ISerial>().To<Serial>();
		}
	}
}
