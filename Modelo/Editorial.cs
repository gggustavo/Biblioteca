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
         public Editorial()
        {
            this.Autor = new HashSet<Autor>();
        }
        
        public int IdEditorial { get; set; }
        public string Nombre { get; set; }
    
        public ICollection<Autor> Autor { get; set; }
    }
}
