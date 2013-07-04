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
    class DatosProducto
    {
        public static DataSet ds;
        static string conexion = Datos.Conex.bdd;

        public static void setBajaProducto(string codigo)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from producto  where codigo = @codigo");
            cmd.Parameters.Add(new SqlParameter("@codigo", codigo));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void NuevoProducto(Producto p)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into producto(detalle, codigo, precio_unidad, iva, total,  stock,  stock_min, margen, id_categoria, imagen, imagen_categoria ) Values (@detalle, @codigo, @precio_unidad, @iva, @total,  @stock,  @stock_min,  @margen, @id_categoria, @imagen, @imagen_categoria)");
            cmd.Parameters.Add(new SqlParameter("@detalle", p.Detalle));
            cmd.Parameters.Add(new SqlParameter("@codigo", p.Codigo));
            //   cmd.Parameters.Add(new SqlParameter("@cod_barra", p.Cod_barra));
            cmd.Parameters.Add(new SqlParameter("@precio_unidad", p.Precio_unidad));
            cmd.Parameters.Add(new SqlParameter("@iva", p.Iva));
            cmd.Parameters.Add(new SqlParameter("@total", p.Total));
            cmd.Parameters.Add(new SqlParameter("@stock", p.Stock));
            //   cmd.Parameters.Add(new SqlParameter("@n_serie", p.N_serie));
            cmd.Parameters.Add(new SqlParameter("@stock_min", p.Stock_min));
            cmd.Parameters.Add(new SqlParameter("@margen", p.Margen));
            cmd.Parameters.Add(new SqlParameter("@id_categoria", p.Cate.Id_categoria));
            cmd.Parameters.Add(new SqlParameter("@imagen", p.Imagen));
            cmd.Parameters.Add(new SqlParameter("@imagen_categoria", p.Imagen_categoria));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }
        public static ArrayList getProductos()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar los productos
            ArrayList listaproductos = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select p.id_producto, p.codigo, p.detalle, p.precio_unidad, p.iva, p.total, p.margen, p.stock, p.stock_min, p.id_categoria, c.id_categoria, c.categoria_nombre, p.imagen , p.imagen_categoria c.imagen from producto p,  Categoria c where c.id_categoria=p.id_categoria order by p.detalle ");
    
            
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {

                Categoria cate = new Categoria(obdr.GetString(10), obdr.GetInt32(11), obdr.GetString(14));
                Producto p = new Producto(obdr.GetInt64(0), obdr.GetString(1), obdr.GetString(2), Convert.ToDecimal(Math.Round(obdr.GetDecimal(3), 2)), obdr.GetDecimal(4), obdr.GetDecimal(5), obdr.GetDecimal(6), obdr.GetInt32(7), obdr.GetInt32(8), cate);
                p.Imagen = obdr.GetString(12);

                p.Imagen_categoria = obdr.GetBoolean(13);
                listaproductos.Add(p);
            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listaproductos;
        }
        public static Producto getProducto_por_id(string codigo)
        {
            Producto p = new Producto();
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar los productos
            ArrayList listaproductos = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select detalle, id_producto, stock from producto where codigo = @codigo ");
            
                cmd.Parameters.Add(new SqlParameter("@codigo", codigo));//asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {

                p.Detalle = obdr.GetString(0);
                p.Id_producto = obdr.GetInt64(1);
                p.Stock = obdr.GetInt32(2);
            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return p;
        }

        public static Int64 obtener_idMax_producto()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            Int64 id = 0;
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select max(id_producto) from producto");

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
        public static ArrayList getProductosBuscarModelo(string dato)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar los productos
            ArrayList listaproductos = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select p.id_producto, p.codigo, p.detalle, p.precio_unidad, p.iva, p.total, p.margen, p.stock, p.stock_min, p.id_categoria, c.id_categoria, c.nombre, p.imagen, p.imagen_categoria, c.imagen from producto p,  Categoria c where c.id_categoria=p.id_categoria " + dato + " order by p.detalle ");
         

            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                Categoria cate = new Categoria(obdr.GetString(11), obdr.GetInt64(10), obdr.GetString(14));
                Producto p = new Producto(obdr.GetInt64(0), obdr.GetString(1), obdr.GetString(2), Convert.ToDecimal(Math.Round(obdr.GetDecimal(3),2)), obdr.GetDecimal(4), Convert.ToDecimal(Math.Round(Convert.ToDecimal(obdr.GetDecimal(5)), 2)), obdr.GetDecimal(6), obdr.GetInt32(7), obdr.GetInt32(8), cate);
                p.Imagen = obdr.GetString(12);
                p.Imagen_categoria = obdr.GetBoolean(13);
                listaproductos.Add(p);
                //string modelo, string descripcion, decimal precio_base2, decimal iva3, decimal total4, int descuento15, int descuento26,  decimal margen47, int id_producto, Categoria cate
            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return listaproductos;
            listaproductos = null;
        }

        public static Int64 verificar_codigo(string codigo)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            Int64 id = 0;
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select count(codigo) from producto where codigo like @codigo");
            cmd.Parameters.Add(new SqlParameter("@codigo", codigo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {

                id = obdr.GetInt32(0);


            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return id;
        }

        public static void NuevoProducto2(Producto p)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into producto(codigo, detalle, precio_unidad, iva, total,  stock,  stock_min,  margen, id_categoria, imagen, imagen_categoria) Values (@codigo, @detalle, @precio_unidad, @iva, @total,  @stock,  @stock_min, @margen, @id_categoria, @imagen, @imagen_categoria)");
            cmd.Parameters.Add(new SqlParameter("@codigo", p.Codigo));
            cmd.Parameters.Add(new SqlParameter("@detalle", p.Detalle));
            //   cmd.Parameters.Add(new SqlParameter("@cod_barra", p.Cod_barra));
            cmd.Parameters.Add(new SqlParameter("@precio_unidad", p.Precio_unidad));
            cmd.Parameters.Add(new SqlParameter("@iva", p.Iva));
            cmd.Parameters.Add(new SqlParameter("@total", p.Total));
            cmd.Parameters.Add(new SqlParameter("@stock", p.Stock));
            //   cmd.Parameters.Add(new SqlParameter("@n_serie", p.N_serie));
            cmd.Parameters.Add(new SqlParameter("@stock_min", p.Stock_min));
            cmd.Parameters.Add(new SqlParameter("@margen", p.Margen));
            cmd.Parameters.Add(new SqlParameter("@id_categoria", p.Cate.Id_categoria));
            cmd.Parameters.Add(new SqlParameter("@imagen", p.Imagen));
            cmd.Parameters.Add(new SqlParameter("@imagen_categoria", p.Imagen_categoria));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }
        public static void ModificarProducto(Producto p)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update producto set codigo=@codigo, detalle=@detalle,  precio_unidad=@precio_unidad, iva=@iva, total=@total, margen=@margen, stock=@stock, stock_min=@stock_min, id_categoria=@id_categoria, imagen=@imagen, imagen_categoria=@imagen_categoria where id_producto = @id_producto");
            cmd.Parameters.Add(new SqlParameter("@codigo", p.Codigo));
            cmd.Parameters.Add(new SqlParameter("@detalle", p.Detalle));
            //   cmd.Parameters.Add(new SqlParameter("@cod_barra", p.Cod_barra));
            cmd.Parameters.Add(new SqlParameter("@precio_unidad", p.Precio_unidad));
            cmd.Parameters.Add(new SqlParameter("@iva", p.Iva));
            cmd.Parameters.Add(new SqlParameter("@total", p.Total));
            cmd.Parameters.Add(new SqlParameter("@stock", p.Stock));
            //   cmd.Parameters.Add(new SqlParameter("@n_serie", p.N_serie));
            cmd.Parameters.Add(new SqlParameter("@stock_min", p.Stock_min));
            cmd.Parameters.Add(new SqlParameter("@margen", p.Margen));
            cmd.Parameters.Add(new SqlParameter("@id_categoria", p.Cate.Id_categoria));
            cmd.Parameters.Add(new SqlParameter("@id_producto", p.Id_producto));
            cmd.Parameters.Add(new SqlParameter("@imagen", p.Imagen));
            cmd.Parameters.Add(new SqlParameter("@imagen_categoria", p.Imagen_categoria));
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }
        public static void CambiarStock(Int64 id_producto, Int32 stock)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update producto set  stock=@stock where id_producto = @id_producto");
            cmd.Parameters.Add(new SqlParameter("@id_producto", id_producto));
            cmd.Parameters.Add(new SqlParameter("@stock", stock));

            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();

            cnn.Close();
        }
    }
}
