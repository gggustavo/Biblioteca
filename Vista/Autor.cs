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
    public partial class Autor : Form
    {
        Modelo.Editorial objetoeditorial;
        Modelo.Autor objetoautor;
        Controladora.Editorial ctreditorial = new Controladora.Editorial();
        Controladora.Autor ctrautor = new Controladora.Autor();

        public Autor()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Aceptar.Enabled = false;
            this.Cancelar.Enabled = false;
            this.informacion.Enabled = false;
            this.editorialBindingSource.DataSource = ctreditorial.GetAll();
            this.autorBindingSource.DataSource = ctrautor.GetAll();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.Aceptar.Enabled = true;
            this.Cancelar.Enabled = true;
            this.modificar.Enabled = false;
            this.Agregar.Enabled = false;
            this.Eliminar.Enabled = false;
            this.informacion.Enabled = true;
            this.Nombre.Text = string.Empty;
            objetoautor = new Modelo.Autor();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (autorBindingSource.Current != null)
            {
                ctrautor.Remove((Modelo.Autor)this.autorBindingSource.Current);
                this.ShowMessage();
                this.autorBindingSource.DataSource = ctrautor.GetAll();
            }
        }

        private void ShowMessage()
        {
            MessageBox.Show("Se ejecuto correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (this.autorBindingSource.Current != null)
            {
                this.Aceptar.Enabled = true;
                this.modificar.Enabled = false;
                this.Cancelar.Enabled = true;
                this.Agregar.Enabled = false;
                this.Eliminar.Enabled = false;
                this.informacion.Enabled = true;
                objetoautor = (Modelo.Autor)(this.autorBindingSource.Current);
                this.Nombre.Text = objetoautor.Nombre;
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoautor.Nombre = this.Nombre.Text;
                objetoautor.IdEditorial = ((Modelo.Editorial)editorialBindingSource.Current).IdEditorial;
                if (objetoautor.IdAutor != 0)
                {
                    ctrautor.Update(objetoautor);
                }
                else
                {
                    ctrautor.Add(objetoautor);
                }
                this.ShowMessage();
                this.autorBindingSource.DataSource = ctrautor.GetAll();

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
                this.Nombre.Text = string.Empty;
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
            this.Nombre.Text = string.Empty;
        }
    }
}
