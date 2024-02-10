using SistemaVentasJones.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasJones.Shared
{
    public class DetalleVenta
    {
        #region ATRIBUTOS/PROPIEDADES
        [Key]
        public int Id { get; set; }
        [Required]
        public int ArticuloId { get; set; }
        [ForeignKey("ArticuloId")]
        public Articulo Articulo { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, double.MaxValue, ErrorMessage = "Valor inválido")]
        public decimal Precio { get; set; }
        [Required]
        public int Cantidad { get; set; }

        public int Descuento { get; set; } = 0;
        public decimal SubTotal => Precio * Cantidad;
        public decimal SubtotalConDescuento => SubTotal * (Descuento / 100M);
        
        public decimal TotalFinal => SubTotal - SubtotalConDescuento;

        [Required]
        public int VentaId { get; set; }
        [ForeignKey("VentaId")]
        public Venta Venta { get; set; }

        //  conectando para hacer la devolucion
        public List<Retornos> Retorno { get; set; } = new List<Retornos>();

        #endregion
    }
}
