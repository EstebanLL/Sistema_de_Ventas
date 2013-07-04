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

    class DatosCategoria
    {

        static string conexion = Datos.Conex.bdd;
        public static ArrayList getCategorias()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listacategorias = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id_categoria, nombre, imagen from categoria order by nombre");
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //Creo los objetos persona y los agrego a la lista
                Categoria cate = new Categoria(obdr.GetString(1), obdr.GetInt64(0), obdr.GetString(2));
                listacategorias.Add(cate);

            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listacategorias;
        }


        public static void NuevoCategoria_Prod(object o)
        {
            Categoria cat = new Categoria();
            cat = (Categoria)o;
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into Categoria(nombre, imagen) Values (@nombre, @imagen)");
            cmd.Parameters.Add(new SqlParameter("@nombre", cat.Nombre));
            cmd.Parameters.Add(new SqlParameter("@imagen", cat.Imagen));

            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }

        public static void ModificarCategoria_Prod(object o)
        {
            Categoria cat = new Categoria();
            cat = (Categoria)o;
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update Categoria set nombre = @nombre, imagen = @imagen where id_categoria = @id_categoria");
            cmd.Parameters.Add(new SqlParameter("@id_categoria", cat.Id_categoria));
            cmd.Parameters.Add(new SqlParameter("@nombre", cat.Nombre));
            cmd.Parameters.Add(new SqlParameter("@imagen", cat.Imagen));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }
        public static void NuevoCategoria_Cli(string nombre)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into Tipo_cliente(nombre) Values (@nombre)");
            cmd.Parameters.Add(new SqlParameter("@nombre", nombre));

            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }
        public static void ModificarCategoria_Cli(string nombre, string nuevo)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update  Tipo_cliente set nombre=@nuevo where nombre = @nombre");
            cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
            cmd.Parameters.Add(new SqlParameter("@nuevo", nuevo));

            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }
    }
}
