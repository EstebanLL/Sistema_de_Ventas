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
    public partial class Venta_No_Impresa : Form
    {

        ArrayList lista = new ArrayList();
        ArrayList lista2 = new ArrayList();
        Clases.Configuracion_factura factura = new Clases.Configuracion_factura();
        decimal total_imprimir = 0;
        string detalle;
        decimal importe;
        Font printFont;
        string printString;
        decimal iva_global = 22;
        int conteo;
        bool validar;
        // ArrayList listaVacia = new ArrayList();
        bool btn_buscar_validar = false;
        // ArrayList listaprimera = new ArrayList();
        public ArrayList listacarrito = new ArrayList();
        public ArrayList listaimprimir = new ArrayList();
        string nombre_del_cliente;
        public Venta_No_Impresa()
        {
            InitializeComponent();

            btn_imprimir.Enabled = false;
            factura = Datos.Conex.traer_datos_facturas();
        }
        public void cargar()
        {

            txt_pesos.Text = "0";




            lista2.Clear();
            // modelo



            lista2 = Datos.DatosVenta.getVenta_cliente_porfecha_impreso(date_fecha.Value.Date);


            for (int i = 0; i < lista2.Count; i++)
            {

                txt_pesos.Text = (Convert.ToDecimal(txt_pesos.Text) + ((Venta)lista2[i]).Total).ToString();
                txt_en_pesos.Text = (Convert.ToDecimal(txt_en_pesos.Text) + ((Venta)lista2[i]).En_pesos).ToString();

            }

            if (lista2.Count > 0)
            {
                listacarrito = Datos.DatosVenta_Producto.getVenta_Producto_no_impreso(date_fecha.Value.Date);
                lista = lista2;
                bdd_ventas.DataSource = lista;
                for (int i = 0; i < listacarrito.Count; i++)
                {
                    bool existe = false;


                    for (int x = 0; x < listaimprimir.Count; x++)
                    {
                        if (((Venta_Producto)listacarrito[i]).Dato2 == ((Venta_Producto)listaimprimir[x]).Dato2)
                        {

                            existe = true;
                            ((Venta_Producto)listaimprimir[x]).Cantidad = ((Venta_Producto)listaimprimir[x]).Cantidad + ((Venta_Producto)listacarrito[i]).Cantidad;
                        }
                    }


                    if (existe == false)
                    {

                        Venta_Producto p = new Venta_Producto();
                        p = (Venta_Producto)listacarrito[i];
                        //    p.Stock = Convert.ToInt32(txt_cantidad.Text);
                        //     bdd_carrito.Rows.Add(p.Codigo, p.Detalle, p.Stock, p.Total);
                        //bdd_print.Rows.Add(p.Stock, p.Detalle, p.Total);
                        listaimprimir.Add(p);
                        // txt_cantidad.Text = "1";

                    }
                    existe = false;

                }

                btn_imprimir.Enabled = true;
                btn_ver.Enabled = true;
            }
            else
            {
                btn_ver.Enabled = false;
                lista.Clear();
                Venta vt = new Venta(0, 0, DateTime.Today, 0, 0, "No hay registros", "No hay registro", "No hay registro", "No hay registro", 1, 1, 1, 1, 0, 0, 0, 0, 0, Principal.iva, " ",0);
                vt.Provisorio = "No hay registros";
                lista.Add(vt);
                bdd_ventas.Refresh();
                bdd_ventas.DataSource = lista;
                btn_imprimir.Enabled = false;

                MessageBox.Show(this, "No hay registros con la fecha seleccionada", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_imprimir.Enabled = false;
            }





        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Principal.cerrar_venta_no_impresa = true;
            this.Close();
        }
        int cant_facturas;
        Int64 factura_numero_conteo;
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "A continuacion se imprimirá los productos no impresos en facturas, ¿Desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;
                Cliente cli = new Cliente();
                cli = DatosCliente.getCliente(42);
                nombre_del_cliente = cli.Nombre;
                int conteo;
                for (conteo = listaimprimir.Count; conteo > 0; )
                {
                    conteo = conteo - factura.Items_max;

                    cant_facturas = cant_facturas + 1;
                }


                factura_numero_conteo = factura.Factura_numero_dato;

                for (int y = 0; y < lista.Count; y++)
                {

                    DatosVenta.setBajaVenta(((Venta)lista[y]).Id_venta);
                    DatosVenta_Producto.setBajaVenta_producto(((Venta)lista[y]).Id_venta);
                }


                Venta v = new Venta(0, 42, DateTime.Now, Convert.ToDecimal(txt_pesos.Text), 1, factura.Venta_Prefijo_dato + factura.Venta_numero_dato.ToString(), " ", "Contado", "Pago", 1, 1, 1, 1, 0, 0, 0, 0, 0, Principal.iva, " ",0);
                DatosVenta.NuevaVenta(v);
                Int64 id_venta = DatosVenta.obtener_id_venta();
                for (int y = 0; y < cant_facturas; y++)
                {
                    Factura fa = new Factura(factura.Factura_Prefijo_dato + (factura.Factura_numero_dato + y).ToString(), 0, id_venta);
                    Datos_Factura.NuevaFacura(fa);

                }
                Clases.Configuracion_factura factura_guardar = new Clases.Configuracion_factura();
                factura_guardar = factura;
                factura_guardar.Factura_numero_dato = factura.Factura_numero_dato + cant_facturas;
                factura_guardar.Venta_numero_dato = factura.Venta_numero_dato + 1;
                Conex.Modificar_Factura(factura_guardar);


                for (int x = 0; x < listaimprimir.Count; x++)
                {

                    Venta_Producto vp = new Venta_Producto(0, id_venta, ((Venta_Producto)listaimprimir[x]).Id_producto, ((Venta_Producto)listaimprimir[x]).Precio, ((Venta_Producto)listaimprimir[x]).Cantidad);
                    DatosVenta_Producto.NuevaVentaProducto(vp);
                }

                try
                {
                    PrintAString(0);
                }
                catch
                {
                    MessageBox.Show(this, "Error al imprimir", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Principal.cerrar_venta_no_impresa = false;
                this.Cursor = Cursors.Default;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
        }
        public void PrintAString(int iniciar)
        {

            PrintDocument pd = new PrintDocument();

            printFont = new Font(factura.Fuente, factura.Tamano);



            pd.PrintPage += new PrintPageEventHandler(PrintPage);

            pd.Print();

            //printPreviewDialog1.Document = pd;
            //    printPreviewDialog1.Show();
        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {


            int y = factura.Yy;

            for (int x = conteo; x < listaimprimir.Count; x++)
            {


                decimal importe = ((Venta_Producto)listaimprimir[x]).Cantidad * ((Venta_Producto)listaimprimir[x]).Precio;

                //bdd_print2.Rows.Add(((Venta_Producto)listaimprimir[x]).Cantidad, ((Venta_Producto)listaimprimir[x]).Dato1, ((Venta_Producto)listaimprimir[x]).Precio, importe);
                if (x > conteo + (factura.Items_max - 1))
                {
                    conteo = conteo + factura.Items_max;

                    x = listaimprimir.Count;
                    importe = 0;

                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                    int count = ((Venta_Producto)listaimprimir[x]).Dato1.Count();
                    if (count > 27)
                    {
                        detalle = ((Venta_Producto)listaimprimir[x]).Dato1.Substring(0, 26);
                    }
                    else
                    {

                        detalle = ((Venta_Producto)listaimprimir[x]).Dato1;

                    }
                    e.Graphics.DrawString(((Venta_Producto)listaimprimir[x]).Cantidad.ToString(), printFont, Brushes.Black, factura.Cantidad_X, y, new StringFormat());
                    e.Graphics.DrawString(detalle.ToString(), printFont, Brushes.Black, factura.Detalle_X, y, new StringFormat());

                    if (((Venta_Producto)listaimprimir[x]).Precio < 10 && ((Venta_Producto)listaimprimir[x]).Precio > 0)
                    {
                        e.Graphics.DrawString(((Venta_Producto)listaimprimir[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X, y, new StringFormat());
                    }
                    else if (((Venta_Producto)listaimprimir[x]).Precio < 100 && ((Venta_Producto)listaimprimir[x]).Precio >= 10)
                    {
                        e.Graphics.DrawString(((Venta_Producto)listaimprimir[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx, y, new StringFormat());
                    }
                    else if (((Venta_Producto)listaimprimir[x]).Precio < 1000 && ((Venta_Producto)listaimprimir[x]).Precio >= 100)
                    {
                        e.Graphics.DrawString(((Venta_Producto)listaimprimir[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 2, y, new StringFormat());
                    }
                    else if (((Venta_Producto)listaimprimir[x]).Precio < 10000 && ((Venta_Producto)listaimprimir[x]).Precio >= 1000)
                    {
                        e.Graphics.DrawString(((Venta_Producto)listaimprimir[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 3, y, new StringFormat());
                    }
                    else
                    {
                        e.Graphics.DrawString(((Venta_Producto)listaimprimir[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 4, y, new StringFormat());
                    }
                    //importe
                    if (importe < 10 && importe >= 0)
                    {
                        e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, factura.Importe_X, y, new StringFormat());
                    }
                    else if (importe < 100 && importe >= 10)
                    {
                        e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, factura.Importe_X - factura.Xx, y, new StringFormat());
                    }
                    else if (importe < 1000 && importe >= 100)
                    {
                        e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, factura.Importe_X - factura.Xx * 2, y, new StringFormat());
                    }
                    else if (importe < 10000 && importe >= 1000)
                    {
                        e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, factura.Importe_X - factura.Xx * 3, y, new StringFormat());
                    }
                    else
                    {
                        e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, factura.Importe_X - factura.Xx * 4, y, new StringFormat());
                    }

                    if (factura.Duplica_en_hoja == true)
                    {

                        e.Graphics.DrawString(((Venta_Producto)listaimprimir[x]).Cantidad.ToString(), printFont, Brushes.Black, factura.Cantidad_X, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        e.Graphics.DrawString(detalle.ToString(), printFont, Brushes.Black, factura.Detalle_X, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        if (((Venta_Producto)listaimprimir[x]).Precio < 10 && ((Venta_Producto)listaimprimir[x]).Precio > 0)
                        {
                            e.Graphics.DrawString(((Venta_Producto)listaimprimir[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        else if (((Venta_Producto)listaimprimir[x]).Precio < 100 && ((Venta_Producto)listaimprimir[x]).Precio >= 10)
                        {
                            e.Graphics.DrawString(((Venta_Producto)listaimprimir[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        else if (((Venta_Producto)listaimprimir[x]).Precio < 1000 && ((Venta_Producto)listaimprimir[x]).Precio >= 100)
                        {
                            e.Graphics.DrawString(((Venta_Producto)listaimprimir[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 2, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        else if (((Venta_Producto)listaimprimir[x]).Precio < 10000 && ((Venta_Producto)listaimprimir[x]).Precio >= 1000)
                        {
                            e.Graphics.DrawString(((Venta_Producto)listaimprimir[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 3, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        else
                        {
                            e.Graphics.DrawString(((Venta_Producto)listaimprimir[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 4, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        //importe
                        if (importe < 10 && importe >= 0)
                        {
                            e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, factura.Importe_X, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        else if (importe < 100 && importe >= 10)
                        {
                            e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, factura.Importe_X - factura.Xx, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        else if (importe < 1000 && importe >= 100)
                        {
                            e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, factura.Importe_X - factura.Xx * 2, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        else if (importe < 10000 && importe >= 1000)
                        {
                            e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, factura.Importe_X - factura.Xx * 3, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        else
                        {
                            e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, factura.Importe_X - factura.Xx * 4, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }

                    }
                    //   e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, 340, y, new StringFormat());
                    y = y + 15;
                }

                total_imprimir = total_imprimir + importe;


            }
            string date = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            decimal iva_local = Math.Round(Convert.ToDecimal((total_imprimir / (100 + iva_global)) * iva_global), 2);
            decimal subtotal = Math.Round(Convert.ToDecimal(total_imprimir - iva_local), 2);
            e.Graphics.DrawString(date, printFont, Brushes.Black, factura.Fecha_X, factura.Fecha_Y, new StringFormat());

            e.Graphics.DrawString(factura.Venta_Prefijo_dato + (factura.Venta_numero_dato - 1).ToString(), printFont, Brushes.Black, factura.Venta_numero_x, factura.Venta_numero_y, new StringFormat());

            if (factura.Observaciones_imprime == true)
            {
                //  e.Graphics.DrawString(txt_observaciones.Text, printFont, Brushes.Black, factura.Observaciones_x, factura.Observaciones_y, new StringFormat());
            }
            if (factura.Tipo_imprime == true)
            {
                e.Graphics.DrawString("Contado", printFont, Brushes.Black, factura.Tipo_x, factura.Tipo_y, new StringFormat());
            }
            e.Graphics.DrawString("X", printFont, Brushes.Black, factura.C_Final_X, factura.C_Final_Y, new StringFormat());


            e.Graphics.DrawString(nombre_del_cliente, printFont, Brushes.Black, factura.Datos_x, factura.Datos_y, new StringFormat());

            e.Graphics.DrawString(total_imprimir.ToString(), printFont, Brushes.Black, factura.Total_x, factura.Total_y, new StringFormat());


            if (factura.Duplica_en_hoja == true)
            {
                e.Graphics.DrawString(date, printFont, Brushes.Black, factura.Fecha_X, factura.Fecha_Y + factura.Duplica_en_hoja_distancia, new StringFormat());

                e.Graphics.DrawString(factura.Venta_Prefijo_dato + (factura.Venta_numero_dato - 1).ToString(), printFont, Brushes.Black, factura.Venta_numero_x, factura.Venta_numero_y + factura.Duplica_en_hoja_distancia, new StringFormat());

                if (factura.Observaciones_imprime == true)
                {
                    //  e.Graphics.DrawString(txt_observaciones.Text, printFont, Brushes.Black, factura.Observaciones_x, factura.Observaciones_y, new StringFormat());
                }
                if (factura.Tipo_imprime == true)
                {
                    e.Graphics.DrawString("Contado", printFont, Brushes.Black, factura.Tipo_x, factura.Tipo_y + factura.Duplica_en_hoja_distancia, new StringFormat());
                }
                e.Graphics.DrawString("X", printFont, Brushes.Black, factura.C_Final_X, factura.C_Final_Y + factura.Duplica_en_hoja_distancia, new StringFormat());


                e.Graphics.DrawString(nombre_del_cliente, printFont, Brushes.Black, factura.Datos_x, factura.Datos_y + factura.Duplica_en_hoja_distancia, new StringFormat());

                e.Graphics.DrawString(total_imprimir.ToString(), printFont, Brushes.Black, factura.Total_x, factura.Total_y + factura.Duplica_en_hoja_distancia, new StringFormat());
            }

            if (factura.Factura_numero_imprime == true)
            {
                e.Graphics.DrawString(factura.Factura_Prefijo_dato + factura_numero_conteo.ToString(), printFont, Brushes.Black, factura.Factura_numero_x, factura.Factura_numero_y, new StringFormat());
                if (factura.Duplica_en_hoja == true)
                {
                    e.Graphics.DrawString(factura.Factura_Prefijo_dato + factura_numero_conteo.ToString(), printFont, Brushes.Black, factura.Factura_numero_x, factura.Factura_numero_y + factura.Duplica_en_hoja_distancia, new StringFormat());

                }
                factura_numero_conteo = factura_numero_conteo + 1;
            }
            total_imprimir = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void bdd_ventas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lista.Count > 0)
            {
                if (((Venta)bdd_ventas.CurrentRow.DataBoundItem).Id_venta != 0)
                {
                    VentaProductos vp = new VentaProductos((Venta)bdd_ventas.CurrentRow.DataBoundItem);
                    vp.ShowDialog();
                }
            }
            Principal.cerrar_venta_no_impresa = false;
            this.Close();
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {

            if (bdd_ventas.SelectedRows != null)
            {
                VentaProductos vp = new VentaProductos((Venta)bdd_ventas.CurrentRow.DataBoundItem);
                vp.ShowDialog();
            }
            Principal.cerrar_venta_no_impresa = false;
            this.Close();
        }
    }
}
