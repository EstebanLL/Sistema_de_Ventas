using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDeGestion.Clases
{
    class Venta_Producto
    {
        Int64 id_venta_producto;
        Int64 id_venta;
        Int64 id_producto;
        int cantidad;
        decimal precio;
        string dato1;
        string dato2;
        string dato3;
        decimal dato4;
        Producto pro;
        public Venta_Producto(Int64 id_venta_producto, Int64 id_venta, Int64 id_producto, decimal precio, Int32 cantidad)
        {

            this.id_venta_producto = id_venta_producto;
            this.id_venta = id_venta;
            this.id_producto = id_producto;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public Venta_Producto(Int64 id_venta_producto, Int64 id_venta, Int64 id_producto, decimal precio, Int32 cantidad, Producto pro)
        {

            this.id_venta_producto = id_venta_producto;
            this.id_venta = id_venta;
            this.id_producto = id_producto;
            this.precio = precio;
            this.cantidad = cantidad;
            this.pro = pro;
        }
        public Venta_Producto() { }


        public Int64 Id_venta
        {
            get { return id_venta; }
            set { id_venta = value; }
        }
        public Int64 Id_venta_producto
        {
            get { return id_venta_producto; }
            set { id_venta_producto = value; }
        }
        public Producto Producto
        {
            get { return pro; }
            set { pro = value; }
        }


        public string Dato1
        {
            get { return dato1; }
            set { dato1 = value; }
        }
        public string Dato2
        {
            get { return dato2; }
            set { dato2 = value; }
        }
        public string Dato3
        {
            get { return dato3; }
            set { dato3 = value; }
        }
        public Int64 Id_producto
        {
            get { return id_producto; }
            set { id_producto = value; }
        }
        public Int32 Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public decimal Dato4
        {
            get { return dato4; }
            set { dato4 = value; }
        }
    }
}
