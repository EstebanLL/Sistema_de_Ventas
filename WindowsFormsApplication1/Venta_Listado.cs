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

using System.Drawing.Printing;
namespace SistemaDeGestion
{
    public partial class Venta_Listado : Form
    {
        Caja cj = new Caja();
        Font printFont;
        string printString;
        ArrayList listaVacia = new ArrayList();
        bool btn_buscar_validar = false;
        ArrayList listaprimera = new ArrayList();
        ArrayList listacarrito = new ArrayList();
        int inicio = 0;
        public Venta_Listado()
        {
            InitializeComponent();
            cbox_filtro_producto.SelectedIndex = 0;
            cargar();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void cargar()
        {

            txt_pesos.Text = "0";



            bool es_fecha = false;
            ArrayList lista = new ArrayList();

            // modelo
            if (cbox_filtro_producto.SelectedIndex == 1)
            {
                string buscar = "and c.nombre like '%" + txt_buscar.Text + "%'";
                lista = Datos.DatosVenta.getVentas(buscar);

                for (int i = 0; i < lista.Count; i++)
                {

                    txt_pesos.Text = (Convert.ToDecimal(txt_pesos.Text) + ((Venta)lista[i]).Total).ToString();

                }

            }
            if (cbox_filtro_producto.SelectedIndex == 0)
            {
                string buscar = "and v.venta_numero like '%" + txt_buscar.Text + "%'";
                lista = Datos.DatosVenta.getVentas(buscar);

                for (int i = 0; i < lista.Count; i++)
                {

                    txt_pesos.Text = (Convert.ToDecimal(txt_pesos.Text) + ((Venta)lista[i]).Total).ToString();

                }

            }

            if (cbox_filtro_producto.SelectedIndex == 3)
            {
                string buscar = "and v.observaciones like '%" + txt_buscar.Text + "%'";
                lista = Datos.DatosVenta.getVentas(buscar);

                for (int i = 0; i < lista.Count; i++)
                {

                    txt_pesos.Text = (Convert.ToDecimal(txt_pesos.Text) + ((Venta)lista[i]).Total).ToString();

                }

            }



            else if (cbox_filtro_producto.SelectedIndex == 2)
            {
                txt_en_pesos.Text = "0";
                bnt_imprimir.Enabled = true;
                if (btn_buscar_validar == true)
                {
                    DateTime fecha1 = date_fecha.Value.AddDays(1);
                    // string buscar = "and  fecha between '" + date_fecha.Value.Year + "-" + date_fecha.Value.Day + "-" + date_fecha.Value.Month + "' and '" + fecha1.Year + "-" + fecha1.Day + "-" + fecha1.Month + "'";
                    lista = Datos.DatosVenta.getVenta_cliente_porfecha(date_fecha.Value.Date);


                    for (int i = 0; i < lista.Count; i++)
                    {

                        txt_pesos.Text = (Convert.ToDecimal(txt_pesos.Text) + ((Venta)lista[i]).Total).ToString();
                        txt_en_pesos.Text = (Convert.ToDecimal(txt_en_pesos.Text) + ((Venta)lista[i]).En_pesos).ToString();

                    }
                    es_fecha = true;
                    cj = Datos.Datos_Caja.get_caja_por_fecha(date_fecha.Value.Date);
                    txt_caja.Text = cj.Monto.ToString();
                }

                else
                {
                    lista = listaVacia;

                }

            }

            if (lista.Count == 0)
            {
                btn_ver.Enabled = false;
                if (es_fecha == false)
                {
                    bdd_ventas.DataSource = listaVacia;
                }
                else
                {
                    if (btn_buscar_validar == true)
                    {

                        MessageBox.Show("No existen registros en la fecha seleccionada", "Mensaje");


                        cargar_si_vacio();
                    }
                }


            }
            else
            {
                btn_ver.Enabled = true;
                listaVacia.Clear();
                listaVacia = lista;
                bdd_ventas.DataSource = listaVacia;
            }

            es_fecha = false;
            btn_buscar_validar = false;


        }

        public void cargar_si_vacio()
        {
            ArrayList lista = new ArrayList();

            string buscar = "and c.nombre like '%" + txt_buscar.Text + "%'";
            lista = Datos.DatosVenta.getVentas(buscar);

            for (int i = 0; i < lista.Count; i++)
            {

                txt_pesos.Text = (Convert.ToDecimal(txt_pesos.Text) + ((Venta)lista[i]).Total).ToString();

            }
            bdd_ventas.DataSource = lista;
        }

        private void cbox_filtro_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_pesos.Text = "0";
            txt_buscar.Text = "";

            cargar_si_vacio();
            validar_CBOX();


        }
        public void validar_CBOX()
        {

            if (cbox_filtro_producto.SelectedIndex == 2)
            {

                date_fecha.Visible = true;
                txt_buscar.Visible = false;
                txt_caja.Visible = true;
                lbl_caja.Visible = true;
                lbl_caja_pesos.Visible = true;
                lbl_en_pesos.Visible = true;
                lbl_S_en_pesos.Visible = true;
                txt_en_pesos.Visible = true;

            }
            else
            {
                txt_buscar.Visible = true;
                date_fecha.Visible = false;
                txt_caja.Visible = false;
                lbl_caja.Visible = false;
                lbl_caja_pesos.Visible = false;
                lbl_en_pesos.Visible = false;
                lbl_S_en_pesos.Visible = false;
                txt_en_pesos.Visible = false      ;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  try
            //  {
            btn_buscar_validar = true;
            cargar();
            // }
            // catch { }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            cargar();
        }
        private void btn_ver_Click(object sender, EventArgs e)
        {

        }

        private void bdd_ventas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VentaProductos vp = new VentaProductos((Venta)bdd_ventas.CurrentRow.DataBoundItem);
            vp.ShowDialog();
        }

