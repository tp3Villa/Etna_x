using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ETNA.SGI.Data.Exportacion;
using ETNA.SGI.Data.Exportacion.PersistenciaSQL;
using ETNA.SGI.Entity.Entidades.Exportacion;
using ETNA.SGI.Data.FabricaAbstractaDAO;
using ETNA.SGI.Entity.Interfaces;

namespace ETNA.SGI.Bussiness.ReglasNegocio.Exportacion
{
    public class BTransaccion : negITransaccion
    {
        //daoTransaccionSQL oDatTab = new daoTransaccionSQL();
        public int BTransaccionVarias(string sql)
        {
            //return oDatTab.DTransaccionVarias(sql);
            return FabricaAbstracta.obtenerFabrica().obtenerTransaccion().DTransaccionVarias(sql);
        }

        public int BInsertCabReq(eReqCab eReqCab)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTransaccion().DInsertCabReq(eReqCab);
        }

        public int BInsertDetReq(EReqDetalle eReqDet)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTransaccion().DInsertDetReq(eReqDet);
        }

        public int DDeleteCabReq(string REQ)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTransaccion().DDeleteCabReq(REQ);
        }

        public int DDeleteDetReq(string REQ)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTransaccion().DDeleteDetReq(REQ);
        }

        public int BUpdateEstadoReq(string REQ)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTransaccion().DUpdateEstadoReq(REQ);
        }

        public int BInserUsuario(ELogin eLogin)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTransaccion().DInserUsuario(eLogin);
        }

        public int DDeleteUSUARIO(string Usuario)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTransaccion().DDeleteUSUARIO(Usuario);
        }

        public int DUpdateUSUARIO(string Usuario,string set)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTransaccion().DUpdateUSUARIO(Usuario, set);
        }

        public int BInserUsuMenu(string Usu, string opc)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTransaccion().DInserUsuMenu(Usu, opc);
        }

        public int BDeleteUsuMenu(string Usu)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTransaccion().DDeleteUsuMenu(Usu);
        }
    }
}
