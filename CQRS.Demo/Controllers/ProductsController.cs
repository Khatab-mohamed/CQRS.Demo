using CQRS.Demo.Entities;
using CQRS.Demo.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ISender _sender;

        public ProductsController(ISender sender) => _sender = sender;


        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _sender.Send(new GetProductsQuery());
            return Ok(products);

        }
    }
}
