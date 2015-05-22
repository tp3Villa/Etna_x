﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using ETNA.SGI.Utils;
using System.Globalization;
using ETNA.SGI.Bussiness.FabricaNegocio;

namespace ETNA.SGI.Presentacion.Formularios.Exportacion
{
    public partial class frmRegistroSolicitudAtencion : Form
    {
        public frmRegistroSolicitudAtencion()
        {
            InitializeComponent();
        }

        public string Opcion = "";
        public string CorrSOLUPD = "";
        public string CorrREQUPD = "";
        
        public string codigoReq = "";
        public string Razon = "";
        public string Destino = "";
        public string Direccion = "";
        
        public string fecha1 = "";
        public string fecha2 = "";
        public string PAIS_CAB_REQ = "";

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            lblIATA.Text = "";
            codIATA = "";
            desIATA = "";
            lblIATA.Text = "";
            try
            {
                Formularios.Exportacion.frmBusquedaRequerimiento frm = new frmBusquedaRequerimiento();
                frm.ShowDialog();
                codigoReq = frm.vcodigoReq;
                Razon = frm.vRazon;
                Destino = frm.vDestino;
                Direccion = frm.vDireccion;
                fecha1 = frm.vfecha1.Substring(6, 2) + "/" + frm.vfecha1.Substring(4, 2) + "/" + frm.vfecha1.Substring(0, 4);
                fecha2 = frm.vfecha2.Substring(6, 2) + "/" + frm.vfecha2.Substring(4, 2) + "/" + frm.vfecha2.Substring(0, 4);
                PAIS_CAB_REQ = frm.vPAIS_CAB_REQ;

                lblCodReq.Text = codigoReq.Trim();
                lblRazon.Text = Razon.Trim();
                lblDestino.Text = Destino.Trim();
                lblDireccion.Text = Direccion.Trim();
                dtFechaReg.Value = Convert.ToDateTime(fecha1);
                dtFechaEsp.Value = Convert.ToDateTime(fecha2);

                FormatoGrilla();
                DataTable dt = new DataTable();
                //objBus = new BTablas();
                dt = FabricaNeg._instancia().ObtenerTablas().BRequerimientoDetalleXCodREQ(lblCodReq.Text.Trim());
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    dr = tbldetalle.NewRow();
                    dr["Codigo"] = dt.Rows[i]["codProd"].ToString();
                    dr["producto"] = dt.Rows[i]["desProd"].ToString();
                    dr["cantidad"] = Convert.ToDecimal(dt.Rows[i]["Cantidad"].ToString());
                    dr["precio"] = Convert.ToDecimal(dt.Rows[i]["PrecioS"].ToString());
                    dr["cif"] = 0;
                    dr["fob"] = 0;
                    dr["Medida"] = "Unidad";
                    tbldetalle.Rows.Add(dr);
                    tbldetalle.AcceptChanges();
                }

                //objTra = new BTransaccion();
                int t = FabricaNeg._instancia().ObtenerTransaccion().BTransaccionVarias("delete from docProdTEMP");

