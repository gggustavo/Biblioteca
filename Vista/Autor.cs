using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Autor : Form
    {
        private Modelo.Autor _autor;
        private readonly Controladora.Editorial _ctrEditorial = new Controladora.Editorial();
        private readonly Controladora.Autor _ctrAutor = new Controladora.Autor();

        public Autor()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Aceptar.Enabled = false;
            Cancelar.Enabled = false;
            informacion.Enabled = false;
            editorialBindingSource.DataSource = _ctrEditorial.GetAll();
            autorBindingSource.DataSource = _ctrAutor.GetAll();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Aceptar.Enabled = true;
            Cancelar.Enabled = true;
            modificar.Enabled = false;
            Agregar.Enabled = false;
            Eliminar.Enabled = false;
            informacion.Enabled = true;
            Nombre.Text = string.Empty;

            _autor = new Modelo.Autor();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (autorBindingSource.Current == null) return;

            _ctrAutor.Remove((Modelo.Autor)autorBindingSource.Current);
            ShowMessage();
            autorBindingSource.DataSource = _ctrAutor.GetAll();
        }

        private static void ShowMessage()
        {
            MessageBox.Show(@"Se ejecuto correctamente", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (autorBindingSource.Current == null) return;

            Aceptar.Enabled = true;
            modificar.Enabled = false;
            Cancelar.Enabled = true;
            Agregar.Enabled = false;
            Eliminar.Enabled = false;
            informacion.Enabled = true;
            _autor = (Modelo.Autor)autorBindingSource.Current;
            Nombre.Text = _autor.Nombre;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                _autor.Nombre = Nombre.Text;
                _autor.IdEditorial = ((Modelo.Editorial)editorialBindingSource.Current).IdEditorial;
                if (_autor.IdAutor != 0)
                {
                    _ctrAutor.Update(_autor);
                }
                else
                {
                    _ctrAutor.Add(_autor);
                }
                ShowMessage();
                autorBindingSource.DataSource = _ctrAutor.GetAll();

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
                Nombre.Text = string.Empty;
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
            Nombre.Text = string.Empty;
        }
    }
}
