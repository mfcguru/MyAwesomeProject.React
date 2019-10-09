using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class OrderDetailDto
	{	
		public int OrderId { get; set; }
		public int ProductId { get; set; }
		[Required]
		public decimal UnitPrice { get; set; }
		[Required]
		public int Quantity { get; set; }
		[Required]
		public decimal Discount { get; set; }
		public string ProductName { get; set; }
	}
}
