using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace EL
{
    [Table("Clientes")]
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        public String NombreCompleto { get; set; }

        [Required]
        public String Identificacion { get; set; }

        [Required]
        public String Celular { get; set; }

        [Required]
        public String Correo { get; set; }

        //pistas de auditoria 

        public int IdUsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuarioActualiza { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool Activo { get; set; }
    }
}
