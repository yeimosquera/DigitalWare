using DigitalWare.data;
using DigitalWare.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DigitalWare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {

        private readonly DataContext _context;

        public FacturaController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<FacturaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<vColsultarFacturacion>>> GetFactura()
        {
            return await _context.vColsultarFacturacion.ToListAsync();
        }

        // GET api/<FacturaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Factura>> GetFactura(int id)
        {
            var factura = await _context.tblFactura.FindAsync(id);
            if (factura == null)
            {
                return NotFound();
            }

            return Ok(factura);
        }

        // POST api/<FacturaController>
        [HttpPost]
        public async Task<ActionResult<Factura>> PostFactura(Factura factura)
        {
            _context.tblFactura.Add(factura);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFactura", new { PK_IdFactura = factura.PK_IdFactura }, factura);
        }

        // PUT api/<FacturaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFactura(int id, Factura factura)
        {
            if (factura == null)
            {
                return NotFound();
            }
            _context.Entry(factura).State = EntityState.Modified;

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

        // DELETE api/<FacturaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFactura(int id)
        {
            var factura = await _context.tblFactura.FindAsync(id);
            if (factura == null) { return NotFound(); }

            _context.tblFactura.Remove(factura);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
