using MyAwesomeProject.Dto;
using System.Collections.Generic;

namespace MyAwesomeProject.Services
{
	public interface ITerritoryService
	{
		TerritoryQueryDto GetById(int id);
		IEnumerable<TerritoryQueryDto> GetAll();
		object Create(TerritoryDto dto);
		void Update(int id, TerritoryDto dto);
		void Delete(int id);
	}
}
