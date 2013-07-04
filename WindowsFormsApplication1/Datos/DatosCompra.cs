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
    class DatosCompra
    {
        public static DataSet ds;
        static string conexion = Datos.Conex.bdd;

        public static void setBajaCompra(Int64 id_compra)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from compra  where id_compra = @id_compra");
            cmd.Parameters.Add(new SqlParameter("@id_compra", id_compra));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static ArrayList getCompras(string dato)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listacompra = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select c.id_compra, c.id_proveedor, c.fecha, c.fecha_factura, c.fecha_vencimiento, c.tipo, c.numero_factura, c.estado, c.importe, p.nombre from compra c, proveedor p where p.id_proveedor = c.id_proveedor " + dato + " order by c.id_compra");
           //                                           
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                Proveedor p = new Proveedor();
                p.Nombre = obdr.GetString(9);
                Compra c = new Compra(obdr.GetInt64(0), obdr.GetInt64(1), obdr.GetDateTime(2), obdr.GetDateTime(3), obdr.GetDateTime(4), obdr.GetString(5), obdr.GetString(6), obdr.GetString(7), Convert.ToDecimal(Math.Round(obdr.GetDecimal(8),2)));
                c.Proveedor = p;
                c.Dato = obdr.GetString(9);
                listacompra.Add(c);


            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listacompra;
        }
        public static ArrayList getCompras_por_fecha(DateTime fecha)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listacompra = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select c.id_compra, c.id_proveedor, c.fecha, c.fecha_factura, c.fecha_vencimiento, c.tipo, c.numero_factura, c.estado, c.importe, p.nombre from compra c, proveedor p where p.id_proveedor = c.id_proveedor and c.fecha = @fecha order by c.id_compra");
            cmd.Parameters.Add(new SqlParameter("@fecha", fecha));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                Proveedor p = new Proveedor();
                p.Nombre = obdr.GetString(9);
                Compra c = new Compra(obdr.GetInt64(0), obdr.GetInt64(1), obdr.GetDateTime(2), obdr.GetDateTime(3), obdr.GetDateTime(4), obdr.GetString(5), obdr.GetString(6), obdr.GetString(7), Convert.ToDecimal(Math.Round(obdr.GetDecimal(8),2)));
                c.Proveedor = p;
                c.Dato = obdr.GetString(9);
                listacompra.Add(c);


            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listacompra;
        }
        public static ArrayList getCompras_Vencidad()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listacompra = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select c.id_compra, c.id_proveedor, c.fecha, c.fecha_factura, c.fecha_vencimiento, c.tipo, c.numero_factura, c.estado, c.importe, p.nombre from compra c, proveedor p where p.id_proveedor = c.id_proveedor and c.fecha_vencimiento <= @fecha  and c.estado like '%Debe%' order by c.id_compra");
            cmd.Parameters.Add(new SqlParameter("@fecha", DateTime.Today));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                Proveedor p = new Proveedor();
                p.Nombre = obdr.GetString(9);
                Compra c = new Compra(obdr.GetInt64(0), obdr.GetInt64(1), obdr.GetDateTime(2), obdr.GetDateTime(3), obdr.GetDateTime(4), obdr.GetString(5), obdr.GetString(6), obdr.GetString(7), Convert.ToDecimal(Math.Round(obdr.GetDecimal(8),2)));
                c.Proveedor = p;
                c.Dato = obdr.GetString(9);
                listacompra.Add(c);


            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listacompra;
        }
        public static void NuevaCompra(Compra c)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into compra(id_proveedor, fecha, importe, fecha_vencimiento, fecha_factura, tipo, estado, numero_factura) Values (@id_proveedor, @fecha,@importe, @fecha_vencimiento, @fecha_factura, @tipo, @estado, @numero_factura)");

            cmd.Parameters.Add(new SqlParameter("@id_proveedor", c.Id_proveedor));

            cmd.Parameters.Add(new SqlParameter("@fecha", c.Fecha));

            cmd.Parameters.Add(new SqlParameter("@importe", c.Importe));
            cmd.Parameters.Add(new SqlParameter("@fecha_vencimiento", c.Fecha_vencimiento));
            cmd.Parameters.Add(new SqlParameter("@fecha_factura", c.Fecha_factura));

            cmd.Parameters.Add(new SqlParameter("@tipo", c.Tipo));
            cmd.Parameters.Add(new SqlParameter("@estado", c.Estado));
            cmd.Parameters.Add(new SqlParameter("@numero_factura", c.Numero_factura));

            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }
        public static Int64 obtener_id_compra()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            Int64 id = 0;
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select max(id_compra) from compra");

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
        public static void ModificaCompraPagarDeuda(Compra c)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update compra set estado=@estado where id_compra = @id_compra");
            cmd.Parameters.Add(new SqlParameter("@id_compra", c.Id_compra));
            cmd.Parameters.Add(new SqlParameter("@estado", "Pago"));


            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }

        public static ArrayList getCompras_entre_fechas(DateTime desde, DateTime hasta)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listacompra = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select c.id_compra, c.id_proveedor, c.fecha, c.fecha_factura, c.fecha_vencimiento, c.tipo, c.numero_factura, c.estado, c.importe, p.nombre from compra c, proveedor p where p.id_proveedor = c.id_proveedor and c.fecha between @desde and @hasta   order by c.id_compra");
            cmd.Parameters.Add(new SqlParameter("@desde", desde));
            cmd.Parameters.Add(new SqlParameter("@hasta", hasta));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                Proveedor p = new Proveedor();
                p.Nombre = obdr.GetString(9);
                Compra c = new Compra(obdr.GetInt64(0), obdr.GetInt64(1), obdr.GetDateTime(2), obdr.GetDateTime(3), obdr.GetDateTime(4), obdr.GetString(5), obdr.GetString(6), obdr.GetString(7), Convert.ToDecimal(Math.Round(obdr.GetDecimal(8), 2)));
                c.Proveedor = p;
                c.Dato = obdr.GetString(9);
                listacompra.Add(c);


            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listacompra;
        }
    }
}
