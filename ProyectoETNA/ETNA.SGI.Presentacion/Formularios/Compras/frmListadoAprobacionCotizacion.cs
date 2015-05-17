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
            table = bCotizacion.DGetCotizacionAprobacion();

            dataGridView1.DataSource = table;

         }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = bCotizacion.DGetCotizacionAprobacion();

            dataGridView1.DataSource = table;
        }
    }
}
