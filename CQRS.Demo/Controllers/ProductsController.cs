using CQRS.Demo.Commands;
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
    
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
           var productToReturn =  await _sender.Send(new AddProductCommand(product));
            return CreatedAtRoute("GetProductById",new {Id= productToReturn.Id },productToReturn);

        }

        [HttpGet("{id:int}", Name ="GetProductById")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _sender.Send(new GetProductByIdQuery(id));
            return Ok(product);

        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] Product product)
        {
            var productToReturn = await _sender.Send(new UpdateProductCommand(product));
            return CreatedAtRoute("GetProductById", new { Id = productToReturn.Id }, productToReturn);

        }
    }
}
