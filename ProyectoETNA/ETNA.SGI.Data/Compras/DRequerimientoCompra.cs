using ETNA.SGI.Entity.Compras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace ETNA.SGI.Data.Compras
{
    public class DRequerimientoCompra
    {

        private DConexion cn = new DConexion();

        private static DRequerimientoCompra dRequerimientoCompra;

        public static DRequerimientoCompra getInstance()
        {
            if (dRequerimientoCompra == null)
            {
                dRequerimientoCompra = new DRequerimientoCompra();
            }
            return dRequerimientoCompra;
        }

        public DataTable DGetAllRequerimientoCompraCotizacion(ERequerimientoCompra eRequerimientoCompra)
        {
            string sql = "SELECT rc.codRequerimiento, c.desCategoria, rc.fechaRegistro, rc.observacion " +
                              "FROM RequerimientoCompra rc " +
                              "INNER JOIN Categoria c " +
                              "ON rc.codCategoria = c.codCategoria " +
                          "WHERE  ( @codRequerimiento = 0 OR rc.codRequerimiento = @codRequerimiento ) " +
                          "AND ( @codCategoria = 0 OR rc.codCategoria = @codCategoria ) " +
                          "AND rc.codEstado='2' ";

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand(sql, cn.Conectar);

            // Configurando los parametros
            command.Parameters.Add("@codRequerimiento", SqlDbType.Int);
            command.Parameters["@codRequerimiento"].Value = eRequerimientoCompra.CodRequerimiento;
            command.Parameters.Add("@codCategoria", SqlDbType.Int);
            command.Parameters["@codCategoria"].Value = eRequerimientoCompra.CodCategoria;

            adapter.SelectCommand = command;

            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

    }
}
