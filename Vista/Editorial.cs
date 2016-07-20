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
    public partial class Editorial : Form
    {
        Modelo.Editorial objetoeditorial;
        Controladora.Editorial ctreditorial = new Controladora.Editorial();

        public Editorial()
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
            objetoeditorial = new Modelo.Editorial();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoeditorial.Nombre = this.Nombre.Text;
                if (objetoeditorial.IdEditorial != 0)
                {
                    ctreditorial.Update(objetoeditorial);
                }
                else
                {
                    ctreditorial.Add(objetoeditorial);
                }                
                this.ShowMessage();
                this.editorialBindingSource.DataSource = ctreditorial.GetAll();
                
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

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (editorialBindingSource.Current != null)
            {
                ctreditorial.Remove((Modelo.Editorial)this.editorialBindingSource.Current);
                this.ShowMessage();
                this.editorialBindingSource.DataSource = ctreditorial.GetAll();
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (this.editorialBindingSource.Current != null)
            {
                this.Aceptar.Enabled = true;
                this.modificar.Enabled = false;
                this.Cancelar.Enabled = true;
                this.Agregar.Enabled = false;
                this.Eliminar.Enabled = false;
                this.informacion.Enabled = true;
                objetoeditorial = (Modelo.Editorial)(this.editorialBindingSource.Current);
                this.Nombre.Text = objetoeditorial.Nombre;
            }
            
        }

        private void ShowMessage()
        {
            MessageBox.Show("Se ejecuto correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
