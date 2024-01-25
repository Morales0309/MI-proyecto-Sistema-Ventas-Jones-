using System.ComponentModel.DataAnnotations;

namespace SistemaVentasJones.Shared
{
    public class TasaCambioModel
    {
        [Key]
        public int Id { get; set; }
        public string Date { get; set; }
        public decimal Rate { get; set; }
    }
}
