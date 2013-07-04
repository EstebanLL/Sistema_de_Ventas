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
    public partial class Cliente_Datos : Form
    {
        Cliente cli = new Cliente();
        bool modificar = false;

        public Cliente_Datos()
        {
            InitializeComponent();
            CargarPaises();

        }
        public Cliente_Datos(object c)
        {
            InitializeComponent();
            CargarPaises();
            this.cli = (Cliente)c;
            txt_nombre.Text = cli.Nombre;
            txt_telefono_numero.Text = cli.Telefono;
            txt_numero_doc.Text = cli.Documento;
            txt_email.Text = cli.Email;
            txt_calle.Text = cli.Direccion;
            txt_ciudad.Text = cli.Ciudad;
            cbox_pais.Text = cli.Pais.Nombre;
            txt_rut.Text = cli.RUT;
            modificar = true;
            this.Text = "Modificar Cliente";
            date_cumple.Value = cli.Nacimiento;
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

                Cliente c = new Cliente();

                if (txt_calle.Text != "")
                {

                    c.Direccion = txt_calle.Text;
                }
                else
                {
                    c.Direccion = " ";
                }

                if (txt_ciudad.Text != "")
                {

                    c.Ciudad = txt_ciudad.Text;
                }
                else
                {
                    c.Ciudad = " ";
                }

                if (txt_email.Text != "")
                {

                    c.Email = txt_email.Text;
                }
                else
                {
                    c.Email = " ";
                }

                if (txt_numero_doc.Text != "")
                {

                    c.Documento = txt_numero_doc.Text;
                }
                else
                {
                    c.Documento = " ";
                }

                if (txt_telefono_numero.Text != "")
                {

                    c.Telefono = txt_telefono_numero.Text;
                }
                else
                {
                    c.Telefono = " ";
                }
                if (txt_rut.Text != "")
                {

                    c.RUT = txt_rut.Text;
                }
                else
                {
                    c.RUT = " ";
                }
                if (cbox_pais.SelectedItem != null)
                {
                    c.id_Pais = ((Pais)cbox_pais.SelectedItem).Id_pais;
                }

                else
                {

                    c.id_Pais = DatosPais.obtener_id_pais_maximo();
                }
                c.Nacimiento = date_cumple.Value;
                c.Nombre = txt_nombre.Text;
                if (modificar == false)
                {
                    DatosCliente.NuevoCliente(c);
                }
                else
                {
                    c.Id_cliente = cli.Id_cliente;
                    DatosCliente.ModificarCliente(c);
                }

                this.Close();
            }

            else
            {
                MessageBox.Show(this, "Debe ingresar el nombre de cliente","¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void txt_numero_doc_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
