using AppCarrera.Formularios;
using AppCarrera2.formulario.reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCarrera2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("¿DESEA CERRAR LA APLICACIÓN?", "ACCIONES", MessageBoxButtons.OKCancel, MessageBoxIcon.Question , MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void nuevaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCarrera agregarCarrera = new frmAgregarCarrera();
            agregarCarrera.ShowDialog();
        }

        private void nuevaAsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarAsignatura agregarAsignatura = new frmAgregarAsignatura();
            agregarAsignatura.ShowDialog();
        }

        private void verCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteCarrera reporteCarrera = new frmReporteCarrera();
            reporteCarrera.ShowDialog();
        }
    }
}
