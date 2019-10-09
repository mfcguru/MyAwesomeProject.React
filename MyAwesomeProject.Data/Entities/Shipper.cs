using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeProject.Data.Entities
{
	public class Shipper
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ShipperId { get; set; }
		[Required]
		public string ShipperName { get; set; }
		[Required]
		public string Phone { get; set; }
		public virtual ICollection<Order> Orders { get; set; }
	}
}
