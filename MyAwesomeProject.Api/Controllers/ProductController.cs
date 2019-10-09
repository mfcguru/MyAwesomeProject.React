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
	public class ProductController : ControllerBase
	{
		private IProductService ProductService;		

		public ProductController(IProductService ProductService)
		{
			this.ProductService = ProductService;			
		}

		[HttpGet]
		public ActionResult<IEnumerable<ProductQueryDto>> Get()
		{
			return Ok(ProductService.GetAll());
		}

		[HttpGet("{id}")]
		public ActionResult<ProductQueryDto> Get(int id)
		{
			return Ok(ProductService.GetById(id));
		}

		[HttpPost]
		public IActionResult Post([FromBody] ProductDto dto)
		{
			return Ok(new { id = ProductService.Create(dto) });
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] ProductDto dto)
		{
			ProductService.Update(id, dto);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			ProductService.Delete(id);
			return Ok();
		}
	}
}
