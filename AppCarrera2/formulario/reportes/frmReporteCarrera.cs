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
    public partial class frmReporteCarrera : Form
    {
        public frmReporteCarrera()
        {
            InitializeComponent();
        }

        private void frmReporteCarrera_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDuniversidaDataSet.SP_MOSTRAR_INFO' Puede moverla o quitarla según sea necesario.
            this.sP_MOSTRAR_INFOTableAdapter.Fill(this.bDuniversidaDataSet.SP_MOSTRAR_INFO);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
