using AutoMapper;
using MyAwesomeProject.BusinessRules;
using MyAwesomeProject.Data;
using MyAwesomeProject.Data.Entities;
using MyAwesomeProject.Dto;
using System.Collections.Generic;
using System.Linq;

namespace MyAwesomeProject.Services
{
	public class RegionService : IRegionService
	{
		private DataContext context;

		public RegionService(DataContext db)
		{
			this.context = db;
		}

		public IEnumerable<RegionQueryDto> GetAll()
		{
			return Mapper.Map<IEnumerable<RegionQueryDto>>(context.Regions);
		}

		public RegionQueryDto GetById(int id)
		{
			var entity = context.Regions.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			return Mapper.Map<RegionQueryDto>(entity);
		}

		public object Create(RegionDto dto)
		{
			var entity = Mapper.Map<Region>(dto);
			context.Add(entity);
			context.SaveChanges();
			return entity.RegionId;
		}

		public void Update(int id, RegionDto dto)
		{
			var entity = context.Regions.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}

			context.Update(Mapper.Map(dto, entity));
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			var entity = context.Regions.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			context.Remove(entity);
			context.SaveChanges();
		}
	}
}
