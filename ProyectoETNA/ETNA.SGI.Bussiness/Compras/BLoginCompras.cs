using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using ETNA.SGI.Data.Compras;
//
namespace ETNA.SGI.Bussiness.Compras
{
    public class BLoginCompras
    {
        DLoginCompras oDatTab = new DLoginCompras();

        public DataTable BLogueo(ETNA.SGI.Entity.Compras.ELogin ObjEn)
        {
            return oDatTab.DLogueo(ObjEn);
        }

    }
}