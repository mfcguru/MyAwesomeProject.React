using AutoMapper;
using MyAwesomeProject.BusinessRules;
using MyAwesomeProject.Data;
using MyAwesomeProject.Data.Entities;
using MyAwesomeProject.Dto;
using System.Collections.Generic;
using System.Linq;

namespace MyAwesomeProject.Services
{
	public class ProductService : IProductService
	{
		private DataContext context;

		public ProductService(DataContext db)
		{
			this.context = db;
		}

		public IEnumerable<ProductQueryDto> GetAll()
		{
			return Mapper.Map<IEnumerable<ProductQueryDto>>(context.Products);
		}

		public ProductQueryDto GetById(int id)
		{
			var entity = context.Products.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			return Mapper.Map<ProductQueryDto>(entity);
		}

		public object Create(ProductDto dto)
		{
			var entity = Mapper.Map<Product>(dto);
			context.Add(entity);
			context.SaveChanges();
			return entity.ProductId;
		}

		public void Update(int id, ProductDto dto)
		{
			var entity = context.Products.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}

			context.Update(Mapper.Map(dto, entity));
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			var entity = context.Products.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			context.Remove(entity);
			context.SaveChanges();
		}
	}
}
