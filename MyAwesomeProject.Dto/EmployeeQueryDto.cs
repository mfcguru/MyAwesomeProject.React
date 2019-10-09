using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class EmployeeQueryDto : EmployeeDto
	{
		public int EmployeeId { get; set; }
	}
}
