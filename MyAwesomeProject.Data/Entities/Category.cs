using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAwesomeProject.Data.Entities
{
	public class Category
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CategoryId { get; set; }
		[Required]
		public string CategoryName { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public string PhotoUrl { get; set; }
		public virtual ICollection<Product> Products { get; set; }
	}
}
