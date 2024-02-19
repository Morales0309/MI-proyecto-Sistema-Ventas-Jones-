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
        [RegularExpression(@"^\d{3}-\d{6}-\d{4}[A-Z]$", ErrorMessage = "El formato de la cédula no es válido.")]
        public string Cedula { get; set; }
        public virtual List<Venta> Ventas { get; set; }
        //public virtual List<Pago> Pagos { get; set; }
        public virtual List<Compra> Compras { get; set; }
    }
}
