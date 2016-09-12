using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Modelo
{
    public class Context : DbContext
    {
        public Context() : base("name=Default")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer(new ContextInitializer());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Editorial>().HasKey(_ => _.IdEditorial);
            modelBuilder.Entity<Autor>().HasKey(_ => _.IdAutor);
            modelBuilder.Entity<Libro>().HasKey(_ => _.IdLibro);

            modelBuilder.Entity<Libro>().HasRequired(_ => _.Autor);
            modelBuilder.Entity<Autor>().HasRequired(_ => _.Editorial);

            modelBuilder.Entity<Prestamo>().HasKey(_ => _.IdPrestamo)
                                           .HasRequired(_ => _.Libro);
            
        }


        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
    }
}
