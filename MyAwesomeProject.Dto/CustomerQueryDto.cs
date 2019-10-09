using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class CustomerQueryDto : CustomerDto
	{
		public int CustomerId { get; set; }
	}
}
