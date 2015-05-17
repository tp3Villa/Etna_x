using ETNA.SGI.Entity.Compras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace ETNA.SGI.Data.Compras
{
    public class DCotizacion
    {
        private DConexion cn = new DConexion();

        private static DCotizacion dCotizacion;

        public static DCotizacion getInstance()
        {
            if (dCotizacion == null)
            {
                dCotizacion = new DCotizacion();
            }
            return dCotizacion;
        }

        public DataTable DCorrelativoCotizacion()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT count(*)+1 AS corr FROM Cotizacion", cn.Conectar);
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            return tabla;
        }

        public DataSet DGetEstados()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT codEstado, desEstado FROM Estado", cn.Conectar);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public DataTable DGetAllCotizacionByReq(string codRequerimiento)
        {
            string sql = "SELECT codCotizacion, codRequerimiento ,codProveedor ,descripcion ,telefono ,fechaExpiracion ,codEstado FROM Cotizacion " +
                        "WHERE codRequerimiento = '" + codRequerimiento + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn.Conectar);
            DataTable tabla = new DataTable();
            try
            {
                da.Fill(tabla);
            }
            catch { }
            return tabla;
        }


        public DataTable getSELECTLIBRE(string SQL)
        {
            SqlDataAdapter da = new SqlDataAdapter(SQL, cn.Conectar);
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            return tabla;
        }

        public DataTable DGetAllCotizacion(ECotizacion ECotizacion)
        {
            string sql = "SELECT codCotizacion, codRequerimiento ,codProveedor ,descripcion ,telefono ,fechaExpiracion ,codEstado FROM Cotizacion " +
                          "WHERE descripcion like '%" + ECotizacion.Descripcion + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn.Conectar);
            DataTable tabla = new DataTable();
            try
            {
                da.Fill(tabla);
            }
            catch { }
            return tabla;

        }


        public DataTable DGetAllCotizacionDetalle(ECotizacionDetalle ECotizacionDetalle)
        {
            string sql = "SELECT codCotizacion, idProducto ,cantidad ,precioUnidad, descuetno FROM CotizacionDetalle " +
                          "WHERE codCotizacion '" + ECotizacionDetalle.CodCotizacion + " ' AND idProducto= '" + ECotizacionDetalle.IdProducto + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn.Conectar);
            DataTable tabla = new DataTable();
            try
            {
                da.Fill(tabla);
            }
            catch { }
            return tabla;

        }
        public int DInsertCotizacion(ECotizacion ECotizacion)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "INSERT INTO Cotizacion (codCotizacion, codRequerimiento ,codProveedor ,descripcion ,telefono ,fechaExpiracion ,codEstado) " +
                " VALUES (" + ECotizacion.CodCotizacion + ", '" + ECotizacion.CodRequerimiento + "', '" + ECotizacion.CodProveedor + "', " +
                " " + ECotizacion.Descripcion + ", '" + ECotizacion.Telefono + "', '" + ECotizacion.FechaExpiracion + "', " +
                " " + ECotizacion.CodEstado + "')";


                cmd.CommandText = sql;
                cmd.Connection = cn.Conectar;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                i = 1;
                cmd.Dispose();
                cn.Conectar.Dispose();
                cn.Conectar.Close();
            }
            catch { throw; }
            return i;
        }

        public int DUpdateCotizacion(ECotizacion ECotizacion)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "UPDATE Cotizacion" +
                             "SET descripcion = '" + ECotizacion.Descripcion + "'" +
                              ",fechaExpiracion = '" + ECotizacion.FechaExpiracion + "'" +
                              ",telefono = " + ECotizacion.Telefono + "'" +
                         "WHERE codCotizacion = " + ECotizacion.CodCotizacion;

                cmd.CommandText = sql;
                cmd.Connection = cn.Conectar;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                i = 1;
                cmd.Dispose();
                cn.Conectar.Dispose();
                cn.Conectar.Close();
            }
            catch { throw; }
            return i;
        }

        public int DUpdateEstadoCotizacion(int codCotizacion, int codEstado)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "UPDATE Cotizacion SET Est_Cab_Req='" + codEstado + "'  WHERE codCotizacion='" + codCotizacion + "'";
                cmd.CommandText = sql;
                cmd.Connection = cn.Conectar;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                i = 1;
                cmd.Dispose();
                cn.Conectar.Dispose();
                cn.Conectar.Close();
            }
            catch { throw; }
            return i;
        }

        public int DDeleteCotizacion(int codCotizacion)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "DELETE Cotizacion WHERE codCotizacion = " + codCotizacion;

                cmd.CommandText = sql;
                cmd.Connection = cn.Conectar;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                i = 1;
                cmd.Dispose();
                cn.Conectar.Dispose();
                cn.Conectar.Close();
            }
            catch { throw; }
            return i;
        }


        public int DInsertCotizacionDetalle(ECotizacionDetalle ECotizacionDetalle)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "INSERT INTO CotizacionDetalle (codCotizacion, idProducto ,cantidad  ,precioUnidad, descuento) " +
                " VALUES (" + ECotizacionDetalle.CodCotizacion + ", '" + ECotizacionDetalle.IdProducto + "', '" + ECotizacionDetalle.Cantidad + "', " + "', '" + ECotizacionDetalle.Descuento + "', " +
                " " + ECotizacionDetalle.PrecioUnidad + "')";


                cmd.CommandText = sql;
                cmd.Connection = cn.Conectar;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                i = 1;
                cmd.Dispose();
                cn.Conectar.Dispose();
                cn.Conectar.Close();
            }
            catch { throw; }
            return i;
        }

        public int DUpdateCotizacionDetalle(ECotizacionDetalle ECotizacionDetalle)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "UPDATE CotizacionDetalle" +
                             "SET precioUnidad = '" + ECotizacionDetalle.PrecioUnidad + "'" +
                              ",descuento = '" + ECotizacionDetalle.Descuento + "'" +
                         "WHERE codCotizacion = '" + ECotizacionDetalle.CodCotizacion + "' AND " +
                         " idProducto = '" + ECotizacionDetalle.IdProducto + "' ";

                cmd.CommandText = sql;
                cmd.Connection = cn.Conectar;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                i = 1;
                cmd.Dispose();
                cn.Conectar.Dispose();
                cn.Conectar.Close();
            }
            catch { throw; }
            return i;
        }


        public int DDeleteCotizacionDetalle(int codCotizacion, int idProducto)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "DELETE CotizacionDetalle WHERE codCotizacion = '" + codCotizacion + "' AND idProducto ='" + idProducto + "'";

                cmd.CommandText = sql;
                cmd.Connection = cn.Conectar;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                i = 1;
                cmd.Dispose();
                cn.Conectar.Dispose();
                cn.Conectar.Close();
            }
            catch { throw; }
            return i;
        }

    }
}
