using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace WindsorWCFGames.Domain
{
	public class Order
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public string Customer { get; set; }
		public List<Product> Products { get; set; }
		public string[] Comments { get; set; }
	}
}
