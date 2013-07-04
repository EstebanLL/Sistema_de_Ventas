using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDeGestion.Clases
{
    class Cliente
    {
     
        Int64 id_cliente;
        string nombre;
        string documento;
        string telefono;
        string email;
        string direccion;
        string ciudad;
        Int64 id_pais;
        string rut;
        DateTime nacimiento;
        Pais pai = new Pais();
        

        public Cliente(Int64 id_cliente, string nombre, string documento, string telefono, string email, string direccion, string ciudad, Int64 pais, Pais pa, string rut, DateTime nacimiento)
        {
     
            this.id_cliente = id_cliente;
            this.nombre = nombre;
            this.documento = documento;
            this.telefono = telefono;
            this.email = email;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.id_pais = pais;
            this.pai = pa;
            this.rut = rut;
            this.nacimiento = nacimiento;
        }
        public Cliente(Int64 id_cliente, string nombre, string documento, string telefono, string email, string direccion, string ciudad, Int64 pais, string rut, DateTime nacimiento)
        {

            this.id_cliente = id_cliente;
            this.nombre = nombre;
            this.documento = documento;
            this.telefono = telefono;
            this.email = email;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.id_pais = pais;
            this.rut = rut;
            this.nacimiento = nacimiento;

        }
        public Cliente() { }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Pais Pais
        {
            get { return pai; }
            set { pai = value; }
        }

        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
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


        public Int64 Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        public string RUT {

            get { return rut; }
            set { rut = value; }
        
        }
        public DateTime Nacimiento
        {
            get { return nacimiento; }
            set { nacimiento = value; }
        }
    }
}
