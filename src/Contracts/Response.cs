using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using WindsorWCFGames.Utils;

namespace WindsorWCFGames.Contracts
{
	[DataContract( Namespace = "http:\\WindsorWCFGames" )]
	[KnownType( "GetKnownTypes" )]
	public class Response
	{
		static readonly Response m_Empty = new Response();
		public static Response Empty { get { return m_Empty; } }

		public static IEnumerable<Type> GetKnownTypes()
		{
			Type[] primitives = new[] { typeof( string ), typeof( int ), typeof( double ), typeof( DateTime ), typeof( int? ), typeof( double? ), typeof( DateTime? ) };
			foreach ( var type in primitives )
				yield return typeof( SingleValueResponse<> ).MakeGenericType( type );
			foreach ( var knownType in KnownTypesHelper.GetKnownTypes<Response>() )
				yield return knownType;
		}
	}

	[DataContract( Namespace = "http:\\WindsorWCFGames" )]
	public class SingleValueResponse<T> : Response
	{
		[DataMember]
		public T Value { get; set; }
	}
}
