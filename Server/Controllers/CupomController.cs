using Segundatentativa.Server;
using Microsoft.AspNetCore.Mvc;
using Segundatentativa.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class CupomController : Controller
{
    private readonly AppDbContext db;

    public CupomController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {   
  
            var cupons = await db.Cupons.ToListAsync();
            return Ok(cupons);
        
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var cupons = await db.Cupons.SingleOrDefaultAsync(x => x.Cupom_Id == Convert.ToInt32(id));
        return Ok(cupons);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Cupom cupom )
    {
        try
        {
            var novoCupom = new Cupom
            {   
                Desconto = cupom.Desconto,
            };

            db.Add(novoCupom);
            await db.SaveChangesAsync();//INSERT INTO
            return Ok();
        }
        catch (Exception e)
        {
            return View(e);
        }
    }

    [HttpPut]
    [Route("Update")]
    public async Task<IActionResult> Put([FromBody] Cupom cupom)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        db.Entry(cupom).State = EntityState.Modified;
        try
        {
            await db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            throw (ex);
        }
        return NoContent();
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<ActionResult<Cupom>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var cupom = await db.Cupons.FindAsync(id);
        if (cupom == null)
        {
            return NotFound();
        }
        db.Cupons.Remove(cupom);
        await db.SaveChangesAsync();
        return cupom;
    }
    private bool UserExists(int id)
    {
        return db.Cupons.Any(e => e.Cupom_Id == id);
    }
   
}