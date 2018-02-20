using Ninject;
using Ninject.Modules;

namespace YouCNC.Service.DiModule
{
	public class DiModule : NinjectModule
	{
		public override void Load()
		{
			IKernel kernel = this.Kernel;

			kernel?.Bind<IService>().To<Service>();
		}
	}
}
