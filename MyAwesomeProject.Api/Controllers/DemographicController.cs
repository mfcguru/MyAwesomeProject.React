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
	public class DemographicController : ControllerBase
	{
		private IDemographicService DemographicService;		

		public DemographicController(IDemographicService DemographicService)
		{
			this.DemographicService = DemographicService;			
		}

		[HttpGet]
		public ActionResult<IEnumerable<DemographicQueryDto>> Get()
		{
			return Ok(DemographicService.GetAll());
		}

		[HttpGet("{id}")]
		public ActionResult<DemographicQueryDto> Get(int id)
		{
			return Ok(DemographicService.GetById(id));
		}

		[HttpPost]
		public IActionResult Post([FromBody] DemographicDto dto)
		{
			return Ok(new { id = DemographicService.Create(dto) });
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] DemographicDto dto)
		{
			DemographicService.Update(id, dto);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			DemographicService.Delete(id);
			return Ok();
		}
	}
}
