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
	public class RegionController : ControllerBase
	{
		private IRegionService RegionService;		

		public RegionController(IRegionService RegionService)
		{
			this.RegionService = RegionService;			
		}

		[HttpGet]
		public ActionResult<IEnumerable<RegionQueryDto>> Get()
		{
			return Ok(RegionService.GetAll());
		}

		[HttpGet("{id}")]
		public ActionResult<RegionQueryDto> Get(int id)
		{
			return Ok(RegionService.GetById(id));
		}

		[HttpPost]
		public IActionResult Post([FromBody] RegionDto dto)
		{
			return Ok(new { id = RegionService.Create(dto) });
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] RegionDto dto)
		{
			RegionService.Update(id, dto);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			RegionService.Delete(id);
			return Ok();
		}
	}
}
