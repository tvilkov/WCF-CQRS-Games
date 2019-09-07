using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using WindsorWCFGames.Utils;

namespace WindsorWCFGames.Contracts
{
	[DataContract( Namespace = "http:\\WindsorWCFGames" )]
	[KnownType( "GetKnownTypes" )]
	public abstract class Request
	{
		public static IEnumerable<Type> GetKnownTypes()
		{
			return KnownTypesHelper.GetKnownTypes<Request>();
		}
	}
}
