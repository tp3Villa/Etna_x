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
    public partial class frmListadoAprobacionCotizacion : Form
    {
        public frmListadoAprobacionCotizacion()
        {
            InitializeComponent();
        }

        private BCotizacion bCotizacion = BCotizacion.getInstance();
        
        private void frmListadoAprobacionCotizacion_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            bCotizacion.SelectLibre("select a.codCotizacion ,a.descripcion , codRequerimiento , a.fechaExpiracion from Cotizacion a , Proveedor b where a.codEstado = 4 and b.codProveedor = a.codProveedor and codCotizacion not in (select c.codCotizacion from OrdenCompra c where c.codCotizacion = a.codCotizacion and c.codRequerimiento = a.codRequerimiento )");

            dataGridView1.DataSource = table;
        }
    }
}
