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
    public partial class Compra_Imprimir : Form
    {
        Clases.Configuracion_factura factura = new Clases.Configuracion_factura();
        Font printFont;
        string printString;
        ArrayList listaVacia = new ArrayList();
        //    bool btn_buscar_validar = false;
        ArrayList listaprimera = new ArrayList();
        ArrayList listacarrito = new ArrayList();
        int inicio = 0;
        DateTime desde;
        DateTime hasta;
        public Compra_Imprimir()
        {
            InitializeComponent();
            factura = Datos.Conex.traer_datos_facturas();
        }

        private void bnt_imprimir_Click(object sender, EventArgs e)
        {

            desde = date_desde.Value.Date;
            hasta = date_hasta.Value.Date;


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
        public void cargar()
        {

            txt_pesos.Text = "0";
            ArrayList lista = new ArrayList();

            // entre fechas

            if (desde == hasta)
            {
                lista = Datos.DatosCompra.getCompras_por_fecha(desde);


            }
            else
            {
                lista = Datos.DatosCompra.getCompras_entre_fechas(desde, hasta);
            }

            for (int i = 0; i < lista.Count; i++)
            {

                txt_pesos.Text = (Convert.ToDecimal(txt_pesos.Text) + ((Compra)lista[i]).Importe).ToString();

            }

            if (lista.Count == 0)
            {
                MessageBox.Show("No existen registros con la fecha seleccionada", "Mensaje");
                listaVacia.Clear();

            }
            else
            {
                listaVacia.Clear();
                listaVacia = lista;

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



            string date = " Listado de Compras entre los dias : " + desde.ToShortDateString() + " y " + hasta.ToShortDateString() + " // Total : [ " + txt_pesos.Text + " ]--------";

            e.Graphics.DrawString(DateTime.Now + " // " + factura.Comercio_nombre, printFont, Brushes.Black, 200, 80, new StringFormat());
            e.Graphics.DrawString(date, printFont, Brushes.Black, 50, 120, new StringFormat());
            e.Graphics.DrawString("N Factura", printFont, Brushes.Black, 50, y, new StringFormat());
            e.Graphics.DrawString("Fecha Factura", printFont, Brushes.Black, 190, y, new StringFormat());
            e.Graphics.DrawString("Proveedor", printFont, Brushes.Black, 300, y, new StringFormat());
            e.Graphics.DrawString("Tipo", printFont, Brushes.Black, 550, y, new StringFormat());
            e.Graphics.DrawString("Estado", printFont, Brushes.Black, 620, y, new StringFormat());
            e.Graphics.DrawString("Importe", printFont, Brushes.Black, 680, y, new StringFormat());

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
                e.Graphics.DrawString(((Compra)listaVacia[x]).Numero_factura.ToString(), printFont, Brushes.Black, 50, y, new StringFormat());
                e.Graphics.DrawString(((Compra)listaVacia[x]).Fecha_factura.ToShortDateString(), printFont, Brushes.Black, 190, y, new StringFormat());
                e.Graphics.DrawString(((Compra)listaVacia[x]).Dato.ToString(), printFont, Brushes.Black, 300, y, new StringFormat());
                e.Graphics.DrawString(((Compra)listaVacia[x]).Tipo, printFont, Brushes.Black, 550, y, new StringFormat());
                e.Graphics.DrawString(((Compra)listaVacia[x]).Estado, printFont, Brushes.Black, 620, y, new StringFormat());
                e.Graphics.DrawString(((Compra)listaVacia[x]).Importe.ToString(), printFont, Brushes.Black, 680, y, new StringFormat());
                y = y + 15;


            }




        }
        private bool SetupThePrinting()
        {


            //   MyDataGridViewPrinter = new DataGridViewPrinter(MyDataGridView, MyPrintDocument, false, true, "INFORMES DE CIUDADES DEL PARAGUAY", new Font("Tahoma", 12, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

            return true;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
