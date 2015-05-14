using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

using ETNA.SGI.Entity.Compras;


namespace ETNA.SGI.Data.Compras
{
    public class DTransaccion
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


        /*
        public int DInsertCabReq(eReqCab eReqCab)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "INSERT INTO Requerimiento (Cod_Cab_Req, Cli_Cab_Req, Pais_Cab_Req, Destino_Cab_Req, IATA_Cab_Req, Fec_Reg_Cab_Req, Fec_Esp_Cab_Req, Pre_Tot_Cab_Req, Est_Cab_Req, Obs_Cab_Req) " +
                " VALUES (" + eReqCab.Cod_Cab_Req + ", " + eReqCab.Cli_Cab_Req + ", '" + eReqCab.Pais_Cab_Req + "', " +
                " '" + eReqCab.Destino_Cab_Req + "', '" + eReqCab.IATA_Cab_Req + "', " + eReqCab.Fec_Reg_Cab_Req + ", " +
                " " + eReqCab.Fec_Esp_Cab_Req + ", " + eReqCab.Pre_Tot_Cab_Req + ", '" + eReqCab.Est_Cab_Req + "', '" + eReqCab.Obs_Cab_Req + "')";
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

        */

    }
}
