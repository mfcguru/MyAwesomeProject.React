using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class EmployeeTerritoryDto
	{	
		public int EmployeeId { get; set; }
		public int TerritoryId { get; set; }
		public string TerritoryName { get; set; }
	}
}
