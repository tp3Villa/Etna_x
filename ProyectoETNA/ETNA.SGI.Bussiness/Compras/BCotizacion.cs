using ETNA.SGI.Data.Compras;
using ETNA.SGI.Entity.Compras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ETNA.SGI.Bussiness.Compras
{
    public class BCotizacion
    {
        private DCotizacion dCotizacion = DCotizacion.getInstance();

        private static BCotizacion bCotizacion;

        public static BCotizacion getInstance()
        {
            if (bCotizacion == null)
            {
                bCotizacion = new BCotizacion();
            }
            return bCotizacion;
        }

        public DataTable SelectLibre(string SQL)
        {
            return dCotizacion.getSELECTLIBRE(SQL);
        }

        public DataTable CorrelativoCotizacion()
        {
            return dCotizacion.DCorrelativoCotizacion();
        }


        public DataTable ObtenerListadoCotizacion(ECotizacion ECotizacion)
        {
            return dCotizacion.DGetAllCotizacion(ECotizacion);
        }


        public DataTable ObtenerCotizacionPorId(ECotizacion ECotizacion)
        {
            return dCotizacion.DGetCotizacionById(ECotizacion);
        }


        public DataTable ObtenerCotizacionDetalle(ECotizacionDetalle ECotizacionDetalle)
        {
            return dCotizacion.DGetAllCotizacionDetalle(ECotizacionDetalle);
        }

        public int InsertarCotizacion(ECotizacion ECotizacion)
        {
            return dCotizacion.DInsertCotizacion(ECotizacion);
        }

        public int ActualizarCotizacion(ECotizacion ECotizacion)
        {
            return dCotizacion.DUpdateCotizacion(ECotizacion);
        }


        public int ActualizarEstadoCotizacion(int CodCotizacion, int CodEstado)
        {
            return dCotizacion.DUpdateEstadoCotizacion(CodCotizacion, CodEstado);
        }

        public int EliminarCotizacion(int CodCotizacion)
        {
            return dCotizacion.DDeleteCotizacion(CodCotizacion);
        }

        public int InsertarCotizacionDetalle(ECotizacionDetalle ECotizacionDetalle)
        {
            return dCotizacion.DInsertCotizacionDetalle(ECotizacionDetalle);
        }

        public int ActualizarCotizacionDetalle(ECotizacionDetalle ECotizacionDetalle)
        {
            return dCotizacion.DUpdateCotizacionDetalle(ECotizacionDetalle);
        }


        public int EliminarCotizacionDetalle(int CodCotizacion, int IdProducto)
        {
            return dCotizacion.DDeleteCotizacionDetalle(CodCotizacion, IdProducto);
        }



    }
}
