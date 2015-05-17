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
            dataGridView1.GridColor = Color.Red;
            txtRequerimiento.Text = Program.Nombre;

            cboEstado.DataSource = bCotizacion.DGetEstados();
            cboEstado.DisplayMember = "desEstado";
            cboEstado.ValueMember = "codEstado";

            dataGridView1.DataSource = bCotizacion.DGetAllCotizacionByReq(Program.CodReq);

        }


        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Formularios.Compras.frmProveedor frm = new frmProveedor();
            frm.ShowDialog();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string criteria = "";

            if (txtRequerimiento.Text == "")
            {
                criteria = " codRequerimiento ='" + txtRequerimiento.Text + "' ";
            };

            if (txtProveedor.Text == "")
            {
                if (criteria == "")
                {
                    criteria = " codProveedor ='" + txtProveedor.Text + "' ";
                }
                else 
                {
                    criteria = criteria + " AND codProveedor ='" + txtProveedor.Text + "' ";
                };                              
            };

            if (txtProveedor.Text == "")
            {
                if (criteria == "")
                {
                    criteria = " codProveedor ='" + txtProveedor.Text + "' ";
                }
                else
                {
                    criteria = criteria + " AND codProveedor ='" + txtProveedor.Text + "' ";
                };
            };

            if (cboEstado.ValueMember == "")
            {
                if (criteria == "")
                {
                    criteria = " codProveedor ='" + txtProveedor.Text + "' ";
                }
                else
                {
                    criteria = criteria + " AND codProveedor ='" + txtProveedor.Text + "' ";
                };
            };
          
          

            dataGridView1.GridColor = Color.Red;
            dataGridView1.DataSource = bCotizacion.getSELECTLIBRE("SELECT codCotizacion, codRequerimiento ,codProveedor ,descripcion ,telefono ,fechaExpiracion ,codEstado FROM Cotizacion " +
           " WHERE " + criteria + "");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Formularios.Compras.frmCotizacion frm = new Formularios.Compras.frmCotizacion();
            frm.Show();
            this.Cursor = Cursors.Default;
        }

    }
}
