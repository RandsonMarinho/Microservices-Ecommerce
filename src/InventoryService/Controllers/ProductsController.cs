using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class ProductsController : ControllerBase
{
    private readonly InventoryDbContext _db;
    public ProductsController(InventoryDbContext db) => _db = db;

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Product p)
    {
        p.Id = Guid.NewGuid();
        _db.Products.Add(p);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = p.Id }, p);
    }

    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<IActionResult> Get(Guid id)
    {
        var p = await _db.Products.FindAsync(id);
        if (p == null) return NotFound();
        return Ok(p);
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> List() => Ok(await _db.Products.ToListAsync());
}