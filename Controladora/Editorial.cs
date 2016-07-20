using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class Editorial
    {

        public Editorial()
        {
        }

        public void Add(Modelo.Editorial entity)
        {
            using (var context = new Modelo.Context())
            {
                context.Editoriales.Add(entity);
                context.SaveChanges();   
            }                 
        }

        public void Remove(Modelo.Editorial entity)
        {
            using (var context = new Modelo.Context())
            {
                var value = context.Editoriales.Where(_ => _.IdEditorial == entity.IdEditorial).FirstOrDefault();
                context.Editoriales.Remove(value);
                context.SaveChanges();  
            }
              
        }

        public void Update(Modelo.Editorial entity)
        {
            using (var context = new Modelo.Context())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            
        }

        public List<Modelo.Editorial> GetAll()
        {
            using (var context = new Modelo.Context()) 
            {
                return context.Editoriales.ToList();
            }           
        }

    }
}
