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
        public frmCotizacion()
        {
            InitializeComponent();
        }

        private void frmCotizacion_Load(object sender, EventArgs e)
        {

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
        }

        private void btnFindProv_Click(object sender, EventArgs e)
        {
            Compras.frmBusquedaProveedor frm = new frmBusquedaProveedor();
            frm.ShowDialog();

            txtProveedor.Text = frm.vCodigo;
        }

 





   
    }
}
