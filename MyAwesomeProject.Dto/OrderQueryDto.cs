using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class OrderQueryDto : OrderDto
	{
		public int OrderId { get; set; }
	}
}
