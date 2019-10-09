using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class RegionDto
	{	
		
		[Required]
		public string RegionName { get; set; }
		
	}
}
