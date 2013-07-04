using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDeGestion.Clases
{
    class ProductoPDF
    {
        string producto;
        decimal total;
        public ProductoPDF(string producto, decimal total)
        {

            this.producto = producto;
            this.total = total;
        }
        public ProductoPDF()
        {

           
        }
        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
