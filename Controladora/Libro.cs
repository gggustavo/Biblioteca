using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                var value = context.Libros.Where(_ => _.IdLibro == entity.IdLibro).FirstOrDefault();
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
                return context.Libros.Include("Autor").ToList();
            }           
        }

    }
}
