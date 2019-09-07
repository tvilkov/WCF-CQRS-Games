using WindsorWCFGames.Contracts.Queries;
using WindsorWCFGames.Contracts;
using WindsorWCFGames.Contracts.DTO;

namespace WindsorWCFGames.Handlers.Queries
{
	public sealed class GetProductsQueryHandler : IRequestHandler<GetProductsQuery>
	{
		public Response Handle( GetProductsQuery request )
		{
			return new GetProductsQueryResult
			{
				Query = request,
				Products = new ProductDTO[] { 
					new ProductDTO { Id = 1, Title="Product 1", Description="Description for product id", Rating = 10},
					new ProductDTO { Id = 1, Title="Product 1", Description="Description for product id", Rating = 10}
				}
			};
		}
	}
}
