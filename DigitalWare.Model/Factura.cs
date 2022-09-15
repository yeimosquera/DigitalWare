using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWare.Model
{
    public class Factura
    {
        [Key]
        public int PK_IdFactura { get; set; }
        [Required]
        public DateTime fecha { get; set; }
        [Required]
        public int FK_IdCliente { get; set; }
    }
}
