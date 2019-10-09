using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class SupplierDto
	{	
		
		[Required]
		public string SupplierName { get; set; }
		[Required]
		public string ContactName { get; set; }
		[Required]
		public string ContactTitle { get; set; }
		[Required]
		public string Address { get; set; }
		[Required]
		public string City { get; set; }
		[Required]
		public string Region { get; set; }
		[Required]
		public string PostalCode { get; set; }
		[Required]
		public string Country { get; set; }
		[Required]
		public string Phone { get; set; }
		[Required]
		public string Fax { get; set; }
		[Required]
		public string WebsiteUrl { get; set; }
		
	}
}
