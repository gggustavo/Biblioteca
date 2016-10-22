using Modelo;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using Controladora.Extension;

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

        public void Remove(int idLibro)
        {
            using (var context = SingletonContext.GetContext())
            {
                var value = GetValueToRemove(idLibro, context);
                context.Entry(value).State = EntityState.Deleted;              
                context.SaveChanges();
            }
        }

        private static Modelo.Libro GetValueToRemove(int idLibro, Context context)
        {
            //Use Store Procedure
            var idParameter = new SqlParameter
            {
                ParameterName = "idLibro",
                Value = idLibro,
                Direction = ParameterDirection.Input
            };

            var value = context.Database
                                .SqlQuery<Modelo.Libro>("exec GetLibroById @idLibro ", idParameter)
                                .SingleOrDefault();
            return value;
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
