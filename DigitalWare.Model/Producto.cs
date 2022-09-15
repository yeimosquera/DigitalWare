using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWare.Model
{
    public class Producto
    {
        [Key]
        public int PK_IdProducto { get; set; }
        [StringLength(150)]
        [Required]
        public string nombre { get; set; } = string.Empty;
        [Required]
        public decimal precio { get; set; }
        [Required]
        public int unidad { get; set; }


    }
}
