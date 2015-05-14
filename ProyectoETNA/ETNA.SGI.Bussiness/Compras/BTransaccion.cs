using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ETNA.SGI.Data.Compras;
using ETNA.SGI.Entity.Compras;

namespace ETNA.SGI.Bussiness.Compras
{
    public class BTransaccion
    {
        DTransaccion oDatTab = new DTransaccion();

        public int BTransaccionVarias(string sql)
        {
            return oDatTab.DTransaccionVarias(sql);
        }

      
    }
}

