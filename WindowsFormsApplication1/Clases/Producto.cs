using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDeGestion.Clases
{
    class Producto
    {

        string detalle;
        //  int cod_barra;
        decimal precio_unidad;
        decimal iva;
        decimal total;

        decimal margen;
        Int64 id_producto;
        Categoria cate;
        String codigo;
        int stock;
        int stock_min;
        String imagen;
        bool imagen_categoria;
        public Producto() { }
        public Producto(Int64 id_producto, string codigo, string detalle, decimal precio_unidad, decimal iva, decimal total, decimal margen, int stock, int stock_min,  Categoria cate)
        {

            this.detalle = detalle;
            this.stock = stock;
            this.id_producto = id_producto;

            this.iva = iva;
            this.margen = margen;
            this.stock_min = stock_min;

            this.precio_unidad = precio_unidad;
            this.total = total;
            this.cate = cate;
            this.codigo = codigo;
            this.cate = cate;
        }


        public Int64 Id_producto
        {
            get { return id_producto; }
            set { id_producto = value; }
        }



        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        /*  public int Cod_barra
          {
              get { return cod_barra; }
              set { cod_barra = value; }
          }*/
        public decimal Precio_unidad
        {
            get { return precio_unidad; }
            set { precio_unidad = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public decimal Iva
        {
            get { return iva; }
            set { iva = value; }
        }
     
        public decimal Margen
        {
            get { return margen; }
            set { margen = value; }
        }

        public Categoria Cate
        {
            get { return cate; }
            set { cate = value; }
        }
        public string nombrecategoria
        {
            get { return cate.Nombre; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public int Stock_min    
        {
            get { return stock_min; }
            set { stock_min = value; }
        }
        /* public int N_serie
         {
             get { return n_serie; }
             set { n_serie = value; }
         }*/

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        public bool Imagen_categoria
        {
            get { return imagen_categoria; }
            set { imagen_categoria = value; }
        }
    }
}