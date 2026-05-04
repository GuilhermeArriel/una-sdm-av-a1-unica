using Microsoft.AspNetCore.Mvc;
using ValeAtivos324112890.Data;
using ValeAtivos324112890.Models;

namespace ValeAtivos324112890.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipamentosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EquipamentosController(AppDbContext context)
        {
            _context = context;
        }

        // POST
        [HttpPost]
        public IActionResult Criar(Equipamento equipamento)
        {
            _context.Equipamentos.Add(equipamento);
            _context.SaveChanges();

            return CreatedAtAction(nameof(BuscarPorId), new { id = equipamento.Id }, equipamento);
        }

        // GET LISTAR
        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _context.Equipamentos.ToList();
            return Ok(lista);
        }

        // GET BUSCAR ID
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            var equipamento = _context.Equipamentos.Find(id);

            if (equipamento == null)
                return NotFound("Equipamento não encontrado");

            return Ok(equipamento);
        }
    }
}