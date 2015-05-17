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
    public partial class frmListadoOrdenCompra : Form
    {
        private BOrdenCompra bOrdenCompra = BOrdenCompra.getInstance();
        private BEstado bEstado = BEstado.getInstance();
        DataTable dtOrdenCompra = new DataTable();
        DataRow dr;

        public frmListadoOrdenCompra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EOrdenCompra eOrdenCompra = new EOrdenCompra();
            if (!"".Equals(txtCodOC.Text)) {
                eOrdenCompra.CodOrdenCompra = Int32.Parse(txtCodOC.Text);
            }
            if (!"".Equals(txtCodReq.Text))
            {
                eOrdenCompra.CodRequerimiento = Int32.Parse(txtCodReq.Text);
            }
            
            eOrdenCompra.CodEstado = (int)cboEstado.SelectedValue;

            cargaGrilla(eOrdenCompra);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Formularios.Compras.frmOrdenCompra frm = new frmOrdenCompra();
            //frm.ShowDialog();
        }

        private void txtCodOC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtCodReq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmListadoOrdenCompra_Load(object sender, EventArgs e)
        {
            // Carga de Combo Estado
            DataTable dtEstado = bEstado.ObtenerListadoEstadoPorOrdenCompra();
            cboEstado.DataSource = dtEstado;
            cboEstado.DisplayMember = "desEstado";
            cboEstado.ValueMember = "codEstado";

            DataRow dr = dtEstado.NewRow();
            dr["desEstado"] = "Todos";
            dr["codEstado"] = 0;

            dtEstado.Rows.InsertAt(dr, 0);
            cboEstado.SelectedIndex = 0;

            // Carga de Grilla
            crearColumnasGrid();
            cargaGrilla(new EOrdenCompra());
        }

        private void cargaGrilla(EOrdenCompra eOrdenCompra)
        {
            DataTable dt = bOrdenCompra.ObtenerListadoOrdenCompra(eOrdenCompra);

            dtOrdenCompra.Clear();
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                dr = dtOrdenCompra.NewRow();
                dr["codigo"] = dt.Rows[i]["codOrdenCompra"].ToString();
                dr["requerimiento"] = dt.Rows[i]["codRequerimiento"].ToString();
                dr["cotizacion"] = dt.Rows[i]["codCotizacion"].ToString();
                dr["proveedor"] = dt.Rows[i]["razonSocial"].ToString();
                dr["fechaEntrega"] = ((DateTime)dt.Rows[i]["fechaEntrega"]).ToShortDateString();
                dr["lugarEntrega"] = dt.Rows[i]["lugarEntrega"].ToString();
                dr["estado"] = dt.Rows[i]["desEstado"].ToString();
                dtOrdenCompra.Rows.Add(dr);
                dtOrdenCompra.AcceptChanges();
            }
        }

        private void crearColumnasGrid() {
            dtOrdenCompra = new DataTable("dtOrdenCompra");    
            dtOrdenCompra.Columns.Add(new DataColumn("codigo", typeof(string)));
            dtOrdenCompra.Columns.Add(new DataColumn("requerimiento", typeof(string)));
            dtOrdenCompra.Columns.Add(new DataColumn("cotizacion", typeof(string)));
            dtOrdenCompra.Columns.Add(new DataColumn("proveedor", typeof(string)));
            dtOrdenCompra.Columns.Add(new DataColumn("fechaEntrega", typeof(string)));
            dtOrdenCompra.Columns.Add(new DataColumn("lugarEntrega", typeof(string)));
            dtOrdenCompra.Columns.Add(new DataColumn("estado", typeof(string)));
            dtOrdenCompra.PrimaryKey = new DataColumn[] { dtOrdenCompra.Columns[0] };
            dtGridOC.DataSource = dtOrdenCompra;
            
            DataGridViewImageColumn modificar = new DataGridViewImageColumn();
            modificar.Name = "modificar";
            modificar.HeaderText = "";
            modificar.Image = global::ETNA.SGI.Presentacion.Properties.Resources.BO12;
            modificar.ReadOnly = true;
            dtGridOC.Columns.Add(modificar);

            DataGridViewImageColumn anular = new DataGridViewImageColumn();
            anular.Name = "anular";
            anular.HeaderText = "";
            anular.Image = global::ETNA.SGI.Presentacion.Properties.Resources.Cancel_Red_mini;
            anular.ReadOnly = true;
            dtGridOC.Columns.Add(anular);

            // Estilos
            dtGridOC.GridColor = Color.Red;
            dtGridOC.Columns["codigo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridOC.Columns["codigo"].Width = 60;
            dtGridOC.Columns["codigo"].HeaderText = "Codigo";
            dtGridOC.Columns["requerimiento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridOC.Columns["requerimiento"].Width = 80;
            dtGridOC.Columns["requerimiento"].HeaderText = "Requerimiento";
            dtGridOC.Columns["cotizacion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridOC.Columns["cotizacion"].Width = 60;
            dtGridOC.Columns["cotizacion"].HeaderText = "Cotizacion";
            dtGridOC.Columns["proveedor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridOC.Columns["proveedor"].HeaderText = "Proveedor";
            dtGridOC.Columns["fechaEntrega"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridOC.Columns["fechaEntrega"].HeaderText = "Fecha Entrega";
            dtGridOC.Columns["lugarEntrega"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridOC.Columns["lugarEntrega"].HeaderText = "Lugar Entrega";
            dtGridOC.Columns["estado"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridOC.Columns["estado"].HeaderText = "Estado";
            dtGridOC.Columns["modificar"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridOC.Columns["modificar"].Width = 40;
            dtGridOC.Columns["anular"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridOC.Columns["anular"].Width = 40;
        }

        
    }
}
