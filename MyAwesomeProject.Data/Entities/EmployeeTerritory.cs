using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeProject.Data.Entities
{
	public class EmployeeTerritory
	{
		[Key]
		public int EmployeeId { get; set; }
		public virtual Employee Employee { get; set; }
		[Key]
		public int TerritoryId { get; set; }
		public virtual Territory Territory { get; set; }
	}
}
