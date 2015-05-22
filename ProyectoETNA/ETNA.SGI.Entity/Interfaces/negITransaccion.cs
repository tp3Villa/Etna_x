using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ETNA.SGI.Entity.Entidades.Exportacion;

namespace ETNA.SGI.Entity.Interfaces
{
    public interface negITransaccion
    {
        int BTransaccionVarias(string sql);
        int BInsertCabReq(eReqCab eReqCab);
        int BInsertDetReq(EReqDetalle eReqDet);
        int DDeleteCabReq(string REQ);
        int DDeleteDetReq(string REQ);
        int BUpdateEstadoReq(string REQ);
        int BInserUsuario(ELogin eLogin);
        int DDeleteUSUARIO(string Usuario);
        int DUpdateUSUARIO(string Usuario, string set);
        int BInserUsuMenu(string Usu, string opc);
        int BDeleteUsuMenu(string Usu);
    }
}
