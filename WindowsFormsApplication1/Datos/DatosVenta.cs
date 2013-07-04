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
    class DatosVenta
    {
        public static DataSet ds;
        static string conexion = Datos.Conex.bdd;
        public static void NuevaVenta(Venta v)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into venta(id_cliente, fecha, total, impreso, venta_numero, factura_numero, estado, tipo, id_fdp_1, id_fdp_2, id_fdp_3, id_fdp_4,fdp1_monto,fdp2_monto,fdp3_monto,fdp4_monto, iva, descuento, observaciones, en_pesos) Values (@id_cliente, @fecha,@total, @impreso, @venta_numero, @factura_numero, @estado, @tipo,@id_fdp_1,@id_fdp_2,@id_fdp_3,@id_fdp_4, @fdp1_monto,@fdp2_monto,@fdp3_monto,@fdp4_monto, @iva,@descuento, @observaciones, @en_pesos)");

            cmd.Parameters.Add(new SqlParameter("@id_cliente", v.Id_cliente));

            cmd.Parameters.Add(new SqlParameter("@fecha", v.Fecha));

            cmd.Parameters.Add(new SqlParameter("@total", v.Total));
            cmd.Parameters.Add(new SqlParameter("@impreso", v.Impreso));


            cmd.Parameters.Add(new SqlParameter("@factura_numero", v.Factura_numero));
            cmd.Parameters.Add(new SqlParameter("@venta_numero", v.Venta_numero));
            cmd.Parameters.Add(new SqlParameter("@estado", v.Estado));
            cmd.Parameters.Add(new SqlParameter("@tipo", v.Tipo));

            cmd.Parameters.Add(new SqlParameter("@id_fdp_1", v.Id_fdp_1));
            cmd.Parameters.Add(new SqlParameter("@id_fdp_2", v.Id_fdp_2));
            cmd.Parameters.Add(new SqlParameter("@id_fdp_3", v.Id_fdp_3));
            cmd.Parameters.Add(new SqlParameter("@id_fdp_4", v.Id_fdp_4));

            cmd.Parameters.Add(new SqlParameter("@fdp1_monto", v.Fdp1_monto));
            cmd.Parameters.Add(new SqlParameter("@fdp2_monto", v.Fdp2_monto));
            cmd.Parameters.Add(new SqlParameter("@fdp3_monto", v.Fdp3_monto));
            cmd.Parameters.Add(new SqlParameter("@fdp4_monto", v.Fdp4_monto));
            cmd.Parameters.Add(new SqlParameter("@iva", v.Iva));
            cmd.Parameters.Add(new SqlParameter("@descuento", v.Descuento));
            cmd.Parameters.Add(new SqlParameter("@observaciones", v.Observaciones));
            cmd.Parameters.Add(new SqlParameter("@en_pesos", v.En_pesos));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static Int64 obtener_id_venta()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            Int64 id = 0;
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select max(id_venta) from venta");

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


        public static ArrayList getVentas(string dato)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listaventa = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select v.id_venta, v.fecha, v.id_cliente, v.total, c.nombre, c.documento, p.nombre, v.impreso, c.ciudad, c.direccion, c.rut, v.venta_numero,  v.factura_numero, v.tipo, v.estado,  v.id_fdp_1, v.id_fdp_2, v.id_fdp_3, v.id_fdp_4, v.fdp1_monto, v.fdp2_monto, v.fdp3_monto, v.fdp4_monto, v.descuento, v.iva, v.observaciones, v.en_pesos from venta v, cliente c, pais p where v.id_cliente = c.id_cliente and c.id_pais = p.id_pais " + dato + " and v.impreso = 1 order by v.id_venta");
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                Pais p = new Pais();
                p.Nombre = obdr.GetString(6);
                Cliente c = new Cliente();
                c.Nombre = obdr.GetString(4);
                c.Id_cliente = obdr.GetInt64(2);
                c.Documento = obdr.GetString(5);
                c.Pais = p;
                c.Ciudad = obdr.GetString(8);
                c.Direccion = obdr.GetString(9);
                c.RUT = obdr.GetString(10);
                Venta v = new Venta(obdr.GetInt64(0), obdr.GetInt64(2), obdr.GetDateTime(1), Convert.ToDecimal(Math.Round(Convert.ToDecimal(obdr.GetDecimal(3)), 2)), obdr.GetInt32(7), obdr.GetString(11), obdr.GetString(12), obdr.GetString(13), obdr.GetString(14), obdr.GetInt32(15), obdr.GetInt32(16), obdr.GetInt32(17), obdr.GetInt32(18), obdr.GetDecimal(19), obdr.GetDecimal(20), obdr.GetDecimal(21), obdr.GetDecimal(22), obdr.GetDecimal(23), obdr.GetDecimal(24), obdr.GetString(25), Convert.ToDecimal(Math.Round(Convert.ToDecimal(obdr.GetDecimal(26)), 2)));
                v.Provisorio = c.Nombre;
                v.Clientes = c;
                listaventa.Add(v);


            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listaventa;
        }
        public static ArrayList getVenta_cliente_porfecha_impreso(DateTime fecha_de)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listaventa = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select v.id_venta, v.fecha, v.id_cliente, v.total, c.nombre, c.documento, p.nombre , v.impreso, v.venta_numero, v.factura_numero, v.tipo, v.estado, v.id_fdp_1, v.id_fdp_2, v.id_fdp_3, v.id_fdp_4, v.fdp1_monto, v.fdp2_monto, v.fdp3_monto, v.fdp4_monto, v.descuento, v.iva, v.observaciones, v.en_pesos  from venta v, cliente c, pais p where v.id_cliente = c.id_cliente and c.id_pais = p.id_pais and  fecha = @fecha_de  and v.impreso = 0 order by v.id_venta");
            cmd.Parameters.Add(new SqlParameter("@fecha_de", fecha_de));
          //  cmd.Parameters.Add(new SqlParameter("@fecha_a", fecha_a));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                Pais p = new Pais();
                p.Nombre = obdr.GetString(6);
                Cliente c = new Cliente();
                c.Nombre = obdr.GetString(4);
                c.Id_cliente = obdr.GetInt64(2);
                c.Documento = obdr.GetString(5);
                c.Pais = p;
                Venta v = new Venta(obdr.GetInt64(0), obdr.GetInt64(2), obdr.GetDateTime(1), Convert.ToDecimal(Math.Round(Convert.ToDecimal(obdr.GetDecimal(3)), 2)), obdr.GetInt32(7), obdr.GetString(8), obdr.GetString(9), obdr.GetString(10), obdr.GetString(11), obdr.GetInt32(12), obdr.GetInt32(13), obdr.GetInt32(14), obdr.GetInt32(15), obdr.GetDecimal(16), obdr.GetDecimal(17), obdr.GetDecimal(18), obdr.GetDecimal(19), obdr.GetDecimal(20), obdr.GetDecimal(21), obdr.GetString(22), Convert.ToDecimal(Math.Round(Convert.ToDecimal(obdr.GetDecimal(23)), 2)));
                v.Provisorio = c.Nombre;
                v.Clientes = c;
                listaventa.Add(v);


            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listaventa;
        }
        public static ArrayList getVenta_cliente_porfecha(DateTime fecha)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listaventa = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select v.id_venta, v.fecha, v.id_cliente, v.total, c.nombre, c.documento, p.nombre , v.impreso, v.venta_numero, v.factura_numero,v.tipo, v.estado,  v.id_fdp_1, v.id_fdp_2, v.id_fdp_3, v.id_fdp_4, v.fdp1_monto, v.fdp2_monto, v.fdp3_monto, v.fdp4_monto, v.descuento, v.iva, v.observaciones, v.en_pesos from venta v, cliente c, pais p where v.id_cliente = c.id_cliente and c.id_pais = p.id_pais and  fecha = @fecha   and v.impreso = 1 order by v.id_venta");
            cmd.Parameters.Add(new SqlParameter("@fecha", fecha));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                Pais p = new Pais();
                p.Nombre = obdr.GetString(6);
                Cliente c = new Cliente();
                c.Nombre = obdr.GetString(4);
                c.Id_cliente = obdr.GetInt64(2);
                c.Documento = obdr.GetString(5);
                c.Pais = p;
                Venta v = new Venta(obdr.GetInt64(0), obdr.GetInt64(2), obdr.GetDateTime(1), Convert.ToDecimal(Math.Round(Convert.ToDecimal(obdr.GetDecimal(3)), 2)), obdr.GetInt32(7), obdr.GetString(8), obdr.GetString(9), obdr.GetString(10), obdr.GetString(11), obdr.GetInt32(12), obdr.GetInt32(13), obdr.GetInt32(14), obdr.GetInt32(15), obdr.GetDecimal(16), obdr.GetDecimal(17), obdr.GetDecimal(18), obdr.GetDecimal(19), obdr.GetDecimal(20), obdr.GetDecimal(21), obdr.GetString(22), Convert.ToDecimal(Math.Round(Convert.ToDecimal(obdr.GetDecimal(23)), 2)));
                v.Provisorio = c.Nombre;
                v.Clientes = c;
                listaventa.Add(v);


            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listaventa;
        }
        public static ArrayList getVenta_cliente_entre_fechas(DateTime desde, DateTime hasta)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listaventa = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select v.id_venta, v.fecha, v.id_cliente, v.total, c.nombre, c.documento, p.nombre , v.impreso, v.venta_numero, v.factura_numero,v.tipo, v.estado, v.id_fdp_1, v.id_fdp_2, v.id_fdp_3, v.id_fdp_4, v.fdp1_monto, v.fdp2_monto, v.fdp3_monto, v.fdp4_monto, v.descuento, v.iva, v.observaciones, v.en_pesos from venta v, cliente c, pais p where v.id_cliente = c.id_cliente and c.id_pais = p.id_pais and  fecha  between @desde and @hasta   and v.impreso = 1 order by v.id_venta");
            cmd.Parameters.Add(new SqlParameter("@desde", desde));
            cmd.Parameters.Add(new SqlParameter("@hasta", hasta));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                Pais p = new Pais();
                p.Nombre = obdr.GetString(6);
                Cliente c = new Cliente();
                c.Nombre = obdr.GetString(4);
                c.Id_cliente = obdr.GetInt64(2);
                c.Documento = obdr.GetString(5);
                c.Pais = p;
                Venta v = new Venta(obdr.GetInt64(0), obdr.GetInt64(2), obdr.GetDateTime(1), Convert.ToDecimal(Math.Round(Convert.ToDecimal(obdr.GetDecimal(3)), 2)), obdr.GetInt32(7), obdr.GetString(8), obdr.GetString(9), obdr.GetString(10), obdr.GetString(11), obdr.GetInt32(12), obdr.GetInt32(13), obdr.GetInt32(14), obdr.GetInt32(15), obdr.GetDecimal(16), obdr.GetDecimal(17), obdr.GetDecimal(18), obdr.GetDecimal(19), obdr.GetDecimal(20), obdr.GetDecimal(21), obdr.GetString(22), Convert.ToDecimal(Math.Round(Convert.ToDecimal(obdr.GetDecimal(23)), 2)));
                v.Provisorio = c.Nombre;
                v.Clientes = c;
                listaventa.Add(v);


            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listaventa;
        }
        public static void setBajaVenta(Int64 id_venta)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from venta  where id_venta = @id_venta");
            cmd.Parameters.Add(new SqlParameter("@id_venta", id_venta));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void ModificarVenta(object o)
        {
            Venta v = new Venta();
            v = (Venta)o;
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update venta set impreso = @impreso, venta_numero = @venta_num, factura_numero =@factura_num where id_venta = @id_venta");
            cmd.Parameters.Add(new SqlParameter("@id_venta", v.Id_venta));
            cmd.Parameters.Add(new SqlParameter("@impreso", 1));
            cmd.Parameters.Add(new SqlParameter("@venta_num", v.Venta_numero));
            cmd.Parameters.Add(new SqlParameter("@factura_num", v.Factura_numero));


            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }
        public static void ModificarVentaReset()
        {
     
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update venta set en_pesos = 0");
            //cmd.Parameters.Add(new SqlParameter("@en_pesos", 0));



            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }
    }
}
