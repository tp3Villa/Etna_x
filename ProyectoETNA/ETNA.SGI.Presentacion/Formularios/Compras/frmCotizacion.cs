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
        ECotizacionDetalle cotizacionDetalle = new ECotizacionDetalle();
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

                DataTable tblDetalle2 = new DataTable();

                cotizacionDetalle.CodCotizacion = icodCotizacion;
                tblDetalle2 = bCotizacion.ObtenerCotizacionDetallePorId(cotizacionDetalle);
                dataGridView1.DataSource = tblDetalle2;

            }
            else
            {
               txtRequerimiento.Text = "";
               txtProveedor.Text = "";
               txtTelefono.Text = "";
               txtDescripcion.Text = "";
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

        private void dataGridView1_KeyPress(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int p = dataGridView1.CurrentRow.Index;

     //           frm.icodCotizacion = Convert.ToInt32(dataGridView1.Rows[p].Cells["codCotizacion"].Value);
     


                for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
       //             dr = dtOrdenCompra.NewRow();
         //           dr["codigo"] = dataGridView1.Rows[i]["descuento"].value;
               
                }

            }
            catch { }


        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            DateTime FechaSis = DateTime.Now;

            string fecha;
            FechaSis = DateTime.Now;

            if (txtRequerimiento.Text == "") { MessageBox.Show("Seleccionar Requerimiento", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Error); btnFindReq.Focus(); this.Cursor = Cursors.Default; return; }
            if (txtProveedor.Text == "") { MessageBox.Show("Seleccionar Proveedor", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Error); btnFindProv.Focus(); this.Cursor = Cursors.Default; return; }
            if (txtTelefono.Text == "") { MessageBox.Show("Ingresar Teléfono", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Error); txtTelefono.Focus(); this.Cursor = Cursors.Default; return; }
           
            if (MessageBox.Show("Se procederá a grabar la cotización", "Compras", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                string corr = "";

                if (sOpcion == "UPD")
                {
                    corr = Convert.ToString(icodCotizacion);
                }
                else
                {
                    corr = bCotizacion.CorrelativoCotizacion().Rows[0][0].ToString();

                   // MessageBox.Show(corr);
                }
                fecha = FechaSis.ToShortDateString().Substring(6, 4) + FechaSis.ToShortDateString().Substring(3, 2) + FechaSis.ToShortDateString().Substring(0, 2);

                cotizacion = new ECotizacion();
                cotizacion.CodCotizacion = Convert.ToInt32(corr);
                cotizacion.CodRequerimiento = Convert.ToInt32(txtRequerimiento.Text.Trim());
                cotizacion.CodProveedor = Convert.ToInt32(txtProveedor.Text.Trim());
                cotizacion.Descripcion = txtDescripcion.Text.Trim();
                cotizacion.Telefono = Convert.ToInt32(txtTelefono.Text.Trim());
                cotizacion.FechaExpiracion = Convert.ToDateTime(dtExpiracion.Text.Trim());
                cotizacion.CodEstado = 4;
       
               
                if (sOpcion == "UPD")
                {
                    cotizacion.FechaActualizacion = FechaSis;
                    cotizacion.UsuarioModificacion = Program.Usuario;
                }
                else
                {
                    cotizacion.FechaRegistro = FechaSis;
                    cotizacion.UsuarioRegistro = Program.Usuario;
                    cotizacion.FechaActualizacion = FechaSis;
                    cotizacion.UsuarioModificacion = Program.Usuario;
                }
                if (sOpcion == "UPD")
                {
                    //bCotizacion.DUpdateProveedor(proveedor);
                    //MessageBox.Show("Proveedor actualizado correctamente ", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int result = bCotizacion.InsertarCotizacion(cotizacion);
                    MessageBox.Show("Cotizacion registrado correctamente ", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();



            }
        }


   
    }
}
