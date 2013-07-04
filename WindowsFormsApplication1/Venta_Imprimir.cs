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
    public partial class Venta_Imprimir : Form
    {
        Clases.Configuracion_factura factura = new Clases.Configuracion_factura();
        string titulo;
        Font printFont;
        string printString;
        ArrayList listaVacia = new ArrayList();
        bool btn_buscar_validar = false;
        ArrayList listaprimera = new ArrayList();
        ArrayList listacarrito = new ArrayList();
        int inicio = 0;
        bool imprime_caja = false;
        public Venta_Imprimir()
        {
            InitializeComponent();
            factura = Datos.Conex.traer_datos_facturas();
        }
        public void cargar()
        {

            txt_pesos.Text = "0";
            ArrayList lista = new ArrayList();

            // modelo

            if (date_desde.Value.Date == date_hasta.Value.Date)
            {
                lista = Datos.DatosVenta.getVenta_cliente_porfecha(date_desde.Value.Date);

            }

            else
            {
                lista = Datos.DatosVenta.getVenta_cliente_entre_fechas(date_desde.Value.Date, date_hasta.Value.Date);
            }

            for (int i = 0; i < lista.Count; i++)
            {

                txt_pesos.Text = (Convert.ToDecimal(txt_pesos.Text) + ((Venta)lista[i]).Total).ToString();

            }


            if (lista.Count == 0)
            {
                MessageBox.Show("No existen registros en la fecha seleccionada", "Mensaje");
                listaVacia.Clear();

            }
            else
            {
                listaVacia.Clear();
                listaVacia = lista;

            }

        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bnt_imprimir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "A continuacion se imprimirá el listado en hoja A4, ¿Desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;
                cargar();
                if (listaVacia.Count > 0)
                {
                    try
                    {
                        PrintAString(0);
                    }
                    catch
                    {
                        MessageBox.Show(this, "Error al imprimir", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                this.Cursor = Cursors.Default;
            }


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

            int y = 150;



            if (imprime_caja == false)
            {

                titulo = " Listado de Ventas entre los dias : " + date_desde.Value.Date.ToShortDateString() + " y " + date_hasta.Value.Date.ToShortDateString() + " // Total : [ " + txt_pesos.Text + " ]-";
            }
            else
            {
                Caja c = new Caja();
                c = Datos_Caja.get_caja_por_fecha(date_desde.Value.Date);
                titulo = " Listado de Ventas del dia : " + date_desde.Value.Date.ToShortDateString() + "// Caja: " + c.Monto.ToString() +" // Total : [ " + txt_pesos.Text + " ]-";
           
            }
            e.Graphics.DrawString(DateTime.Now + " // " + factura.Comercio_nombre, printFont, Brushes.Black, 200, 80, new StringFormat());
            e.Graphics.DrawString(titulo, printFont, Brushes.Black, 30, 110, new StringFormat());
            e.Graphics.DrawString("N Venta", printFont, Brushes.Black, 50, y, new StringFormat());

            e.Graphics.DrawString("Cliente", printFont, Brushes.Black, 190, y, new StringFormat());
            e.Graphics.DrawString("Fecha", printFont, Brushes.Black, 360, y, new StringFormat());
            e.Graphics.DrawString("Total", printFont, Brushes.Black, 450, y, new StringFormat());
            e.Graphics.DrawString("Comentario", printFont, Brushes.Black, 530, y, new StringFormat());
            y = y + 15;
            for (int x = inicio; x < listaVacia.Count; x++)
            {
                if (y > 1000)
                {
                    inicio = x;
                    e.HasMorePages = true;
                    break;
                }
                else
                {
                    e.HasMorePages = false;
                }
                e.Graphics.DrawString(((Venta)listaVacia[x]).Venta_numero.ToString(), printFont, Brushes.Black, 50, y, new StringFormat());
 
                e.Graphics.DrawString(((Venta)listaVacia[x]).Provisorio.ToString(), printFont, Brushes.Black, 190, y, new StringFormat());
                e.Graphics.DrawString(((Venta)listaVacia[x]).Fecha.Day.ToString() + "/" + ((Venta)listaVacia[x]).Fecha.Month.ToString() + "/" + ((Venta)listaVacia[x]).Fecha.Year.ToString(), printFont, Brushes.Black, 360, y, new StringFormat());
                e.Graphics.DrawString(((Venta)listaVacia[x]).Total.ToString(), printFont, Brushes.Black, 450, y, new StringFormat());
                e.Graphics.DrawString(((Venta)listaVacia[x]).Observaciones, printFont, Brushes.Black, 530, y, new StringFormat());
                y = y + 15;


            }




        }
        private bool SetupThePrinting()
        {


            //   MyDataGridViewPrinter = new DataGridViewPrinter(MyDataGridView, MyPrintDocument, false, true, "INFORMES DE CIUDADES DEL PARAGUAY", new Font("Tahoma", 12, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

            return true;
        }

        private void date_desde_ValueChanged(object sender, EventArgs e)
        {
            if (date_desde.Value.Date == date_hasta.Value.Date)
            {

                chk_imprime_caja.Enabled = true;
            }
            else
            {

                chk_imprime_caja.Enabled = false;
            }
        }

        private void date_hasta_ValueChanged(object sender, EventArgs e)
        {
            if (date_desde.Value.Date == date_hasta.Value.Date)
            {

                chk_imprime_caja.Enabled = true;
            }
            else
            {

                chk_imprime_caja.Enabled = false;
            }
        }

        private void chk_imprime_caja_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_imprime_caja.Checked == true)
            {

                imprime_caja = true;
            }
            else {
                imprime_caja = false;
            }
        }

        private void Venta_Imprimir_Load(object sender, EventArgs e)
        {

        }
    }
}
