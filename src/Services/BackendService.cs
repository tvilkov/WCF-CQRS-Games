using WindsorWCFGames.Contracts;
using WindsorWCFGames.Integration;
using WindsorWCFGames.Utils;

namespace WindsorWCFGames.Services
{
	sealed class BackendService : IBackendService
	{
		private readonly IRequestHandlerFactory m_RequestHandlerFactory;

		public BackendService( IRequestHandlerFactory factory )
		{
			m_RequestHandlerFactory = factory;
		}

		public Response Send( Request request )
		{
			var handler = m_RequestHandlerFactory.CreateHandler( request.GetType() );
			var resp = (Response)ReflectionHelper.CreateInvoker( request.GetType() ).DynamicInvoke( handler, request );
			return resp;
		}
	}
}

