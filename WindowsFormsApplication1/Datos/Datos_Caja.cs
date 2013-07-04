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
    class Datos_Caja
    {
        static string conexion = Datos.Conex.bdd;
        public static void NuevaCaja(decimal monto)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into caja(monto, fecha) Values (@monto, @fecha)");
            cmd.Parameters.Add(new SqlParameter("@monto", monto));
            cmd.Parameters.Add(new SqlParameter("@fecha", DateTime.Today));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }
        public static Clases.Caja get_caja_por_fecha(DateTime fecha)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            Caja cj = new Caja();
        
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select  id_caja, monto from caja where fecha = @fecha");
            cmd.Parameters.Add(new SqlParameter("@fecha", fecha));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {

                cj.Id_caja = obdr.GetInt64(0);
                cj.Monto = Math.Round(obdr.GetDecimal(1),2);
            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return cj;
        }
        public static int get_Contar_caja_por_fecha(DateTime fecha)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            int conteo = 0;
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select count (id_caja) from caja where fecha = @fecha");
            cmd.Parameters.Add(new SqlParameter("@fecha", fecha));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {

                conteo = obdr.GetInt32(0);
            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return conteo;
        }
        public static void ModificarCaja(Caja cj)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update caja set monto = @monto where id_caja = @id_caja");
            cmd.Parameters.Add(new SqlParameter("@monto", cj.Monto));
            cmd.Parameters.Add(new SqlParameter("@id_caja", cj.Id_caja));

            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        

        }
    }
}
