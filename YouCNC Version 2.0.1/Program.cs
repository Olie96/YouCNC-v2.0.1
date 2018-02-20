using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Ninject;
using YouCNC.Service;
using YouCNC.Service.DiModule;
using YouCNC_Version_2._0._1.Forms;

namespace YouCNC_Version_2._0._1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		private static void Main()
        {
			var kernel = new StandardKernel(new DiModule());
			kernel.Load(Assembly.GetExecutingAssembly());
			var service = kernel.Get<IService>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(service));
        }  

	}
}
