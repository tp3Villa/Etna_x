using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ETNA.SGI.Propiedades;
using ETNA.SGI.Entity.Interfaces;

namespace ETNA.SGI.Data.FabricaAbstractaDAO
{
    public abstract class FabricaAbstracta
    {
        public static FabricaAbstracta obtenerFabrica()
        {
            String direccion = Fabrica_Propiedades.Default.Fabrica;
            FabricaAbstracta fabrica = (FabricaAbstracta)(Activator.CreateInstance(null, direccion)).Unwrap();
            return fabrica;
        }

        public abstract daoILogin obtenerLogin();
        public abstract daoITablas obtenerTablas();
        public abstract daoITransaccion obtenerTransaccion();




    }
}
