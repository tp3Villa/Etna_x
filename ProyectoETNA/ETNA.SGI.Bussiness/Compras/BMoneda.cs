using ETNA.SGI.Data.Compras;
using ETNA.SGI.Entity.Compras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ETNA.SGI.Bussiness.Compras
{
    public class BMoneda
    {

        private DMoneda dMoneda = DMoneda.getInstance();

        private static BMoneda bMoneda;

        public static BMoneda getInstance()
        {
            if (bMoneda == null)
            {
                bMoneda = new BMoneda();
            }
            return bMoneda;
        }
        
        public DataTable ObtenerListadoMoneda()
        {
            return dMoneda.DGetAllMoneda();
        }

    }
}
