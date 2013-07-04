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
    public partial class Proveedor_Admin : Form
    {
        ArrayList listaVacia = new ArrayList();
        ArrayList listaproveedores = new ArrayList();
        public Proveedor_Admin()
        {
            InitializeComponent();
            cbox_filtro_producto.SelectedIndex = 0;
            buscar();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void buscar()
        {

            ArrayList lista = new ArrayList();

            // nombre
            if (cbox_filtro_producto.SelectedIndex == 0)
            {

                string buscar = "and p.nombre like '%" + txt_buscar.Text + "%'";
                lista = DatosProveedor.getProveedores(buscar);
            }

           
            //direccion
            else if (cbox_filtro_producto.SelectedIndex == 1)
            {

                string buscar = "and p.email like '%" + txt_buscar.Text + "%'";
                lista = DatosProveedor.getProveedores(buscar);
            }
            //telefono
            else if (cbox_filtro_producto.SelectedIndex == 2)
            {

                string buscar = "and p.direccion like '%" + txt_buscar.Text + "%'";
                lista = DatosProveedor.getProveedores(buscar);
            }
            //docmuento
            else if (cbox_filtro_producto.SelectedIndex == 3)
            {

                string buscar = "and p.telefono like '%" + txt_buscar.Text + "%'";
                lista = DatosProveedor.getProveedores(buscar);
            }
            //comentarios
            else if (cbox_filtro_producto.SelectedIndex == 4)
            {

                string buscar = "and p.comentario like '%" + txt_buscar.Text + "%'";
                lista = DatosProveedor.getProveedores(buscar);
            }
            else
            {
                lista = listaVacia;

            }
            if (lista.Count == 0)
            {
                bdd_proveedores.DataSource = listaVacia;
            }
            else
            {
                listaVacia.Clear();
                listaVacia = lista;
                bdd_proveedores.DataSource = listaVacia;
            }


        }

        private void cbox_filtro_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_buscar.SelectAll();
            txt_buscar.Focus();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btn_Nuevo_pro_Click(object sender, EventArgs e)
        {
            Proveedor_Datos pd = new Proveedor_Datos(true);
            pd.ShowDialog();
            txt_buscar.Text = "";
            buscar();
        }

        private void btn_modifica_Click(object sender, EventArgs e)
        {
            Proveedor_Datos pd = new Proveedor_Datos(false, (Proveedor)bdd_proveedores.CurrentRow.DataBoundItem);
            pd.ShowDialog();
            txt_buscar.Text = "";
            buscar();
        }

        private void bdd_proveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Proveedor_Datos pd = new Proveedor_Datos(false, (Proveedor)bdd_proveedores.CurrentRow.DataBoundItem);
            pd.ShowDialog();
            txt_buscar.Text = "";
            buscar();
        }

   

        
    }
}
