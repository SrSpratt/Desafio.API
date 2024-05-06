using Desafio.API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Desafio.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProductList()
        {
            List<Product> list = new List< Product>();
            Product product = new Product(
               ID: 1,
               Name: "Produto 1");
            list.Add(product);
            return Ok(list);
        }

        [HttpPost]
        public ActionResult<Product> UpdateProduct([FromBody] Product product)
        {
            return Ok();
        }

    }

}
