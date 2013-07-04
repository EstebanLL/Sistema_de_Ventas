using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDeGestion.Clases
{
    class Configuracion_factura
    {
        int fecha_x;
        int fecha_y;
        int rut_x;
        int rut_y;
        int c_final_x;
        int c_final_y;
        int datos_x;
        int datos_y;
        int datos_yy;
        int xx;
        int yy;
        int cantidad_x;
        int detalle_x;
        int precio_x;
        int importe_x;
        int subtotal_x;
        int subtotal_y;
        int iva_x;
        int iva_y;
        int total_x;
        int total_y;
        int tamano;
        int items_max;
        string fuente;
        string comercio_nombre;
        string venta_prefijo_dato;
        string factura_prefijo_dato;
        Int64 venta_numero_dato;
        Int64 factura_numero_dato;
        int venta_numero_x;
        int venta_numero_y;
        int factura_numero_x;
        int factura_numero_y;

        bool factura_numero_imprime;
        bool observaciones_imprime;
        int observaciones_x;
        int observaciones_y;
        bool tipo_imprime;
        int tipo_x;
        int tipo_y;
        bool duplica_en_hoja;
        int duplica_en_hoja_distancia;


        public Configuracion_factura() { }
        public Configuracion_factura(int fecha_x, int fecha_y, int rut_x, int rut_y, int c_final_x, int c_final_y, int datos_x, int datos_y, int datos_yy, int xx, int yy, int cantidad_x, int detalle_x, int precio_x, int importe_x, int subtotal_x, int subtotal_y, int iva_x, int iva_y, int total_x, int total_y, int tamano, string fuente, int items_max, string venta_prefijo_dato, string factura_prefijo_dato, Int64 venta_numero_dato, Int64 factura_numero_dato, int venta_numero_x, int venta_numero_y, int factura_numero_x, int factura_numero_y, bool factura_numero_imprime, bool observaciones_imprime, int observaciones_x, int observaciones_y, bool tipo_imprime, int tipo_x, int tipo_y, bool duplica_en_hoja, int duplica_en_hoja_distancia, string comercio_nombre)
        {
            this.comercio_nombre = comercio_nombre;
            this.duplica_en_hoja = duplica_en_hoja;
            this.duplica_en_hoja_distancia = duplica_en_hoja_distancia;
            this.items_max = items_max;
            this.tamano = tamano;
            this.fuente = fuente;
            this.fecha_x = fecha_x;
            this.fecha_y = fecha_y;
            this.rut_x = rut_x;
            this.rut_y = rut_y;
            this.c_final_x = c_final_x;
            this.c_final_y = c_final_y;
            this.datos_x = datos_x;
            this.datos_y = datos_y;
            this.datos_yy = datos_yy;
            this.xx = xx;
            this.yy = yy;
            this.cantidad_x = cantidad_x;
            this.detalle_x = detalle_x;
            this.precio_x = precio_x;
            this.importe_x = importe_x;
            this.subtotal_x = subtotal_x;
            this.subtotal_y = subtotal_y;
            this.iva_x = iva_x;
            this.iva_y = iva_y;
            this.total_x = total_x;
            this.total_y = total_y;

            this.venta_prefijo_dato = venta_prefijo_dato;
            this.factura_prefijo_dato = factura_prefijo_dato;
            this.venta_numero_dato = venta_numero_dato;
            this.factura_numero_dato = factura_numero_dato;
            this.venta_numero_x = venta_numero_x;
            this.venta_numero_y = venta_numero_y;
            this.factura_numero_x = factura_numero_x;
            this.factura_numero_y = factura_numero_y;

            this.factura_numero_imprime = factura_numero_imprime;
            this.observaciones_imprime = observaciones_imprime;
            this.observaciones_x = observaciones_x;
            this.observaciones_y = observaciones_y;
            this.tipo_imprime = tipo_imprime;
            this.tipo_x = tipo_x;
            this.tipo_y = tipo_y;
        }
        public int Items_max
        {
            get { return items_max; }
            set { items_max = value; }
        }
        public int Fecha_X
        {
            get { return fecha_x; }
            set { fecha_x = value; }
        }
        public int Fecha_Y
        {
            get { return fecha_y; }
            set { fecha_y = value; }
        }
        public int Rut_X
        {
            get { return rut_x; }
            set { rut_x = value; }
        }
        public int Rut_y
        {
            get { return rut_y; }
            set { rut_y = value; }
        }
        public int C_Final_X
        {
            get { return c_final_x; }
            set { c_final_x = value; }
        }
        public int C_Final_Y
        {
            get { return c_final_y; }
            set { c_final_y = value; }
        }
        public int Datos_x
        {
            get { return datos_x; }
            set { datos_x = value; }
        }
        public int Datos_y
        {
            get { return datos_y; }
            set { datos_y = value; }
        }
        public int Datos_YY
        {
            get { return datos_yy; }
            set { datos_yy = value; }
        }
        public int Xx
        {
            get { return xx; }
            set { xx = value; }
        }
        public int Yy
        {
            get { return yy; }
            set { yy = value; }
        }
        public int Cantidad_X
        {
            get { return cantidad_x; }
            set { cantidad_x = value; }
        }
        public int Detalle_X
        {
            get { return detalle_x; }
            set { detalle_x = value; }
        }
        public int Importe_X
        {
            get { return importe_x; }
            set { importe_x = value; }
        }
        public int Precio_X
        {
            get { return precio_x; }
            set { precio_x = value; }
        }
        public int Subtotal_X
        {
            get { return subtotal_x; }
            set { subtotal_x = value; }
        }
        public int SubTotal_y
        {
            get { return subtotal_y; }
            set { subtotal_y = value; }
        }
        public int Iva_X
        {
            get { return iva_x; }
            set { iva_x = value; }
        }
        public int Iva_Y
        {
            get { return iva_y; }
            set { iva_y = value; }
        }
        public int Total_x
        {
            get { return total_x; }
            set { total_x = value; }
        }
        public int Total_y
        {
            get { return total_y; }
            set { total_y = value; }
        }

        public int Tamano
        {
            get { return tamano; }
            set { tamano = value; }
        }
        public string Fuente
        {
            get { return fuente; }
            set { fuente = value; }
        }
        public string Factura_Prefijo_dato
        {
            get { return factura_prefijo_dato; }
            set { factura_prefijo_dato = value; }
        }
        public string Comercio_nombre
        {
            get { return comercio_nombre; }
            set { comercio_nombre = value; }
        }
        public string Venta_Prefijo_dato
        {
            get { return venta_prefijo_dato; }
            set { venta_prefijo_dato = value; }
        }
        public Int64 Factura_numero_dato
        {
            get { return factura_numero_dato; }
            set { factura_numero_dato = value; }
        }
        public Int64 Venta_numero_dato
        {
            get { return venta_numero_dato; }
            set { venta_numero_dato = value; }
        }
        public int Venta_numero_x
        {
            get { return venta_numero_x; }
            set { venta_numero_x = value; }
        }
        public int Venta_numero_y
        {
            get { return venta_numero_y; }
            set { venta_numero_y = value; }
        }
        public int Factura_numero_x
        {
            get { return factura_numero_x; }
            set { factura_numero_x = value; }
        }
        public int Factura_numero_y
        {
            get { return factura_numero_y; }
            set { factura_numero_y = value; }
        }


        public bool Factura_numero_imprime
        {
            get { return factura_numero_imprime; }
            set { factura_numero_imprime = value; }
        }
        public bool Observaciones_imprime
        {
            get { return observaciones_imprime; }
            set { observaciones_imprime = value; }
        }
        public bool Tipo_imprime
        {
            get { return tipo_imprime; }
            set { tipo_imprime = value; }
        }
        public bool Duplica_en_hoja
        {
            get { return duplica_en_hoja; }
            set { duplica_en_hoja = value; }
        }
        public int Duplica_en_hoja_distancia
        {
            get { return duplica_en_hoja_distancia; }
            set { duplica_en_hoja_distancia = value; }
        }
        /*     bool factura_numero_imprime;
        bool observaciones_imprime;
        int observaciones_x;
        int observaciones_y;
        bool tipo_imprime;
        int tipo_x;
        int tipo_y;
         * */
        public int Observaciones_x
        {
            get { return observaciones_x; }
            set { observaciones_x = value; }
        }
        public int Observaciones_y
        {
            get { return observaciones_y; }
            set { observaciones_y = value; }
        }
        public int Tipo_x
        {
            get { return tipo_x; }
            set { tipo_x = value; }
        }
        public int Tipo_y
        {
            get { return tipo_y; }
            set { tipo_y = value; }
        }

    }
}
