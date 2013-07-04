using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaDeGestion.Clases;
using SistemaDeGestion.Datos;

namespace SistemaDeGestion
{
    public partial class Usuarios_Datos : Form
    {
        string categoria;
        //  int select = 0;
        int valores = 0;

        bool alta;
        //bool verificacion = false;
        string catego;
        Usuario user;


        public Usuarios_Datos()
        {
            InitializeComponent();
            alta = true;
            cbox_tipo.SelectedIndex = 1;
        }

        public Usuarios_Datos(object u)
        {

            this.user = (Usuario)u;

            InitializeComponent();

            valores = 2;


            txt_usuario.Enabled = false;
            valores = 2;

            txt_nombre.Text = user.Nombre;
            txt_usuario.Text = user.Usuarios;
            txt_contraseña.Text = user.Pass;
            txt_apellido.Text = user.Apellido;
            cbox_tipo.Text = user.Categoria;


            alta = false;


            this.Text = "Modificar Usuario";


        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (cbox_tipo.SelectedIndex == 0)
            {
                categoria = "Administrador";
            }
            else if (cbox_tipo.SelectedIndex == 1)
            {
                categoria = "Vendedor";
            }

            if (Validar())
            {
                // es una modificación
                if (alta == false)
                {
                    Usuario u = new Usuario(0, txt_usuario.Text, txt_contraseña.Text, categoria, txt_nombre.Text, txt_apellido.Text);

                    DatosUsuario.ModificaUsuario(u);

                }

                    //es una alta
                else
                {






                    Usuario u = new Usuario(0, txt_usuario.Text, txt_contraseña.Text, categoria, txt_nombre.Text, txt_apellido.Text);
                    DatosUsuario.NuevoUsuario(u);
                }


                this.Close();
            }
        }
        private bool Validar()
        {
            string catego = cbox_tipo.SelectedText.ToString();


            if (txt_usuario.Text.Equals(""))
            {
                MessageBox.Show(this, "Debe ingresar un nombre de usuario!", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_usuario.Focus();
                return false;
            }
            else
            {



                if (txt_contraseña.Text.Equals(""))
                {
                    MessageBox.Show(this, "Debe ingresar una contraseña!", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_contraseña.Focus();
                    return false;
                }
                else
                {
                    if (txt_contraseña.Text != txt_Rep_contraseña.Text)
                    {
                        MessageBox.Show(this, "Las Contraseñas ingresadas no coinciden", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_contraseña.Focus();
                        return false;

                    }
                    else
                    {


                        if (txt_nombre.Text.Equals(""))
                        {
                            MessageBox.Show(this, "Debe ingresar un nombre!", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txt_nombre.Focus();
                            return false;

                        }
                        else
                        {

                            if (txt_apellido.Text.Equals(""))
                            {
                                MessageBox.Show(this, "Debe ingresar un apellido!", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txt_apellido.Focus();
                                return false;
                            }
                            else
                            {
                                return true;

                            }


                        }
                    }


                }
            }
        }





    }
}
