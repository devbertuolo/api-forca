using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalavrasController : ControllerBase
    {
        private readonly TodoContext _context;

        public PalavrasController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/Palavras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Palavra>>> GetPalavras()
        {
            return await _context.Palavras.ToListAsync(); // Retorna todas as palavras da tabela "PALAVRAS"
        }

        // GET: api/Palavras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Palavra>> GetPalavra(int id)
        {
            var palavra = await _context.Palavras.FindAsync(id);

            if (palavra == null)
            {
                return NotFound();
            }

            return palavra;
        }
    }
}