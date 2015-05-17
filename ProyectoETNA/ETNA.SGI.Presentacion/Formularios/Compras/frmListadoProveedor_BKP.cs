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

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tblDetalle = new DataTable();

            proveedor.RazonSocial = txtRazonSocial.Text.Trim();
            tblDetalle = bProveedor.DGetAllProveedor(proveedor);

            dataGridView1.DataSource = tblDetalle;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    int p = dataGridView1.CurrentRow.Index;
                    Formularios.Compras.frmProveedor frm = new frmProveedor();
                    frm.sOpcion = "UPD";
                    frm.icodProveedor = Convert.ToInt32(dataGridView1.Rows[p].Cells["codProveedor"].Value.ToString());
                    frm.ShowDialog();

                }
                catch { }
            }
        }


     }
}
