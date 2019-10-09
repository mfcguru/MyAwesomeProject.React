using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class DemographicQueryDto : DemographicDto
	{
		public int DemographicId { get; set; }
	}
}
