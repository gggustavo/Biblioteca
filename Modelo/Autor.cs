using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Autor
    {
        public Autor()
        {
            this.Libro = new HashSet<Libro>();
        }

        public int IdAutor { get; set; }
        public string Nombre { get; set; }
    
        public ICollection<Libro> Libro { get; set; }

        public int IdEditorial { get; set; }
        public Editorial Editorial { get; set; }

    }
}
