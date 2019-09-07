using System.Runtime.Serialization;
using WindsorWCFGames.Contracts.DTO;

namespace WindsorWCFGames.Contracts.Queries
{
	[DataContract( Namespace = "http:\\WindsorWCFGames" )]
	public sealed class GetProductsQuery : Request
	{
		[DataMember]
		public string TitleFilter { get; set; }
	}

	[DataContract( Namespace = "http:\\WindsorWCFGames" )]
	public sealed class GetProductsQueryResult : Response
	{
		[DataMember]
		public GetProductsQuery Query { get; set; }

		[DataMember]
		public ProductDTO[] Products { get; set; }
	}
}
