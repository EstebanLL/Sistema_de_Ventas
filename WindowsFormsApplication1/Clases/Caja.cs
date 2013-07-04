using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SistemaDeGestion.Clases
{
    class Caja
    {
    
     decimal monto;
        Int64 id_caja;
        DateTime fecha;
        public Caja()
        {


        }
          public Caja( Int64 id_caja, DateTime fecha, decimal monto)
        {
            this.id_caja = id_caja;
            this.fecha = fecha;
            this.monto = monto;
                
        }
          public Int64 Id_caja
          {
              get { return id_caja; }
              set { id_caja = value; }
          }
          public DateTime Fecha
          {
              get { return fecha; }
              set { fecha = value; }
          }
          public Decimal Monto
          {
              get { return monto; }
              set { monto = value; }
          }
    }
}
