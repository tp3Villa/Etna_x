using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using ETNA.SGI.Data.Compras;
//
namespace ETNA.SGI.Bussiness.Compras
{
    public class BLogin
    {
        DLogin oDatTab = new DLogin();

        public DataTable BLogueo(ETNA.SGI.Entity.Compras.ELogin ObjEn)
        {
            return oDatTab.DLogueo(ObjEn);
        }

    }
}