using System;
using Castle.MicroKernel;
using WindsorWCFGames.Handlers;

namespace WindsorWCFGames.Integration
{
	sealed class RequestHandlerFactory : IRequestHandlerFactory
	{
		readonly IKernel m_Kernel;

		public RequestHandlerFactory( IKernel kernel )
		{
			m_Kernel = kernel;
		}

		public object CreateHandler( Type requestType )
		{
			var handlerType = typeof( IRequestHandler<> ).MakeGenericType( requestType );
			return m_Kernel.Resolve( handlerType );
		}
	}
}