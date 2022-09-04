using AppCarrera2.datos;
using AppCarrera2.domino;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCarrera.Formularios
{
    public partial class frmAgregarCarrera : Form
    {
        DBHelper oHelperDB;
        Carrera carrera;
        public frmAgregarCarrera()
        {
            InitializeComponent();
            oHelperDB = new DBHelper();
            
        }

        private void frmAgregarCarrera_Load(object sender, EventArgs e)
        {
            cargarMateria();
            habilitar(false);
            limpiar();
            btnNuevo.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cargarMateria()
        {
            DataTable tabla = oHelperDB.consultarBD("SP_CONSULTAR_ASIGNATURAS");
            cboMateria.DataSource = tabla;
            cboMateria.ValueMember = tabla.Columns[0].ColumnName;
            cboMateria.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar(true);
        }

        private void limpiar()
        {
            txtNuevaCarrera.Text = "";
            txtAñoCursado.Text = "";
            cboMateria.SelectedValue = -1;
            rbt1erCuatrimestre.Checked = false;
            rbt2doCuatrimestre.Checked = false;
        }

        private void habilitar(bool v)
        {
            txtNuevaCarrera.Enabled = v;
            txtAñoCursado.Enabled = v;
            rbt1erCuatrimestre.Enabled = v;
            rbt2doCuatrimestre.Enabled = v;
            cboMateria.Enabled = v;
            btnAgregar.Enabled = v;
            btnAceptar.Enabled = v;
            btnNuevo.Enabled = !v;
            dgvDetalleCarrera.Enabled = v;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNuevaCarrera.Text == "")
            {
                MessageBox.Show("Ingresar el NOMBRE de la carrera", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboMateria.SelectedItem.Equals(String.Empty))
            {
                MessageBox.Show("Ingresar una MATERIA", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!rbt1erCuatrimestre.Checked && !rbt2doCuatrimestre.Checked)
            {
                MessageBox.Show("Seleccione un Cuatrimestre", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtAñoCursado.Text == "")
            {
                MessageBox.Show("Ingrese Año de Cursado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow row in dgvDetalleCarrera.Rows)
            {
                if (row.Cells["colMateria"].Value.ToString().Equals(cboMateria.Text))
                {
                    MessageBox.Show("La MATERIA: " + cboMateria.Text + "ya esta agregada!", "Control",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            DataRowView item = (DataRowView)cboMateria.SelectedItem;
            int codAsignatura = Convert.ToInt32(item.Row.ItemArray[0]);
            string nombre = item.Row.ItemArray[1].ToString();


            Asignatura asignatura = new Asignatura(codAsignatura, nombre);
            int anioCursado = int.Parse(txtAñoCursado.Text);
            int cuatrimestre = 0;
            if (rbt1erCuatrimestre.Checked) cuatrimestre = 1;
            if (rbt1erCuatrimestre.Checked) cuatrimestre = 2;

            DetalleCarrera detalle = new DetalleCarrera(anioCursado, cuatrimestre, asignatura);
            carrera.AgregarDet(detalle);
            dgvDetalleCarrera.Rows.Add(detalle.AnioCursado, detalle.Cuatrimestre, detalle.Materia);

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtNuevaCarrera.Text == "")
            {
                MessageBox.Show("Ingresar nombre de CARRERA", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            GuardarCarrera();


            limpiar();
            habilitar(false);
        }

        private void GuardarCarrera()
        {
            carrera.NombreTitulo = txtNuevaCarrera.Text;
            //if (oHelperDB.ConfirmarCarrera(carrera))
            {
                MessageBox.Show("Carrera registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDetalleCarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalleCarrera.CurrentCell.ColumnIndex == 4)
            {
                carrera.EliminarDet(dgvDetalleCarrera.CurrentCell.RowIndex);
                dgvDetalleCarrera.Rows.Remove(dgvDetalleCarrera.CurrentRow);
            }
        }

        private void txtNuevaCarrera_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}
