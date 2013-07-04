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
      
    class Datos_Factura
    { static string conexion = Datos.Conex.bdd;
    public static void NuevaFacura(Factura f)
    {
        //creo la conexion
        SqlConnection cnn = new SqlConnection(conexion);
        //abro la conexion
        cnn.Open();
        //Creo el comando sql a utlizar
        SqlCommand cmd = new SqlCommand("insert into factura(id_venta, factura_numero) Values (@id_venta, @factura_numero)");
        cmd.Parameters.Add(new SqlParameter("@id_venta", f.Id_venta));
        cmd.Parameters.Add(new SqlParameter("@factura_numero", f.Factura_numero));
        //asigno la conexion al comando
        cmd.Connection = cnn;

        cmd.ExecuteNonQuery();
        cnn.Close();
    }

    public static ArrayList getFacturas(Int64 id_venta)
    {
        //creo la conexion
        SqlConnection cnn = new SqlConnection(conexion);
        //abro la conexion
        cnn.Open();
        //creo la lista para almacenar las personas
        ArrayList listafacturas = new ArrayList();
        //Creo el comando sql a utlizar
        SqlCommand cmd = new SqlCommand("select factura_numero, id_factura from factura where id_venta = @id_venta order by factura_numero");

        cmd.Parameters.Add(new SqlParameter("@id_venta", id_venta));
        //asigno la conexion al comando
        cmd.Connection = cnn;
        //creo el datareader
        SqlDataReader obdr = cmd.ExecuteReader();
        //recorro el datareader
        while (obdr.Read())
        {
            //Creo los objetos persona y los agrego a la lista
            Factura f = new Factura(obdr.GetString(0), obdr.GetInt64(1), id_venta);
            listafacturas.Add(f);

        }
        //Cierro la conexion
        cnn.Close();
        //retorno la lsita
        return listafacturas;
    }
    }
}
