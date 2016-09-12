using Modelo;

namespace Controladora
{
    public class Prestamo
    {
        public void Add(Modelo.Prestamo entity)
        {
            using (var context = SingletonContext.GetContext())
            {
                context.Prestamos.Add(entity);
                context.SaveChanges();
            }
        }
    }
}
