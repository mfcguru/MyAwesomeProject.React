using AutoMapper;
using MyAwesomeProject.BusinessRules;
using MyAwesomeProject.Data;
using MyAwesomeProject.Data.Entities;
using MyAwesomeProject.Dto;
using System.Collections.Generic;
using System.Linq;

namespace MyAwesomeProject.Services
{
	public class DemographicService : IDemographicService
	{
		private DataContext context;

		public DemographicService(DataContext db)
		{
			this.context = db;
		}

		public IEnumerable<DemographicQueryDto> GetAll()
		{
			return Mapper.Map<IEnumerable<DemographicQueryDto>>(context.Demographics);
		}

		public DemographicQueryDto GetById(int id)
		{
			var entity = context.Demographics.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			return Mapper.Map<DemographicQueryDto>(entity);
		}

		public object Create(DemographicDto dto)
		{
			var entity = Mapper.Map<Demographic>(dto);
			context.Add(entity);
			context.SaveChanges();
			return entity.DemographicId;
		}

		public void Update(int id, DemographicDto dto)
		{
			var entity = context.Demographics.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}

			context.Update(Mapper.Map(dto, entity));
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			var entity = context.Demographics.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			context.Remove(entity);
			context.SaveChanges();
		}
	}
}
