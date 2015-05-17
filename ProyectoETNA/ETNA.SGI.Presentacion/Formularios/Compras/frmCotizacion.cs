using ETNA.SGI.Bussiness.Compras;
using ETNA.SGI.Entity.Compras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ETNA.SGI.Presentacion.Formularios.Compras
{
    public partial class frmCotizacion : Form
    {

        public int icodCotizacion;
        public string sOpcion;
        private BRequerimientoCompra bRequerimientoCompra = BRequerimientoCompra.getInstance();

        ECotizacion cotizacion = new ECotizacion();
        BCotizacion bCotizacion = BCotizacion.getInstance(); 

        public frmCotizacion()
        {
            InitializeComponent();
        }

        private void frmCotizacion_Load(object sender, EventArgs e)
        {
            if (sOpcion == "UPD")
            {
                DataTable tblDetalle = new DataTable();

                cotizacion.CodCotizacion = icodCotizacion;
                tblDetalle = bCotizacion.ObtenerCotizacionPorId(cotizacion);

                txtRequerimiento.Text = tblDetalle.Rows[0]["codRequerimiento"].ToString();
                txtProveedor.Text = tblDetalle.Rows[0]["codProveedor"].ToString();
                txtTelefono.Text = tblDetalle.Rows[0]["telefono"].ToString();
                txtDescripcion.Text = tblDetalle.Rows[0]["descripcion"].ToString();
                dtExpiracion.Text = tblDetalle.Rows[0]["fechaExpiracion"].ToString();
              

            }
            else
            {
               txtRequerimiento.Text = "";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas Cancelar la Transaccion", "Compras", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnFindReq_Click(object sender, EventArgs e)
        {
            Compras.frmListadoReqCotizacion frm = new frmListadoReqCotizacion();
            frm.ShowDialog();

            txtRequerimiento.Text = frm.vCodigoReq;

            DataTable tblDetalle = new DataTable();
            tblDetalle = bRequerimientoCompra.ObtenerRequerimientoDetalleCompraCotizacion(txtRequerimiento.Text);
            dataGridView1.DataSource = tblDetalle;

            
        }

        private void btnFindProv_Click(object sender, EventArgs e)
        {
            Compras.frmBusquedaProveedor frm = new frmBusquedaProveedor();
            frm.ShowDialog();

            txtProveedor.Text = frm.vCodigo;
        }
        
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

        }



   
    }
}
