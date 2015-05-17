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
      

        private BCotizacion bCotizacion = BCotizacion.getInstance();
        private BEstado bEstado = BEstado.getInstance();
        DataTable dtCotizacion = new DataTable();
        DataRow dr;

        public frmListadoCotizacion()
        {
            InitializeComponent();
        }

        private void txtCotizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRequerimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Formularios.Compras.frmProveedor frm = new frmProveedor();
            frm.ShowDialog();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            ECotizacion eCotizacion = new ECotizacion();
            if (!"".Equals(txtCotizacion.Text))
            {
                eCotizacion.CodCotizacion = Int32.Parse(txtCotizacion.Text);
            }
            if (!"".Equals(txtRequerimiento.Text))
            {
                eCotizacion.CodRequerimiento = Int32.Parse(txtRequerimiento.Text);
            }

            eCotizacion.CodEstado = (int)cboEstado.SelectedValue;

            cargaGrilla(eCotizacion);
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

        private void frmListadoCotizacion_Load(object sender, EventArgs e)
        {
            // Carga de Combo Estado
            DataTable dtEstado = bEstado.ObtenerListadoEstadoPorCotizacion();
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
            cargaGrilla(new ECotizacion());

        }
      

        private void cargaGrilla(ECotizacion eCotizacion)
        {
            DataTable dt = bCotizacion.ObtenerListadoCotizacion(eCotizacion);
            dtCotizacion.Clear();

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                dr = dtCotizacion.NewRow();
                dr["codigo"] = dt.Rows[i]["codCotizacion"].ToString();
                dr["requerimiento"] = dt.Rows[i]["codRequerimiento"].ToString();
                dr["proveedor"] = dt.Rows[i]["razonSocial"].ToString();
                dr["descripcion"] = dt.Rows[i]["descripcion"].ToString();
                dr["telefono"] = dt.Rows[i]["telefono"].ToString();
                dr["fechaExpiracion"] = ((DateTime)dt.Rows[i]["fechaExpiracion"]).ToShortDateString();
                dr["estado"] = dt.Rows[i]["desEstado"].ToString();
                dtCotizacion.Rows.Add(dr);
                dtCotizacion.AcceptChanges();
            }
        }


        private void crearColumnasGrid()
        {
            dtCotizacion = new DataTable("dtCotizacion");
            dtCotizacion.Columns.Add(new DataColumn("codigo", typeof(string)));
            dtCotizacion.Columns.Add(new DataColumn("requerimiento", typeof(string)));
            dtCotizacion.Columns.Add(new DataColumn("proveedor", typeof(string)));
            dtCotizacion.Columns.Add(new DataColumn("descripcion", typeof(string)));
            dtCotizacion.Columns.Add(new DataColumn("telefono", typeof(string)));
            dtCotizacion.Columns.Add(new DataColumn("fechaExpiracion", typeof(string)));
            dtCotizacion.Columns.Add(new DataColumn("estado", typeof(string)));
            dtCotizacion.PrimaryKey = new DataColumn[] { dtCotizacion.Columns[0] };
            dtGridCot.DataSource = dtCotizacion;

            DataGridViewImageColumn modificar = new DataGridViewImageColumn();
            modificar.Name = "modificar";
            modificar.HeaderText = "";
            modificar.Image = global::ETNA.SGI.Presentacion.Properties.Resources.BO12;
            modificar.ReadOnly = true;
            dtGridCot.Columns.Add(modificar);

            DataGridViewImageColumn anular = new DataGridViewImageColumn();
            anular.Name = "eliminar";
            anular.HeaderText = "";
            anular.Image = global::ETNA.SGI.Presentacion.Properties.Resources.Cancel_Red_mini;
            anular.ReadOnly = true;
            dtGridCot.Columns.Add(anular);

            // Estilos
            dtGridCot.GridColor = Color.Red;
            dtGridCot.Columns["codigo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridCot.Columns["codigo"].Width = 60;
            dtGridCot.Columns["codigo"].HeaderText = "Codigo";
            dtGridCot.Columns["requerimiento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridCot.Columns["requerimiento"].Width = 80;
            dtGridCot.Columns["requerimiento"].HeaderText = "Requerimiento";
            dtGridCot.Columns["proveedor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridCot.Columns["proveedor"].HeaderText = "Proveedor";
            dtGridCot.Columns["descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridCot.Columns["descripcion"].HeaderText = "Descripcion";
            dtGridCot.Columns["telefono"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridCot.Columns["telefono"].HeaderText = "Telefono";
            dtGridCot.Columns["fechaExpiracion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridCot.Columns["fechaExpiracion"].HeaderText = "Fecha Expiracion";
            dtGridCot.Columns["estado"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridCot.Columns["estado"].HeaderText = "Estado";
            dtGridCot.Columns["modificar"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridCot.Columns["modificar"].Width = 40;
            dtGridCot.Columns["anular"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridCot.Columns["anular"].Width = 40;
        }

        private void dtGridCot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Modificar
            if (e.ColumnIndex == 7)
            {
                MessageBox.Show("Modificar");

            }

            // Anular
            if (e.ColumnIndex == 8)
            {
                MessageBox.Show("Eliminar");
            }
        }

      

    }
}
