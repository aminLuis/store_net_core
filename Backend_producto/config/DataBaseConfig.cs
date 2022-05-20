using Microsoft.EntityFrameworkCore;
using Backend_producto.models;

namespace Backend_producto.config
{
    public class DataBaseConfig : DbContext
    {
        public DataBaseConfig(DbContextOptions<DataBaseConfig> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
