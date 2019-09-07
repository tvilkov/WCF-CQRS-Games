using System.ServiceModel;
using WindsorWCFGames.Contracts;

namespace WindsorWCFGames.Contracts
{
	[ServiceContract( Namespace = "http:\\WindsorWCFGames" )]
	public interface IBackendService
	{
		[OperationContract]
		Response Send( Request request );
	}

	public static class BackendServiceExtensions
	{
		public static TResponse Send<TResponse>( this IBackendService backend, Request request ) where TResponse : Response
		{
			return (TResponse)backend.Send( request );
		}

		public static TValue SendSingleValue<TValue>( this IBackendService backend, Request request )
		{
			return ( (SingleValueResponse<TValue>)backend.Send( request ) ).Value;
		}
	}
}

