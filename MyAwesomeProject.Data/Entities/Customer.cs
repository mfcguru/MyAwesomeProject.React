using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeProject.Data.Entities
{
	public class Customer
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CustomerId { get; set; }
		[Required]
		public string CustomerName { get; set; }
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
		public virtual ICollection<CustomerDemographic> CustomerDemographics { get; set; }
		public virtual ICollection<Order> Orders { get; set; }
	}
}
