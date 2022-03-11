using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiIngresoHitss.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string? Producto { get; set; }
        public string? Descripcion { get; set; }
        public double Valor { get; set; }
    }
}
