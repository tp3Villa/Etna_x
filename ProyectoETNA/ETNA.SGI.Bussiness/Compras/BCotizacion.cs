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

        public DataTable BCorrelativoCotizacion()
        {
            return bCotizacion.BCorrelativoCotizacion();
        }

        public DataTable DGetAllCotizacion(ECotizacion ECotizacion)
        {
            return dCotizacion.DGetAllCotizacion(ECotizacion);
        }


        public DataTable DGetAllCotizacionDetalle(ECotizacionDetalle ECotizacionDetalle)
        {
            return dCotizacion.DGetAllCotizacionDetalle(ECotizacionDetalle);
        }

        public int DInsertCotizacion(ECotizacion ECotizacion)
        {
            return dCotizacion.DInsertCotizacion(ECotizacion);
        }

        public int DUpdateCotizacion(ECotizacion ECotizacion)
        {
            return dCotizacion.DUpdateCotizacion(ECotizacion);
        }


        public int DUpdateEstadoCotizacion(int CodCotizacion, int CodEstado)
        {
            return dCotizacion.DUpdateEstadoCotizacion(CodCotizacion, CodEstado);
        }

        public int DDeleteCotizacion(int CodCotizacion)
        {
            return dCotizacion.DDeleteCotizacion(CodCotizacion);
        }

        public int DInsertCotizacionDetalle(ECotizacionDetalle ECotizacionDetalle)
        {
            return dCotizacion.DInsertCotizacionDetalle(ECotizacionDetalle);
        }

        public int DUpdateCotizacionDetalle(ECotizacionDetalle ECotizacionDetalle)
        {
            return dCotizacion.DUpdateCotizacionDetalle(ECotizacionDetalle);
        }


        public int DDeleteCotizacionDetalle(int CodCotizacion, int IdProducto)
        {
            return dCotizacion.DDeleteCotizacionDetalle(CodCotizacion, IdProducto);
        }


    }
}
