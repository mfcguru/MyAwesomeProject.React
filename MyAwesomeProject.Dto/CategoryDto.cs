using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class CategoryDto
	{	
		
		[Required]
		public string CategoryName { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public string PhotoUrl { get; set; }
		
	}
}
