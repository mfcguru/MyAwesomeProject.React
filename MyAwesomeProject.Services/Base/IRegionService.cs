using MyAwesomeProject.Dto;
using System.Collections.Generic;

namespace MyAwesomeProject.Services
{
	public interface IRegionService
	{
		RegionQueryDto GetById(int id);
		IEnumerable<RegionQueryDto> GetAll();
		object Create(RegionDto dto);
		void Update(int id, RegionDto dto);
		void Delete(int id);
	}
}
