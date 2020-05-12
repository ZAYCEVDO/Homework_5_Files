using Autofac;
using WindowsFormsApp1.Controls;

namespace WindowsFormsApp1
{
	public sealed class MainFormModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			base.Load(builder);

			builder
				.RegisterType<ProjectSettings>()
				.AsSelf()
				.SingleInstance();
			builder
				.RegisterType<LogControler>()
				.AsSelf()
				.SingleInstance();
			builder
				.RegisterType<PlayerControler>()
				.AsSelf()
				.SingleInstance();

		}
	}
}
