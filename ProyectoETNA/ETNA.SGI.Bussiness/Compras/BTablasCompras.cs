using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using ETNA.SGI.Data.Compras;

//

namespace ETNA.SGI.Bussiness.Compras
{
    public class BTablasCompras
    {
        DTablasCompras oDatTab = new DTablasCompras();

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

        public DataTable BCorrelativoProveedor()
        {
            return oDatTab.DCorrelativoProveedor();
        }
    }
}
