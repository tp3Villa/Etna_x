using ETNA.SGI.Entity.Compras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ETNA.SGI.Data.Compras
{
    public class DEstado
    {
        private DConexion cn = new DConexion();

        private static DEstado dEstado;

        public static DEstado getInstance()
        {
            if (dEstado == null)
            {
                dEstado = new DEstado();
            }
            return dEstado;
        }

        public DataTable DGetAllEstadoByOrdenCompra()
        {
            string sql = "SELECT codEstado,desEstado FROM Estado where codEstado in (4,3)";

            SqlDataAdapter adapter = new SqlDataAdapter();

            // Create the SelectCommand.
            SqlCommand command = new SqlCommand(sql, cn.Conectar);
            
            adapter.SelectCommand = command;
                
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

        public DataTable DGetAllEstadoByCotizacion()
        {
            string sql = "SELECT codEstado,desEstado FROM Estado where codEstado in (4,2)";

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
