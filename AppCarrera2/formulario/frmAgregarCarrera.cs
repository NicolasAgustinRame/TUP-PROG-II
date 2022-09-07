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
            carrera = new Carrera();
            
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
            dgvDetalleCarrera.Rows.Clear();
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

            foreach (DetalleCarrera detc in carrera.DetallesCarreras)
            {
                if (detc.Materia.Nombre == cboMateria.Text)
                {
                    MessageBox.Show("La MATERIA: " + cboMateria.Text + "ya esta agregada!", "Control",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            Asignatura asignatura = new Asignatura();
            asignatura.CodAsignatura = Convert.ToInt32(cboMateria.SelectedValue);
            asignatura.Nombre = cboMateria.Text;
            int anioCursado = Convert.ToInt32(txtAñoCursado.Text);
            int cuatrimestre = 0;
            if (rbt1erCuatrimestre.Checked) cuatrimestre = 1;
            if (rbt2doCuatrimestre.Checked) cuatrimestre = 2;

            DetalleCarrera detallecarrera = new DetalleCarrera(anioCursado, cuatrimestre, asignatura);
            carrera.AgregarDetalle(detallecarrera);
            dgvDetalleCarrera.Rows.Add(new Object[] { asignatura.CodAsignatura, asignatura.Nombre, anioCursado, cuatrimestre });


        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtNuevaCarrera.Text == "")
            {
                MessageBox.Show("Ingresar nombre de CARRERA", "Control", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            oHelperDB.ConfirmarCarrera(carrera);
            MessageBox.Show("Carrera ingresada correctamente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limpiar();
            habilitar(false);
        }

        

        private void dgvDetalleCarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalleCarrera.CurrentCell.ColumnIndex == 4)
            {
                carrera.EliminarDetalle(dgvDetalleCarrera.CurrentCell.RowIndex);
                dgvDetalleCarrera.Rows.Remove(dgvDetalleCarrera.CurrentRow);
            }
        }

        private void txtNuevaCarrera_TextChanged(object sender, EventArgs e)
        {
            carrera.NombreTitulo = txtNuevaCarrera.Text;
        }
    }

}