        private void bdd_ventas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VentaProductos vp = new VentaProductos((Venta)bdd_ventas.CurrentRow.DataBoundItem);
            vp.ShowDialog();
        }

        private void bnt_imprimir_Click(object sender, EventArgs e)
        {
            Venta_Imprimir vi = new Venta_Imprimir();
            vi.ShowDialog();
        }
        public void PrintAString(int iniciar)
        {

            PrintDocument pd = new PrintDocument();

            printFont = new Font("Courier New", 9);



            pd.PrintPage += new PrintPageEventHandler(PrintPage);

            pd.Print();


        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {

            int y = 110;




            string date = "------------  Listado de ventas realizadas el dia : " + date_fecha.Value.Day.ToString() + "/" + date_fecha.Value.Month.ToString() + "/" + date_fecha.Value.Year.ToString() + " // Total : [ " + txt_pesos.Text + " ]--------";


            e.Graphics.DrawString(date, printFont, Brushes.Black, 10, 80, new StringFormat());

            for (int x = inicio; x < listaVacia.Count; x++)
            {
                if (y > 240)
                {
                    inicio = x;
                    e.HasMorePages = true;
                }
                e.Graphics.DrawString(((Venta)listaVacia[x]).Id_venta.ToString(), printFont, Brushes.Black, 110, y, new StringFormat());
                e.Graphics.DrawString(((Venta)listaVacia[x]).Provisorio.ToString(), printFont, Brushes.Black, 150, y, new StringFormat());
                e.Graphics.DrawString(((Venta)listaVacia[x]).Fecha.Day.ToString() + "/" + ((Venta)listaVacia[x]).Fecha.Month.ToString() + "/" + ((Venta)listaVacia[x]).Fecha.Year.ToString(), printFont, Brushes.Black, 300, y, new StringFormat());
                e.Graphics.DrawString(((Venta)listaVacia[x]).Total.ToString(), printFont, Brushes.Black, 400, y, new StringFormat());
                y = y + 15;


            }





        }

        private void txt_pesos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void date_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bdd_ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pesos_Click(object sender, EventArgs e)
        {

        }

        private void btn_ver_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (bdd_ventas.SelectedRows != null)
            {
                VentaProductos vp = new VentaProductos((Venta)bdd_ventas.CurrentRow.DataBoundItem);
                vp.ShowDialog();
            }
        }



    }
}
