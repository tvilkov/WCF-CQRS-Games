using System;
using System.Collections.Generic;
using System.Linq;

namespace WindsorWCFGames.Utils
{
	static class KnownTypesHelper
	{
		public static IEnumerable<Type> GetKnownTypes<TBase>()
		{
			var knownTypes = typeof( TBase ).Assembly.GetExportedTypes()
								.Where( x => typeof( TBase ).IsAssignableFrom( x ) && !x.IsGenericTypeDefinition );
			return knownTypes;
		}
	}
}
