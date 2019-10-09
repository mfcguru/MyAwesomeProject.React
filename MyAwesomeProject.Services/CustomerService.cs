using AutoMapper;
using MyAwesomeProject.BusinessRules;
using MyAwesomeProject.Data;
using MyAwesomeProject.Data.Entities;
using MyAwesomeProject.Dto;
using System.Collections.Generic;
using System.Linq;

namespace MyAwesomeProject.Services
{
	public class CustomerService : ICustomerService
	{
		private DataContext context;

		public CustomerService(DataContext db)
		{
			this.context = db;
		}

		public IEnumerable<CustomerQueryDto> GetAll()
		{
			return Mapper.Map<IEnumerable<CustomerQueryDto>>(context.Customers);
		}

		public CustomerQueryDto GetById(int id)
		{
			var entity = context.Customers.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			return Mapper.Map<CustomerQueryDto>(entity);
		}

		public object Create(CustomerDto dto)
		{
			var entity = Mapper.Map<Customer>(dto);
			context.Add(entity);
			context.SaveChanges();
			return entity.CustomerId;
		}

		public void Update(int id, CustomerDto dto)
		{
			var entity = context.Customers.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}

			context.Update(Mapper.Map(dto, entity));
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			var entity = context.Customers.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			context.Remove(entity);
			context.SaveChanges();
		}
	}
}
