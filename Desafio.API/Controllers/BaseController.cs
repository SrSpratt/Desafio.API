using Desafio.API.AbstractModels;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.API.Controllers
{
    public abstract class BaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository _data;
        public BaseController(TRepository data)
        {
            _data = data;
        }


        //Recebe a lista completa de produtos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await _data.GetAll();
        }

        //Recebe um produto
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var product = await _data.Get(id);
            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        //Atualiza o registro de um produto
        [HttpPut("{id}")]
        public async Task<IActionResult> Put (int id, TEntity product)
        {
            if (id != product.ID)
                return BadRequest();
            await _data.Update(product);
            return NoContent();
        }


        //Registra um produto
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity product)
        {
            await _data.Add(product);
            return CreatedAtAction("Get", new { ID = product.ID }, product);
        }

        //Apaga umm produto
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var product = await _data.Delete(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

    }
}