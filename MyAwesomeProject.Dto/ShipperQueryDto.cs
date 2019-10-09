using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class ShipperQueryDto : ShipperDto
	{
		public int ShipperId { get; set; }
	}
}
