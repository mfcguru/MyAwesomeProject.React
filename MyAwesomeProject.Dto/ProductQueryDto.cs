using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class ProductQueryDto : ProductDto
	{
		public int ProductId { get; set; }
	}
}
