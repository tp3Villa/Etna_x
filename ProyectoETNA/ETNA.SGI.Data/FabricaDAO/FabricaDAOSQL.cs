using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ETNA.SGI.Data.FabricaAbstractaDAO;
using ETNA.SGI.Entity.Interfaces;
using ETNA.SGI.Data.Exportacion.PersistenciaSQL;

namespace ETNA.SGI.Data.FabricaDAO
{
    public class FabricaDAOSQL : FabricaAbstracta
    {
        public override Entity.Interfaces.daoILogin obtenerLogin()
        {
            daoILogin objeto = (daoILogin)(new daoLoginSQL());
            return objeto;
        }

        public override Entity.Interfaces.daoITablas obtenerTablas()
        {
            daoITablas objeto = (daoITablas)(new daoTablasSQL());
            return objeto;
        }

        public override Entity.Interfaces.daoITransaccion obtenerTransaccion()
        {
            daoITransaccion objeto = (daoITransaccion)(new daoTransaccionSQL());
            return objeto;
        }
    }
}
