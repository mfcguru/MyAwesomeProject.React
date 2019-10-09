using MyAwesomeProject.Dto;
using System.Collections.Generic;

namespace MyAwesomeProject.Services
{
	public interface IOrderService
	{
		OrderQueryDto GetById(int id);
		IEnumerable<OrderQueryDto> GetAll();
		object Create(OrderDto dto);
		void Update(int id, OrderDto dto);
		void Delete(int id);
	}
}
