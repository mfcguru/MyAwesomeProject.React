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
	public class ShipperController : ControllerBase
	{
		private IShipperService ShipperService;		

		public ShipperController(IShipperService ShipperService)
		{
			this.ShipperService = ShipperService;			
		}

		[HttpGet]
		public ActionResult<IEnumerable<ShipperQueryDto>> Get()
		{
			return Ok(ShipperService.GetAll());
		}

		[HttpGet("{id}")]
		public ActionResult<ShipperQueryDto> Get(int id)
		{
			return Ok(ShipperService.GetById(id));
		}

		[HttpPost]
		public IActionResult Post([FromBody] ShipperDto dto)
		{
			return Ok(new { id = ShipperService.Create(dto) });
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] ShipperDto dto)
		{
			ShipperService.Update(id, dto);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			ShipperService.Delete(id);
			return Ok();
		}
	}
}
