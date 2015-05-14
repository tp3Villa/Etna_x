using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

using ETNA.SGI.Entity.Compras;


namespace ETNA.SGI.Data.Compras
{
    public class DTransaccionCompras
    {
        DConexion cn = new DConexion();

        public int DTransaccionVarias(string sql)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
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


        
        public int DInsertProveedor(EProveedor EProveedor)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "INSERT INTO Proveedor (codProveedor, razonSocial, direccion, telefono, fechaRegistro, email, ruc, observacion) " +
                " VALUES (" + EProveedor.CodProveedor + ", " + EProveedor.RazonSocial + ", '" + EProveedor.Direccion + "', " +
                " '" + EProveedor.Telefono + "', '" + EProveedor.FechaRegistro + "', " + EProveedor.Email + ", " +
                " " + EProveedor.Ruc +   "', '" + EProveedor.Observacion + "')";
                            
                
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
