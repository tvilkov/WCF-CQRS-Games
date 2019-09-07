using System.Runtime.Serialization;

namespace WindsorWCFGames.Contracts.Commands
{
	[DataContract( Namespace = "http:\\WindsorWCFGames" )]
	public sealed class ChangeAliasCommand : Request
	{
		[DataMember]
		public string EntityType { get; set; }
		[DataMember]
		public string NewAlias { get; set; }
	}

	[DataContract( Namespace = "http:\\WindsorWCFGames" )]
	public sealed class ChangeAliasCommandResult: Response
	{
		[DataMember]
		public string RequestedAlias { get; set; }
		[DataMember]
		public string SetAlias { get; set; }
	} 
}
