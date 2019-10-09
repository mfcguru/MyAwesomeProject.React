using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class OrderDto
	{	
		
		[Required]
		[Range(1, int.MaxValue)]
		public int CustomerId { get; set; }
		[Required]
		[Range(1, int.MaxValue)]
		public int EmployeeId { get; set; }
		[Required]
		public DateTime OrderDate { get; set; }
		[Required]
		public DateTime RequiredDate { get; set; }
		[Required]
		public DateTime ShippedDate { get; set; }
		[Required]
		[Range(1, int.MaxValue)]
		public int ShipperId { get; set; }
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
		[Required]
		public IEnumerable<OrderDetailDto> OrderDetails { get; set; }
	}
}
