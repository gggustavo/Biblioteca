namespace Modelo
{
    public class Editorial
    {
        public int IdEditorial { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
