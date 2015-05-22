using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using ETNA.SGI.Data.Exportacion;

using ETNA.SGI.Data.Exportacion.PersistenciaSQL;
using ETNA.SGI.Data.FabricaAbstractaDAO;
using ETNA.SGI.Entity.Interfaces;

namespace ETNA.SGI.Bussiness.ReglasNegocio.Exportacion
{
    public class BLogin : negILogin
    {
        public DataTable BLogueo(ETNA.SGI.Entity.Entidades.Exportacion.ELogin ObjEn)
        {
            //return oDatTab.DLogueo(ObjEn);
            return FabricaAbstracta.obtenerFabrica().obtenerLogin().DLogueo(ObjEn);
        }

    }
}
