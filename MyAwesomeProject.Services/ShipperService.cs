using AutoMapper;
using MyAwesomeProject.BusinessRules;
using MyAwesomeProject.Data;
using MyAwesomeProject.Data.Entities;
using MyAwesomeProject.Dto;
using System.Collections.Generic;
using System.Linq;

namespace MyAwesomeProject.Services
{
	public class ShipperService : IShipperService
	{
		private DataContext context;

		public ShipperService(DataContext db)
		{
			this.context = db;
		}

		public IEnumerable<ShipperQueryDto> GetAll()
		{
			return Mapper.Map<IEnumerable<ShipperQueryDto>>(context.Shippers);
		}

		public ShipperQueryDto GetById(int id)
		{
			var entity = context.Shippers.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			return Mapper.Map<ShipperQueryDto>(entity);
		}

		public object Create(ShipperDto dto)
		{
			var entity = Mapper.Map<Shipper>(dto);
			context.Add(entity);
			context.SaveChanges();
			return entity.ShipperId;
		}

		public void Update(int id, ShipperDto dto)
		{
			var entity = context.Shippers.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}

			context.Update(Mapper.Map(dto, entity));
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			var entity = context.Shippers.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			context.Remove(entity);
			context.SaveChanges();
		}
	}
}
