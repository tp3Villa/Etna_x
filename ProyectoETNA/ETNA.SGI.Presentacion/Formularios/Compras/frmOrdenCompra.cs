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
            txtDescuento.Text = "0.00";
            txtIgv.Text = "";            
            txtTotal.Text = "0.00";
        }

        private void btnBuscarRequerimiento_Click(object sender, EventArgs e)
        {
            Formularios.Compras.frmListadoRequerimientoCompra frm = new frmListadoRequerimientoCompra();
            frm.ShowDialog();
        }
    }
}
