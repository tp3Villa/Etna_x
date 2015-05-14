using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETNA.SGI.Entity.Compras
{
    public class EProveedor
    {
        private int codProveedor;
        
        public int CodProveedor
        {
            get { return codProveedor; }
            set { codProveedor = value; }
        }
        private string razonSocial;

        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private int telefono;

       public int Telefono
        {
           get { return telefono; }
            set { telefono = value; }
        }

        private DateTime fechaRegistro;

       public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private int ruc;

        public int Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }

        private string observacion;

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
    }
}