using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ETNA.SGI.Entity.Compras
{
    public class ECotizacion
    {

        private int codCotizacion;

        public int CodCotizacion
        {
            get { return codCotizacion; }
            set { codCotizacion = value; }
        }
        private int codRequerimiento;

        public int CodRequerimiento
        {
            get { return codRequerimiento; }
            set { codRequerimiento = value; }
        }

        private int codProveedor;

        public int CodProveedor
        {
            get { return codProveedor; }
            set { codProveedor = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private DateTime fechaExpiracion;

        public DateTime FechaExpiracion
        {
            get { return fechaExpiracion; }
            set { fechaExpiracion = value; }
        }

        private int codEstado;

        public int CodEstado
        {
            get { return codEstado; }
            set { codEstado = value; }
        }

    }

}
