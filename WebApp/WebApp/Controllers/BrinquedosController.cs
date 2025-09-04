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

    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Brinquedo>>> GetAll()
        => await _context.Brinquedos.AsNoTracking().ToListAsync();

   
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Brinquedo>> GetById(int id)
        => await _context.Brinquedos.FindAsync(id) is { } b ? Ok(b) : NotFound();

    
    [HttpPost]
    public async Task<ActionResult<Brinquedo>> Create([FromBody] Brinquedo brinquedo)
    {
        brinquedo.IdBrinquedo = 0; 
        _context.Brinquedos.Add(brinquedo);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = brinquedo.IdBrinquedo }, brinquedo);
    }


    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] Brinquedo dto)
    {
        if (id != dto.IdBrinquedo)
            return BadRequest("ID do corpo difere do caminho.");

        
        var entity = await _context.Brinquedos.FindAsync(id);
        if (entity is null) return NotFound();

        
        entity.NomeBrinquedo = dto.NomeBrinquedo;
        entity.TipoBrinquedo = dto.TipoBrinquedo;
        entity.Classificacao = dto.Classificacao;
        entity.Tamanho = dto.Tamanho;
        entity.Preco = dto.Preco;

        await _context.SaveChangesAsync();
        return NoContent();
    }



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


