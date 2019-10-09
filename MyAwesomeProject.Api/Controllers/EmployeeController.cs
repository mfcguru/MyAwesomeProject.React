using MyAwesomeProject.BusinessRules;
using MyAwesomeProject.Dto;
using MyAwesomeProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyAwesomeProject.Api.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		private IEmployeeService EmployeeService;		

		public EmployeeController(IEmployeeService EmployeeService)
		{
			this.EmployeeService = EmployeeService;			
		}

		[HttpGet]
		public ActionResult<IEnumerable<EmployeeQueryDto>> Get()
		{
			return Ok(EmployeeService.GetAll());
		}

		[HttpGet("{id}")]
		public ActionResult<EmployeeQueryDto> Get(int id)
		{
			return Ok(EmployeeService.GetById(id));
		}

		[HttpPost]
		public IActionResult Post([FromBody] EmployeeDto dto)
		{
			return Ok(new { id = EmployeeService.Create(dto) });
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] EmployeeDto dto)
		{
			EmployeeService.Update(id, dto);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			EmployeeService.Delete(id);
			return Ok();
		}
	}
}
