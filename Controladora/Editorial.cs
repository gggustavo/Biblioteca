using Modelo;
using System.Collections.Generic;
using System.Linq;

namespace Controladora
{
    public class Editorial
    {
        public void Add(Modelo.Editorial entity)
        {
            using (var context = SingletonContext.GetContext())
            {
                context.Editoriales.Add(entity);
                context.SaveChanges();
            }
        }

        public void Remove(Modelo.Editorial entity)
        {
            using (var context = SingletonContext.GetContext())
            {
                var value = context.Editoriales.FirstOrDefault(_ => _.IdEditorial == entity.IdEditorial);
                context.Editoriales.Remove(value);
                context.SaveChanges();
            }
        }

        public void Update(Modelo.Editorial entity)
        {
            using (var context = SingletonContext.GetContext())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public IList<Modelo.Editorial> GetAll()
        {
            using (var context = SingletonContext.GetContext())
            {
                return context.Editoriales.ToList();
            }
        }
    }
}
