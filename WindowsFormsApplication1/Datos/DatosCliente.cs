using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using SistemaDeGestion.Clases;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeGestion.Datos
{
    class DatosCliente
    {
        static string conexion = Datos.Conex.bdd;
        public static Cliente getCliente(Int64 id_cliente)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
     Cliente c = new Cliente();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select c.id_cliente, c.nombre, c.documento, c.telefono, c.email, c.direccion, c.ciudad, c.id_pais, p.nombre, c.rut, c.nacimiento from cliente c, pais p where c.id_pais = p.id_pais and id_cliente = @id_cliente");
            cmd.Parameters.Add(new SqlParameter("@id_cliente", id_cliente));
            
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {


                c.Nombre = obdr.GetString(1);

            }


            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return c;
        }
            public static ArrayList getClientes(string dato)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listaclientes = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select c.id_cliente, c.nombre, c.documento, c.telefono, c.email, c.direccion, c.ciudad, c.id_pais, p.nombre, c.rut, c.nacimiento from cliente c, pais p where c.id_pais = p.id_pais " + dato + " order by c.nombre");
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                Pais pa = new Pais(obdr.GetInt64(7), obdr.GetString(8));
                //Creo los objetos persona y los agrego a la lista
                Cliente c = new Cliente(obdr.GetInt64(0), obdr.GetString(1), obdr.GetString(2), obdr.GetString(3), obdr.GetString(4), obdr.GetString(5), obdr.GetString(6), obdr.GetInt64(7), pa, obdr.GetString(9), obdr.GetDateTime(10));
             
                listaclientes.Add(c);


            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listaclientes;
        }

            public static void NuevoCliente(Cliente c)
            {
                //creo la conexion
                SqlConnection cnn = new SqlConnection(conexion);
                //abro la conexion
                cnn.Open();
                //Creo el comando sql a utlizar
                SqlCommand cmd = new SqlCommand("insert into cliente(nombre,  telefono, email, direccion, ciudad,id_pais, documento, rut, nacimiento) Values (@nombre, @telefono, @email, @direccion, @ciudad, @id_pais,  @documento, @rut, @nacimiento)");
                cmd.Parameters.Add(new SqlParameter("@nombre", c.Nombre));

                cmd.Parameters.Add(new SqlParameter("@telefono", c.Telefono));
                cmd.Parameters.Add(new SqlParameter("@email", c.Email));
                cmd.Parameters.Add(new SqlParameter("@direccion", c.Direccion));
                cmd.Parameters.Add(new SqlParameter("@ciudad", c.Ciudad));

                cmd.Parameters.Add(new SqlParameter("@documento", c.Documento));
                cmd.Parameters.Add(new SqlParameter("@id_pais", c.id_Pais));
                cmd.Parameters.Add(new SqlParameter("@rut", c.RUT));
                cmd.Parameters.Add(new SqlParameter("@nacimiento", c.Nacimiento));
                //asigno la conexion al comando
                cmd.Connection = cnn;

                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            public static Int64 obtener_id_cliente_maximo()
            {
                //creo la conexion
                SqlConnection cnn = new SqlConnection(conexion);
                //abro la conexion
                cnn.Open();
                //creo la lista para almacenar las personas
                Int64 id = 0;
                //Creo el comando sql a utlizar
                SqlCommand cmd = new SqlCommand("select max(id_cliente) from cliente");

                //asigno la conexion al comando
                cmd.Connection = cnn;
                //creo el datareader
                SqlDataReader obdr = cmd.ExecuteReader();
                //recorro el datareader
                while (obdr.Read())
                {

                    id = obdr.GetInt64(0);


                }
                //Cierro la conexion
                cnn.Close();
                //retorno la lsita
                return id;
            }
         
            public static void ModificarCliente(Cliente c)
            {
                //creo la conexion
                SqlConnection cnn = new SqlConnection(conexion);
                //abro la conexion
                cnn.Open();
                //Creo el comando sql a utlizar
                SqlCommand cmd = new SqlCommand("update cliente set id_pais=@id_pais, nombre=@nombre,  direccion=@direccion, ciudad=@ciudad, documento=@documento,  email=@email,  rut=@rut, telefono=@telefono, nacimiento=@nacimiento where id_cliente = @id_cliente");
                cmd.Parameters.Add(new SqlParameter("@id_cliente", c.Id_cliente));
                cmd.Parameters.Add(new SqlParameter("@id_pais", c.id_Pais));
                cmd.Parameters.Add(new SqlParameter("@telefono", c.Telefono));
                cmd.Parameters.Add(new SqlParameter("@nombre", c.Nombre));
                cmd.Parameters.Add(new SqlParameter("@direccion", c.Direccion));
                cmd.Parameters.Add(new SqlParameter("@ciudad", c.Ciudad));
                cmd.Parameters.Add(new SqlParameter("@documento", c.Documento));
                //   cmd.Parameters.Add(new SqlParameter("@n_serie", p.N_serie));
                cmd.Parameters.Add(new SqlParameter("@email", c.Email));
                cmd.Parameters.Add(new SqlParameter("@rut", c.RUT));
                cmd.Parameters.Add(new SqlParameter("@nacimiento", c.Nacimiento));
                cmd.Connection = cnn;

                cmd.ExecuteNonQuery();
            }
}
}