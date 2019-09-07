using System;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WindsorWCFGames.Contracts.DTO 
{ 
	[DataContract(Name="order", Namespace="WindsorWCFGames.Contracts.DTO")]
	public partial class OrderDTO {

		[DataMember(Name="id")]    
		public System.Int32 Id { get; set; }			

		[DataMember(Name="date")]    
		public System.DateTime Date { get; set; }			

		[DataMember(Name="customer")]    
		public System.String Customer { get; set; }			

		[DataMember(Name="products")]    
		public ProductDTO[] Products { get; set; }			

		[DataMember(Name="comments")]    
		public System.String[] Comments { get; set; }			

	}
}
