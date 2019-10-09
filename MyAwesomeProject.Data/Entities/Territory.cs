using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeProject.Data.Entities
{
	public class Territory
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int TerritoryId { get; set; }
		[Required]
		public string TerritoryName { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public int RegionId { get; set; }
		public virtual Region Region { get; set; }
		public virtual ICollection<EmployeeTerritory> EmployeeTerritories { get; set; }
	}
}
