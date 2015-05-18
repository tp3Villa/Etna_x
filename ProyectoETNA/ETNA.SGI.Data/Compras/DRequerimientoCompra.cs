﻿using ETNA.SGI.Entity.Compras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace ETNA.SGI.Data.Compras
{
    public class DRequerimientoCompra
    {

        private DConexion cn = new DConexion();

        private static DRequerimientoCompra dRequerimientoCompra;

        public static DRequerimientoCompra getInstance()
        {
            if (dRequerimientoCompra == null)
            {
                dRequerimientoCompra = new DRequerimientoCompra();
            }
            return dRequerimientoCompra;
        }

        public DataTable DGetAllRequerimientoCompraCotizacion(ERequerimientoCompra eRequerimientoCompra)
        {
            string sql = "SELECT rc.codRequerimiento, c.desCategoria, rc.fechaRegistro, rc.observacion " +
                              "FROM RequerimientoCompra rc " +
                              "INNER JOIN Categoria c " +
                              "ON rc.codCategoria = c.codCategoria " +
                          "WHERE  ( @codRequerimiento = 0 OR rc.codRequerimiento = @codRequerimiento ) " +
                          "AND ( @codCategoria = 0 OR rc.codCategoria = @codCategoria ) " +
                          "AND rc.codEstado='2' ";

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand(sql, cn.Conectar);

            // Configurando los parametros
            command.Parameters.Add("@codRequerimiento", SqlDbType.Int);
            command.Parameters["@codRequerimiento"].Value = eRequerimientoCompra.CodRequerimiento;
            command.Parameters.Add("@codCategoria", SqlDbType.Int);
            command.Parameters["@codCategoria"].Value = eRequerimientoCompra.CodCategoria;

            adapter.SelectCommand = command;

            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }


        public DataTable DGetAllRequerimientoCompraCotizacionDetalle(string codReq)
        {
            string sql = "SELECT rc.idProducto, p.descripcionProducto, rc.cantidad " +
                              "FROM RequerimientoDetalleCompra rc " +
                              "INNER JOIN Producto p " +
                              "ON rc.idProducto = p.idProducto " +
                          "WHERE  ( @codRequerimiento = 0 OR rc.codRequerimiento = @codRequerimiento ) " ;

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand(sql, cn.Conectar);

            // Configurando los parametros
            command.Parameters.Add("@codRequerimiento", SqlDbType.Int);
            command.Parameters["@codRequerimiento"].Value = codReq;

            adapter.SelectCommand = command;

            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }


        public DataTable DGetAllRequerimientoCompraOrdenCompra(ERequerimientoCompra eRequerimientoCompra)
        {
            string sql = "select rq.codRequerimiento,c.desCategoria, rq.fechaRegistro, rq.usuarioRegistro, rq.observacion from RequerimientoCompra rq " +
                            "INNER JOIN Categoria c " +
                            "ON c.codCategoria = rq.codCategoria " +
                            "INNER JOIN Cotizacion ct " +
                            "ON ct.codRequerimiento = rq.codRequerimiento " +
                            "INNER JOIN OrdenCompra oc " +
                            "ON oc.codRequerimiento <> rq.codRequerimiento " +
                         "WHERE rq.codEstado = 2 AND ct.codEstado = 2 " +
                         " AND ( @codRequerimiento = 0 OR rq.codRequerimiento = @codRequerimiento ) " +
                          "AND ( @codCategoria = 0 OR rq.codCategoria = @codCategoria ) ";
            
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand(sql, cn.Conectar);

            // Configurando los parametros
            command.Parameters.Add("@codRequerimiento", SqlDbType.Int);
            command.Parameters["@codRequerimiento"].Value = eRequerimientoCompra.CodRequerimiento;
            command.Parameters.Add("@codCategoria", SqlDbType.Int);
            command.Parameters["@codCategoria"].Value = eRequerimientoCompra.CodCategoria;

            adapter.SelectCommand = command;

            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

        public DataTable DGetAllDetalleByCodRequerimientoCompra(int codRequerimientoCompra)
        {
            string sql = "select rq.codRequerimiento, ct.codCotizacion, pv.razonSocial, ctd.idProducto, pd.descripcionProducto, ctd.cantidad, ctd.precioUnidad, ctd.descuento from RequerimientoCompra rq " +
                            "INNER JOIN Cotizacion ct " +
                            "ON ct.codRequerimiento = rq.codRequerimiento " +
                            "INNER JOIN Proveedor pv " +
                            "ON pv.codProveedor = ct.codProveedor " +
                            "INNER JOIN CotizacionDetalle ctd " +
                            "ON ctd.codCotizacion = ct.codCotizacion " +
                            "INNER JOIN producto pd " +
                            "ON pd.idProducto = ctd.idProducto " +
                         "WHERE rq.codRequerimiento = @codRequerimiento AND ct.codEstado = 2";

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand(sql, cn.Conectar);

            // Configurando los parametros
            command.Parameters.Add("@codRequerimiento", SqlDbType.Int);
            command.Parameters["@codRequerimiento"].Value = codRequerimientoCompra;

            adapter.SelectCommand = command;

            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

    }
}
