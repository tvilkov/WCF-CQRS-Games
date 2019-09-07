using System;
using System.Collections.Concurrent;
using System.Linq.Expressions;
using WindsorWCFGames.Handlers;

namespace WindsorWCFGames.Utils
{
	static class ReflectionHelper
	{
		static readonly ConcurrentDictionary<Type, Delegate> cachedInvokers = new ConcurrentDictionary<Type, Delegate>();

		public static Delegate CreateInvoker( Type requestType )
		{
			Delegate result;

			if ( cachedInvokers.TryGetValue( requestType, out result ) )
				return result;

			var handlerType = typeof( IRequestHandler<> ).MakeGenericType( requestType );
			var paramHandler = Expression.Parameter( handlerType, "handler" );
			var paramRequest = Expression.Parameter( requestType, "request" );

			result = Expression.Lambda(
				Expression.Call( paramHandler, handlerType.GetMethod( "Handle" ), paramRequest ),
				paramHandler,
				paramRequest ).Compile();

			cachedInvokers[requestType] = result;

			return result;
		}
	}
}
