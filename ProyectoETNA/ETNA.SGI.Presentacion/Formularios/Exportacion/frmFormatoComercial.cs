using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETNA.SGI.Bussiness.FabricaNegocio;
using System.Globalization;



namespace ETNA.SGI.Presentacion.Formularios.Exportacion
{
    public partial class frmFormatoComercial : Form
    {
        public frmFormatoComercial()
        {
            InitializeComponent();
        }

        public string textFormatoComercial = "";
        DataTable dtTipoDoc = new DataTable();

        public string evalua = "";

        public string tipo = "";
        public string fechaPubli = "";
        public string fechaExpi = "";
        public string estado = "";
        public string ruta = "";
        public string version = "";


        private void frmFormatoComercial_Load(object sender, EventArgs e)
        {
            dtTipoDoc = FabricaNeg._instancia().ObtenerTablas().getSELECTLIBRE("SELECT cod_siicex,des_siicex FROM dbo.DosSIICEX");
            cbTipoDoc.DataSource = dtTipoDoc;
            cbTipoDoc.DisplayMember = "des_siicex";
            cbTipoDoc.ValueMember = "cod_siicex";

            if (evalua == "NEW")
            {
                chkDisponible.Checked = true;
                chkDisponible.Enabled = false;
            }
            else
            {
                cbTipoDoc.Enabled = false;
                chkDisponible.Enabled = true;
                cbTipoDoc.SelectedValue = Convert.ToInt16(tipo);
                

                dtFechaPubl.Value = Convert.ToDateTime(fechaPubli);
                dtFechaExpi.Value = Convert.ToDateTime(fechaExpi );
                if (estado == "A")
                {
                    chkDisponible.Checked = true;
                }
                else
                {
                    chkDisponible.Checked = false;             
                }
                txtRuta.Text = ruta;
                txtVersion.Text = version;
                txtVersion.Enabled = false;


            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir del Formulario?", "Exportacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "Archivos de texto|*.pdf";
            openfiledialog.Title = "Abrir Archivo";
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = openfiledialog.FileName.ToString();
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = openfiledialog.FileName.ToString();
                proc.Start();
                proc.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVersion.Text.Trim() == "")
                {
                    MessageBox.Show("Porfavor Ingrese Version del Documento!!", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtRuta.Text.Trim() == "")
                {
                    MessageBox.Show("Porfavor Ingrese Ruta!!", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fecha, fecha2;
                fecha = dtFechaPubl.Value.Year.ToString() + dtFechaPubl.Value.Month.ToString("00", CultureInfo.InvariantCulture) + dtFechaPubl.Value.Day.ToString("00", CultureInfo.InvariantCulture);
                fecha2 = dtFechaExpi.Value.Year.ToString() + dtFechaExpi.Value.Month.ToString("00", CultureInfo.InvariantCulture) + dtFechaExpi.Value.Day.ToString("00", CultureInfo.InvariantCulture);

                string estado = "";
                if (chkDisponible.Checked == true)
                {
                    estado = "A";
                }
                else
                {
                    estado = "I";
                }
                int K = 0;
                if (evalua == "NEW")
                {
                    K = FabricaNeg._instancia().ObtenerTransaccion().BTransaccionVarias("INSERT INTO dbo.DetalleDocExportacion (Cod_SIICEX, Version, Estado, Fecha_Publicacion, Fecha_Expiracion, Documento_Adjunto, Cod_Usuario) " +
        " VALUES (" + cbTipoDoc.SelectedValue.ToString() + ", '" + txtVersion.Text.ToString() + "', '" + estado + "', '" + fecha + "', '" + fecha2 + "', '" + txtRuta.Text.Trim() + "', '" + Program.Usuario + "')");

                    MessageBox.Show("Formato Comercial ingresado Correctamente", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //frmAtencionSolicitud.Actualiza = true;                    
                }
                else
                {
                    K = FabricaNeg._instancia().ObtenerTransaccion().BTransaccionVarias("UPDATE dbo.DetalleDocExportacion SET Estado = '" + estado + "',Fecha_Publicacion = '" + fecha + "',Fecha_Expiracion = '" + fecha2 + "',Documento_Adjunto = '" + txtRuta.Text.Trim() + "' ,Cod_Usuario = '" + Program.Usuario + "' WHERE Cod_SIICEX = " + cbTipoDoc.SelectedValue.ToString() + " AND Version = '" + txtVersion.Text.ToString() + "'");
                    MessageBox.Show("Se modificó correctamente el Formato Comercial", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                frmBusquedaFormatoComercial.Actualiza = true;
                this.Close();
            }
            catch { MessageBox.Show("Versión del Documento ya fue ingresada, Porfavor ingrese una versión diferente", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
