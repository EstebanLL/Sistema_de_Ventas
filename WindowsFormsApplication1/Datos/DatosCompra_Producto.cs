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
    class DatosCompra_Producto
    {
        public static DataSet ds;
        static string conexion = Datos.Conex.bdd;
        public static void NuevaCompraProducto(Compra_Producto cp)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into compra_producto(id_compra, id_producto, precio, cantidad) Values (@id_compra, @id_producto, @precio, @cantidad)");

            cmd.Parameters.Add(new SqlParameter("@id_compra", cp.Id_compra));

            cmd.Parameters.Add(new SqlParameter("@id_producto", cp.Id_producto));
            cmd.Parameters.Add(new SqlParameter("@precio", cp.Precio));
            cmd.Parameters.Add(new SqlParameter("@cantidad", cp.Cantidad));

            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }
        public static ArrayList getCompra_Producto(Int64 id)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listacompra = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select cp.precio, cp.cantidad, p.detalle,c.nombre, p.codigo from compra_producto cp, producto p, categoria c where cp.id_producto = p.id_producto and p.id_categoria = c.id_categoria and cp.id_compra = @id_compra");
            cmd.Parameters.Add(new SqlParameter("@id_compra", id));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {


                Compra_Producto cp = new Compra_Producto();

                cp.Precio = Convert.ToDecimal(Math.Round(Convert.ToDecimal(obdr.GetDecimal(0)), 2));
                cp.Cantidad = obdr.GetInt32(1);
                cp.Dato1 = obdr.GetString(2);
                cp.Dato2 = obdr.GetString(4);
                cp.Dato3 = obdr.GetString(3);

                listacompra.Add(cp);


            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listacompra;
        }
        public static void setBajaCompra_producto(Int64 id_compra)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from compra_producto  where id_compra = @id_compra");
            cmd.Parameters.Add(new SqlParameter("@id_compra", id_compra));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
