using ETNA.SGI.Data.Compras;
using ETNA.SGI.Entity.Compras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ETNA.SGI.Bussiness.Compras
{
    public class BCategoria
    {

        private DCategoria dCategoria = DCategoria.getInstance();

        private static BCategoria bCategoria;

        public static BCategoria getInstance()
        {
            if (bCategoria == null)
            {
                bCategoria = new BCategoria();
            }
            return bCategoria;
        }
        
        public DataTable ObtenerListadoCategoria()
        {
            return dCategoria.DGetAllCategoria();
        }

    }
}
