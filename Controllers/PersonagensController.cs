using Microsoft.AspNetCore.Mvc;
using ProjetoDWA.Data;
using ProjetoDWA.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoDWA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonagensController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public PersonagensController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddPersonagem(Personagem personagem)
        {
            if (personagem == null) {
                return BadRequest("Dados Inválidos!");
            }

            _appDbContext.DWA.Add(personagem);
            await _appDbContext.SaveChangesAsync();

            return StatusCode(201, personagem);
        }

        [HttpGet]
        public async Task<ActionResult <IEnumerable<Personagem>>> GetPersonagem()
        {
            var personagens = await _appDbContext.DWA.ToListAsync();

            return Ok(personagens);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Personagem>> GetPersonagem(int id)
        {
            var personagem = await _appDbContext.DWA.FindAsync(id);

            if (personagem == null) {
                return NotFound("Personagem não encontrado!");
            }

            return Ok(personagem);
        }
    }
}