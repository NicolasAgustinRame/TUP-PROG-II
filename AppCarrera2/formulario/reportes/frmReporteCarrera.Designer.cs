namespace AppCarrera2.formulario.reportes
{
    partial class frmReporteCarrera
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sPMOSTRARINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDuniversidaDataSet = new AppCarrera2.formulario.reportes.BDuniversidaDataSet();
            this.sP_MOSTRAR_INFOTableAdapter = new AppCarrera2.formulario.reportes.BDuniversidaDataSetTableAdapters.SP_MOSTRAR_INFOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDuniversidaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPMOSTRARINFOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppCarrera2.formulario.reportes.rptCarreras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(677, 579);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sPMOSTRARINFOBindingSource
            // 
            this.sPMOSTRARINFOBindingSource.DataMember = "SP_MOSTRAR_INFO";
            this.sPMOSTRARINFOBindingSource.DataSource = this.bDuniversidaDataSet;
            // 
            // bDuniversidaDataSet
            // 
            this.bDuniversidaDataSet.DataSetName = "BDuniversidaDataSet";
            this.bDuniversidaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_MOSTRAR_INFOTableAdapter
            // 
            this.sP_MOSTRAR_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 581);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteCarrera";
            this.Text = "Reporte Carreras";
            this.Load += new System.EventHandler(this.frmReporteCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDuniversidaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BDuniversidaDataSet bDuniversidaDataSet;
        private System.Windows.Forms.BindingSource sPMOSTRARINFOBindingSource;
        private BDuniversidaDataSetTableAdapters.SP_MOSTRAR_INFOTableAdapter sP_MOSTRAR_INFOTableAdapter;
    }
}