namespace Modelo
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string isbn { get; set; }
        public string Titulo { get; set; }
        public int Paginas { get; set; }
        public int Precio { get; set; }

        public int IdAutor { get; set; }
        public Autor Autor { get; set; }

        public Prestamo Prestamo { get; set; }
    }
}
