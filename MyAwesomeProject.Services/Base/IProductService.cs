using MyAwesomeProject.Dto;
using System.Collections.Generic;

namespace MyAwesomeProject.Services
{
	public interface IProductService
	{
		ProductQueryDto GetById(int id);
		IEnumerable<ProductQueryDto> GetAll();
		object Create(ProductDto dto);
		void Update(int id, ProductDto dto);
		void Delete(int id);
	}
}
