using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Editorial : Form
    {
        private Modelo.Editorial _editorial;
        private readonly Controladora.Editorial _ctrEditorial = new Controladora.Editorial();

        public Editorial()
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

            _editorial = new Modelo.Editorial();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                _editorial.Nombre = Nombre.Text;
                if (_editorial.IdEditorial != 0)
                {
                    _ctrEditorial.Update(_editorial);
                }
                else
                {
                    _ctrEditorial.Add(_editorial);
                }
                ShowMessage();
                editorialBindingSource.DataSource = _ctrEditorial.GetAll();
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

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (editorialBindingSource.Current == null) return;

            _ctrEditorial.Remove((Modelo.Editorial) editorialBindingSource.Current);
            ShowMessage();
            editorialBindingSource.DataSource = _ctrEditorial.GetAll();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (editorialBindingSource.Current == null) return;

            Aceptar.Enabled = true;
            modificar.Enabled = false;
            Cancelar.Enabled = true;
            Agregar.Enabled = false;
            Eliminar.Enabled = false;
            informacion.Enabled = true;
            _editorial = (Modelo.Editorial) editorialBindingSource.Current;
            Nombre.Text = _editorial.Nombre;
        }

        private static void ShowMessage()
        {
            MessageBox.Show(@"Se ejecuto correctamente", @"Informacion", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
