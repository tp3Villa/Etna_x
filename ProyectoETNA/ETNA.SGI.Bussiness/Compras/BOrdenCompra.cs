using ETNA.SGI.Data.Compras;
using ETNA.SGI.Entity.Compras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ETNA.SGI.Bussiness.Compras
{
    public class BOrdenCompra
    {

        private DOrdenCompra dOrdenCompra = DOrdenCompra.getInstance();

        private static BOrdenCompra bOrdenCompra;

        public static BOrdenCompra getInstance()
        {
            if (bOrdenCompra == null)
            {
                bOrdenCompra = new BOrdenCompra();
            }
            return bOrdenCompra;
        }

        public DataTable ObtenerListadoOrdenCompra(EOrdenCompra EOrdenCompra)
        {
            return dOrdenCompra.DGetAllOrdenCompra(EOrdenCompra);
        }

        public int ActualizarEstadoOrdenCompra(EOrdenCompra eOrdenCompra)
        {
            return dOrdenCompra.DUpdateEstadoOrdenCompra(eOrdenCompra);
        }

    }
}
