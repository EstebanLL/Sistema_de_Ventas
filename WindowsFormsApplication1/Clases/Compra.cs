using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDeGestion.Clases
{
    class Compra
    {
        Int64 id_compra;
        Int64 id_proveedor;
        DateTime fecha;
        DateTime fecha_factura;
        DateTime fecha_vencimiento;

        string tipo;
        string numero_factura;
        string estado;
        decimal importe;
        Proveedor pro;
        string dato;
        public Compra() { }
        public Compra(Int64 id_compra, Int64 id_proveedor, DateTime fecha, DateTime fecha_factura, DateTime fecha_vencimiento, string tipo, string numero_factura, string estado, decimal importe)
        {
            this.id_compra = id_compra;
            this.id_proveedor = id_proveedor;
            this.fecha = fecha;
            this.fecha_factura = fecha_factura;
            this.fecha_vencimiento = fecha_vencimiento;
            this.tipo = tipo;
            this.numero_factura = numero_factura;
            this.estado = estado;
            this.importe = importe;

        }


        public Int64 Id_compra
        {
            get { return id_compra; }
            set { id_compra = value; }
        }
        public Proveedor Proveedor
        {
            get { return pro; }
            set { pro = value; }
        }
     
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        } 
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Int64 Id_proveedor
        {
            get { return id_proveedor; }
            set { id_proveedor = value; }
        }
        public DateTime Fecha_vencimiento
        {
            get { return fecha_vencimiento; }
            set { fecha_vencimiento = value; }
        }
        public DateTime Fecha_factura
        {
            get { return fecha_factura; }
            set { fecha_factura = value; }
        }
    
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
   
        public string Numero_factura
        {
            get { return numero_factura; }
            set { numero_factura = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }
    }
}
