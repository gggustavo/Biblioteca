using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Context : DbContext
    {
        
        public Context() : base("name=Default")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer<Context>(new ContextInitializer());
        }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Editorial>().HasKey(_ => _.IdEditorial);
            modelBuilder.Entity<Autor>().HasKey(_ => _.IdAutor);
            modelBuilder.Entity<Libro>().HasKey(_ => _.IdLibro);
          
            modelBuilder.Entity<Libro>().HasRequired(_ => _.Autor).WithMany(_ => _.Libro);
            modelBuilder.Entity<Autor>().HasRequired(_ => _.Editorial).WithMany(_ => _.Autor);
        }

        

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }


    }
}
