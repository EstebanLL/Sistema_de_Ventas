using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using SistemaDeGestion.Clases;

namespace SistemaDeGestion.Datos
{
    class Conex
    {
        public static string bdd = Principal.conexion;

        
        public static Decimal contizacion_real()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(bdd);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            decimal id = 0;
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select real from config where id_config like @id_config");
            cmd.Parameters.Add(new SqlParameter("@id_config", "1"));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {

                id = Convert.ToDecimal(Math.Round(Convert.ToDecimal(obdr.GetDecimal(0)), 2));


            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return id;
        }

        public static Decimal traer_iva()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(bdd);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            decimal id = 0;
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select iva from config where id_config like @id_config");
            cmd.Parameters.Add(new SqlParameter("@id_config", "1"));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {

                id = Convert.ToDecimal(Math.Round(Convert.ToDecimal(obdr.GetDecimal(0)), 2));


            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return id;
        }
        public static Clases.Configuracion_factura traer_datos_facturas()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(bdd);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
          Clases.Configuracion_factura cf = new Clases.Configuracion_factura();
            //Creo el comando sql a utlizar
          SqlCommand cmd = new SqlCommand("select  fecha_x, fecha_y, rut_x, rut_y, c_final_x, c_final_y, datos_x, datos_y, datos_yy,   xx,   yy, cantidad_x,  detalle_x , precio_x ,importe_x, subtotal_x,  subtotal_y ,  iva_x , iva_y, total_x, total_y, fuente, tamano, items_max, venta_prefijo_dato, factura_prefijo_dato,  venta_numero_dato,  factura_numero_dato,  venta_numero_x,  venta_numero_y,  factura_numero_x,  factura_numero_y , factura_numero_imprime,  observaciones_imprime,  observaciones_x,  observaciones_y,  tipo_imprime,  tipo_x,  tipo_y, duplica_en_hoja, duplica_en_hoja_distancia, comercio_nombre from config where id_config like @id_config");
            cmd.Parameters.Add(new SqlParameter("@id_config", "1"));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {

                Clases.Configuracion_factura cf2 = new Clases.Configuracion_factura(obdr.GetInt32(0), obdr.GetInt32(1), obdr.GetInt32(2), obdr.GetInt32(3), obdr.GetInt32(4), obdr.GetInt32(5), obdr.GetInt32(6), obdr.GetInt32(7), obdr.GetInt32(8), obdr.GetInt32(9), obdr.GetInt32(10), obdr.GetInt32(11), obdr.GetInt32(12), obdr.GetInt32(13), obdr.GetInt32(14), obdr.GetInt32(15), obdr.GetInt32(16), obdr.GetInt32(17), obdr.GetInt32(18), obdr.GetInt32(19), obdr.GetInt32(20), obdr.GetInt32(22), obdr.GetString(21), obdr.GetInt32(23), obdr.GetString(24), obdr.GetString(25), obdr.GetInt64(26), obdr.GetInt64(27), obdr.GetInt32(28), obdr.GetInt32(29), obdr.GetInt32(30), obdr.GetInt32(31), obdr.GetBoolean(32), obdr.GetBoolean(33), obdr.GetInt32(34), obdr.GetInt32(35), obdr.GetBoolean(36), obdr.GetInt32(37), obdr.GetInt32(38), obdr.GetBoolean(39), obdr.GetInt32(40), obdr.GetString(41));

                cf = cf2;
            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return cf;
            cf = null;
        }
        public static void Modificar_Factura(object f)
        {
            Configuracion_factura cf = new Configuracion_factura();
            cf = (Configuracion_factura)f;
            //creo la conexion
            SqlConnection cnn = new SqlConnection(bdd);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update config set venta_numero_dato=@venta_numero_dato, venta_prefijo_dato=@venta_prefijo_dato, factura_prefijo_dato=@factura_prefijo_dato, factura_numero_dato=@factura_numero_dato where id_config = @id_config");
            cmd.Parameters.Add(new SqlParameter("@venta_numero_dato", cf.Venta_numero_dato));
            cmd.Parameters.Add(new SqlParameter("@venta_Prefijo_dato", cf.Venta_Prefijo_dato));
            cmd.Parameters.Add(new SqlParameter("@factura_Prefijo_dato", cf.Factura_Prefijo_dato));
            cmd.Parameters.Add(new SqlParameter("@factura_numero_dato", cf.Factura_numero_dato));
            cmd.Parameters.Add(new SqlParameter("@id_config", "1"));

            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static void Modificar_Cotizacion_REAL(decimal real)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(bdd);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update config set real=@real where id_config = @id_config");
            cmd.Parameters.Add(new SqlParameter("@real", real));
            cmd.Parameters.Add(new SqlParameter("@id_config","1"));

            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }
        public static void Modificar_Datos_Factura(Clases.Configuracion_factura cf)
        {
            
            //creo la conexion
            SqlConnection cnn = new SqlConnection(bdd);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update config set comercio_nombre=@comercio_nombre, duplica_en_hoja=@duplica_en_hoja,duplica_en_hoja_distancia=@duplica_en_hoja_distancia, venta_numero_x=@venta_numero_x,venta_numero_y=@venta_numero_y, factura_numero_x = @factura_numero_x,factura_numero_y=@factura_numero_y, tipo_x=@tipo_x, tipo_y=@tipo_y, tipo_imprime=@tipo_imprime, observaciones_x=@observaciones_x, observaciones_y=@observaciones_y, factura_numero_imprime=@factura_numero_imprime, observaciones_imprime=@observaciones_imprime, fecha_x=@fecha_x, fecha_y=@fecha_y, rut_x=@rut_x, rut_y=@rut_y, c_final_x=@c_final_x, c_final_y=@c_final_y, datos_x=@datos_x, datos_y=@datos_y, datos_yy=@datos_yy, xx=@xx, yy=@yy, cantidad_x=@cantidad_x, detalle_x=@detalle_x, precio_x=@precio_x, importe_x=@importe_x, subtotal_x=@subtotal_x, subtotal_y=@subtotal_y, iva_x=@iva_x, iva_y=@iva_y, total_x=@total_x, total_y=@total_y, tamano=@tamano, fuente=@fuente, items_max=@items_max where id_config = @id_config");

            cmd.Parameters.Add(new SqlParameter("@duplica_en_hoja", cf.Duplica_en_hoja));
            cmd.Parameters.Add(new SqlParameter("@duplica_en_hoja_distancia", cf.Duplica_en_hoja_distancia));
            cmd.Parameters.Add(new SqlParameter("@venta_numero_x", cf.Venta_numero_x));
            cmd.Parameters.Add(new SqlParameter("@venta_numero_y", cf.Venta_numero_y));
            cmd.Parameters.Add(new SqlParameter("@factura_numero_x", cf.Factura_numero_x));
            cmd.Parameters.Add(new SqlParameter("@factura_numero_y", cf.Factura_numero_y));
            cmd.Parameters.Add(new SqlParameter("@id_config", "1"));
            cmd.Parameters.Add(new SqlParameter("@comercio_nombre", cf.Comercio_nombre));
            cmd.Parameters.Add(new SqlParameter("@fecha_x", cf.Fecha_X));
            cmd.Parameters.Add(new SqlParameter("@fecha_y", cf.Fecha_Y));
            cmd.Parameters.Add(new SqlParameter("@rut_x", cf.Rut_X));
            cmd.Parameters.Add(new SqlParameter("@rut_y", cf.Rut_y));
            cmd.Parameters.Add(new SqlParameter("@c_final_x", cf.C_Final_X));
            cmd.Parameters.Add(new SqlParameter("@c_final_y", cf.C_Final_Y));
            cmd.Parameters.Add(new SqlParameter("@datos_x", cf.Datos_x));
            cmd.Parameters.Add(new SqlParameter("@datos_y", cf.Datos_y));
            cmd.Parameters.Add(new SqlParameter("@datos_yy", cf.Datos_YY));
            cmd.Parameters.Add(new SqlParameter("@xx", cf.Xx));
            cmd.Parameters.Add(new SqlParameter("@yy", cf.Yy));
            cmd.Parameters.Add(new SqlParameter("@cantidad_x", cf.Cantidad_X));
            cmd.Parameters.Add(new SqlParameter("@detalle_x", cf.Detalle_X));
            cmd.Parameters.Add(new SqlParameter("@precio_x", cf.Precio_X));
            cmd.Parameters.Add(new SqlParameter("@importe_x", cf.Importe_X));
            cmd.Parameters.Add(new SqlParameter("@subtotal_x", cf.Subtotal_X));
            cmd.Parameters.Add(new SqlParameter("@subtotal_y", cf.SubTotal_y));
            cmd.Parameters.Add(new SqlParameter("@iva_x", cf.Iva_X));
            cmd.Parameters.Add(new SqlParameter("@iva_y", cf.Iva_Y));
            cmd.Parameters.Add(new SqlParameter("@total_x", cf.Total_x));
            cmd.Parameters.Add(new SqlParameter("@total_y", cf.Total_y));
            cmd.Parameters.Add(new SqlParameter("@fuente", cf.Fuente));
            cmd.Parameters.Add(new SqlParameter("@tamano", cf.Tamano));

            cmd.Parameters.Add(new SqlParameter("@items_max", cf.Items_max));



            cmd.Parameters.Add(new SqlParameter("@factura_numero_imprime", cf.Factura_numero_imprime));
            cmd.Parameters.Add(new SqlParameter("@observaciones_imprime", cf.Observaciones_imprime));
            cmd.Parameters.Add(new SqlParameter("@observaciones_x", cf.Observaciones_x));
            cmd.Parameters.Add(new SqlParameter("@observaciones_y", cf.Observaciones_y));
            cmd.Parameters.Add(new SqlParameter("@tipo_imprime", cf.Tipo_imprime));
            cmd.Parameters.Add(new SqlParameter("@tipo_x", cf.Tipo_x));

            cmd.Parameters.Add(new SqlParameter("@tipo_y", cf.Tipo_y));




            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }
        public static void Modificar_IVA(decimal iva)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(bdd);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update config set iva=@iva where id_config = @id_config");
            cmd.Parameters.Add(new SqlParameter("@iva", iva));
            cmd.Parameters.Add(new SqlParameter("@id_config", "1"));

            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }

        public static void Log(String logMessage, TextWriter w)
        {
            w.Write("\r\nEntrada al log : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
            // Update the underlying file.
            w.Flush();
        }

    }

}
