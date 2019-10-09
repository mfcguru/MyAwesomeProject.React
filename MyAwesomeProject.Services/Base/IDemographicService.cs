using MyAwesomeProject.Dto;
using System.Collections.Generic;

namespace MyAwesomeProject.Services
{
	public interface IDemographicService
	{
		DemographicQueryDto GetById(int id);
		IEnumerable<DemographicQueryDto> GetAll();
		object Create(DemographicDto dto);
		void Update(int id, DemographicDto dto);
		void Delete(int id);
	}
}
