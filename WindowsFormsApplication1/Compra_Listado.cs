using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using SistemaDeGestion.Clases;
using SistemaDeGestion.Datos;
using System.IO;

namespace SistemaDeGestion
{
    public partial class Compra_Listado : Form
    {
        Font printFont;
        string printString;
        ArrayList listaVacia = new ArrayList();
        bool btn_buscar_validar = false;
      bool    btn_buscar_validar_vencidos;
        ArrayList listaprimera = new ArrayList();
        ArrayList listacarrito = new ArrayList();
        int inicio = 0;
        public Compra_Listado()
        {
            InitializeComponent();
            cbox_filtro_producto.SelectedIndex = 0;
            cargar();
        }
        public Compra_Listado(bool carga)
        {
            InitializeComponent();
            cbox_filtro_producto.SelectedIndex = 4;
            cargar();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {

        }
        public void cargar()
        {
            // try
            //{


            txt_pesos.Text = "0";



            bool es_fecha = false;
            ArrayList lista = new ArrayList();

            // modelo
            if (cbox_filtro_producto.SelectedIndex == 0)
            {
                string buscar = "and c.numero_factura like '%" + txt_buscar.Text + "%'";
                lista = Datos.DatosCompra.getCompras(buscar);
                // tets
                for (int i = 0; i < lista.Count; i++)
                {

                    txt_pesos.Text = (Convert.ToDecimal(txt_pesos.Text) + ((Compra)lista[i]).Importe).ToString();

                }

            }

            else if (cbox_filtro_producto.SelectedIndex == 1)
            {

     
                if (btn_buscar_validar == true)
                {
                    DateTime fecha1 = date_fecha.Value.AddDays(1);
                    // and  fecha = @fecha_de 
                    string buscar = "and  c.fecha_factura = " + date_fecha.Value.Day + "/" + date_fecha.Value.Month + "/" + date_fecha.Value.Year + " ";
                    lista = Datos.DatosCompra.getCompras_por_fecha(date_fecha.Value.Date);


                    for (int i = 0; i < lista.Count; i++)
                    {

                        txt_pesos.Text = (Convert.ToDecimal(txt_pesos.Text) + ((Compra)lista[i]).Importe).ToString();

                    }
                    es_fecha = true;

                }

                else
                {
                    lista = listaVacia;

                }

            }

            else if (cbox_filtro_producto.SelectedIndex == 2)
            {

                string buscar = "and p.nombre like '%" + txt_buscar.Text + "%'";
                lista = Datos.DatosCompra.getCompras(buscar);
                // tets
                for (int i = 0; i < lista.Count; i++)
                {

                    txt_pesos.Text = (Convert.ToDecimal(txt_pesos.Text) + ((Compra)lista[i]).Importe).ToString();

                }


            }
            else if (cbox_filtro_producto.SelectedIndex == 3)
            {

                string buscar = "and c.estado like '%Debe%'";
                lista = Datos.DatosCompra.getCompras(buscar);
                // tets
                for (int i = 0; i < lista.Count; i++)
                {

                    txt_pesos.Text = (Convert.ToDecimal(txt_pesos.Text) + ((Compra)lista[i]).Importe).ToString();

                }
   

            }
            else if (cbox_filtro_producto.SelectedIndex == 4)
            {


                string buscar = "and " + DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year + " >= c.fecha_vencimiento and c.estado like '%Debe%'";
                lista = Datos.DatosCompra.getCompras_Vencidad();
                // tets
                for (int i = 0; i < lista.Count; i++)
                {

                    txt_pesos.Text = (Convert.ToDecimal(txt_pesos.Text) + ((Compra)lista[i]).Importe).ToString();

                }

                btn_buscar_validar_vencidos = true;
                es_fecha = true;
                btn_buscar_validar = false;
            }
            if (lista.Count == 0)
            {
    
                if (es_fecha == false)
                {
                    bdd_compra.DataSource = listaVacia;
                }
                else
                {
                    if (btn_buscar_validar == true)
                    {

                        MessageBox.Show("No existen registros con la fecha seleccionada", "Mensaje");


                        cargar_si_vacio();
                    }
                    if (btn_buscar_validar_vencidos == true)
                    {

                        MessageBox.Show("No existen facturas vencidas", "Mensaje");


                        cargar_si_vacio();
                    }
                }


            }
            else
            {
                listaVacia.Clear();
                listaVacia = lista;
                bdd_compra.DataSource = listaVacia;


            }

            es_fecha = false;
            btn_buscar_validar = false;
            btn_buscar_validar_vencidos = false;
            //   }
            // catch { } 
       
        }
        public void cargar_si_vacio()
        {
            ArrayList lista = new ArrayList();

            string buscar = "and c.numero_factura like '%" + txt_buscar.Text + "%'";
            lista = Datos.DatosCompra.getCompras(buscar);
            // tets
            for (int i = 0; i < lista.Count; i++)
            {

                txt_pesos.Text = (Convert.ToDecimal(txt_pesos.Text) + ((Compra)lista[i]).Importe).ToString();

            }
            bdd_compra.DataSource = lista;

        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            Compra_Productos cp = new Compra_Productos((Compra)bdd_compra.CurrentRow.DataBoundItem);
            cp.ShowDialog();
            cargar_si_vacio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_buscar_validar = true;
            cargar();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            cargar();
        }

        private void bnt_imprimir_Click(object sender, EventArgs e)
        {
            Compra_Imprimir ci = new Compra_Imprimir();
            ci.ShowDialog();
        }

        private void cbox_filtro_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_pesos.Text = "0";
            txt_buscar.Text = "";



        

            if (cbox_filtro_producto.SelectedIndex == 1)
            {
                date_fecha.Visible = true;
                txt_buscar.Visible = false;
                btn_buscar_validar = true;
            }
            else
            {
                date_fecha.Visible = false;
                txt_buscar.Visible = true;
            }
            cargar();
        }

        private void bdd_compra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Compra_Productos cp = new Compra_Productos((Compra)bdd_compra.CurrentRow.DataBoundItem);
            cp.ShowDialog();
            cargar_si_vacio();
        }

     



    }
}
