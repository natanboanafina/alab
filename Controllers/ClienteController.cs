using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : Controller
{
    private readonly AlabDbContext _context;

    public ClienteController(AlabDbContext context) => _context = context;

    // GET
    [HttpGet(Name = "GetClientes")]
    public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes() => await _context.Clientes.ToListAsync();

    // GET BY ID
    [HttpGet("{id}", Name = "GetClienteById")]
    public async Task<ActionResult<Cliente>> GetCliente(int id)
    {
        var cliente = await _context.Clientes.FindAsync(id);

        if (cliente == null)
        {
            return NotFound();
        }

        return cliente;
    }

    // POST
    [HttpPost]
    public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();

        // return CreatedAtAction("GetCliente", new { id = cliente.ClienteId }, cliente);
        return Ok(await _context.Clientes.ToListAsync());
    }

    // Put
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCliente(int id, Cliente cliente)
    {
        if (id != cliente.ClienteId)
        {
            return BadRequest();
        }

        var existingCliente = await _context.Clientes.FindAsync(id);
        if (existingCliente == null)
        {
            return NotFound();
        }

        // Atualize manualmente as propriedades específicas que você deseja modificar
        existingCliente.Nome = cliente.Nome;
        existingCliente.Sobrenome = cliente.Sobrenome;
        existingCliente.DataNascimento = cliente.DataNascimento;
        existingCliente.CPF = cliente.CPF;
        existingCliente.EstadoCivil = cliente.EstadoCivil;
        existingCliente.Renda = cliente.Renda;
        existingCliente.Contrato = cliente.Contrato;
        // Atualize outras propriedades conforme necessário
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ClienteExists(id))
            {
                return NotFound();
            }
            else
            {
                throw new DbUpdateConcurrencyException("Ocorreu um erro de concorrência durante a atualização do cliente.");
            }
        }
        return NoContent();
    }

    // DELETE
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCliente(int id)
    {
        var cliente = await _context.Clientes.FindAsync(id);
        if (cliente == null)
        {
            return NotFound();
        }

        _context.Clientes.Remove(cliente);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool ClienteExists(int id)
    {
        return _context.Clientes.Any(e => e.ClienteId == id);
    }
}
