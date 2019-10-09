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
	public class OrderController : ControllerBase
	{
		private IOrderService OrderService;		

		public OrderController(IOrderService OrderService)
		{
			this.OrderService = OrderService;			
		}

		[HttpGet]
		public ActionResult<IEnumerable<OrderQueryDto>> Get()
		{
			return Ok(OrderService.GetAll());
		}

		[HttpGet("{id}")]
		public ActionResult<OrderQueryDto> Get(int id)
		{
			return Ok(OrderService.GetById(id));
		}

		[HttpPost]
		public IActionResult Post([FromBody] OrderDto dto)
		{
			return Ok(new { id = OrderService.Create(dto) });
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] OrderDto dto)
		{
			OrderService.Update(id, dto);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			OrderService.Delete(id);
			return Ok();
		}
	}
}
