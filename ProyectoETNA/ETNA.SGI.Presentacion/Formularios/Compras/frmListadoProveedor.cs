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
    public partial class frmListadoProveedor : Form
    {
        public frmListadoProveedor()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Formularios.Compras.frmProveedor frm = new frmProveedor();
            frm.ShowDialog();
        }


        private BProveedor bProveedor = BProveedor.getInstance();
        EProveedor proveedor = new EProveedor();

        private void frmListadoProveedor_Load(object sender, EventArgs e)
        {

            DataTable tblDetalle = new DataTable();
            
           tblDetalle =  bProveedor.DGetAllProveedor(proveedor);

           dataGridView1.DataSource = tblDetalle;

           /* DataTable tblDetalle = new DataTable();
            tblDetalle.Columns.Add(new DataColumn("1", typeof(string)));
            tblDetalle.Columns.Add(new DataColumn("2", typeof(string)));
            tblDetalle.Columns.Add(new DataColumn("3", typeof(string)));

            DataRow fila = tblDetalle.NewRow();
            fila["1"] = "D0001";
            fila["2"] = "Empresas Exportadoras";
            fila["3"] = "Ver documento";
            tblDetalle.Rows.Add(fila);

            fila = tblDetalle.NewRow();
            fila["1"] = "D0002";
            fila["2"] = "Eventos Comerciales";
            fila["3"] = "Ver documento";
            tblDetalle.Rows.Add(fila);

            fila = tblDetalle.NewRow();
            fila["1"] = "D0003";
            fila["2"] = "Requisitos de Calidad e Inocuidad";
            fila["3"] = "Ver documento";
            tblDetalle.Rows.Add(fila); */

            
        }


     }
}
