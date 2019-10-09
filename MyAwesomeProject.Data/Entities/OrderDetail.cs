using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeProject.Data.Entities
{
	public class OrderDetail
	{
		[Key]
		public int OrderId { get; set; }
		public virtual Order Order { get; set; }
		[Key]
		public int ProductId { get; set; }
		public virtual Product Product { get; set; }
		[Required]
		public decimal UnitPrice { get; set; }
		[Required]
		public int Quantity { get; set; }
		[Required]
		public decimal Discount { get; set; }
	}
}
