using DigitalWare.data;
using DigitalWare.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DigitalWare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleFacturaController : ControllerBase
    {
        private readonly DataContext _context;

        public DetalleFacturaController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<DetalleFacturaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleFactura>>> GetDetalleFactura()
        {
            return await _context.tblDetalleFactura.ToListAsync();
        }

        // GET api/<DetalleFacturaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleFactura>> GetDetalleFactura(int id)
        {
            var dFactura = await _context.tblDetalleFactura.FindAsync(id);
            if (dFactura == null)
            {
                return NotFound();
            }

            return Ok(dFactura);
        }

        // POST api/<DetalleFacturaController>
        [HttpPost]
        public async Task<ActionResult<Producto>> PostDetalleFactura(DetalleFactura detalleFactura)
        {
            _context.tblDetalleFactura.Add(detalleFactura);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalleFactura", new { PK_IdDetalle = detalleFactura.PK_IdDetalle }, detalleFactura);
        }

        // PUT api/<DetalleFacturaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalleFacturao(int id, DetalleFactura detalleFactura)
        {
            if (detalleFactura == null)
            {
                return NotFound();
            }
            _context.Entry(detalleFactura).State = EntityState.Modified;

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

        // DELETE api/<DetalleFacturaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalleFactura(int id)
        {
            var dfactura = await _context.tblDetalleFactura.FindAsync(id);
            if (dfactura == null) { return NotFound(); }

            _context.tblDetalleFactura.Remove(dfactura);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
