using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeProject.Data.Entities
{
	public class Product
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ProductId { get; set; }
		[Required]
		public string ProductName { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public int SupplierId { get; set; }
		public virtual Supplier Supplier { get; set; }
		[Required]
		public int CategoryId { get; set; }
		public virtual Category Category { get; set; }
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
		public virtual ICollection<OrderDetail> OrderDetails { get; set; }
	}
}
