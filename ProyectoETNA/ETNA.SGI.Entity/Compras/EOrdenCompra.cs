using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETNA.SGI.Entity.Compras
{
    public class EOrdenCompra
    {
        private int codOrdenCompra;

        public int CodOrdenCompra
        {
            get { return codOrdenCompra; }
            set { codOrdenCompra = value; }
        }
        private int codRequerimiento;

        public int CodRequerimiento
        {
            get { return codRequerimiento; }
            set { codRequerimiento = value; }
        }
        private int codCotizacion;

        public int CodCotizacion
        {
            get { return codCotizacion; }
            set { codCotizacion = value; }
        }
        private int codMoneda;

        public int CodMoneda
        {
            get { return codMoneda; }
            set { codMoneda = value; }
        }
        private int codCondicionPago;

        public int CodCondicionPago
        {
            get { return codCondicionPago; }
            set { codCondicionPago = value; }
        }
        private DateTime fechaRegistro;

        public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }
        private DateTime fechaActualizacion;

        public DateTime FechaActualizacion
        {
            get { return fechaActualizacion; }
            set { fechaActualizacion = value; }
        }
        private string usuarioRegistro;

        public string UsuarioRegistro
        {
            get { return usuarioRegistro; }
            set { usuarioRegistro = value; }
        }
        private string usuarioModificacion;

        public string UsuarioModificacion
        {
            get { return usuarioModificacion; }
            set { usuarioModificacion = value; }
        }
        private DateTime fechaEntrega;

        public DateTime FechaEntrega
        {
            get { return fechaEntrega; }
            set { fechaEntrega = value; }
        }
        private double subtotal;

        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        private double descuento;

        public double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
        private double igv;

        public double Igv
        {
            get { return igv; }
            set { igv = value; }
        }
        private double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        private string observacion;

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
        
    }
}
