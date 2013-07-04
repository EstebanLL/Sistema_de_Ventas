using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDeGestion.Clases
{
    
    class Factura
    {
        string factrua_numero;
        Int64 id_factura;
        Int64 id_venta;
          public Factura(string factura_numero, Int64 id_factura, Int64 id_venta)
        {
            this.factrua_numero = factura_numero;
            this.id_factura = id_factura;
            this.id_venta = id_venta;

        }

          public Int64 Id_factura
          {
              get { return id_factura; }
              set { id_factura = value; }
          }
          public Int64 Id_venta
          {
              get { return id_venta; }
              set { id_venta = value; }
          }
          public string Factura_numero
          {
              get { return factrua_numero; }
              set { factrua_numero = value; }
          }
    }
}
