using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class DemographicDto
	{	
		
		[Required]
		public string DemographicName { get; set; }
		[Required]
		public string Description { get; set; }
		
	}
}
