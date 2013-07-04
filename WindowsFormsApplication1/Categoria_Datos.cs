using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaDeGestion.Datos;
using SistemaDeGestion.Clases;
namespace SistemaDeGestion
{
    public partial class Categoria_Datos : Form
    {
       int tipo;
        string nombre;
        int modificar;
        Categoria catego = new Categoria();
        public Categoria_Datos(object cat)
        {
            InitializeComponent();
         
            catego = (Categoria)cat;
            modificar = 1;
            tipo = 2;
            textBox1.Text = catego.Nombre;
            txt_ruta_imagen.Text = catego.Imagen;
            label_imagen_no_disponible.Visible = false;
            if (catego.Imagen != " ")
            {
                try
                {
                    pbox_imagen.Image = Image.FromFile(txt_ruta_imagen.Text);
                    label_imagen_no_disponible.Visible = false; 
                }
                catch
                {
                    label_imagen_no_disponible.Visible = true;
                    pbox_imagen.Visible = false;
                }
            }
        }
        public Categoria_Datos(int tip, int mod, string nada)
        {
            try
            {

                nombre = nada;
                modificar = mod;

                InitializeComponent();
                this.tipo = tip;
                if (tipo == 1 && modificar == 1)
                {

                    textBox1.Text = nada;

                }
                if (tipo == 2 && modificar == 1)
                {

                    textBox1.Text = nada;


                }
            }
            catch {

                MessageBox.Show(this, "[0002]Error al cargar datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show(this, "Tiene que ingresar un nombre valido", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                catego.Nombre = textBox1.Text;
                if (txt_ruta_imagen.Text == "")
                {
                    txt_ruta_imagen.Text = " ";
                }
                catego.Imagen = txt_ruta_imagen.Text;
              //  try
               // {
                    if (tipo == 1 && modificar == 0)
                    {

                      //DatosCategoria.NuevoCategoria_Cli(textBox1.Text);

                    }
                    if (tipo == 2 && modificar == 0)
                    {


                        DatosCategoria.NuevoCategoria_Prod(catego);

                    }
                    if (tipo == 1 && modificar == 1)
                    {

                   //     DatosCategoria.ModificarCategoria_Cli(nombre, textBox1.Text);

                    }
                    if (tipo == 2 && modificar == 1)
                    {

                       
                        DatosCategoria.ModificarCategoria_Prod(catego);

                    }
                    this.Close();
               /* }

                catch
                {
                    MessageBox.Show(this, "[0001]Error al grabar datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }*/
            }
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
            if (open_buscar_imagen.ShowDialog() == DialogResult.OK)
            {

                txt_ruta_imagen.Text = open_buscar_imagen.FileName;
                try
                {
                    pbox_imagen.Image = Image.FromFile(txt_ruta_imagen.Text);
                    label_imagen_no_disponible.Visible = false;
                    pbox_imagen.Visible = true;
                }
                catch
                {
                    label_imagen_no_disponible.Visible = true;
                    pbox_imagen.Visible = false;
                }

            }
        }
    }
}
