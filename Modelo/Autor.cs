namespace Modelo
{
    public class Autor
    {
        public int IdAutor { get; set; }
        public string Nombre { get; set; }
        public int IdEditorial { get; set; }
        public Editorial Editorial { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
