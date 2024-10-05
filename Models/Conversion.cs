using System.ComponentModel.DataAnnotations.Schema;

namespace parcial_antaurco.Models
{
    [Table("Conversion")]
    public class Conversion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public decimal MontoOriginal { get; set; }
        public string? MonedaOriginal { get; set; } // USD o BTC
        public decimal MontoConvertido { get; set; }
        public string? MonedaConvertida { get; set; } // USD o BTC
        public DateTime Fecha { get; set; } // Fecha de la conversión
    }
}