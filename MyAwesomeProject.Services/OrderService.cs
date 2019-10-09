using AutoMapper;
using MyAwesomeProject.BusinessRules;
using MyAwesomeProject.Data;
using MyAwesomeProject.Data.Entities;
using MyAwesomeProject.Dto;
using System.Collections.Generic;
using System.Linq;

namespace MyAwesomeProject.Services
{
	public class OrderService : IOrderService
	{
		private DataContext context;

		public OrderService(DataContext db)
		{
			this.context = db;
		}

		public IEnumerable<OrderQueryDto> GetAll()
		{
			return Mapper.Map<IEnumerable<OrderQueryDto>>(context.Orders);
		}

		public OrderQueryDto GetById(int id)
		{
			var entity = context.Orders.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			return Mapper.Map<OrderQueryDto>(entity);
		}

		public object Create(OrderDto dto)
		{
			var entity = Mapper.Map<Order>(dto);
			context.Add(entity);
			context.SaveChanges();
			return entity.OrderId;
		}

		public void Update(int id, OrderDto dto)
		{
			var entity = context.Orders.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}

			context.Update(Mapper.Map(dto, entity));
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			var entity = context.Orders.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			context.Remove(entity);
			context.SaveChanges();
		}
	}
}
