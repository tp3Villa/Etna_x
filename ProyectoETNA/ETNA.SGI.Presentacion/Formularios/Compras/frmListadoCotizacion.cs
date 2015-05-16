using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ETNA.SGI.Bussiness.Compras;
using ETNA.SGI.Entity.Compras;
using ETNA.SGI.Utils;
using System.Globalization;

namespace ETNA.SGI.Presentacion.Formularios.Compras
{
    public partial class frmListadoCotizacion : Form
    {
        public frmListadoCotizacion()
        {
            InitializeComponent();
        }

        private BCotizacion bCotizacion = BCotizacion.getInstance();
        ECotizacion cotizacion = new ECotizacion();
        ECotizacionDetalle cotizacionDetalle = new ECotizacionDetalle();

        private void frmListadoProveedor_Load(object sender, EventArgs e)
        {

            DataTable tblDetalle = new DataTable();

            tblDetalle = bCotizacion.DGetAllCotizacion(cotizacion);
            dataGridView1.DataSource = tblDetalle;

        }


        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Formularios.Compras.frmProveedor frm = new frmProveedor();
            frm.ShowDialog();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            DataTable tblDetalle = new DataTable();

            cotizacion.Descripcion = txtDescripcion.Text.Trim();
            tblDetalle = bCotizacion.DGetAllCotizacion(cotizacion);

            dataGridView1.DataSource = tblDetalle;
        }

    }
}
