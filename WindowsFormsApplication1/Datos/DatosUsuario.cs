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

    class DatosUsuario
    {

        //static string conexion = "data source=localhost; initial catalog = Novartis; integrated security=true";
        public static DataSet ds;
        static string conexion = Datos.Conex.bdd;
        // public int usuarios2;

        public static bool getUsuarios(string usuario, string pass, string catego)
        {

            //      bool verificacion;
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listaUsuarios = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id_usuario, usuario, pass, categoria, nombre, apellido from usuario where usuario like @usuario and pass like @pass and categoria like @catego");

            cmd.Parameters.Add(new SqlParameter("@usuario", usuario));
            cmd.Parameters.Add(new SqlParameter("@pass", pass));
            cmd.Parameters.Add(new SqlParameter("@catego", catego));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader






            while (obdr.Read())
            {
                //Creo los objetos persona y los agrego a la lista
                Usuario u = new Usuario(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetString(3), obdr.GetString(4), obdr.GetString(5));
                listaUsuarios.Add(u);






            }

            if (listaUsuarios.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

            // return listaUsuarios;

            //Cierro la conexion
            cnn.Close();
            //retorno la lsita



        }


     /*   public static void NuevoCliente(Cliente c)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into cliente(nombre, apellido, telefono, email, calle, n_calle, depto, dni, id_tipo_cli, id_tipo_doc, id_localidad) Values (@nombre, @apellido, @telefono, @email, @calle, @n_calle, @depto, @dni, @id_tipo_cli, @id_tipo_doc, @id_localidad)");
            cmd.Parameters.Add(new SqlParameter("@nombre", c.Nombre));
            cmd.Parameters.Add(new SqlParameter("@apellido", c.Apellido));
            cmd.Parameters.Add(new SqlParameter("@telefono", c.Telefono));
            cmd.Parameters.Add(new SqlParameter("@email", c.Email));
            cmd.Parameters.Add(new SqlParameter("@calle", c.Calle));
            cmd.Parameters.Add(new SqlParameter("@n_calle", c.N_calle));
            cmd.Parameters.Add(new SqlParameter("@depto", c.Depto));
            cmd.Parameters.Add(new SqlParameter("@dni", c.Dni));
            cmd.Parameters.Add(new SqlParameter("@id_tipo_cli", c.Tipo_cli.Id_tipo_cliente));
            cmd.Parameters.Add(new SqlParameter("@id_tipo_doc", c.Tipo_doc.Id_tipo_doc));
            cmd.Parameters.Add(new SqlParameter("@id_localidad", c.Loc.Id_localidad));

            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }*/
        public static void NuevoUsuario(Usuario c)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into usuario(nombre, apellido, usuario, pass, categoria) Values (@nombre, @apellido, @usuario, @pass, @categoria)");
            cmd.Parameters.Add(new SqlParameter("@nombre", c.Nombre));
            cmd.Parameters.Add(new SqlParameter("@apellido", c.Apellido));
            cmd.Parameters.Add(new SqlParameter("@usuario", c.Usuarios));
            cmd.Parameters.Add(new SqlParameter("@pass", c.Pass));
            cmd.Parameters.Add(new SqlParameter("@categoria", c.Categoria));

            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }
        public static void ModificaUsuario(Usuario c)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update usuario set nombre=@nombre, apellido=@apellido, usuario=@usuario, pass=@pass, categoria=@categoria where usuario = @usuario");
            cmd.Parameters.Add(new SqlParameter("@nombre", c.Nombre));
            cmd.Parameters.Add(new SqlParameter("@apellido", c.Apellido));
            cmd.Parameters.Add(new SqlParameter("@usuario", c.Usuarios));
            cmd.Parameters.Add(new SqlParameter("@pass", c.Pass));
            cmd.Parameters.Add(new SqlParameter("@categoria", c.Categoria));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }

     /*   public static void ModificaCliente(Cliente c)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update cliente set nombre=@nombre, apellido=@apellido, telefono=@telefono, email=@email, calle=@calle, n_calle=@n_calle, depto=@depto, dni=@dni, id_tipo_cli=@id_tipo_cli, id_tipo_doc=@id_tipo_doc, id_localidad=@id_localidad where id_cliente = @id_cliente");
            cmd.Parameters.Add(new SqlParameter("@nombre", c.Nombre));
            cmd.Parameters.Add(new SqlParameter("@apellido", c.Apellido));
            cmd.Parameters.Add(new SqlParameter("@telefono", c.Telefono));
            cmd.Parameters.Add(new SqlParameter("@email", c.Email));
            cmd.Parameters.Add(new SqlParameter("@calle", c.Calle));
            cmd.Parameters.Add(new SqlParameter("@n_calle", c.N_calle));
            cmd.Parameters.Add(new SqlParameter("@depto", c.Depto));
            cmd.Parameters.Add(new SqlParameter("@dni", c.Dni));
            cmd.Parameters.Add(new SqlParameter("@id_tipo_cli", c.Tipo_cli.Id_tipo_cliente));
            cmd.Parameters.Add(new SqlParameter("@id_tipo_doc", c.Tipo_doc.Id_tipo_doc));
            cmd.Parameters.Add(new SqlParameter("@id_cliente", c.Id_cliente));
            cmd.Parameters.Add(new SqlParameter("@id_localidad", c.Loc.Id_localidad));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }
        public static void BorraCliente(Cliente c)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from cliente where id_cliente = @id_cliente");
            cmd.Parameters.Add(new SqlParameter("@id_cliente", c.Id_cliente));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
        }*/
        public static DataSet getBuscarUsuarioNombre(string buscar)
        {
            ds = new DataSet();
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand("select * from Usuario where nombre like @buscar", cnn);

            cmd.Parameters.Add(new SqlParameter("@buscar", buscar));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Usuario");
            cnn.Close();
            return ds;
        }
        public static DataSet getBuscarUsuarioUsuario(string buscar)
        {
            ds = new DataSet();
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand("select * from Usuario where usuario like @buscar", cnn);

            cmd.Parameters.Add(new SqlParameter("@buscar", buscar));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Usuario");
            cnn.Close();
            return ds;
        }
        public static DataSet getBuscarUsuarioCategoria(string buscar)
        {
            ds = new DataSet();
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand("select * from Usuario where categoria like @buscar", cnn);

            cmd.Parameters.Add(new SqlParameter("@buscar", buscar));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Usuario");
            cnn.Close();
            return ds;
        }

        public static ArrayList getDatosUsuarios()
        {            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList lista = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id_usuario, usuario, categoria, pass, nombre, apellido from Usuario");
            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                Usuario u = new Usuario(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(3), obdr.GetString(2), obdr.GetString(4), obdr.GetString(5));
                lista.Add(u);
            }
            //Cierro la conexion
            cnn.Close();
            //retorno la lsita
            return lista;

        }
        public static void setUsuario(DataSet datset)
        {
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand("select * from Usuario", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(datset, "Usuario");
            cnn.Close();
        }



        public static void setBajaUsuario(int id_usuario)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from usuario  where id_usuario = @id_prod_cod");
            cmd.Parameters.Add(new SqlParameter("@id_prod_cod", id_usuario));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static bool getUsuarioExiste(string usuario)
        {

            //      bool verificacion;
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listaUsuarios = new ArrayList();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id_usuario, usuario, pass, categoria, nombre, apellido from usuario where usuario like @usuario ");

            cmd.Parameters.Add(new SqlParameter("@usuario", usuario));


            //asigno la conexion al comando
            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader






            while (obdr.Read())
            {
                //Creo los objetos persona y los agrego a la lista
                Usuario u = new Usuario(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetString(3), obdr.GetString(4), obdr.GetString(5));
                listaUsuarios.Add(u);






            }

            if (listaUsuarios.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

            // return listaUsuarios;

            //Cierro la conexion
            cnn.Close();
            //retorno la lsita



        }


    }

}
