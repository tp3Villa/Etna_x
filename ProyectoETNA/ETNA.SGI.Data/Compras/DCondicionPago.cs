
using ETNA.SGI.Entity.Compras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ETNA.SGI.Data.Compras
{
    public class DCondicionPago
    {
        private DConexion cn = new DConexion();

        private static DCondicionPago dCondicionPago;

        public static DCondicionPago getInstance()
        {
            if (dCondicionPago == null)
            {
                dCondicionPago = new DCondicionPago();
            }
            return dCondicionPago;
        }

        public DataTable DGetAllCondicionPago()
        {
            string sql = "SELECT codCondicionPago,desCondicionPago FROM CondicionPago";

            SqlDataAdapter adapter = new SqlDataAdapter();

            // Create the SelectCommand.
            SqlCommand command = new SqlCommand(sql, cn.Conectar);

            adapter.SelectCommand = command;

            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

        public DataTable DGetAllCondicionPagoByDesc(ECondicionPago ECondicionPago)
        {
            string sql = "SELECT codCondicionPago,desCondicionPago FROM CondicionPago where desCondicionPago like '%" + ECondicionPago.DesCondicionPago  +"%'";
            SqlDataAdapter adapter = new SqlDataAdapter();

            // Create the SelectCommand.
            SqlCommand command = new SqlCommand(sql, cn.Conectar);

            adapter.SelectCommand = command;

            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }
    }
}
