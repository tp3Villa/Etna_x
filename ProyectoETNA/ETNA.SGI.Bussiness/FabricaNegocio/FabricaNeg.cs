using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ETNA.SGI.Entity.Interfaces;
using ETNA.SGI.Bussiness.ReglasNegocio.Exportacion;

namespace ETNA.SGI.Bussiness.FabricaNegocio
{
    public class FabricaNeg
    {
        //patron Singlenton (Permite crear una sola instancia del Objeto)

        private static FabricaNeg instancia = null;
        public static FabricaNeg _instancia() 
        {
            if (instancia == null)
            {
                instancia = new FabricaNeg();            
            }
            return instancia;
        }

        public negILogin ObtenerLogin()
        {
            negILogin objeto = (negILogin)(new BLogin());
            return objeto;
        }

        public negITablas ObtenerTablas()
        {
            negITablas objeto = (negITablas)(new BTablas());
            return objeto;
        }

        public negITransaccion ObtenerTransaccion()
        {
            negITransaccion objeto = (negITransaccion)(new BTransaccion());
            return objeto;
        }
    }
}
