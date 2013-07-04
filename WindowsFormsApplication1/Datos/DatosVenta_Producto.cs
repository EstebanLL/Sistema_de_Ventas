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
    class DatosVenta_Producto
    {
        public static DataSet ds;
        static string conexion = Datos.Conex.bdd;

        public static void NuevaVentaProducto(Venta_Producto vp)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into venta_producto(id_venta, id_producto, precio, cantidad) Values (@id_venta, @id_producto, @precio, @cantidad)");

            cmd.Parameters.Add(new SqlParameter("@id_venta", vp.Id_venta));

            cmd.Parameters.Add(new SqlParameter("@id_producto", vp.Id_producto));
            cmd.Parameters.Add(new SqlParameter("@precio", vp.Precio));
            cmd.Parameters.Add(new SqlParameter("@cantidad", vp.Cantidad));

            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }
        public static ArrayList getVenta_Producto_no_impreso_todos()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listaventa = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select v.id_venta from  venta v where  v.impreso like '0'");


            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {


                Venta_Producto vp = new Venta_Producto();


                vp.Id_venta = obdr.GetInt64(0);
                listaventa.Add(vp);


            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listaventa;
        }
        public static ArrayList getVenta_Producto_no_impreso(DateTime fecha)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listaventa = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select vp.precio, vp.cantidad, p.detalle,c.nombre, p.codigo, p.id_producto from venta_producto vp, producto p, categoria c, venta v where vp.id_producto = p.id_producto and p.id_categoria = c.id_categoria and vp.id_venta = v.id_venta and v.impreso like '0' and v.fecha = @fecha order by id_venta_producto");
            cmd.Parameters.Add(new SqlParameter("@fecha", fecha));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {


                Venta_Producto vp = new Venta_Producto();

                vp.Precio = Convert.ToDecimal(Math.Round(Convert.ToDecimal(obdr.GetDecimal(0)), 2));
                vp.Cantidad = obdr.GetInt32(1);
                vp.Dato1 = obdr.GetString(2);
                vp.Dato2 = obdr.GetString(4);
                vp.Dato3 = obdr.GetString(3);
                vp.Id_producto = obdr.GetInt64(5);
                listaventa.Add(vp);


            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listaventa;
        }
        public static ArrayList getVenta_Producto(Int64 id)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listaventa = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select vp.precio, vp.cantidad, p.detalle,c.nombre, p.codigo from venta_producto vp, producto p, categoria c where vp.id_producto = p.id_producto and p.id_categoria = c.id_categoria and vp.id_venta = @id_venta order by id_venta_producto");
            cmd.Parameters.Add(new SqlParameter("@id_venta", id));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {


                Venta_Producto vp = new Venta_Producto();

                vp.Precio = Convert.ToDecimal(Math.Round(Convert.ToDecimal(obdr.GetDecimal(0)), 2));
                vp.Cantidad = obdr.GetInt32(1);
                vp.Dato1 = obdr.GetString(2);
                vp.Dato2 = obdr.GetString(4);
                vp.Dato3 = obdr.GetString(3);

                listaventa.Add(vp);


            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listaventa;
        }
        public static void setBajaVenta_producto(Int64 id_venta)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from venta_producto  where id_venta = @id_venta");
            cmd.Parameters.Add(new SqlParameter("@id_venta", id_venta));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
            cnn.Close();
        }
     
    }
}
