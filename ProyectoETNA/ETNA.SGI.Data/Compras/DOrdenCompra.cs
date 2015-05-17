using ETNA.SGI.Entity.Compras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ETNA.SGI.Data.Compras
{
    public class DOrdenCompra
    {
        private DConexion cn = new DConexion();

        private static DOrdenCompra dOrdenCompra;

        public static DOrdenCompra getInstance()
        {
            if (dOrdenCompra == null)
            {
                dOrdenCompra = new DOrdenCompra();
            }
            return dOrdenCompra;
        }

        public DataTable DCorrelativoOrdenCompra()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT count(*)+1 AS corr FROM OrdenCompra", cn.Conectar);
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            return tabla;
        }

        public DataTable DGetAllOrdenCompra(EOrdenCompra EOrdenCompra)
        {
            string sql = "SELECT oc.codOrdenCompra,oc.codRequerimiento,oc.codCotizacion,p.razonSocial,oc.codEstado,e.desEstado,oc.fechaEntrega,oc.lugarEntrega " +
                              "FROM OrdenCompra oc " +
                              "INNER JOIN Cotizacion c " +
                              "ON oc.codCotizacion = c.codCotizacion " +
                              "INNER JOIN Proveedor p " +
                              "ON c.codProveedor = p.codProveedor " +
                              "INNER JOIN Estado e " +
                              "ON oc.codEstado = e.codEstado " +
                          "WHERE  ( @codOrdenCompra = 0 OR oc.codOrdenCompra = @codOrdenCompra ) " +
                          "AND ( @codRequerimiento = 0 OR oc.codRequerimiento = @codRequerimiento ) " +
                          "AND ( @codEstado = 0 OR oc.codEstado = @codEstado )";
            
            SqlDataAdapter adapter = new SqlDataAdapter();

            // Create the SelectCommand.
            SqlCommand command = new SqlCommand(sql, cn.Conectar);

            // Add the parameters for the SelectCommand.
            command.Parameters.Add("@codOrdenCompra", SqlDbType.Int);
            command.Parameters["@codOrdenCompra"].Value = EOrdenCompra.CodOrdenCompra;
            command.Parameters.Add("@codRequerimiento", SqlDbType.Int);
            command.Parameters["@codRequerimiento"].Value = EOrdenCompra.CodRequerimiento;
            command.Parameters.Add("@codEstado", SqlDbType.Int);
            command.Parameters["@codEstado"].Value = EOrdenCompra.CodEstado;

            adapter.SelectCommand = command;

            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }
    }
}
