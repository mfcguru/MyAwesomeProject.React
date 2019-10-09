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
	public class SupplierController : ControllerBase
	{
		private ISupplierService SupplierService;		

		public SupplierController(ISupplierService SupplierService)
		{
			this.SupplierService = SupplierService;			
		}

		[HttpGet]
		public ActionResult<IEnumerable<SupplierQueryDto>> Get()
		{
			return Ok(SupplierService.GetAll());
		}

		[HttpGet("{id}")]
		public ActionResult<SupplierQueryDto> Get(int id)
		{
			return Ok(SupplierService.GetById(id));
		}

		[HttpPost]
		public IActionResult Post([FromBody] SupplierDto dto)
		{
			return Ok(new { id = SupplierService.Create(dto) });
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] SupplierDto dto)
		{
			SupplierService.Update(id, dto);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			SupplierService.Delete(id);
			return Ok();
		}
	}
}
