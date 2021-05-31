using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class UsuarioContext : DbContext
    {
        /*public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
        {
        }*/
        

        public DbSet<Item> Items { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<Tarjeta> Tarjetas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseMySQL("server=localhost;database=ProyectoAS;user=takina;password=password");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Item>().ToTable("Item");
            modelBuilder.Entity<Producto>().ToTable("Producto");
            modelBuilder.Entity<Inventario>().ToTable("Inventario");
            modelBuilder.Entity<Tarjeta>().ToTable("Tarjeta");
        }
    }
}
