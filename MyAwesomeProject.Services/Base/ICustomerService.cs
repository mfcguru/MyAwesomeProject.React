using MyAwesomeProject.Dto;
using System.Collections.Generic;

namespace MyAwesomeProject.Services
{
	public interface ICustomerService
	{
		CustomerQueryDto GetById(int id);
		IEnumerable<CustomerQueryDto> GetAll();
		object Create(CustomerDto dto);
		void Update(int id, CustomerDto dto);
		void Delete(int id);
	}
}
