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
    class DatosProveedor
    {
        static string conexion = Datos.Conex.bdd;

        public static ArrayList getProveedores(string dato)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listaproveedores = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select p.id_proveedor, p.nombre, p.telefono , p.email, p.direccion, p.ciudad, p.id_pais, p.comentario,   pa.id_pais, pa.nombre from proveedor p,  pais pa where  p.id_pais=pa.id_pais " + dato + " order by p.nombre");
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //Creo los objetos persona y los agrego a la lista
                Pais pa = new Pais(obdr.GetInt64(8), obdr.GetString(9));

                Proveedor p = new Proveedor(obdr.GetString(1), obdr.GetString(2), obdr.GetString(3), obdr.GetString(4), obdr.GetString(5), obdr.GetInt64(6), obdr.GetInt64(0), obdr.GetString(7), pa);
                listaproveedores.Add(p);

            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listaproveedores;
        }
        public static void ModificaProveedor(Proveedor p)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update proveedor set nombre=@nombre, telefono=@telefono, email=@email, direccion=@direccion, ciudad=@ciudad, id_pais=@id_pais,  comentario=@comentario  where id_proveedor = @id_proveedor");
            cmd.Parameters.Add(new SqlParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SqlParameter("@telefono", p.Telefono));
            cmd.Parameters.Add(new SqlParameter("@email", p.Email));
            cmd.Parameters.Add(new SqlParameter("@direccion", p.Direccion));
            cmd.Parameters.Add(new SqlParameter("@ciudad", p.Ciudad));
            cmd.Parameters.Add(new SqlParameter("@id_pais", p.id_Pais));
            cmd.Parameters.Add(new SqlParameter("@comentario", p.Comentario));

            cmd.Parameters.Add(new SqlParameter("@id_proveedor", p.Id_proveedor));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }

        public static void NuevoProveedor(Proveedor p)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into proveedor (nombre, telefono, email, direccion, ciudad, id_pais,  comentario) Values (@nombre, @telefono, @email, @direccion, @ciudad, @id_pais, @comentario)");
            cmd.Parameters.Add(new SqlParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SqlParameter("@telefono", p.Telefono));
            cmd.Parameters.Add(new SqlParameter("@email", p.Email));
            cmd.Parameters.Add(new SqlParameter("@direccion", p.Direccion));
            cmd.Parameters.Add(new SqlParameter("@ciudad", p.Ciudad));
            cmd.Parameters.Add(new SqlParameter("@id_pais", p.id_Pais));
            cmd.Parameters.Add(new SqlParameter("@comentario", p.Comentario));

            cmd.Parameters.Add(new SqlParameter("@id_proveedor", p.Id_proveedor));

            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }

        public static Int64 obtener_id_proveedor_maximo()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            Int64 id = 0;
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select max(id_proveedor) from proveedor");

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
    }
}
