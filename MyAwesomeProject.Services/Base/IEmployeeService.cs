using MyAwesomeProject.Dto;
using System.Collections.Generic;

namespace MyAwesomeProject.Services
{
	public interface IEmployeeService
	{
		EmployeeQueryDto GetById(int id);
		IEnumerable<EmployeeQueryDto> GetAll();
		object Create(EmployeeDto dto);
		void Update(int id, EmployeeDto dto);
		void Delete(int id);
	}
}
