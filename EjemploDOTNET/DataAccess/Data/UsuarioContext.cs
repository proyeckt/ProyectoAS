using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class UsuarioContext : DbContext
    {
        /*public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
        {
        }*/
        

        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseMySQL("server=localhost;database=ProyectoAS;user=takina;password=password");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Course>().ToTable("Course");
            //modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
        }
    }
}
