using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindsorWCFGames.Domain
{
	public class Product
	{
		public long Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime? SupplyDate { get; set; }
		public double Rating { get; set; }
		public List<string> Tags { get; set; }
		public decimal[] PriceHistory { get; set; }
	}
}
