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

        private DConexion cn = new DConexion();

        private static DProveedor dProveedor;

        public static DProveedor getInstance()
        {
            if (dProveedor == null){
                dProveedor = new DProveedor();
            }
            return dProveedor;
        }        

        public DataTable DCorrelativoProveedor()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT count(*)+1 AS corr FROM Proveedor", cn.Conectar);
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            return tabla;
        }

        public DataTable DGetAllProveedor(EProveedor EProveedor)
        {
            string sql = "SELECT codProveedor,razonSocial,direccion,telefono,fechaRegistro,email,ruc,observacion,(CASE codEstado when 5 then 'Activo' else 'Inactivo' end)  estado FROM Proveedor " +
                          "WHERE razonSocial like '%" + EProveedor.RazonSocial + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn.Conectar);
            DataTable tabla = new DataTable();
            try
            {
                da.Fill(tabla);
            }
            catch {  }
            return tabla;
                
        }

        public DataTable DGetProveedorById(EProveedor EProveedor)
        {
            string sql = "SELECT codProveedor,razonSocial,direccion,telefono,fechaRegistro,email,ruc,observacion,codCondicionPago,codEstado FROM Proveedor " +
                          "WHERE codProveedor = " + EProveedor.CodProveedor + "";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn.Conectar);
            DataTable tabla = new DataTable();
            try
            {
                da.Fill(tabla);
            }
            catch { }
            return tabla;

        }

        public DataTable DGetProveedorWithStatus(EProveedor EProveedor)
        {
            string sql = "SELECT codProveedor,razonSocial,direccion,telefono,fechaRegistro,email,ruc,observacion, (CASE codEstado when 5 then 'Activo' else 'Inactivo' end)  estado FROM Proveedor " +
                          "WHERE razonSocial like '%" + EProveedor.RazonSocial + "%' and codEstado ="+EProveedor.CodEstado+"";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn.Conectar);
            DataTable tabla = new DataTable();
            try
            {
                da.Fill(tabla);
            }
            catch { }
            return tabla;

        }

        public int DInsertProveedor(EProveedor EProveedor)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "INSERT INTO Proveedor (codProveedor, razonSocial, direccion, telefono, fechaRegistro, email, ruc, observacion,codCondicionPago,codEstado,usuarioRegistro) " +
                " VALUES (" + EProveedor.CodProveedor + ", '" + EProveedor.RazonSocial + "', '" + EProveedor.Direccion + "', " +
                " " + EProveedor.Telefono + ", '" + EProveedor.FechaRegistro + "', '" + EProveedor.Email + "', " +
                " " + EProveedor.Ruc + ", '" + EProveedor.Observacion + "'" +
                ", '" + EProveedor.CodCondicionPago + "'"  +
                ", '" + EProveedor.CodEstado + "'" +
                ", '" + EProveedor.UsuarioRegistro + "'" +
                ")";


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

        public int DUpdateProveedor(EProveedor EProveedor)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "UPDATE Proveedor" +
                             " SET razonSocial = '" + EProveedor.RazonSocial + "'" +
                              ",direccion = '" + EProveedor.Direccion + "'" +
                              ",telefono = " + EProveedor.Telefono +
                              ",fechaRegistro = '" + EProveedor.FechaRegistro +"'"+
                              ",email = '" + EProveedor.Email + "'" +
                              ",ruc = " + EProveedor.Ruc +
                              ",observacion = '" + EProveedor.Observacion + "'" +
                              ",codCondicionPago = " + EProveedor.CodCondicionPago +
                              ",codEstado = " + EProveedor.CodEstado +
                              ",fechaActualizacion = '" + EProveedor.FechaActualizacion + "'" +
                              ",usuarioModificacion = '" + EProveedor.UsuarioModificacion.Trim() + "'" +
                         " WHERE codProveedor = " + EProveedor.CodProveedor;

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

        public int DDeleteProveedor(int CodProveedor)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "DELETE Proveedor WHERE codProveedor = " + CodProveedor;

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
