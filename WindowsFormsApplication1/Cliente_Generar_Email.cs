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
    public partial class Cliente_Generar_Email : Form
    {
        ArrayList listaVacia = new ArrayList();
        ArrayList listaclientes = new ArrayList();
        public Cliente_Generar_Email()
        {
            InitializeComponent();
            buscar();
            cbox_filtro_producto.SelectedIndex = 0;
        }



        public void buscar()
        {

            ArrayList lista = new ArrayList();

            // nombre
            if (cbox_filtro_producto.SelectedIndex == 0)
            {

                string buscar = "and c.nombre like '%" + txt_buscar.Text + "%'";
                lista = DatosCliente.getClientes(buscar);
            }

            //doc
            else if (cbox_filtro_producto.SelectedIndex == 1)
            {

                string buscar = "and c.documento like '%" + txt_buscar.Text + "%'";
                lista = DatosCliente.getClientes(buscar);
            }
            //direccion
            else if (cbox_filtro_producto.SelectedIndex == 2)
            {

                string buscar = "and c.email like '%" + txt_buscar.Text + "%'";
                lista = DatosCliente.getClientes(buscar);
            }
            //telefono
            else if (cbox_filtro_producto.SelectedIndex == 3)
            {

                string buscar = "and c.direccion like '%" + txt_buscar.Text + "%'";
                lista = DatosCliente.getClientes(buscar);
            }
            //docmuento
            else if (cbox_filtro_producto.SelectedIndex == 4)
            {

                string buscar = "and c.telefono like '%" + txt_buscar.Text + "%'";
                lista = DatosCliente.getClientes(buscar);
            }
            else if (cbox_filtro_producto.SelectedIndex == 5)
            {

                string buscar = "and c.telefono like '%" + txt_buscar.Text + "%'";
                lista = DatosCliente.getClientes(buscar);
                for (int x = lista.Count; x > 0; x--)
                {
                    if (((Cliente)lista[x - 1]).Nacimiento.Day != DateTime.Today.Day || ((Cliente)lista[x - 1]).Nacimiento.Month != DateTime.Today.Month)
                    {
                        lista.RemoveAt(x - 1);

                    }

                }
            }
            else
            {
                lista = listaVacia;

            }
            if (lista.Count == 0)
            {
                if (cbox_filtro_producto.SelectedIndex == 5)
                {

                    MessageBox.Show(this, "No existen clientes que cumplan años el día de hoy", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbox_filtro_producto.SelectedIndex = 0;
                }
                bdd_clientes.DataSource = listaVacia;
            }
            else
            {
                listaVacia.Clear();
                listaVacia = lista;
                bdd_clientes.DataSource = listaVacia;
            }


        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void cbox_filtro_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_filtro_producto.SelectedIndex == 5)
            {

                txt_buscar.ReadOnly = true;

            }
            else
            {
                txt_buscar.ReadOnly = false;

            }
            txt_buscar.Text = "";
            txt_buscar.Focus();
            buscar();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            if (chk_lista_completa.Checked == false)
            {
                if (((Cliente)bdd_clientes.CurrentRow.DataBoundItem).Email != " ")
                {
                    if (txt_email.Text != "")
                    {
                        txt_email.Text = txt_email.Text + "; " + ((Cliente)bdd_clientes.CurrentRow.DataBoundItem).Email;
                    }
                    else
                    {
                        txt_email.Text = ((Cliente)bdd_clientes.CurrentRow.DataBoundItem).Email;

                    }
                }
            }
            else
            {
                if (listaVacia.Count > 0)
                {

                    for (int i = 0; i < listaVacia.Count; i++)
                    {
                        if (((Cliente)listaVacia[i]).Email != " ")
                        {
                            if (txt_email.Text != "")
                            {
                                txt_email.Text = txt_email.Text + "; " + ((Cliente)listaVacia[i]).Email;
                            }
                            else
                            {
                                txt_email.Text = ((Cliente)listaVacia[i]).Email;

                            }
                        }
                    }

                }

            }
        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            buscar();
        }



        private void btn_copiar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_email.Text);
            }
            catch
            {
            }
        }

        private void bdd_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
                if (((Cliente)bdd_clientes.CurrentRow.DataBoundItem).Email != " ")
                {
                    if (txt_email.Text != "")
                    {
                        txt_email.Text = txt_email.Text + "; " + ((Cliente)bdd_clientes.CurrentRow.DataBoundItem).Email;
                    }
                    else
                    {
                        txt_email.Text = ((Cliente)bdd_clientes.CurrentRow.DataBoundItem).Email;

                    }
                }
          
        }

    }
}
