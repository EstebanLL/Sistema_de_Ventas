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
    public partial class Cliente_Admin : Form
    {
        ArrayList listaVacia = new ArrayList();
        ArrayList listaclientes = new ArrayList();

        public Cliente_Admin()
        {
            InitializeComponent();
            cbox_filtro_producto.SelectedIndex = 0;
            buscar();
        }

        public Cliente_Admin(bool cumple)
        {
            InitializeComponent();
            cbox_filtro_producto.SelectedIndex = 0;


            ArrayList lista = new ArrayList();

            // nombre
            if (cbox_filtro_producto.SelectedIndex == 0)
            {

                string buscarse = "and c.nombre like '%%'";
                lista = DatosCliente.getClientes(buscarse);
            }




            for (int x = lista.Count; x > 0; x--)
            {
                if (((Cliente)lista[x - 1]).Nacimiento.Day != DateTime.Today.Day || ((Cliente)lista[x - 1]).Nacimiento.Month != DateTime.Today.Month)
                {
                    lista.RemoveAt(x - 1);

                }

            }
            listaVacia.Clear();
            listaVacia = lista;
            bdd_clientes.DataSource = listaVacia;

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

        private void bdd_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente_Datos cd = new Cliente_Datos((Cliente)bdd_clientes.CurrentRow.DataBoundItem);
            cd.ShowDialog();
            buscar();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modifica_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente_Datos cd = new Cliente_Datos((Cliente)bdd_clientes.CurrentRow.DataBoundItem);
                cd.ShowDialog();
                buscar();
            }
            catch { }
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

    

        private void btn_Nuevo_cli_Click(object sender, EventArgs e)
        {
            Cliente_Datos cd = new Cliente_Datos();
            cd.ShowDialog();
            buscar();
        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            buscar();
        }



    }
}
