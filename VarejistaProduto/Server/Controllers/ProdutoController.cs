using Microsoft.AspNetCore.Mvc;
using VarejistaProduto.Server.Repository.IRepository;

namespace VarejistaProduto.Server.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _dbProduto;

        public ProdutoController(IProdutoRepository dbProduto)
        {
            _dbProduto = dbProduto;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutosAsync()
        {
            IEnumerable<Produto> produtoLista = await _dbProduto.GetAllAsync();

            return Ok(produtoLista);
        }

        [HttpGet("{id:int}", Name = "GetProduto")]
        public async Task<ActionResult<Produto>> GetProdutoAsync(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var produto = await _dbProduto.GetAsync(u => u.Id == id);

            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);
        }


        [HttpPost]
        public async Task<ActionResult<Produto>> CreateProdutoAsync([FromBody] Produto produto)
        {
            if (produto == null)
            {
                return BadRequest();
            }

            await _dbProduto.CreateAsync(produto);
            return CreatedAtRoute("GetProduto", new { id = produto.Id }, produto);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteProdutoAsync(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var produto = await _dbProduto.GetAsync(u => u.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            await _dbProduto.RemoveAsync(produto);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateProdutoAsync(int id, [FromBody] Produto updateProduto) 
        {
            if (updateProduto == null || id != updateProduto.Id)
            {
                return BadRequest();
            }
            await _dbProduto.UpdateAsync(updateProduto);

            return NoContent();
        }

    }


}

