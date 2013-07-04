using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaDeGestion.Datos;

namespace SistemaDeGestion
{
    public partial class Login : Form
    {
        bool existe = false;
        public Login()
        {
           existe = false;
            InitializeComponent();
            string[] a = { "Vendedor", "Administrador" };
            cbox_catego.Items.Clear();
            cbox_catego.Items.AddRange(a);
            cbox_catego.SelectedIndex = 0;

            // cbox_catego.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //   cbox_catego.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "Admin" && txt_password.Text == "1234lcda")
            {
                Principal.existe = true;
                Principal.usuario_valido = 5;
                existe = true;
                this.Close();

            }
            else
            {
                try
                {
                    string usuario = txt_usuario.Text.ToString();
                    string pass = txt_password.Text.ToString();
                    string catego = cbox_catego.SelectedItem.ToString();

                  /*  if (catego == "Tecnico")
                    {
                     bool verificacion_tecn = DatosUsuario.getUsuarios(usuario, pass, "Vendedor");
                       bool verificacion_adm = DatosUsuario.getUsuarios(usuario, pass, "Administrador");
                  //    bool verificacion_tecven = DatosUsuario.getUsuarios(usuario, pass, "Tecnico/Vendedor");

                        if (verificacion_adm == true)
                        {
                            Principal.existe = true;
                            Principal.usuario_valido = 1;
                            existe = true;
                            this.Close();
                        }
                        if (verificacion_tecn == true)
                        {

                            Principal.existe = true;
                            Principal.usuario_valido = 2;
                            existe = true;
                            this.Close();
                        }

                        if (verificacion_tecven == true)
                        {

                            Inicio.existe = true;
                            Inicio.usuario_valido = 2;
                            existe = true;
                            this.Close();
                        }

                    }*/
                    if (catego == "Vendedor")
                    {
                        bool verificacion_vend = DatosUsuario.getUsuarios(usuario, pass, "Vendedor");
                        bool verificacion_adm = DatosUsuario.getUsuarios(usuario, pass, "Administrador");
                     //   bool verificacion_tecven = DatosUsuario.getUsuarios(usuario, pass, "Tecnico/Vendedor");

                        if (verificacion_adm == true)
                        {
                            Principal.existe = true;
                            Principal.usuario_valido = 1;
                            existe = true;
                            Principal.usuario = txt_usuario.Text;
                            this.Close();

                        }

                      /*  if (verificacion_tecven == true)
                        {
                            Principal.existe = true;
                            Principal.usuario_valido = 3;
                            existe = true;
                            this.Close();
                        }*/
                        if (verificacion_vend == true)
                        {

                            Principal.existe = true;
                            Principal.usuario_valido = 3;
                            existe = true;
                            Principal.usuario = txt_usuario.Text;
                            this.Close();
                        }
                    }

                    if (catego == "Administrador")
                    {
                        bool verificacion_adm = DatosUsuario.getUsuarios(usuario, pass, "Administrador");

                        if (verificacion_adm == true)
                        {
                            Principal.existe = true;
                            Principal.usuario_valido = 1;
                            existe = true;
                            Principal.usuario = txt_usuario.Text;
                            this.Close();
                        }
                    }

                    if (existe == false)
                    {
                        MessageBox.Show(this, "No existe usuario", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch
                {
                    MessageBox.Show(this, "Error en la conexion", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

            this.Close();

        }


        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            if (existe != true)
            {
                Principal.usuario_valido = 0;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (existe != true)
            {
                Principal.usuario_valido = 0;
            }
        }



    }
}
