using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWare.Model
{
    public class vColsultarFacturacion
    {
        [Key]
        public int PK_IdCliente { get; set; }        
        public string primer_nombre { get; set; } = string.Empty;      
        public string segundo_nombre { get; set; } = string.Empty;        
        public string primer_apellido { get; set; } = string.Empty;       
        public string segundo_apellido { get; set; } = string.Empty;
        public DateTime fecha_nacimiento { get; set; }
        public int cantidad { get; set; }        
        public int FK_IdFactura { get; set; }        
        public int FK_IdProducto { get; set; }        
        public DateTime fecha { get; set; }        
        public int FK_IdCliente { get; set; }
        public string nombre { get; set; } = string.Empty;        
        public decimal precio { get; set; }       
        public int unidad { get; set; }
    }
}
