using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDeGestion.Clases
{
    class Pais
    {
        Int64 id_pais;
        string nombre;
        public Pais() { }
        public Pais(Int64 id_pais, string nombre)
        {
            this.id_pais = id_pais;
            this.nombre = nombre;

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Int64 Id_pais
        {
            get { return id_pais; }
            set { id_pais = value; }
        }
    }
}
