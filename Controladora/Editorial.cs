using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class Editorial
    {
        Modelo.ModelContainer container;

        public Editorial()
        {
            container = Modelo.ModelContainer.GetInstance();
        }

        public void Add(Modelo.Editorial entity)
        {
            container.Editoriales.Add(entity);
            container.SaveChanges();        
        }

        public void Remove(Modelo.Editorial entity)
        {
            container.Editoriales.Remove(entity);
            container.SaveChanges();    
        }

        public void Update(Modelo.Editorial entity)
        {
            container.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            container.SaveChanges();
        }

        public List<Modelo.Editorial> GetAll()
        {
            return container.Editoriales.ToList();
        }

    }
}
