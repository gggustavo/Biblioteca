using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Libro : Form
    {
        private readonly Controladora.Autor _ctrAutor = new Controladora.Autor();
        private readonly Controladora.Libro _ctrLibro = new Controladora.Libro();

        private Modelo.Libro _libro;

        public Libro()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            Aceptar.Enabled = false;
            Cancelar.Enabled = false;
            informacion.Enabled = false;
            autorBindingSource.DataSource = _ctrAutor.GetAll();
            libroBindingSource.DataSource = _ctrLibro.GetAll();

            base.OnLoad(e);
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Aceptar.Enabled = true;
            Cancelar.Enabled = true;
            modificar.Enabled = false;
            Agregar.Enabled = false;
            Eliminar.Enabled = false;
            informacion.Enabled = true;
            Titulo.Text = string.Empty;
            isbn.Text = string.Empty;
            paginas.Text = string.Empty;
            precio.Text = string.Empty;

            _libro = new Modelo.Libro();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (libroBindingSource.Current == null) return;

            _ctrLibro.Remove((Modelo.Libro) libroBindingSource.Current);
            ShowMessage();
            libroBindingSource.DataSource = _ctrLibro.GetAll();
        }

        private void ShowMessage()
        {
            MessageBox.Show(@"Se ejecuto correctamente", @"Informacion", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (libroBindingSource.Current == null) return;

            Aceptar.Enabled = true;
            modificar.Enabled = false;
            Cancelar.Enabled = true;
            Agregar.Enabled = false;
            Eliminar.Enabled = false;
            informacion.Enabled = true;
            _libro = (Modelo.Libro) libroBindingSource.Current;

            Titulo.Text = _libro.Titulo;
            isbn.Text = _libro.isbn;
            paginas.Text = _libro.Paginas.ToString();
            precio.Text = _libro.Precio.ToString();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                _libro.Titulo = Titulo.Text;
                _libro.isbn = isbn.Text;
                _libro.Paginas = Convert.ToInt32(paginas.Text);
                _libro.Precio = Convert.ToInt32(precio.Text);

                _libro.IdAutor = ((Modelo.Autor) autorBindingSource.Current).IdAutor;

                if (_libro.IdLibro != 0)
                {
                    _ctrLibro.Update(_libro);
                }
                else
                {
                    _ctrLibro.Add(_libro);
                }
                ShowMessage();
                libroBindingSource.DataSource = _ctrLibro.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            finally
            {
                Aceptar.Enabled = false;
                Cancelar.Enabled = false;
                Agregar.Enabled = true;
                Eliminar.Enabled = true;
                modificar.Enabled = true;
                informacion.Enabled = false;
                Titulo.Text = string.Empty;
                isbn.Text = string.Empty;
                paginas.Text = string.Empty;
                precio.Text = string.Empty;
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Aceptar.Enabled = false;
            Cancelar.Enabled = false;
            Agregar.Enabled = true;
            Eliminar.Enabled = true;
            modificar.Enabled = true;
            informacion.Enabled = false;
            Titulo.Text = string.Empty;
            isbn.Text = string.Empty;
            paginas.Text = string.Empty;
            precio.Text = string.Empty;
        }
    }
}
