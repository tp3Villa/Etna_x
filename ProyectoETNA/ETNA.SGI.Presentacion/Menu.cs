﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;



using ETNA.SGI.Bussiness.FabricaNegocio;

namespace ETNA.SGI.Presentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        Process pr = new Process();
        //BTablas objBusTab = new BTablas();

        DataTable dtOcpionesxUsuario = new DataTable();
        DataView dvOpcionesxUsuario = new DataView();

        private void Menu_Load(object sender, EventArgs e)
        {
            stStrip00.Visible = false;
            stStrip01.Text = "Sistema ETNA      ";
            stStrip02.Text = "Usuario: " + Program.Usuario.Trim();

            //objBusTab = new BTablas();
            dtOcpionesxUsuario = FabricaNeg._instancia().ObtenerTablas().getSELECTLIBRE("select COD_USUARIO AS COD_USU,COD_OPCIONMENU AS cod_men from dbo.UsuMenu");
            dvOpcionesxUsuario = new DataView(dtOcpionesxUsuario, "cod_usu = '" + Program.Usuario.Trim() + "'", "", DataViewRowState.OriginalRows);

            CargaAutorizaciones();
        }


        void CargaAutorizaciones()
        {
            ToolStripMenuItem item = new ToolStripMenuItem();
            ToolStripMenuItem item1 = this.menuStrip1.Items[0] as ToolStripMenuItem;
            ToolStripMenuItem item2 = this.menuStrip1.Items[1] as ToolStripMenuItem;
            ToolStripMenuItem item3 = this.menuStrip1.Items[2] as ToolStripMenuItem;
            ToolStripMenuItem item4 = this.menuStrip1.Items[3] as ToolStripMenuItem;
            if (dvOpcionesxUsuario.Count > 0)
            {
                for (int i = 0; i <= dvOpcionesxUsuario.Count - 1; i++)
                {
                    string opcion = dvOpcionesxUsuario[i]["cod_men"].ToString().Trim();
                    string opcion1 = dvOpcionesxUsuario[i]["cod_men"].ToString().Trim() + "S";
                    string opcion2 = dvOpcionesxUsuario[i]["cod_men"].ToString().Trim() + "T";

                    //if ((opcion!="RQG06") && (opcion!="RQG07"))
                    //{
                    //    toolStrip1.Items[opcion].Enabled = true;
                    //}
                    //try { toolStrip1.Items[opcion].Enabled = true; }
                    //catch { }
                    //try { item1.DropDownItems[opcion1].Enabled = true; }
                    //catch { }
                    //try { item2.DropDownItems[opcion1].Enabled = true; }
                    //catch { }
                    //try { item3.DropDownItems[opcion1].Enabled = true; }
                    //catch { }
                    try { toolStrip1.Items[opcion].Visible = true; }
                    catch { }
                    try { toolStrip1.Items[opcion2].Visible = true; }
                    catch { }
                    try { item1.DropDownItems[opcion1].Visible = true; }
                    catch { }
                    try { item2.DropDownItems[opcion1].Visible = true; }
                    catch { }
                    try { item3.DropDownItems[opcion1].Visible = true; }
                    catch { }
                    try { item4.DropDownItems[opcion1].Visible = true; }
                    catch { }
                }
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            
            stStrip03.Text = "Fecha: " + DateTime.Now.ToShortDateString().ToString();
            stStrip04.Text = "Hora: " + DateTime.Now.ToLongTimeString().ToString();
        }

        private void resquisicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void anulaciónDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Formularios.Exportacion.frmAtencionSolicitud frm = new Formularios.Exportacion.frmAtencionSolicitud();
            frm.Show();
            this.Cursor = Cursors.Default;
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pr.StartInfo.FileName = "calc.exe";
            pr.Start();
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pr.StartInfo.FileName = "calc.exe";
            pr.Start();
        }

        private void requerimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Exportacion.frmActualizarInfoRequerimiento frm = new Formularios.Exportacion.frmActualizarInfoRequerimiento();
            frm.Show();
        }

        private void formatoComercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Exportacion.frmBusquedaFormatoComercial frm = new Formularios.Exportacion.frmBusquedaFormatoComercial();
            frm.Show();
        }

        private void aprobacionSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Exportacion.frmAprobacionSolicitud frm = new Formularios.Exportacion.frmAprobacionSolicitud();
            frm.Show();
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Formularios.TablasPrincipales.frmPaises frm = new Formularios.TablasPrincipales.frmPaises();
            frm.ShowDialog();
            this.Cursor = Cursors.Default;   
        }

        private void adminstracionSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Formularios.frmConfiguracion frm = new Formularios.frmConfiguracion();
            frm.ShowDialog();
            this.Cursor = Cursors.Default;   
        }

        private void ETN04S_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Formularios.Exportacion.frmActualizarInfoRequerimiento frm = new Formularios.Exportacion.frmActualizarInfoRequerimiento();
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void ETN09S_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Formularios.Exportacion.frmCronogramaDespacho frm = new Formularios.Exportacion.frmCronogramaDespacho();
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }
    }
}
