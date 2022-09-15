using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWare.Model
{
    public class DetalleFactura
    {
        [Key]
        public int PK_IdDetalle { get; set; }
        [Required]
        public int cantidad { get; set; }
        [Required]
        public int FK_IdFactura { get; set; }
        [Required]
        public int FK_IdProducto { get; set; }

    }
}
