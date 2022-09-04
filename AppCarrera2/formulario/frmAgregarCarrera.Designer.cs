namespace AppCarrera.Formularios
{
    partial class frmAgregarCarrera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAgregarCarrera = new System.Windows.Forms.Label();
            this.lblNuevaCarrera = new System.Windows.Forms.Label();
            this.txtNuevaCarrera = new System.Windows.Forms.TextBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.rbt1erCuatrimestre = new System.Windows.Forms.RadioButton();
            this.rbt2doCuatrimestre = new System.Windows.Forms.RadioButton();
            this.lblAñoCursado = new System.Windows.Forms.Label();
            this.txtAñoCursado = new System.Windows.Forms.TextBox();
            this.dgvDetalleCarrera = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregarCarrera
            // 
            this.lblAgregarCarrera.AutoSize = true;
            this.lblAgregarCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarCarrera.Location = new System.Drawing.Point(414, 9);
            this.lblAgregarCarrera.Name = "lblAgregarCarrera";
            this.lblAgregarCarrera.Size = new System.Drawing.Size(324, 33);
            this.lblAgregarCarrera.TabIndex = 0;
            this.lblAgregarCarrera.Text = "AGREGAR CARRERA";
            // 
            // lblNuevaCarrera
            // 
            this.lblNuevaCarrera.AutoSize = true;
            this.lblNuevaCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCarrera.Location = new System.Drawing.Point(256, 52);
            this.lblNuevaCarrera.Name = "lblNuevaCarrera";
            this.lblNuevaCarrera.Size = new System.Drawing.Size(137, 24);
            this.lblNuevaCarrera.TabIndex = 1;
            this.lblNuevaCarrera.Text = "Nueva Carrera:";
            // 
            // txtNuevaCarrera
            // 
            this.txtNuevaCarrera.Location = new System.Drawing.Point(399, 56);
            this.txtNuevaCarrera.Name = "txtNuevaCarrera";
            this.txtNuevaCarrera.Size = new System.Drawing.Size(448, 20);
            this.txtNuevaCarrera.TabIndex = 0;
            this.txtNuevaCarrera.TextChanged += new System.EventHandler(this.txtNuevaCarrera_TextChanged);
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlan.Location = new System.Drawing.Point(487, 92);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(178, 25);
            this.lblPlan.TabIndex = 3;
            this.lblPlan.Text = "Plan de Estudio";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(317, 129);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(76, 24);
            this.lblMateria.TabIndex = 4;
            this.lblMateria.Text = "Materia:";
            // 
            // cboMateria
            // 
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(399, 132);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(448, 21);
            this.cboMateria.TabIndex = 1;
            this.cboMateria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuatrimestre.Location = new System.Drawing.Point(273, 173);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(120, 24);
            this.lblCuatrimestre.TabIndex = 6;
            this.lblCuatrimestre.Text = "Cuatrimestre:";
            // 
            // rbt1erCuatrimestre
            // 
            this.rbt1erCuatrimestre.AutoSize = true;
            this.rbt1erCuatrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt1erCuatrimestre.Location = new System.Drawing.Point(399, 175);
            this.rbt1erCuatrimestre.Name = "rbt1erCuatrimestre";
            this.rbt1erCuatrimestre.Size = new System.Drawing.Size(159, 22);
            this.rbt1erCuatrimestre.TabIndex = 2;
            this.rbt1erCuatrimestre.TabStop = true;
            this.rbt1erCuatrimestre.Text = "Primer Cuatrimestre";
            this.rbt1erCuatrimestre.UseVisualStyleBackColor = true;
            // 
            // rbt2doCuatrimestre
            // 
            this.rbt2doCuatrimestre.AutoSize = true;
            this.rbt2doCuatrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt2doCuatrimestre.Location = new System.Drawing.Point(564, 175);
            this.rbt2doCuatrimestre.Name = "rbt2doCuatrimestre";
            this.rbt2doCuatrimestre.Size = new System.Drawing.Size(174, 22);
            this.rbt2doCuatrimestre.TabIndex = 3;
            this.rbt2doCuatrimestre.TabStop = true;
            this.rbt2doCuatrimestre.Text = "Segundo Cuatrimestre";
            this.rbt2doCuatrimestre.UseVisualStyleBackColor = true;
            // 
            // lblAñoCursado
            // 
            this.lblAñoCursado.AutoSize = true;
            this.lblAñoCursado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoCursado.Location = new System.Drawing.Point(240, 219);
            this.lblAñoCursado.Name = "lblAñoCursado";
            this.lblAñoCursado.Size = new System.Drawing.Size(153, 24);
            this.lblAñoCursado.TabIndex = 9;
            this.lblAñoCursado.Text = "Año de Cursado:";
            // 
            // txtAñoCursado
            // 
            this.txtAñoCursado.Location = new System.Drawing.Point(399, 224);
            this.txtAñoCursado.Name = "txtAñoCursado";
            this.txtAñoCursado.Size = new System.Drawing.Size(159, 20);
            this.txtAñoCursado.TabIndex = 4;
            // 
            // dgvDetalleCarrera
            // 
            this.dgvDetalleCarrera.AllowUserToAddRows = false;
            this.dgvDetalleCarrera.AllowUserToDeleteRows = false;
            this.dgvDetalleCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCarrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colMateria,
            this.colAnioCursado,
            this.colCuatrimestre,
            this.colAcciones});
            this.dgvDetalleCarrera.Location = new System.Drawing.Point(64, 259);
            this.dgvDetalleCarrera.Name = "dgvDetalleCarrera";
            this.dgvDetalleCarrera.ReadOnly = true;
            this.dgvDetalleCarrera.Size = new System.Drawing.Size(1092, 303);
            this.dgvDetalleCarrera.TabIndex = 6;
            this.dgvDetalleCarrera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleCarrera_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colMateria
            // 
            this.colMateria.HeaderText = "Materia";
            this.colMateria.Name = "colMateria";
            this.colMateria.ReadOnly = true;
            this.colMateria.Width = 386;
            // 
            // colAnioCursado
            // 
            this.colAnioCursado.HeaderText = "Año de Cursado";
            this.colAnioCursado.Name = "colAnioCursado";
            this.colAnioCursado.ReadOnly = true;
            this.colAnioCursado.Width = 200;
            // 
            // colCuatrimestre
            // 
            this.colCuatrimestre.HeaderText = "Cuatrimestre";
            this.colCuatrimestre.Name = "colCuatrimestre";
            this.colCuatrimestre.ReadOnly = true;
            this.colCuatrimestre.Width = 300;
            // 
            // colAcciones
            // 
            this.colAcciones.HeaderText = "Acciones";
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.ReadOnly = true;
            this.colAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAcciones.Text = "Eliminar";
            this.colAcciones.UseColumnTextForButtonValue = true;
            this.colAcciones.Width = 162;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(724, 214);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 39);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(495, 621);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(138, 36);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(639, 621);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 36);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(351, 621);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(138, 36);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmAgregarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1207, 669);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDetalleCarrera);
            this.Controls.Add(this.txtAñoCursado);
            this.Controls.Add(this.lblAñoCursado);
            this.Controls.Add(this.rbt2doCuatrimestre);
            this.Controls.Add(this.rbt1erCuatrimestre);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.txtNuevaCarrera);
            this.Controls.Add(this.lblNuevaCarrera);
            this.Controls.Add(this.lblAgregarCarrera);
            this.Name = "frmAgregarCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Carrera";
            this.Load += new System.EventHandler(this.frmAgregarCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCarrera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarCarrera;
        private System.Windows.Forms.Label lblNuevaCarrera;
        private System.Windows.Forms.TextBox txtNuevaCarrera;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.RadioButton rbt1erCuatrimestre;
        private System.Windows.Forms.RadioButton rbt2doCuatrimestre;
        private System.Windows.Forms.Label lblAñoCursado;
        private System.Windows.Forms.TextBox txtAñoCursado;
        private System.Windows.Forms.DataGridView dgvDetalleCarrera;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnioCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuatrimestre;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
    }
}