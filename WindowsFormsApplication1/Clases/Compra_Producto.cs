using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDeGestion.Clases
{
    class Compra_Producto
    {
        Int64 id_compra_producto;
        Int64 id_compra;
        Int64 id_producto;
        decimal precio;
        int cantidad;
        string dato1;
        string dato2;
        string dato3;
        decimal dato4;
        Producto pro;
        public Compra_Producto(Int64 id_compra_producto, Int64 id_compra, Int64 id_producto, decimal precio, Int32 cantidad)
        {

            this.id_compra_producto = id_compra_producto;
            this.id_compra = id_compra;
            this.id_producto = id_producto;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public Compra_Producto(Int64 id_compra_producto, Int64 id_compra, Int64 id_producto, decimal precio, Int32 cantidad, Producto pro)
        {

            this.id_compra_producto = id_compra_producto;
            this.id_compra = id_compra;
            this.id_producto = id_producto;
            this.precio = precio;
            this.cantidad = cantidad;
            this.pro = pro;
        }
        public Compra_Producto() { }


        public Int64 Id_compra
        {
            get { return id_compra; }
            set { id_compra = value; }
        }
        public Int64 Id_compra_producto
        {
            get { return id_compra_producto; }
            set { id_compra_producto = value; }
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
