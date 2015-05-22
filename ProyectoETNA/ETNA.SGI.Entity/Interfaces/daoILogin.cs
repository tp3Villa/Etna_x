using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ETNA.SGI.Entity.Interfaces
{
    public interface daoILogin
    {
        DataTable DLogueo(ETNA.SGI.Entity.Entidades.Exportacion.ELogin ObjEn);
    }
}
