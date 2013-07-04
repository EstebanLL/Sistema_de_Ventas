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
using System.Collections;

namespace SistemaDeGestion
{
    public partial class Proveedor_Datos : Form
    {
        bool alta;
        Proveedor pro = new Proveedor();
        public Proveedor_Datos(bool alta)
        {
            InitializeComponent();
            this.alta = true;
            CargarPaises();
            this.Text = "Nuevo Proveedor";
        }
        public Proveedor_Datos(bool alta, object p)
        {
            InitializeComponent();
            this.pro = (Proveedor)p;
            this.alta = false;
            CargarPaises();
            txt_nombre.Text = pro.Nombre;
            txt_calle.Text = pro.Direccion;
            txt_telefono_numero.Text = pro.Telefono;
            txt_email.Text = pro.Email;
            txt_ciudad.Text = pro.Ciudad;
            txt_comentario.Text = pro.Comentario;
            cbox_pais.Text = pro.Pais.Nombre;
            this.Text = "Modificar Proveedor";
        }
        private void CargarPaises()
        {
            ArrayList paises = new ArrayList();
            paises = DatosPais.getPaises();
            cbox_pais.DataSource = paises;
            cbox_pais.DisplayMember = "Nombre";
            cbox_pais.ValueMember = "Id_pais";
            cbox_pais.Refresh();
            cbox_pais.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbox_pais.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "")
            {



                if (txt_calle.Text != "")
                {


                    pro.Direccion = txt_calle.Text;
                }
                else
                {

                    pro.Direccion = " ";
                }

                if (txt_ciudad.Text != "")
                {

                    pro.Ciudad = txt_ciudad.Text;
                }
                else
                {
                    pro.Ciudad = " ";
                }

                if (txt_email.Text != "")
                {

                    pro.Email = txt_email.Text;
                }
                else
                {
                    pro.Email = " ";
                }

              

                if (txt_telefono_numero.Text != "")
                {

                    pro.Telefono = txt_telefono_numero.Text;
                }
                else
                {
                    pro.Telefono = " ";
                }
                if (txt_comentario.Text != "")
                {

                    pro.Comentario = txt_comentario.Text;
                }
                else
                {
                    pro.Comentario = " ";
                }
                if (cbox_pais.SelectedItem != null)
                {
                    pro.id_Pais = ((Pais)cbox_pais.SelectedItem).Id_pais;
                }

                else
                {

                    pro.id_Pais = DatosPais.obtener_id_pais_maximo();
                }
                pro.Nombre = txt_nombre.Text;

                if (alta == true)
                {
                    DatosProveedor.NuevoProveedor(pro);
                }
                else
                {
                    DatosProveedor.ModificaProveedor(pro);

                }
                this.Close();
            }

            else
            {
                MessageBox.Show(this, "Debe ingresar el nombre del proveedor", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

           
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
