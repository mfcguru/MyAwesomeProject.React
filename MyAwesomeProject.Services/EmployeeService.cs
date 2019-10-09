using AutoMapper;
using MyAwesomeProject.BusinessRules;
using MyAwesomeProject.Data;
using MyAwesomeProject.Data.Entities;
using MyAwesomeProject.Dto;
using System.Collections.Generic;
using System.Linq;

namespace MyAwesomeProject.Services
{
	public class EmployeeService : IEmployeeService
	{
		private DataContext context;

		public EmployeeService(DataContext db)
		{
			this.context = db;
		}

		public IEnumerable<EmployeeQueryDto> GetAll()
		{
			return Mapper.Map<IEnumerable<EmployeeQueryDto>>(context.Employees);
		}

		public EmployeeQueryDto GetById(int id)
		{
			var entity = context.Employees.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			return Mapper.Map<EmployeeQueryDto>(entity);
		}

		public object Create(EmployeeDto dto)
		{
			var entity = Mapper.Map<Employee>(dto);
			context.Add(entity);
			context.SaveChanges();
			return entity.EmployeeId;
		}

		public void Update(int id, EmployeeDto dto)
		{
			var entity = context.Employees.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}

			context.Update(Mapper.Map(dto, entity));
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			var entity = context.Employees.Find(id);
			if (entity == null)
			{
				throw new NotFoundException();
			}
			context.Remove(entity);
			context.SaveChanges();
		}
	}
}
