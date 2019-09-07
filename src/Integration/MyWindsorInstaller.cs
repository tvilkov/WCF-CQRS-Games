using Castle.Facilities.WcfIntegration;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using WindsorWCFGames.Services;
using WindsorWCFGames.Handlers;
using WindsorWCFGames.Handlers.Commands;
using WindsorWCFGames.Contracts;

namespace WindsorWCFGames.Integration
{
	public class MyWindsorInstaller : IWindsorInstaller
	{
		public void Install( IWindsorContainer container, IConfigurationStore store )
		{
			container.Register(				
				AllTypes.FromAssemblyContaining<ChangeAliasCommandHandler>()
				.BasedOn( typeof( IRequestHandler<> ) )
				.WithService.Base()
				.Configure( c => c.LifeStyle.Transient )
				);

			container.Register( Component.For<IRequestHandlerFactory>().ImplementedBy<RequestHandlerFactory>() );

			container.AddFacility<WcfFacility>();

			container.Register(
				Component.For<IBackendService>().ImplementedBy<BackendService>().Named( "WcfService" )
					.AsWcfService( new DefaultServiceModel() ) );

			container.Register(
				Component.For<IBackendService>().AsWcfClient(
					WcfEndpoint.FromConfiguration( "BackendService" ) ).Named( "WcfClient" ).LifeStyle.Transient );
		}
	}
}
