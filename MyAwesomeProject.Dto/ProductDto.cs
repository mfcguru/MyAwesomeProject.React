using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class ProductDto
	{	
		
		[Required]
		public string ProductName { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		[Range(1, int.MaxValue)]
		public int SupplierId { get; set; }
		[Required]
		[Range(1, int.MaxValue)]
		public int CategoryId { get; set; }
		[Required]
		public string QuantityPerUnit { get; set; }
		[Required]
		public decimal UnitPrice { get; set; }
		[Required]
		public int UnitsInStock { get; set; }
		[Required]
		public int ReorderLevel { get; set; }
		[Required]
		public bool Discontinued { get; set; }
		
	}
}
