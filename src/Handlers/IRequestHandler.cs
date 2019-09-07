using WindsorWCFGames.Contracts;

namespace WindsorWCFGames.Handlers
{
	public interface IRequestHandler<T> where T : Request
	{
		Response Handle( T request );
	}
}
