using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeProject.Data.Entities
{
	public class Demographic
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int DemographicId { get; set; }
		[Required]
		public string DemographicName { get; set; }
		[Required]
		public string Description { get; set; }
		public virtual ICollection<CustomerDemographic> CustomerDemographics { get; set; }
	}
}
