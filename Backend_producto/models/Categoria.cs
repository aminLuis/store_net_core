using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_producto.models
{
    public class Categoria
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string descripcion { get; set; }
    }
}
