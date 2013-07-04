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
    class DatosPais
    {
        static string conexion = Datos.Conex.bdd;
        public static Int64 obtener_id_pais_maximo()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            Int64 id = 0;
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select max(id_pais) from pais");

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
        public static ArrayList getPaises()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listapaises = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id_pais, nombre from pais  order by nombre");
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //Creo los objetos persona y los agrego a la lista
                Pais pai = new Pais(obdr.GetInt64(0), obdr.GetString(1));
                listapaises.Add(pai);

            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listapaises;
        }

    }
}
