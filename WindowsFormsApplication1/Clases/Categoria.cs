using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDeGestion.Clases
{
    class Categoria
    {

        string nombre;
        Int64 id_categoria;
        string imagen;

        public Categoria(string nombre, Int64 id_categoria, string imagen)
        {
            this.id_categoria = id_categoria;
            this.nombre = nombre;
            this.imagen = imagen;
                
        }


        public Categoria()
        {


        }
        public Int64 Id_categoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
    }
}
