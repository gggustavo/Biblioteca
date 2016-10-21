using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Vista
{
    public partial class ReporteLibro : Form
    {
        private readonly Controladora.Libro _libro = new Controladora.Libro();

        public ReporteLibro()
        {
            InitializeComponent();
        }

        private void ReporteLibro_Load(object sender, EventArgs e)
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            var dataSource = new ReportDataSource
            {
                Name = "sourceLibro",
                Value = _libro.GetAll().ToList()
            };

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dataSource);

            reportViewer1.RefreshReport();
        }
    }
}
