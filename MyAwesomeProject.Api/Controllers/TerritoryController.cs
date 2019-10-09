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
	public class TerritoryController : ControllerBase
	{
		private ITerritoryService TerritoryService;		

		public TerritoryController(ITerritoryService TerritoryService)
		{
			this.TerritoryService = TerritoryService;			
		}

		[HttpGet]
		public ActionResult<IEnumerable<TerritoryQueryDto>> Get()
		{
			return Ok(TerritoryService.GetAll());
		}

		[HttpGet("{id}")]
		public ActionResult<TerritoryQueryDto> Get(int id)
		{
			return Ok(TerritoryService.GetById(id));
		}

		[HttpPost]
		public IActionResult Post([FromBody] TerritoryDto dto)
		{
			return Ok(new { id = TerritoryService.Create(dto) });
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] TerritoryDto dto)
		{
			TerritoryService.Update(id, dto);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			TerritoryService.Delete(id);
			return Ok();
		}
	}
}
