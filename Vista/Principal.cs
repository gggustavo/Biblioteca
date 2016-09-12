using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var libro = new Libro();
            libro.ShowDialog();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var autor = new Autor();
            autor.ShowDialog();
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editorial = new Editorial();
            editorial.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
