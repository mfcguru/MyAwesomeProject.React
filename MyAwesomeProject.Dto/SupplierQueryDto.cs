using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class SupplierQueryDto : SupplierDto
	{
		public int SupplierId { get; set; }
	}
}
