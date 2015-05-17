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
    public partial class frmListadoRequerimientoCompra : Form
    {

        private BCategoria bCategoria = BCategoria.getInstance();
        public int iCodRequerimientoCompra;
        public string vCodigo;
        public string vDescripcion;

        //private BRequerimientoCompra bRequerimientoCompra = BRequerimientoCompra.getInstance();
        //ERequerimientoCompra eRequerimientoCompra = new ERequerimientoCompra();

        public frmListadoRequerimientoCompra()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void frmListadoRequerimientoCompra_Load(object sender, EventArgs e)
        {
            // Carga de Combo Estado
            DataTable dtCategoria = bCategoria.ObtenerListadoCategoria();
            cboCategoria.DataSource = dtCategoria;
            cboCategoria.DisplayMember = "desCategoria";
            cboCategoria.ValueMember = "codCategoria";

            DataRow dr = dtCategoria.NewRow();
            dr["desCategoria"] = "Todos";
            dr["codCategoria"] = 0;

            dtCategoria.Rows.InsertAt(dr, 0);
            cboCategoria.SelectedIndex = 0;

            txtCodigo.Text = "";

            DataTable table = new DataTable();
            //table = bRequerimientoCompra.DGetAllRequerimientoCompra();

            dataGridView1.DataSource = table; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    int p = dataGridView1.CurrentRow.Index;
                    vCodigo = dataGridView1.Rows[p].Cells["codRequerimientoCompra"].Value.ToString();
                    vDescripcion = dataGridView1.Rows[p].Cells["desRequerimientoCompra"].Value.ToString();
                    this.Close();
                }
                catch { }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            //eRequerimientoCompra.DesRequerimientoCompra = txtDescripcion.Text;

            //table = bRequerimientoCompra.DGetAllRequerimientoCompraByDesc(eRequerimientoCompra);

            dataGridView1.DataSource = table; 
        }
    }
}