                //objBus = new BTablas();
                //dtReqProSii = objBus.getSELECTLIBRE("SELECT * FROM dbo.docProdTEMP");
            }
            catch { }
            this.Cursor = Cursors.Default;
        }

        DataTable tbldetalle1;
        DataRow dr1;
        DataTable tbldetalle;
        DataRow dr;

        private void frmRegistroSolicitudAtencion_Load(object sender, EventArgs e)
        {
            int t = FabricaNeg._instancia().ObtenerTransaccion().BTransaccionVarias("delete from docProdTEMP");

            FormatoGrilla();
            lblResponsable.Text = Program.Nombre;
            dataGridView1.GridColor = Color.Red;

            int j = 0;
            //objBus = new BTablas();
            DataTable dtOcpiones = FabricaNeg._instancia().ObtenerTablas().getSELECTLIBRE("SELECT * FROM dbo.DosSIICEX");
            while (j <= dtOcpiones.Rows.Count - 1)
            {
                ListViewItem List;
                List = lvAccesos.Items.Add(dtOcpiones.Rows[j]["Cod_SIICEX"].ToString());
                List.SubItems.Add(dtOcpiones.Rows[j]["Des_SIICEX"].ToString());
                j += 1;
            }

            if (Opcion != "")
            {
                button2.Enabled = false;
                if (Opcion == "VIS")
                {
                    button2.Enabled = false;
                    button6.Enabled = false;

                    button1.Enabled = false;
                    button3.Enabled = false;
                    dtFechaEsp.Enabled = false;
                    richTextBox1.Enabled = false;
                    txtCIF.Enabled = false;
                    txtFOB.Enabled = false;
                }


                DataTable dt = new DataTable();
                //objBus = new BTablas();
                dt = FabricaNeg._instancia().ObtenerTablas().getSELECTLIBRE("SELECT             R.idProducto AS codProd,            descripcionProducto AS desProd,            cantidad AS cantidad, "+
 " pre_prod AS PrecioS,            (cantidad*pre_prod) AS subPrecioS,            tipounidadMedida AS UndMeda,            Peso AS Peso,CIF,FOB FROM Requerimiento_Detalle AS R " +
 " LEFT OUTER JOIN  Producto AS P ON (R.idProducto=P.idProducto)             WHERE Cod_Det_Req='" + CorrREQUPD + "'");

                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    dr = tbldetalle.NewRow();
                    dr["Codigo"] = dt.Rows[i]["codProd"].ToString();
                    dr["producto"] = dt.Rows[i]["desProd"].ToString();
                    dr["cantidad"] = Convert.ToDecimal(dt.Rows[i]["Cantidad"].ToString());
                    dr["precio"] = Convert.ToDecimal(dt.Rows[i]["PrecioS"].ToString());
                    dr["cif"] = Convert.ToDecimal(dt.Rows[i]["CIF"].ToString()); ;
                    dr["fob"] = Convert.ToDecimal(dt.Rows[i]["FOB"].ToString()); ;
                    dr["Medida"] = "Unidad";
                    tbldetalle.Rows.Add(dr);
                    tbldetalle.AcceptChanges();
                }



                int m = FabricaNeg._instancia().ObtenerTransaccion().BTransaccionVarias("INSERT INTO docProdTEMP (IDPRODUCTO, COD_SIICEX) SELECT IDPRODUCTO, COD_SIICEX FROM DocProdReq WHERE COD_CAB_REQ=" + CorrREQUPD);

                
                DataTable dtMo = FabricaNeg._instancia().ObtenerTablas().getSELECTLIBRE("SELECT Cod_Solicitud,S.Cod_Cab_Req AS Cod_Cab_Req_Solicitud,IATA_CAB_REQ,(SELECT IATA_DES FROM dbo.IATA WHERE IATA_COD=IATA_CAB_REQ) DES_IATA, " +
 " R.Cod_Pais AS PAIS_CAB_REQ,(SELECT NOM_PAIS FROM PAIS WHERE Cod_Pais=R.Cod_Pais) AS PAIS,RAZON_SOCIAL,DIRECCION,FEC_REG_CAB_REQ,Convert(varchar(10), FEC_RES_ESP_SOLICITUD,103) AS FEC_RES_ESP_SOLICITUD,observacion_solicitud  " +
 " FROM dbo.SolicitudAtencion AS S  LEFT OUTER JOIN  dbo.Requerimiento AS R ON (S.Cod_Cab_Req=R.COD_CAB_REQ) LEFT OUTER JOIN CLIENTE AS C ON (R.Cod_Cliente=C.Cod_Cliente) WHERE Cod_Solicitud=" + CorrSOLUPD);

                codigoReq = CorrREQUPD;

                codIATA = dtMo.Rows[0]["IATA_CAB_REQ"].ToString();
                desIATA = dtMo.Rows[0]["DES_IATA"].ToString();
                lblIATA.Text = desIATA;
                Razon = dtMo.Rows[0]["RAZON_SOCIAL"].ToString();
                Destino = dtMo.Rows[0]["DIRECCION"].ToString();
                Direccion = dtMo.Rows[0]["PAIS"].ToString();
                fecha1 = dtMo.Rows[0]["FEC_REG_CAB_REQ"].ToString().Substring(6, 2) + "/" + dtMo.Rows[0]["FEC_REG_CAB_REQ"].ToString().Substring(4, 2) + "/" + dtMo.Rows[0]["FEC_REG_CAB_REQ"].ToString().Substring(0, 4);
                //fecha2 = dtMo.Rows[0]["FEC_RES_ESP_SOLICITUD"].ToString().Substring(6, 2) + "/" + dtMo.Rows[0]["FEC_RES_ESP_SOLICITUD"].ToString().Substring(4, 2) + "/" + dtMo.Rows[0]["FEC_RES_ESP_SOLICITUD"].ToString().Substring(0, 4);
                fecha2 = dtMo.Rows[0]["FEC_RES_ESP_SOLICITUD"].ToString();
                PAIS_CAB_REQ = dtMo.Rows[0]["PAIS_CAB_REQ"].ToString();

                richTextBox1.Text = dtMo.Rows[0]["observacion_solicitud"].ToString().Trim();
                

                lblCodReq.Text = codigoReq.Trim();
                lblRazon.Text = Razon.Trim();
                lblDestino.Text = Destino.Trim();
                lblDireccion.Text = Direccion.Trim();
                dtFechaReg.Value = Convert.ToDateTime(fecha1);
                dtFechaEsp.Value = Convert.ToDateTime(fecha2);
            }


        }


        private void FormatoGrilla()
        {   
            tbldetalle = new DataTable("tabll1");
            tbldetalle.Columns.Add(new DataColumn("Codigo", typeof(string)));
            tbldetalle.Columns.Add(new DataColumn("producto", typeof(string)));
            tbldetalle.Columns.Add(new DataColumn("cantidad", typeof(decimal)));
            tbldetalle.Columns.Add(new DataColumn("Medida", typeof(string)));
            tbldetalle.Columns.Add(new DataColumn("precio", typeof(decimal)));
            tbldetalle.Columns.Add(new DataColumn("cif", typeof(decimal)));
            tbldetalle.Columns.Add(new DataColumn("fob", typeof(decimal)));
            tbldetalle.PrimaryKey = new DataColumn[] { tbldetalle.Columns[0] };
            dataGridView1.DataSource = tbldetalle;


            dataGridView1.Columns["Codigo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["producto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["cantidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Medida"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["precio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["cif"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["fob"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        string codIATA = "";
        string desIATA = "";

        private void button6_Click(object sender, EventArgs e)
        {
            if (lblDestino.Text.Trim() != "")
            {
                this.Cursor = Cursors.WaitCursor;
                Exportacion.FrmBusquedaGRAL frm = new FrmBusquedaGRAL();
                //OT = Orden de Trabajo
                frm.Busqueda = "IAT";
                frm.cod_pai_IATA = PAIS_CAB_REQ;
                frm.ShowDialog();
                codIATA = frm.vCodigo;
                desIATA = frm.vDescripcion;
                lblIATA.Text = frm.vDescripcion;
                //codPais = frm.vCodigo;
                //nomPais = frm.vDescripcion;
                //txtPai.Text = frm.vDescripcion;
                this.Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Porfavor Seleccione Requerimiento", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        string codPROD = "";
        string desPROD = "";
        DataTable dtReqProSii = new DataTable();
        DataView dvReqProSii = new DataView();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    int p = dataGridView1.CurrentRow.Index;
                    txtCIF.Text = dataGridView1.Rows[p].Cells["cif"].Value.ToString();
                    txtFOB.Text = dataGridView1.Rows[p].Cells["fob"].Value.ToString();

                    codPROD = dataGridView1.Rows[p].Cells["Codigo"].Value.ToString();
                    desPROD = dataGridView1.Rows[p].Cells["producto"].Value.ToString();
                    label22.Text = "Producto - Bateria " + desPROD;
                    //frm.ShowDialog();
                    //objBus = new BTablas();
                    dtReqProSii = FabricaNeg._instancia().ObtenerTablas().getSELECTLIBRE("SELECT idproducto AS Doc_Prod,cod_siicex AS Doc_Siicex FROM dbo.docProdTEMP");
                    panel1.Visible = true;
                    dvReqProSii = new DataView(dtReqProSii, "Doc_Prod=" + codPROD + "", "", DataViewRowState.OriginalRows);
                    int i = 0;
                    while (i <= lvAccesos.Items.Count - 1)
                    {
                        lvAccesos.Items[i].Checked = false;
                        i += 1;
                    }
                    i = 0;
                    if (dvReqProSii.Count > 0)
                    {
                        while (i <= lvAccesos.Items.Count - 1)
                        {
                            for (int j = 0; j <= dvReqProSii.Count - 1; j++)
                            {
                                if (lvAccesos.Items[i].Text.ToString().Trim() == dvReqProSii[j]["Doc_Siicex"].ToString().Trim())
                                {
                                    lvAccesos.Items[i].Checked = true;
                                }
                            }
                            i += 1;
                        }
                    }
                    else
                    {
                        while (i <= lvAccesos.Items.Count - 1)
                        {
                            lvAccesos.Items[i].Checked = false;
                            i += 1;
                        }
                    }
                    txtCIF.Focus();
                }
                catch { }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtCIF.Text == "") || (Convert.ToDecimal(txtCIF.Text) == 0))
            {
                MessageBox.Show("Porfavor Ingrese CIF", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCIF.Focus();
                return;
            }

            if ((txtFOB.Text == "") || (Convert.ToDecimal(txtFOB.Text) == 0))
            {
                MessageBox.Show("Porfavor Ingrese FOB", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFOB.Focus();
                return;
            }

            int t = 0;
            int i = 0;
            int k = 0;
            string flat = "";
            string opcion = "";
            while (i <= lvAccesos.Items.Count - 1)
            {
                if (lvAccesos.Items[i].Checked == true)
                {
                    k = 0;
                    opcion = lvAccesos.Items[i].Text.ToString().Trim();
                    flat = "1";
                }
                i += 1;
            }

            if (flat == "")
            {
                MessageBox.Show("Seleccione Documentos", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            t = 0;
            i = 0;
            k = 0;
            //objBus = new BTablas();
            dtReqProSii = FabricaNeg._instancia().ObtenerTablas().getSELECTLIBRE("SELECT idproducto AS Doc_Prod,cod_siicex AS Doc_Siicex FROM dbo.docProdTEMP");
            if (dtReqProSii.Rows.Count > 0)
            {
                //objTra = new BTransaccion();
                t = FabricaNeg._instancia().ObtenerTransaccion().BTransaccionVarias("delete from docProdTEMP where idproducto=" + codPROD);
            }
            
            t = 0;
            k = 0;
            while (i <= lvAccesos.Items.Count - 1)
            {
                if (lvAccesos.Items[i].Checked == true)
                {
                    k = 0;
                    opcion = lvAccesos.Items[i].Text.ToString().Trim();

                    //objTra = new BTransaccion();
                    t = FabricaNeg._instancia().ObtenerTransaccion().BTransaccionVarias("INSERT INTO [docProdTEMP] ([idproducto],[cod_siicex]) VALUES " +
                                                  "(" + codPROD + ",'" + opcion + "')");
                    flat = "1";
                }
                i += 1;
            }



            dr = tbldetalle.Rows.Find(codPROD);
            dr.BeginEdit();
            dr["cif"] = Convert.ToDecimal(txtCIF.Text.ToString());
            dr["fob"] = Convert.ToDecimal(txtFOB.Text.ToString());
            dr.EndEdit();
            tbldetalle.AcceptChanges();



            MessageBox.Show("Ingreso Correcto", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            panel1.Visible = false;



            

        }

        TControlVB oControl = new TControlVB();
        private void txtCIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtFOB.Focus();
                }
            }
            catch { }
            /****Validar para ingresar decimales o no segun el tipo de Unidad Medida*/
            oControl.NumeroDec(e, txtCIF);
        }

        private void txtFOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            oControl.NumeroDec(e, txtFOB);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal cif1 = 0;
            decimal fob1 = 0;
            if (lblCodReq.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Codigo Requerimiento", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lblIATA.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese IATA", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {

                cif1 = Convert.ToDecimal(dataGridView1["cif", i].Value.ToString());
                fob1 = Convert.ToDecimal(dataGridView1["fob", i].Value.ToString());

                if (cif1 == 0)
                {
                    MessageBox.Show("Porfavor Ingrese CIF", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (fob1 == 0)
                {
                    MessageBox.Show("Porfavor Ingrese FOB", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (MessageBox.Show("¿Desea Grabar la Solicitud?", "Exportación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // comienza grabacion
                //insertamos la solicitud
                //objBus = new BTablas();


                string corr = "";

                if (CorrSOLUPD == "")
                {
                    corr = FabricaNeg._instancia().ObtenerTablas().getSELECTLIBRE(" SELECT count(*)+1 AS corr FROM SolicitudAtencion").Rows[0][0].ToString();
                }
                else
                {
                    corr = CorrSOLUPD;
                }


                string fecha, fecha2;
                DateTime FechaSis = DateTime.Now;
                fecha = FechaSis.ToShortDateString().Substring(6, 4) + FechaSis.ToShortDateString().Substring(3, 2) + FechaSis.ToShortDateString().Substring(0, 2);
                fecha2 = dtFechaEsp.Value.Year.ToString() + dtFechaEsp.Value.Month.ToString("00", CultureInfo.InvariantCulture) + dtFechaEsp.Value.Day.ToString("00", CultureInfo.InvariantCulture);

                int K = 0;
                if (CorrSOLUPD == "")
                {
                    //objTra = new BTransaccion();
                    K = FabricaNeg._instancia().ObtenerTransaccion().BTransaccionVarias("DELETE FROM SolicitudAtencion WHERE Cod_Solicitud=" + corr);

                    //objTra = new BTransaccion();
                    K = FabricaNeg._instancia().ObtenerTransaccion().BTransaccionVarias("INSERT INTO dbo.SolicitudAtencion (Cod_Cab_Req, Res_Solicitud, Fec_Reg_Solicitud, Fec_Res_Esp_Solicitud, Fec_Desp_Solicitud, Estado_Solicitud, Observacion_Solicitud) " +
        " VALUES (" + Convert.ToDecimal(lblCodReq.Text.Trim()) + ", '" + Program.Usuario + "', '" + fecha + "', '" + fecha2 + "', '" + fecha + "', 'A', '" + richTextBox1.Text.Trim() + "')");
                }
                else
                {
                    K = FabricaNeg._instancia().ObtenerTransaccion().BTransaccionVarias("UPDATE dbo.SolicitudAtencion SET  Res_Solicitud='" + Program.Usuario + "',Fec_Reg_Solicitud='" + fecha + "',Fec_Res_Esp_Solicitud='" + fecha2 + "', " +
" Fec_Desp_Solicitud='" + fecha + "',Estado_Solicitud='A',Observacion_Solicitud='" + richTextBox1.Text.Trim() + "' " +
" WHERE cod_solicitud=" + corr);             
                }



                //objTra = new BTransaccion();
                K = FabricaNeg._instancia().ObtenerTransaccion().BTransaccionVarias("UPDATE Requerimiento SET  IATA_Cab_Req='" + codIATA + "',Est_Cab_Req='P' WHERE Cod_Cab_Req=" + Convert.ToDecimal(lblCodReq.Text.Trim()));

                decimal cifG, fobG, codProdG = 0;
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    codProdG = Convert.ToDecimal(dataGridView1["Codigo", i].Value.ToString());
                    cifG = Convert.ToDecimal(dataGridView1["cif", i].Value.ToString());
                    fobG = Convert.ToDecimal(dataGridView1["fob", i].Value.ToString());
                    //objTra = new BTransaccion();
                    K = FabricaNeg._instancia().ObtenerTransaccion().BTransaccionVarias("UPDATE Requerimiento_Detalle SET CIF=" + cifG + ",FOB=" + fobG + " WHERE Cod_Det_Req=" + Convert.ToDecimal(lblCodReq.Text.Trim()) + " AND IDPRODUCTO=" + codProdG);
                }

                //objTra = new BTransaccion();
                K = FabricaNeg._instancia().ObtenerTransaccion().BTransaccionVarias("DELETE FROM DocProdReq WHERE Cod_Cab_Req=" + Convert.ToDecimal(lblCodReq.Text.Trim()));

                //objTra = new BTransaccion();
                K = FabricaNeg._instancia().ObtenerTransaccion().BTransaccionVarias("INSERT INTO DocProdReq (Cod_Cab_Req, idProducto, Cod_SIICEX) SELECT '" + Convert.ToDecimal(lblCodReq.Text.Trim()) + "' AS Cod_Cab_Req,idProducto, Cod_SIICEX FROM docProdTEMP");

                //objTra = new BTransaccion();
                K = FabricaNeg._instancia().ObtenerTransaccion().BTransaccionVarias("delete from docProdTEMP");


                MessageBox.Show("Solicitud ingresada Correctamente", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAtencionSolicitud.Actualiza = true;                
                this.Close();

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Deseas Cancelar la Transaccion", "Exportación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //{
                this.Close();
            //}
        }
    }
}
