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
	public class CustomerController : ControllerBase
	{
		private ICustomerService CustomerService;		

		public CustomerController(ICustomerService CustomerService)
		{
			this.CustomerService = CustomerService;			
		}

		[HttpGet]
		public ActionResult<IEnumerable<CustomerQueryDto>> Get()
		{
			return Ok(CustomerService.GetAll());
		}

		[HttpGet("{id}")]
		public ActionResult<CustomerQueryDto> Get(int id)
		{
			return Ok(CustomerService.GetById(id));
		}

		[HttpPost]
		public IActionResult Post([FromBody] CustomerDto dto)
		{
			return Ok(new { id = CustomerService.Create(dto) });
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] CustomerDto dto)
		{
			CustomerService.Update(id, dto);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			CustomerService.Delete(id);
			return Ok();
		}
	}
}
