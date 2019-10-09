using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeProject.Data.Entities
{
	public class Region
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int RegionId { get; set; }
		[Required]
		public string RegionName { get; set; }
		public virtual ICollection<Territory> Territories { get; set; }
	}
}
