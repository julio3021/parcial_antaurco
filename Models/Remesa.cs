using System.ComponentModel.DataAnnotations.Schema;

namespace parcial_antaurco.Models
{
    [Table("Remesa")]
    public class Remesa
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? NombreRemitente { get; set; }
    public string? NombreDestinatario { get; set; }
    public string? PaisOrigen { get; set; }
    public string? PaisDestino { get; set; }
    public decimal MontoEnviado { get; set; }
    public string? Moneda { get; set; } 
    public decimal TasaDeCambio { get; set; }
    public decimal MontoFinal { get; set; }
    public string? Estado { get; set; } 
}

}