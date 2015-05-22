using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ETNA.SGI.Entity.Interfaces
{
    public interface negITablas
    {
        DataTable getSELECTLIBRE(string SQL);
        DataTable BPaises();
        DataTable BPaisesIATA(string cod_pai);
        DataTable BClienteCodRaz();
        DataTable BProducto();
        DataTable BProductoBusquedaXCodigo(string Bus);
        DataTable BCorrelativo();
        DataTable BRequerimientoBusquedaXCodigoCliente(string Bus);
        DataTable BRequerimientoDetalleXCodREQ(string Req);
        DataTable BRequerimientoCabeceraXCodREQ(string Req);
        DataTable BRequerimientos();
        DataTable BRequerimientosBUSQUEDAANIDAD(string Cod_Req, string Razon, decimal desde, decimal hasta);

        //Taller de Proyecto 3 aplicacion de patrones
        DataTable BConsula_Aprobacion_Solicitudes(string Estado1, string Estado2, string fecha1, string fecha2, int opcion);
        DataTable BConsula_Versiones_Documentos_Detalle(int Estado1, string Estado2, string fecha1, string fecha2, int opcion);

    }
}
