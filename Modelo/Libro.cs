using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
   
   public class Libro
    {
        public int IdLibro { get; set; }
        public int isbn { get; set; }
        public string Titulo { get; set; }
        public int Paginas { get; set; }
        public int Precio { get; set; }

        public Autor Autor { get; set; }
    }
}
