using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentasJones.Shared
{
    public class ApplicationUser : IdentityUser
    {
        public string NombreyApellido { get; set; }
        public string Apellido { get; set; }
        // buscar algún regex de cédula
        [RegularExpression("[0-9]{13}[A-Z]{1}",
            ErrorMessage = "El término introducido no corresponde la formato de cédula nicaragüense")]
        public string Cedula { get; set; }
        public virtual List<Venta> Ventas { get; set; }
        //public virtual List<Pago> Pagos { get; set; }
        public virtual List<Compra> Compras { get; set; }
    }
}
