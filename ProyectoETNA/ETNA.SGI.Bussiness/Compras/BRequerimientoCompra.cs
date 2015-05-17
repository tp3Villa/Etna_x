using ETNA.SGI.Data.Compras;
using ETNA.SGI.Entity.Compras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
namespace ETNA.SGI.Bussiness.Compras
{
    public class BRequerimientoCompra
    {

        private DRequerimientoCompra dRequerimientoCompra = DRequerimientoCompra.getInstance();

        private static BRequerimientoCompra bRequerimientoCompra;

        public static BRequerimientoCompra getInstance()
        {
            if (bRequerimientoCompra == null)
            {
                bRequerimientoCompra = new BRequerimientoCompra();
            }
            return bRequerimientoCompra;
        }

        public DataTable ObtenerListadoRequerimientoCompraCotizacion(ERequerimientoCompra eRequerimientoCompra)
        {
            return dRequerimientoCompra.DGetAllRequerimientoCompraCotizacion(eRequerimientoCompra);
        }


    }
}
