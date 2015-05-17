using ETNA.SGI.Data.Compras;
using ETNA.SGI.Entity.Compras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ETNA.SGI.Bussiness.Compras
{
    public class BEstado
    {

        private DEstado dEstado = DEstado.getInstance();

        private static BEstado bEstado;

        public static BEstado getInstance()
        {
            if (bEstado == null)
            {
                bEstado = new BEstado();
            }
            return bEstado;
        }
        
        public DataTable ObtenerListadoEstadoPorOrdenCompra()
        {
            return dEstado.DGetAllEstadoByOrdenCompra();
        }

    }
}
