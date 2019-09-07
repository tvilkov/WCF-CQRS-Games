#region [Usings]

using System;
using Castle.Windsor;
using Castle.Windsor.Installer;
using WindsorWCFGames.Services;
using WindsorWCFGames.Contracts.Commands;
using WindsorWCFGames.Contracts.Queries;
using WindsorWCFGames.Contracts;

#endregion

namespace WindsorWCFGames
{
	class Program
	{
		static volatile bool Stop;

		static void Main()
		{
			Console.CancelKeyPress += ( s, e ) => { Stop = true; };

			using ( var container = SetupContainer() )
			{
				var srv = container.Resolve<IBackendService>( "WcfClient" );
				var res1 = srv.Send<ChangeAliasCommandResult> ( new ChangeAliasCommand { EntityType="Credit", NewAlias="My Credit" } );
				//var res1 = srv.SendSingleValue<string>( new ChangeAliasCommand { EntityType = "Credit", NewAlias = "My Credit" } );
				var res2 = srv.Send<GetProductsQueryResult>( new GetProductsQuery { TitleFilter = "us" } );
			}

			Console.WriteLine( "FINISHED (Press ENTER to exit)" );
			Console.ReadLine();
		}

		static IWindsorContainer SetupContainer()
		{
			var container = new WindsorContainer().Install( FromAssembly.This() );
			return container;
		}
	}
}