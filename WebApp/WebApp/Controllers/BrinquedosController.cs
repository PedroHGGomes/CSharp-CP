using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BrinquedosController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

    /// <summary>Lista todos os brinquedos.</summary>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Brinquedo>>> GetAll()
        => await _context.Brinquedos.AsNoTracking().ToListAsync();

    /// <summary>Obtém um brinquedo por ID.</summary>
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Brinquedo>> GetById(int id)
        => await _context.Brinquedos.FindAsync(id) is { } b ? Ok(b) : NotFound();

    /// <summary>Cria um novo brinquedo.</summary>
    [HttpPost]
    public async Task<ActionResult<Brinquedo>> Create([FromBody] Brinquedo brinquedo)
    {
        brinquedo.IdBrinquedo = 0; // garantimos que o BD vai gerar o ID
        _context.Brinquedos.Add(brinquedo);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = brinquedo.IdBrinquedo }, brinquedo);
    }

    /// <summary>Atualiza um brinquedo existente.</summary>
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] Brinquedo brinquedo)
    {
        if (id != brinquedo.IdBrinquedo)
            return BadRequest("ID do corpo difere do caminho.");

        var exists = await _context.Brinquedos.AnyAsync(b => b.IdBrinquedo == id);
        if (!exists) return NotFound();

        _context.Entry(brinquedo).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    /// <summary>Remove um brinquedo.</summary>
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var entity = await _context.Brinquedos.FindAsync(id);
        if (entity is null) return NotFound();

        _context.Brinquedos.Remove(entity);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}


