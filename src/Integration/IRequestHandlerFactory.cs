using System;

namespace WindsorWCFGames.Integration
{
	interface IRequestHandlerFactory
	{
		object CreateHandler( Type requestType );
	}
}
