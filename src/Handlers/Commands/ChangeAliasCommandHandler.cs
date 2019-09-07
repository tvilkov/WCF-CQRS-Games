using WindsorWCFGames.Contracts.Commands;
using WindsorWCFGames.Contracts;

namespace WindsorWCFGames.Handlers.Commands
{
	public sealed class ChangeAliasCommandHandler : IRequestHandler<ChangeAliasCommand>
	{
		public Response Handle( ChangeAliasCommand request )
		{
			//return new SingleValueResponse<string> { Value = request.NewAlias };
			return new ChangeAliasCommandResult
			{
				RequestedAlias = request.NewAlias,
				SetAlias = ( request.NewAlias ?? "" ).Trim()
			};
		}
	}
}
