using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class Libro : Form
    {
        Controladora.Autor _ctrAutor = new Controladora.Autor();
        Controladora.Libro _ctrLibro = new Controladora.Libro();

        Modelo.Libro _libro;

        public Libro()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.Aceptar.Enabled = false;
            this.Cancelar.Enabled = false;
            this.informacion.Enabled = false;            
            this.autorBindingSource.DataSource = _ctrAutor.GetAll();
            this.libroBindingSource.DataSource = _ctrLibro.GetAll();

            base.OnLoad(e);
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.Aceptar.Enabled = true;
            this.Cancelar.Enabled = true;
            this.modificar.Enabled = false;
            this.Agregar.Enabled = false;
            this.Eliminar.Enabled = false;
            this.informacion.Enabled = true;
            this.Titulo.Text = string.Empty;
            this.isbn.Text = string.Empty;
            this.paginas.Text = string.Empty;
            this.precio.Text = string.Empty;

            _libro = new Modelo.Libro();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (libroBindingSource.Current != null)
            {
                _ctrLibro.Remove((Modelo.Libro)this.libroBindingSource.Current);
                this.ShowMessage();
                this.libroBindingSource.DataSource = _ctrLibro.GetAll();
            }
        }

        private void ShowMessage()
        {
            MessageBox.Show("Se ejecuto correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (this.libroBindingSource.Current != null)
            {
                this.Aceptar.Enabled = true;
                this.modificar.Enabled = false;
                this.Cancelar.Enabled = true;
                this.Agregar.Enabled = false;
                this.Eliminar.Enabled = false;
                this.informacion.Enabled = true;
                _libro = (Modelo.Libro)(this.libroBindingSource.Current);

                this.Titulo.Text = _libro.Titulo;
                this.isbn.Text = _libro.isbn;
                this.paginas.Text = _libro.Paginas.ToString();
                this.precio.Text = _libro.Precio.ToString();
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                _libro.Titulo = this.Titulo.Text;
                _libro.isbn = this.isbn.Text;
                _libro.Paginas = Convert.ToInt32(this.paginas.Text);
                _libro.Precio = Convert.ToInt32(this.precio.Text);

                _libro.IdAutor = ((Modelo.Autor)autorBindingSource.Current).IdAutor;

                if (_libro.IdLibro != 0)
                {
                    _ctrLibro.Update(_libro);
                }
                else
                {
                    _ctrLibro.Add(_libro);
                }
                this.ShowMessage();
                this.libroBindingSource.DataSource = _ctrLibro.GetAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                this.Aceptar.Enabled = false;
                this.Cancelar.Enabled = false;
                this.Agregar.Enabled = true;
                this.Eliminar.Enabled = true;
                this.modificar.Enabled = true;
                this.informacion.Enabled = false;
                this.Titulo.Text = string.Empty;
                this.isbn.Text = string.Empty;
                this.paginas.Text = string.Empty;
                this.precio.Text = string.Empty;

            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Aceptar.Enabled = false;
            this.Cancelar.Enabled = false;
            this.Agregar.Enabled = true;
            this.Eliminar.Enabled = true;
            this.modificar.Enabled = true;
            this.informacion.Enabled = false;
            this.Titulo.Text = string.Empty;
            this.isbn.Text = string.Empty;
            this.paginas.Text = string.Empty;
            this.precio.Text = string.Empty;
        }
    }
}
