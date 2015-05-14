using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using ETNA.SGI.Data.Compras;

//

namespace ETNA.SGI.Bussiness.Compras
{
    public class BTablas
    {
        DTablas oDatTab = new DTablas();

        public DataTable getSELECTLIBRE(string SQL)
        {
            return oDatTab.getSELECTLIBRE(SQL);
        }

           public DataTable BProducto()
        {
            return oDatTab.DProducto();
        }

        public DataTable BProductoBusquedaXCodigo(string Bus)
        {
            return oDatTab.DProductoBusquedaXCodigo(Bus);
        }

     
    }
}
