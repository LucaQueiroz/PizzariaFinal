using Segundatentativa.Server;
using Microsoft.AspNetCore.Mvc;
using Segundatentativa.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;



[ApiController]
[Route("[controller]")]
public class UsuarioController : Controller
{
    private readonly AppDbContext db;

    public UsuarioController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var usuarios = await db.Usuarios.ToListAsync();
        return Ok(usuarios);
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var usuario = await db.Usuarios.SingleOrDefaultAsync(x => x.Usuario_Id == Convert.ToInt32(id));
        return Ok(usuario);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Usuario usuario)
    {
        try
        {
            var novoUsuario = new Usuario
            {
                Nome = usuario.Nome,
                Sobrenome = usuario.Sobrenome,
                CPF = usuario.CPF,
                DataDeNascimento = usuario.DataDeNascimento,
                Endereço = usuario.Endereço,
                Email = usuario.Email,
                Senha = usuario.Senha,
                ConfirmarSenha = usuario.ConfirmarSenha,
                AcceptTerms = usuario.AcceptTerms
            };

            db.Add(novoUsuario);
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
    public async Task<IActionResult> Put([FromBody] Usuario usuario)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        db.Entry(usuario).State = EntityState.Modified;
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
    public async Task<ActionResult<Usuario>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var usuario = await db.Usuarios.FindAsync(id);
        if (usuario == null)
        {
            return NotFound();
        }
        db.Usuarios.Remove(usuario);
        await db.SaveChangesAsync();
        return usuario;
    }

    private bool UserExists(int id)
    {
        return db.Usuarios.Any(e => e.Usuario_Id == id);
    }

}