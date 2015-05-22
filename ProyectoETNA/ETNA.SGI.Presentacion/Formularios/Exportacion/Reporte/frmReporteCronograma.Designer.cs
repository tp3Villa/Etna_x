namespace ETNA.SGI.Presentacion.Formularios.Exportacion.Reporte
{
    partial class frmReporteCronograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteCronograma));
            this.eReporteCronograma = new System.Windows.Forms.BindingSource(this.components);
            this.eCronogramaDespachoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.eReporteCronograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCronogramaDespachoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eReporteCronograma
            // 
            this.eReporteCronograma.DataSource = typeof(ETNA.SGI.Bussiness.ReglasNegocio.Exportacion.BTablas);
            // 
            // eCronogramaDespachoBindingSource
            // 
            this.eCronogramaDespachoBindingSource.DataSource = typeof(ETNA.SGI.Entity.Entidades.Exportacion.eCronogramaDespacho);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cronograma";
            reportDataSource1.Value = this.eCronogramaDespachoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ETNA.SGI.Presentacion.Formularios.Exportacion.Reporte.CronogramaDespacho.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(730, 594);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmReporteCronograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 594);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReporteCronograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Despacho";
            this.Load += new System.EventHandler(this.frmReporteCronograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eReporteCronograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCronogramaDespachoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource eReporteCronograma;
        private System.Windows.Forms.BindingSource eCronogramaDespachoBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}