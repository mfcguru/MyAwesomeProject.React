using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class ShipperDto
	{	
		
		[Required]
		public string ShipperName { get; set; }
		[Required]
		public string Phone { get; set; }
		
	}
}
