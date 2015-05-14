using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ETNA.SGI.Data.Compras;
using ETNA.SGI.Entity.Compras;

namespace ETNA.SGI.Bussiness.Compras
{
    public class BTransaccionCompras
    {
        DTransaccionCompras oDatTab = new DTransaccionCompras();

        public int BTransaccionVarias(string sql)
        {
            return oDatTab.DTransaccionVarias(sql);
        }



        public int BInsertProveedor(EProveedor EProveedor)
        {
            return oDatTab.DInsertProveedor(EProveedor);
        }

      
    }
}

