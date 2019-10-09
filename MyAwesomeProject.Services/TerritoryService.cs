using AutoMapper;
using MyAwesomeProject.BusinessRules;
using MyAwesomeProject.Data;
using MyAwesomeProject.Data.Entities;
using MyAwesomeProject.Dto;
using System.Collections.Generic;
using System.Linq;

namespace MyAwesomeProject.Services
{
	public class TerritoryService : ITerritoryService
	{
		private DataContext context;

		public TerritoryService(DataContext db)
		{
			this.context = db;
		}

		public IEnumerable<TerritoryQueryDto> GetAll()
		{
			return Mapper.Map<IEnumerable<TerritoryQueryDto>>(context.Territories);
		}

		public TerritoryQueryDto GetById(int id)
		{
			var entity = context.Territories.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			return Mapper.Map<TerritoryQueryDto>(entity);
		}

		public object Create(TerritoryDto dto)
		{
			var entity = Mapper.Map<Territory>(dto);
			context.Add(entity);
			context.SaveChanges();
			return entity.TerritoryId;
		}

		public void Update(int id, TerritoryDto dto)
		{
			var entity = context.Territories.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}

			context.Update(Mapper.Map(dto, entity));
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			var entity = context.Territories.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			context.Remove(entity);
			context.SaveChanges();
		}
	}
}
