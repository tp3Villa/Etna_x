using ETNA.SGI.Entity.Compras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ETNA.SGI.Data.Compras
{
    public class DProveedor
    {
        DConexion cn = new DConexion();

        public DataTable DCorrelativoProveedor()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT count(*)+1 AS corr FROM Proveedor", cn.Conectar);
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            return tabla;
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
                " " + EProveedor.Ruc + "', '" + EProveedor.Observacion + "')";


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
