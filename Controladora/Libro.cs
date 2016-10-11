using Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Controladora
{
    public class Libro
    {
        public void Add(Modelo.Libro entity)
        {
            using (var context = SingletonContext.GetContext())
            {
                context.Libros.Add(entity);
                context.SaveChanges();
            }
        }

        public void Remove(Modelo.Libro entity)
        {
            using (var context = SingletonContext.GetContext())
            {
                var value = context.Libros.FirstOrDefault(_ => _.IdLibro == entity.IdLibro);
                context.Libros.Remove(value);
                context.SaveChanges();
            }
        }

        public void Update(Modelo.Libro entity)
        {
            using (var context = SingletonContext.GetContext())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Modelo.Libro> GetAll()
        {
            using (var context = SingletonContext.GetContext())
            {
                return context.Libros.Include("Autor").Include("Prestamo").ToList();
            }
        }

        public bool IsAvailable(int idLibro)
        {
            var context = SingletonContext.GetContext();
            var libro = context.Prestamos.FirstOrDefault(_ => _.IdLibro == idLibro);
            return libro != null && libro.Estado;
        }

        public IList<Modelo.Libro> GetAllByFilter(string isbn, string titulo) 
        {
            if (string.IsNullOrEmpty(isbn) && string.IsNullOrEmpty(titulo)) return SingletonContext.GetContext().Libros.Include("Autor").Include("Prestamo").ToList();
            
            Expression<System.Func<Modelo.Libro, bool>> predicateIsbn = libro => libro.isbn == isbn;
            Expression<System.Func<Modelo.Libro, bool>> predicateTitulo = libro => libro.Titulo == titulo;
            Expression<System.Func<Modelo.Libro, bool>> predicateFinal;
            
            if (!string.IsNullOrEmpty(isbn)) {
                predicateIsbn.And(predicateTitulo);
                predicateFinal = predicateIsbn;
            }
            else
                predicateFinal = predicateTitulo;
            
            var context = SingletonContext.GetContext();
            var libros = context.Libros.Where(predicateFinal).ToList();

            return libros;
        }
    }
}
