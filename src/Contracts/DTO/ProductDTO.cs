using System;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WindsorWCFGames.Contracts.DTO 
{ 
	[DataContract(Name="product", Namespace="WindsorWCFGames.Contracts.DTO")]
	public partial class ProductDTO {

		[DataMember(Name="id")]    
		public System.Int64 Id { get; set; }			

		[DataMember(Name="title")]    
		public System.String Title { get; set; }			

		[DataMember(Name="description")]    
		public System.String Description { get; set; }			

		[DataMember(Name="supplyDate")]    
		public System.DateTime? SupplyDate { get; set; }			

		[DataMember(Name="rating")]    
		public System.Double Rating { get; set; }			

		[DataMember(Name="tags")]    
		public System.String[] Tags { get; set; }			

		[DataMember(Name="priceHistory")]    
		public System.Decimal[] PriceHistory { get; set; }			

	}
}
