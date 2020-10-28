using Segundatentativa.Server;
using Microsoft.AspNetCore.Mvc;
using Segundatentativa.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class PedidoProdutoController : Controller
{
    private readonly AppDbContext db;

    public PedidoProdutoController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {   
  
            var pedidosprodutos = await db.PedidosProdutos.ToListAsync();
            return Ok(pedidosprodutos);
        
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var pedidosprodutos = await db.PedidosProdutos.SingleOrDefaultAsync(x => x.PedidoProduto_Id == Convert.ToInt32(id));
        return Ok(pedidosprodutos);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] PedidoProduto PedidoProduto )
    {
        try
        {
            

            db.Add(PedidoProduto);
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
    public async Task<IActionResult> Put([FromBody] PedidoProduto pedidoproduto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        db.Entry(pedidoproduto).State = EntityState.Modified;
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
    public async Task<ActionResult<PedidoProduto>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var pp = await db.PedidosProdutos.FindAsync(id);
        if (pp == null)
        {
            return NotFound();
        }
        db.PedidosProdutos.Remove(pp);
        await db.SaveChangesAsync();
        return pp;
    }
    private bool UserExists(int id)
    {
        return db.PedidosProdutos.Any(e => e.PedidoProduto_Id == id);
    }
   
}