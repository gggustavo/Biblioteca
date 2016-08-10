﻿using System;
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
        Modelo.Autor _autor;
        Controladora.Editorial _ctrEditorial = new Controladora.Editorial();
        Controladora.Autor _ctrAutor = new Controladora.Autor();

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
            this.editorialBindingSource.DataSource = _ctrEditorial.GetAll();
            this.autorBindingSource.DataSource = _ctrAutor.GetAll();
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

            _autor = new Modelo.Autor();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (autorBindingSource.Current != null)
            {
                _ctrAutor.Remove((Modelo.Autor)this.autorBindingSource.Current);
                this.ShowMessage();
                this.autorBindingSource.DataSource = _ctrAutor.GetAll();
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
                _autor = (Modelo.Autor)(this.autorBindingSource.Current);
                this.Nombre.Text = _autor.Nombre;
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                _autor.Nombre = this.Nombre.Text;
                _autor.IdEditorial = ((Modelo.Editorial)editorialBindingSource.Current).IdEditorial;
                if (_autor.IdAutor != 0)
                {
                    _ctrAutor.Update(_autor);
                }
                else
                {
                    _ctrAutor.Add(_autor);
                }
                this.ShowMessage();
                this.autorBindingSource.DataSource = _ctrAutor.GetAll();

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
