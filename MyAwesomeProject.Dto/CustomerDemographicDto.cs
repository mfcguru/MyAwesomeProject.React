using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class CustomerDemographicDto
	{	
		public int CustomerId { get; set; }
		public int DemographicId { get; set; }
		public string DemographicName { get; set; }
	}
}
