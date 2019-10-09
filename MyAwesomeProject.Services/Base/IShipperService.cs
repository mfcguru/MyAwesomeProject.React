using MyAwesomeProject.Dto;
using System.Collections.Generic;

namespace MyAwesomeProject.Services
{
	public interface IShipperService
	{
		ShipperQueryDto GetById(int id);
		IEnumerable<ShipperQueryDto> GetAll();
		object Create(ShipperDto dto);
		void Update(int id, ShipperDto dto);
		void Delete(int id);
	}
}
