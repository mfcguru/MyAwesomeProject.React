using AutoMapper;
using MyAwesomeProject.BusinessRules;
using MyAwesomeProject.Data;
using MyAwesomeProject.Data.Entities;
using MyAwesomeProject.Dto;
using System.Collections.Generic;
using System.Linq;

namespace MyAwesomeProject.Services
{
	public class SupplierService : ISupplierService
	{
		private DataContext context;

		public SupplierService(DataContext db)
		{
			this.context = db;
		}

		public IEnumerable<SupplierQueryDto> GetAll()
		{
			return Mapper.Map<IEnumerable<SupplierQueryDto>>(context.Suppliers);
		}

		public SupplierQueryDto GetById(int id)
		{
			var entity = context.Suppliers.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			return Mapper.Map<SupplierQueryDto>(entity);
		}

		public object Create(SupplierDto dto)
		{
			var entity = Mapper.Map<Supplier>(dto);
			context.Add(entity);
			context.SaveChanges();
			return entity.SupplierId;
		}

		public void Update(int id, SupplierDto dto)
		{
			var entity = context.Suppliers.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}

			context.Update(Mapper.Map(dto, entity));
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			var entity = context.Suppliers.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			context.Remove(entity);
			context.SaveChanges();
		}
	}
}
