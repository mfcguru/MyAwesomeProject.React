using MyAwesomeProject.Dto;
using System.Collections.Generic;

namespace MyAwesomeProject.Services
{
	public interface ISupplierService
	{
		SupplierQueryDto GetById(int id);
		IEnumerable<SupplierQueryDto> GetAll();
		object Create(SupplierDto dto);
		void Update(int id, SupplierDto dto);
		void Delete(int id);
	}
}
