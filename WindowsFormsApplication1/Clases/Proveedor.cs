using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDeGestion.Clases
{
    class Proveedor
    {

        string nombre;

        string telefono;
        string email;
        string direccion;
        string ciudad;
        Int64 id_pais;

        Int64 id_proveedor;
        string comentario;

        Pais pai = new Pais();

        public Proveedor(string nombre, string telefono, string email, string direccion, string ciudad, Int64 id_pais, Int64 id_proveedor, string comentario, Pais pa)
        {
            this.nombre = nombre;
            this.pai = pa;
            this.telefono = telefono;
            this.email = email;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.id_pais = id_pais;
            this.id_proveedor = id_proveedor;
            this.comentario = comentario;


        }
        public Proveedor()
        {

        }
        public Pais Pais
        {
            get { return pai; }
            set { pai = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Int64 Id_proveedor
        {
            get { return id_proveedor; }
            set { id_proveedor = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public Int64 id_Pais
        {
            get { return id_pais; }
            set { id_pais = value; }
        }
    }
}
