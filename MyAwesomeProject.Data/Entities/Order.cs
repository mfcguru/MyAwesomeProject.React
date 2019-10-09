using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeProject.Data.Entities
{
	public class Order
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int OrderId { get; set; }
		[Required]
		public int CustomerId { get; set; }
		public virtual Customer Customer { get; set; }
		[Required]
		public int EmployeeId { get; set; }
		public virtual Employee Employee { get; set; }
		[Required]
		public DateTime OrderDate { get; set; }
		[Required]
		public DateTime RequiredDate { get; set; }
		[Required]
		public DateTime ShippedDate { get; set; }
		[Required]
		public int ShipperId { get; set; }
		public virtual Shipper Shipper { get; set; }
		[Required]
		public int Freight { get; set; }
		[Required]
		public string ShipName { get; set; }
		[Required]
		public string ShipAddress { get; set; }
		[Required]
		public string ShipCity { get; set; }
		[Required]
		public string ShipRegion { get; set; }
		[Required]
		public string ShipPostalCode { get; set; }
		[Required]
		public string ShipCountry { get; set; }
		public virtual ICollection<OrderDetail> OrderDetails { get; set; }
	}
}
