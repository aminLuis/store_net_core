using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_producto.models
{
 
    public class Producto
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "Varchar(255)")]
        public string descripcion { get; set; }

        [Required]
        [Column(TypeName = "Varchar(20)")]
        public double precio { get; set; }

        [Required]
        [Column(TypeName = "Varchar(10)")]
        public int cantidad { get; set; }

        [Required]
        public int categoriaId { get; set; }

        public Categoria? Categoria { get; set; }
    }
}
