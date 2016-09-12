using System.Runtime.Serialization.Formatters;

namespace Modelo
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }

        public int IdLibro { get; set; }
        public Libro Libro { get; set; }

        public bool Estado { get; set; }

        public override string ToString()
        {
            return Estado ? "Prestado" : "Disponible";
        }
    }
}
