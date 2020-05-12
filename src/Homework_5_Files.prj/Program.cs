using Autofac;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			using(var container = RegisterServices.Create())
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(container.Resolve<MainForm>());
			}
			
		}
	}
}
