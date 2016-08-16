using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class Autor
    {

        public void Add(Modelo.Autor entity)
        {
            using (var context = SingletonContext.GetContext())
            {
                context.Autores.Add(entity);
                context.SaveChanges();   
            }                 
        }

        public void Remove(Modelo.Autor entity)
        {
            using (var context = SingletonContext.GetContext())
            {
                var value = context.Autores.Where(_ => _.IdAutor == entity.IdAutor).FirstOrDefault();
                context.Autores.Remove(value);
                context.SaveChanges();  
            }
              
        }

        public void Update(Modelo.Autor entity)
        {
            using (var context = SingletonContext.GetContext())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            
        }

        public IList<Modelo.Autor> GetAll()
        {
            using (var context = SingletonContext.GetContext()) 
            {
                return context.Autores.Include("Editorial").ToList();
            }           
        }

    }
}
