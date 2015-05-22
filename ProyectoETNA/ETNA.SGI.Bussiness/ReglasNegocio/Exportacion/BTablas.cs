using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using ETNA.SGI.Data.Exportacion.PersistenciaSQL;
using ETNA.SGI.Data.FabricaAbstractaDAO;
using ETNA.SGI.Entity.Interfaces;



namespace ETNA.SGI.Bussiness.ReglasNegocio.Exportacion
{
    public class BTablas : negITablas
    {
        public DataTable getSELECTLIBRE(string SQL)
        {
            //return oDatTab.getSELECTLIBRE(SQL);
            return FabricaAbstracta.obtenerFabrica().obtenerTablas().getSELECTLIBRE(SQL);
        }

        public DataTable BPaises()
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTablas().DPaises();
        }

        public DataTable BPaisesIATA(string cod_pai)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTablas().DPaisesIATA(cod_pai);
        }

        public DataTable BClienteCodRaz()
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTablas().DClienteCodRaz();
        }

        
        public DataTable BProducto()
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTablas().DProducto();
        }

        public DataTable BProductoBusquedaXCodigo(string Bus)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTablas().DProductoBusquedaXCodigo(Bus);
        }

        public DataTable BCorrelativo()
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTablas().DCorrelativo();
        }

        public DataTable BRequerimientoBusquedaXCodigoCliente(string Bus)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTablas().DRequerimientoBusquedaXCodigoCliente(Bus);
        }

        public DataTable BRequerimientoDetalleXCodREQ(string Req)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTablas().DRequerimientoDetalleXCodREQ(Req);
        }

        public DataTable BRequerimientoCabeceraXCodREQ(string Req)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTablas().DRequerimientoCabeceraXCodREQ(Req);
        }

        public DataTable BRequerimientos()
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTablas().DRequerimientos();
        }

        public DataTable BRequerimientosBUSQUEDAANIDAD(string Cod_Req, string Razon, decimal desde, decimal hasta)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTablas().DRequerimientosBUSQUEDAANIDAD(Cod_Req, Razon, desde, hasta);
        }



        //TALLER DE PROYECTOS 3 APLICACION DE PATRONES 
        public DataTable BConsula_Aprobacion_Solicitudes(string Estado1, string Estado2, string fecha1, string fecha2, int opcion)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTablas().DListaSolicitudesPendienteAprobacion(Estado1, Estado2, fecha1, fecha2, opcion);
        }


        public DataTable BConsula_Versiones_Documentos_Detalle(int Estado1, string Estado2, string fecha1, string fecha2, int opcion)
        {
            return FabricaAbstracta.obtenerFabrica().obtenerTablas().DListaDocumentosVersionDetalle(Estado1, Estado2, fecha1, fecha2, opcion);
        }
    }
}
