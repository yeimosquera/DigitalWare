using DigitalWare.data;
using DigitalWare.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DigitalWare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductoController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<ProductoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProducto()
        {
            return await _context.tblProducto.ToListAsync();
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> GetProducto(int id)
        {
            var producto = await _context.tblProducto.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }

            return Ok(producto);
        }

        // POST api/<ProductoController>
        [HttpPost]
        public async Task<ActionResult<Producto>> PostCliente(Producto producto)
        {
            _context.tblProducto.Add(producto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducto", new { PK_IdProducto = producto.PK_IdProducto }, producto);
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducto(int id, Producto producto)
        {
            if (producto == null)
            {
                return NotFound();
            }
            _context.Entry(producto).State = EntityState.Modified;

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

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            var producto = await _context.tblProducto.FindAsync(id);
            if (producto == null) { return NotFound(); }

            _context.tblProducto.Remove(producto);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
