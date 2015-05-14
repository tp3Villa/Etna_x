using ETNA.SGI.Data.Compras;
using ETNA.SGI.Entity.Compras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ETNA.SGI.Bussiness.Compras
{
    class BProveedor
    {
        DProveedor oDatTab = new DProveedor();

        public DataTable BCorrelativoProveedor()
        {
            return oDatTab.DCorrelativoProveedor();
        }

        public int BInsertProveedor(EProveedor EProveedor)
        {
            return oDatTab.DInsertProveedor(EProveedor);
        }
    }
}
