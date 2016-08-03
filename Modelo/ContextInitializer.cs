using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            CargarEditoriales(context);
            CargarAutores(context);

            base.Seed(context);
        }

        private void CargarEditoriales(Context context)
        {
            var editoriales = new List<Editorial>();
            var editorial = new Editorial
            {
                Nombre = "Bonum"
            };
            editoriales.Add(editorial);

            editorial = new Editorial
            {
                Nombre = "Botella al Mar"
            };
            editoriales.Add(editorial);

            editorial = new Editorial
            {
                Nombre = "Café de las ciudades"
            };
            editoriales.Add(editorial);

            editorial = new Editorial
            {
                Nombre = "Calibroscopio"
            };
            editoriales.Add(editorial);

            editorial = new Editorial
            {
                Nombre = "Catapulta"
            };
            editoriales.Add(editorial);

            editorial = new Editorial
            {
                Nombre = "Circcus"
            };
            editoriales.Add(editorial);

            editorial = new Editorial
            {
                Nombre = "Clasco"
            };
            editoriales.Add(editorial);

            editorial = new Editorial
            {
                Nombre = "Club House Publisher"
            };
            editoriales.Add(editorial);

            context.Editoriales.AddRange(editoriales);

            context.SaveChanges();
        }


        private void CargarAutores(Context context) 
        {
            var autores = new List<Autor>();

            var autor = new Autor
            {
                Nombre = "Pedro Mairal",
                IdEditorial = 1
            };

            autores.Add(autor);

            autor = new Autor
            {
                Nombre = "Lucio V. Mansilla",
                IdEditorial = 5
            };

            autores.Add(autor);

            autor = new Autor
            {
                Nombre = "Mario Kaplún",
                IdEditorial = 4
            };

            autores.Add(autor);

            autor = new Autor
            {
                Nombre = "Miguel Mazzeo",
                IdEditorial = 1
            };

            autores.Add(autor);

            autor = new Autor
            {
                Nombre = "Gerardo Ribas",
                IdEditorial = 2
            };

            autores.Add(autor);

            autor = new Autor
            {
                Nombre = "Néstor Sánchez",
                IdEditorial = 3
            };

            autores.Add(autor);

            autor = new Autor
            {
                Nombre = "Alberto Tabbia",
                IdEditorial = 2
            };

            autores.Add(autor);

            context.Autores.AddRange(autores);

            context.SaveChanges();
        }
    }
}
