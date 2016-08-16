using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

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
