using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCarrera2.formulario.reportes
{
    public partial class frmReporteAsignaturas : Form
    {
        public frmReporteAsignaturas()
        {
            InitializeComponent();
        }

        private void frmReporteAsignaturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Asignaturas' Puede moverla o quitarla según sea necesario.
            this.asignaturasTableAdapter.Fill(this.dataSet1.Asignaturas);

            this.reportViewer1.RefreshReport();
        }
    }
}
