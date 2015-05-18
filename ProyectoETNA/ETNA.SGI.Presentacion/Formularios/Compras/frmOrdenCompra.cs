using ETNA.SGI.Bussiness.Compras;
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
    public partial class frmOrdenCompra : Form
    {
        private BMoneda bMoneda = BMoneda.getInstance();
        private static double IGV = 0.19;

        public frmOrdenCompra()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOrdenCompra_Load(object sender, EventArgs e)
        {
            // Carga de Combo Moneda
            DataTable dtMoneda = bMoneda.ObtenerListadoMoneda();
            cboMoneda.DataSource = dtMoneda;
            cboMoneda.DisplayMember = "desMoneda";
            cboMoneda.ValueMember = "codMoneda";
            
            cboMoneda.SelectedIndex = 0;

            // Fecha Actual
            dtpFechaEntrega.Value = DateTime.Today;

            txtLugarEntrega.Text = "";
            txtObservacion.Text = "";
            txtRequerimiento.Text = "";
            txtCotizacion.Text = "";
            txtProveedor.Text = "";
            txtSubTotal.Text = 0.ToString("0.00");
            txtIgv.Text = IGV.ToString("0.00");
            txtTotal.Text = 0.ToString("0.00");
        }

        private void btnBuscarRequerimiento_Click(object sender, EventArgs e)
        {
            Formularios.Compras.frmListadoRequerimientoCompra frm = new frmListadoRequerimientoCompra();
            frm.CodRequerimientoCompra = txtRequerimiento.Text;
            frm.CodCotizacion = txtCotizacion.Text;
            frm.Proveedor = txtProveedor.Text;
            frm.TotalSinIGV = txtSubTotal.Text;
            frm.ShowDialog();
            txtRequerimiento.Text = frm.CodRequerimientoCompra;
            txtCotizacion.Text = frm.CodCotizacion;
            txtProveedor.Text = frm.Proveedor;            
            if (frm.DtDetalleRequerimientoCompra != null && frm.DtDetalleRequerimientoCompra.Rows.Count > 0)
            {
                dtGridDetalleOC.DataSource = frm.DtDetalleRequerimientoCompra;
                txtSubTotal.Text = frm.TotalSinIGV;
                txtTotal.Text = (Double.Parse(frm.TotalSinIGV) - (Double.Parse(frm.TotalSinIGV) * IGV)).ToString("0.00");
            }            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtLugarEntrega.Text)) {
                MessageBox.Show("Debe ingresar el lugar de entrega");
                return;
            }
            if ("".Equals(txtRequerimiento.Text))
            {
                MessageBox.Show("Debe seleccionar el requerimiento de compra");
                return;
            }
            if (dtpFechaEntrega.Value <= DateTime.Today)
            {
                MessageBox.Show("Debe seleccionar una fecha mayor a la actual");
                return;
            }

            // Guardar la Orden de Compra con su detalle

        }
    }
}
