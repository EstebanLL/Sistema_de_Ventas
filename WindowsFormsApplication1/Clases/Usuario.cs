using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SistemaDeGestion.Clases
{
    class Usuario
    {
        int id_usuario;
        string usuario;
        string pass;
        string categoria;
        string nombre;
        string apellido;

        public Usuario(int id_usuario, string usuario, string pass, string categoria, string nombre, string apellido)
        {


            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.categoria = categoria;
            this.pass = pass;
            this.usuario = usuario;
            this.apellido = apellido;

        }

        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Usuarios
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
    }


}
