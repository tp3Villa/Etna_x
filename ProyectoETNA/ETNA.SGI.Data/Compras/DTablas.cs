using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;


namespace ETNA.SGI.Data.Compras
{
    public class DTablas
    {
        DConexion cn = new DConexion();


        public DataTable DProducto()
        {
            //iDB2DataAdapter da = new iDB2DataAdapter("SELECT R01CPE AS CODIGO,R01NOM AS NOMBRE FROM QS36F.RIPMGEN5 ORDER BY R01CPE", cn.Conectar);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM producto", cn.Conectar);
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            return tabla;
        }

    
    }
}
