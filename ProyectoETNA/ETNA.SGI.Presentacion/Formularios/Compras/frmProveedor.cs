using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ETNA.SGI.Bussiness.Compras;
using ETNA.SGI.Data.Compras;
using ETNA.SGI.Entity.Compras;
using ETNA.SGI.Utils;
using System.Globalization;

namespace ETNA.SGI.Presentacion.Formularios.Compras
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {

        }

        EProveedor proveedor = new EProveedor();
       // BProveedor tProveedor =  new BProveedor();

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            /* UPC - 14.02.2015 - Edinson Rojas Villarreyes - Begin */
            /* Se valida que se ingrese los campos requeridos */

            DateTime FechaSis = DateTime.Now;

            string fecha;
            FechaSis = DateTime.Now;

            if (txtRazonSocial.Text == "") { MessageBox.Show("Ingresar Razón Social", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Error); txtRazonSocial.Focus(); this.Cursor = Cursors.Default; return; }
            if (txtRUC.Text == "") { MessageBox.Show("Ingresar RUC", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Error); txtRUC.Focus(); this.Cursor = Cursors.Default; return; }
            if (txtTelefono.Text == "") { MessageBox.Show("Ingresar Teléfono", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Error); txtTelefono.Focus(); this.Cursor = Cursors.Default; return; }
            if (txtDire.Text == "") { MessageBox.Show("Ingresar Direccion", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Error); txtDire.Focus(); this.Cursor = Cursors.Default; return; }
            if (txtEmail.Text == "") { MessageBox.Show("Ingresar Correo Eléctronico", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Error); txtEmail.Focus(); this.Cursor = Cursors.Default; return; }
            //if (richTextBox1.Text == "") { MessageBox.Show("Ingresar Observaciones", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Error); richTextBox1.Focus(); this.Cursor = Cursors.Default; return; }
            if (txtObs.Text == "") { MessageBox.Show("Ingresar Observaciones", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Error); txtObs.Focus(); this.Cursor = Cursors.Default; return; }

            if (MessageBox.Show("Se procederá a grabar el proveedor", "Compras", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
               /* string corr = "";

                corr = objBus.BCorrelativoProveedor().Rows[0][0].ToString();


                objtra = new BTransaccionCompras();

                objBus = new BTablasCompras(); */
                fecha = FechaSis.ToShortDateString().Substring(6, 4) + FechaSis.ToShortDateString().Substring(3, 2) + FechaSis.ToShortDateString().Substring(0, 2);
                
                proveedor = new EProveedor();
                proveedor.CodProveedor = Convert.ToInt32("1");
                proveedor.RazonSocial = txtRazonSocial.Text.Trim();
                proveedor.Direccion = txtDire.Text.Trim();
                proveedor.Telefono = Convert.ToInt32(txtTelefono.Text.Trim());
                proveedor.FechaRegistro = FechaSis;
                proveedor.Email = txtEmail.Text.Trim();
                proveedor.Ruc = Convert.ToInt32(txtRUC.Text.Trim());
                proveedor.Observacion = txtObs.Text.Trim();
                /*

                objtra = new BTransaccionCompras();
                int h = objtra.BInsertProveedor(proveedor);


                */
                MessageBox.Show("Proveedor Ingresado Correctamente ", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Close();


            }
            /* UPC - 14.02.2015 - Edinson Rojas Villarreyes - End */

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
