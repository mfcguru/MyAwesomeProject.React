using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeProject.Data.Entities
{
	public class CustomerDemographic
	{
		[Key]
		public int CustomerId { get; set; }
		public virtual Customer Customer { get; set; }
		[Key]
		public int DemographicId { get; set; }
		public virtual Demographic Demographic { get; set; }
	}
}
