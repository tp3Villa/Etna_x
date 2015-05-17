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


        public DataTable getSELECTLIBRE(string SQL)
        {
            SqlDataAdapter da = new SqlDataAdapter(SQL, cn.Conectar);
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            return tabla;
        }

        public DataTable DGetAllCotizacion(ECotizacion eCotizacion)
        {
            string sql = "SELECT c.codCotizacion,c.codRequerimiento,p.razonSocial,c.descripcion,c.telefono, c.fechaExpiracion,e.desEstado " +
                              "FROM Cotizacion c " +
                              "INNER JOIN Proveedor p " +
                              "ON c.codProveedor = p.codProveedor " +
                              "INNER JOIN Estado e " +
                              "ON c.codEstado = e.codEstado " +
                          "WHERE  ( @codCotizacion = 0 OR c.codCotizacion = @codCotizacion ) " +
                          "AND ( @codRequerimiento = 0 OR c.codRequerimiento = @codRequerimiento ) " +
                          "AND ( @codEstado = 0 OR c.codEstado = @codEstado )";

            SqlDataAdapter adapter = new SqlDataAdapter();

            // Create the SelectCommand.
            SqlCommand command = new SqlCommand(sql, cn.Conectar);

            // Add the parameters for the SelectCommand.
            command.Parameters.Add("@codCotizacion", SqlDbType.Int);
            command.Parameters["@codCotizacion"].Value = eCotizacion.CodCotizacion;
            command.Parameters.Add("@codRequerimiento", SqlDbType.Int);
            command.Parameters["@codRequerimiento"].Value = eCotizacion.CodRequerimiento;
            command.Parameters.Add("@codEstado", SqlDbType.Int);
            command.Parameters["@codEstado"].Value = eCotizacion.CodEstado;

            adapter.SelectCommand = command;

            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

        public DataTable DGetCotizacionById(ECotizacion eCotizacion)
        {
            string sql = "SELECT c.codCotizacion,c.codRequerimiento,c.codProveedor, p.razonSocial,c.descripcion,c.telefono, c.fechaExpiracion,e.desEstado " +
                              "FROM Cotizacion c " +
                              "INNER JOIN Proveedor p " +
                              "ON c.codProveedor = p.codProveedor " +
                              "INNER JOIN Estado e " +
                              "ON c.codEstado = e.codEstado " +
                          "WHERE  ( @codCotizacion = 0 OR c.codCotizacion = @codCotizacion ) " +
                          "AND ( @codRequerimiento = 0 OR c.codRequerimiento = @codRequerimiento ) " +
                          "AND ( @codEstado = 0 OR c.codEstado = @codEstado )";

            SqlDataAdapter adapter = new SqlDataAdapter();

            // Create the SelectCommand.
            SqlCommand command = new SqlCommand(sql, cn.Conectar);

            // Add the parameters for the SelectCommand.
            command.Parameters.Add("@codCotizacion", SqlDbType.Int);
            command.Parameters["@codCotizacion"].Value = eCotizacion.CodCotizacion;
            command.Parameters.Add("@codRequerimiento", SqlDbType.Int);
            command.Parameters["@codRequerimiento"].Value = eCotizacion.CodRequerimiento;
            command.Parameters.Add("@codEstado", SqlDbType.Int);
            command.Parameters["@codEstado"].Value = eCotizacion.CodEstado;

            adapter.SelectCommand = command;

            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

        public DataTable DGetCotizacionDetalleById(ECotizacionDetalle eCotizacionDetalle)
        {
            string sql = "SELECT c.idProducto, p.descripcionProducto, c.cantidad,c.precioUnidad,c.descuento " +
                              "FROM CotizacionDetalle c " +
                               "INNER JOIN Producto p " +
                              "ON c.idProducto = p.idProducto " +
                          "WHERE  ( @codCotizacion = 0 OR c.codCotizacion = @codCotizacion ) ";

            SqlDataAdapter adapter = new SqlDataAdapter();

            // Create the SelectCommand.
            SqlCommand command = new SqlCommand(sql, cn.Conectar);

            // Add the parameters for the SelectCommand.
            command.Parameters.Add("@codCotizacion", SqlDbType.Int);
            command.Parameters["@codCotizacion"].Value = eCotizacionDetalle.CodCotizacion;
            adapter.SelectCommand = command;

            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;



        }

        public DataTable DGetAllCotizacionDetalle(ECotizacionDetalle eCotizacionDetalle)
        {
            string sql = "SELECT c.codCotizacion,c.idProducto,c.cantidad,c.precioUnidad,c.descuento " +
                              "FROM CotizacionDetalle c " +
                          "WHERE  ( @codCotizacion = 0 OR c.codCotizacion = @codCotizacion ) " +
                          "AND ( @idProducto = 0 OR c.idProducto = @idProducto ) ";

            SqlDataAdapter adapter = new SqlDataAdapter();

            // Create the SelectCommand.
            SqlCommand command = new SqlCommand(sql, cn.Conectar);

            // Add the parameters for the SelectCommand.
            command.Parameters.Add("@codCotizacion", SqlDbType.Int);
            command.Parameters["@codCotizacion"].Value = eCotizacionDetalle.CodCotizacion;
            command.Parameters.Add("@idProducto", SqlDbType.Int);
            command.Parameters["@idProducto"].Value = eCotizacionDetalle.IdProducto;

            adapter.SelectCommand = command;

            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
                        
        }
        public int DInsertCotizacion(ECotizacion eCotizacion)
        {
            int i = 0;
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;

                string sql = "INSERT INTO Cotizacion (codCotizacion, codRequerimiento ,codProveedor ,descripcion ,telefono ,fechaExpiracion ,codEstado, fechaRegistro, fechaActualizacion, usuarioRegistro, usuarioModificacion) " +
               " VALUES (@codCotizacion, @codRequerimiento, @codProveedor, @descripcion, @telefono, @fechaExpiracion, @codEstado, @fechaRegistro, @fechaActualizacion, @usuarioRegistro, @usuarioActualizacion)";

                // Configurando los parametros
                command.Parameters.Add("@codCotizacion", SqlDbType.Int);
                command.Parameters["@codCotizacion"].Value = eCotizacion.CodCotizacion;
                command.Parameters.Add("@codRequerimiento", SqlDbType.Int);
                command.Parameters["@codRequerimiento"].Value = eCotizacion.CodRequerimiento;
                command.Parameters.Add("@codProveedor", SqlDbType.Int);
                command.Parameters["@codProveedor"].Value = eCotizacion.CodRequerimiento;
                command.Parameters.Add("@descripcion", SqlDbType.VarChar);
                command.Parameters["@descripcion"].Value = eCotizacion.Descripcion;
                command.Parameters.Add("@telefono", SqlDbType.Int);
                command.Parameters["@telefono"].Value = eCotizacion.Telefono;
                command.Parameters.Add("@fechaExpiracion", SqlDbType.Date);
                command.Parameters["@fechaExpiracion"].Value = eCotizacion.FechaExpiracion;
                command.Parameters.Add("@codEstado", SqlDbType.Int);
                command.Parameters["@codEstado"].Value = eCotizacion.CodEstado;

                command.Parameters.Add("@fechaRegistro", SqlDbType.DateTime);
                command.Parameters["@fechaRegistro"].Value = eCotizacion.FechaRegistro;                
                command.Parameters.Add("@fechaActualizacion", SqlDbType.DateTime);
                command.Parameters["@fechaActualizacion"].Value = eCotizacion.FechaActualizacion;

                command.Parameters.Add("@usuarioRegistro", SqlDbType.VarChar);
                command.Parameters["@usuarioRegistro"].Value = eCotizacion.UsuarioRegistro;

                command.Parameters.Add("@usuarioActualizacion", SqlDbType.VarChar);
                command.Parameters["@usuarioActualizacion"].Value = eCotizacion.UsuarioModificacion;

                command.CommandText = sql;
                command.Connection = cn.Conectar;
                command.Connection.Open();
                command.ExecuteNonQuery();
                i = 1;
                command.Dispose();
                //command.Connection.Dispose();
                command.Connection.Close();
            }
            catch { throw; }
            return i;


        }


        public int DUpdateCotizacion(ECotizacion eCotizacion)
        {
            int i = 0;
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;

                string sql = "UPDATE INTO Cotizacion" +
                "SET descripcion = @descripcion " +
                           ",fechaExpiracion = @fechaExpiracion" +
                           ",telefono = @telefono'" +
                           ",fechaActualizacion = @fechaActualizacion'" +
                           ",usuarioModificacion = @usuarioActualizacion'" +
                      "WHERE codCotizacion = @codCotizacion";

      
                // Configurando los parametros
                command.Parameters.Add("@codCotizacion", SqlDbType.Int);
                command.Parameters["@codCotizacion"].Value = eCotizacion.CodCotizacion;
                command.Parameters.Add("@descripcion", SqlDbType.VarChar);
                command.Parameters["@descripcion"].Value = eCotizacion.Descripcion;
                command.Parameters.Add("@telefono", SqlDbType.Int);
                command.Parameters["@telefono"].Value = eCotizacion.Telefono;
                command.Parameters.Add("@fechaExpiracion", SqlDbType.Date);
                command.Parameters["@fechaExpiracion"].Value = eCotizacion.FechaExpiracion;
                command.Parameters.Add("@fechaActualizacion", SqlDbType.DateTime);
                command.Parameters["@fechaActualizacion"].Value = eCotizacion.FechaActualizacion;
                command.Parameters.Add("@usuarioActualizacion", SqlDbType.VarChar);
                command.Parameters["@usuarioActualizacion"].Value = eCotizacion.UsuarioModificacion;

                command.CommandText = sql;
                command.Connection = cn.Conectar;
                command.Connection.Open();
                command.ExecuteNonQuery();
                i = 1;
                command.Dispose();
                //command.Connection.Dispose();
                command.Connection.Close();
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
                // cn.Conectar.Dispose();
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

                string sql = "UPDATE Cotizacion SET codEstado='" + codEstado + "'  WHERE codCotizacion='" + codCotizacion + "'";
                cmd.CommandText = sql;
                cmd.Connection = cn.Conectar;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                i = 1;
                cmd.Dispose();
                //cn.Conectar.Dispose();
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
                //  cn.Conectar.Dispose();
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
                // cn.Conectar.Dispose();
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
                //cn.Conectar.Dispose();
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
                //cn.Conectar.Dispose();
                cn.Conectar.Close();
            }
            catch { throw; }
            return i;
        }

        public DataTable DGetCotizacionAprobacion()
        {
            //string sql = "select codCotizacion ,descripcion , codRequerimiento , fechaExpiracion from Cotizacion a INNER JOIN Proveedor b where a.codEstado = 4 and b.codProveedor = a.codProveedor and codCotizacion not in (select c.codCotizacion from OrdenCompra c where c.codCotizacion = a.codCotizacion and c.codRequerimiento = a.codRequerimiento )";
            string sql = "select codCotizacion ,descripcion , codRequerimiento , fechaExpiracion from Cotizacion a where a.codEstado =@codEstado and a.codCotizacion not in (select c.codCotizacion from OrdenCompra c where c.codCotizacion = a.codCotizacion and c.codRequerimiento = a.codRequerimiento )";

            SqlDataAdapter adapter = new SqlDataAdapter();

            // Create the SelectCommand.
            SqlCommand command = new SqlCommand(sql, cn.Conectar);

            // Add the parameters for the SelectCommand.
            command.Parameters.Add("@codEstado", SqlDbType.Int);
            command.Parameters["@codEstado"].Value = 4;
            adapter.SelectCommand = command;

            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

    }
}
