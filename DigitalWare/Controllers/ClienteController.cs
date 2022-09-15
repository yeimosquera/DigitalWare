using DigitalWare.data;
using DigitalWare.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DigitalWare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly DataContext _context;

        public ClienteController(DataContext context)
        {
            _context = context;
        }


        // GET: api/<ClienteController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetCliente()
        {
            return await _context.tblCliente.ToListAsync();
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>>GetCliente(int id)
        {
           var cliente = await _context.tblCliente.FindAsync(id);
           if(cliente == null)
            {
                return NotFound();
            }

           return Ok(cliente);
        }

        // POST api/<ClienteController>
        [HttpPost]
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {
            _context.tblCliente.Add(cliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCliente", new { PK_IdCliente = cliente.PK_IdCliente }, cliente);
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, Cliente cliente)
        {
            if (cliente == null)
            {
                return NotFound();
            }
            _context.Entry(cliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }

            return NoContent();

        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var cliente = await _context.tblCliente.FindAsync(id);
            if (cliente == null) { return NotFound(); }

            _context.tblCliente.Remove(cliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        
    }
}
