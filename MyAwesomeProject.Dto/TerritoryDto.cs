using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class TerritoryDto
	{	
		
		[Required]
		public string TerritoryName { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		[Range(1, int.MaxValue)]
		public int RegionId { get; set; }
		
	}
}
