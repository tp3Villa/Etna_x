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
        ECotizacion eCotizacion = new ECotizacion();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    if (MessageBox.Show("Se procederá a aprobar la Cotización, desea continuar?", "Compras", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        int p = dataGridView1.CurrentRow.Index;

                        eCotizacion.CodCotizacion = Convert.ToInt32(dataGridView1.Rows[p].Cells["codCotizacion"].Value.ToString());
                        eCotizacion.CodEstado = 2;
                        eCotizacion.UsuarioAprobacion = Program.Usuario;
                        eCotizacion.FechaAprobacion =  DateTime.Now;
                        
                        int exito = bCotizacion.DUpdateAprobacionCotizacion(eCotizacion);

                        MessageBox.Show("La cotización fue aprobada. ", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DataTable table = new DataTable();
                        table = bCotizacion.DGetCotizacionAprobacion();

                        dataGridView1.DataSource = table;
                    }                   
                }
                catch { }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se procederá a cerrar la ventana, desea continuar?", "Compras", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
