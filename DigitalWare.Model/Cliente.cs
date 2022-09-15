using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWare.Model
{
    public class Cliente
    {
        [Key]
        public int PK_IdCliente { get; set; }

        [StringLength(255)]
        public string primer_nombre { get; set; } = string.Empty;
        [StringLength(255)]
        public string segundo_nombre { get; set; } = string.Empty;
        [StringLength(255)]
        public string primer_apellido { get; set; } = string.Empty;
        [StringLength(255)]
        public string segundo_apellido { get; set; } = string.Empty;
       
        public DateTime fecha_nacimiento { get; set; } 

    }
}
