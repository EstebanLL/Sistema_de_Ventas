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
    public partial class VentaProductos : Form
    {
        int conteo;
      
        bool validar;
        string mensaje;
        Clases.Configuracion_factura factura = new Clases.Configuracion_factura();
        decimal iva_global = Principal.iva;

        decimal total_imprimir = 0;

        string detalle;
        decimal importe;
        Font printFont;
        string printString;
        Venta v = new Venta();
        ArrayList listacarrito = new ArrayList();
        bool es_nuevo = true;

        public VentaProductos()
        {
            InitializeComponent();
        }
        public VentaProductos(object vp)
        {
            InitializeComponent();
            this.v = (Venta)vp;
            txt_cliente.Text = v.Clientes.Nombre;
            txt_doc.Text = v.Clientes.Documento;
            txt_pais.Text = v.Clientes.Pais.Nombre;
            txt_venta_num.Text = v.Venta_numero.ToString();
            cbox_factura_num.Text = v.Factura_numero.ToString();
            txt_direccion.Text = v.Clientes.Direccion;
            txt_RUT.Text = v.Clientes.RUT;
            txt_ciudad.Text = v.Clientes.Ciudad;
            fecha.Value = v.Fecha;
            listacarrito = Datos.DatosVenta_Producto.getVenta_Producto(v.Id_venta);
            CargarFacturas();
            bdd_carrito.DataSource = listacarrito;
            for (int i = 0; i < listacarrito.Count; i++)
            {
               
                ((Venta_Producto)listacarrito[i]).Dato4 = ((Venta_Producto)listacarrito[i]).Cantidad * ((Venta_Producto)listacarrito[i]).Precio;
                txt_subtotal_sin_desc.Text = (Convert.ToDecimal(txt_subtotal_sin_desc.Text) + (((Venta_Producto)listacarrito[i]).Precio * ((Venta_Producto)listacarrito[i]).Cantidad)).ToString();


            }
            txt_observaciones.Text = v.Observaciones;
            txt_con_iva.Text = v.Total.ToString();
            txt_descuento_porcent.Text = Math.Round(((100 / (v.Total+v.Descuento)) * v.Descuento),3).ToString();
            txt_tipo.Text = v.Tipo;
            txt_descuento_pesos.Text = Math.Round(v.Descuento,2).ToString();
            decimal subtotal = Math.Round((v.Total / ((Principal.iva / 100) + 1)), 2);
            txt_subtotal_pesos.Text = subtotal.ToString();
            txt_iva_pesos.Text = (v.Total - subtotal).ToString();

            factura = Datos.Conex.traer_datos_facturas();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarFacturas()
        {
            ArrayList facturas = new ArrayList();
            facturas = Datos_Factura.getFacturas(v.Id_venta);
            cbox_factura_num.DataSource = facturas;
            cbox_factura_num.DisplayMember = "factura_numero";
         
            cbox_factura_num.Refresh();
     

        }

        int cantidad_facturas_existentes;
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            cantidad_facturas_existentes = 0;
            conteo = 0;

            bool imprime = true;
            if (v.Impreso == 0)
            {
                DialogResult dr = MessageBox.Show(this, "A continuacion se imprimirá una nueva factura, ¿Desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    
                    factura_numero_conteo = factura.Factura_numero_dato;
                    int conteos;
                    for (conteos = listacarrito.Count; conteos > 0; )
                    {
                        conteos = conteos - factura.Items_max;

                        cant_facturas = cant_facturas + 1;
                    }

                    for (int y = 0; y < cant_facturas; y++)
                    {
                        Factura fa = new Factura(factura.Factura_Prefijo_dato + (factura.Factura_numero_dato + y).ToString(), 0, v.Id_venta);
                        Datos_Factura.NuevaFacura(fa);

                    }
                    v.Factura_numero =  " " ;
                    v.Venta_numero = factura.Venta_Prefijo_dato + factura.Venta_numero_dato;
                    DatosVenta.ModificarVenta(this.v);
                    Clases.Configuracion_factura factura_guardar = new Clases.Configuracion_factura();
                    factura_guardar = factura;
                    factura_guardar.Factura_numero_dato = factura.Factura_numero_dato + cant_facturas;
                    factura_guardar.Venta_numero_dato = factura.Venta_numero_dato + 1;
                    Conex.Modificar_Factura(factura_guardar);
                    cbox_factura_num.Text = v.Factura_numero;
                    txt_venta_num.Text = v.Venta_numero;
                    v.Impreso = 1;

                    imprime = true;
                    es_nuevo = true;
                } if (dr == DialogResult.No)
                {
                    imprime = false;
                }
                btn_imprimir.Enabled = false;
            }
            else {
                cbox_factura_num.SelectedIndex = 0;
                if (cbox_factura_num.Items.Count == 2)
                {

                    mensaje = cbox_factura_num.Text + " y su siguiente ";
                    cbox_factura_num.SelectedIndex = 1;
                    mensaje = mensaje + cbox_factura_num.Text ;
                }
                else if (cbox_factura_num.Items.Count > 2)
                {

                    mensaje = cbox_factura_num.Text + " y su siguientes " + (cbox_factura_num.Items.Count - 1).ToString() + " numeraciones";
                }
                else
                {
                    mensaje = cbox_factura_num.Text + " ";
                }
             DialogResult dr = MessageBox.Show(this,"Se imprimirá en la factura Nº: "+ mensaje +", ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (dr == DialogResult.No)
             {
                  imprime = false;
             }
         
             es_nuevo = false;
             int conteos;
             for (conteos = listacarrito.Count; conteos > 0; )
             {
                 conteos = conteos - factura.Items_max;

                 cant_facturas = cant_facturas + 1;
             }
            }
            if (imprime == true)
            {
                PrintAString(0);
            }
      
            
        }

        public void PrintAString(int iniciar)
        {

            PrintDocument pd = new PrintDocument();

            printFont = new Font(factura.Fuente, factura.Tamano);



            pd.PrintPage += new PrintPageEventHandler(PrintPage);

            pd.Print();
            //  printPreviewDialog1.Document = pd;
            //  printPreviewDialog1.ShowDialog();
    
        }
        int cant_facturas;
        Int64 factura_numero_conteo;
        private void PrintPage(object sender, PrintPageEventArgs e)
        {

            int y = factura.Yy;

            for (int x = conteo; x < listacarrito.Count; x++)
            {


                importe = ((Venta_Producto)listacarrito[x]).Cantidad * ((Venta_Producto)listacarrito[x]).Precio;

                // bdd_print2.Rows.Add(((Producto)listacarrito[x]).Stock, ((Producto)listacarrito[x]).Detalle, ((Producto)listacarrito[x]).Total, importe);
                if (x > conteo + (factura.Items_max - 1))
                {
                    conteo = conteo + factura.Items_max;

                    x = listacarrito.Count;
                    importe = 0;
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                    int count = ((Venta_Producto)listacarrito[x]).Dato1.Count();
                    if (count > 27)
                    {
                        detalle = ((Venta_Producto)listacarrito[x]).Dato1.Substring(0, 26);
                    }
                    else
                    {

                        detalle = ((Venta_Producto)listacarrito[x]).Dato1;

                    }
                    e.Graphics.DrawString(((Venta_Producto)listacarrito[x]).Cantidad.ToString(), printFont, Brushes.Black, factura.Cantidad_X, y, new StringFormat());
                    e.Graphics.DrawString(detalle.ToString(), printFont, Brushes.Black, factura.Detalle_X, y, new StringFormat());
                    if (((Venta_Producto)listacarrito[x]).Precio < 10 && ((Venta_Producto)listacarrito[x]).Precio > 0)
                    {
                        e.Graphics.DrawString(((Venta_Producto)listacarrito[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X, y, new StringFormat());
                    }
                    else if (((Venta_Producto)listacarrito[x]).Precio < 100 && ((Venta_Producto)listacarrito[x]).Precio >= 10)
                    {
                        e.Graphics.DrawString(((Venta_Producto)listacarrito[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx, y, new StringFormat());
                    }
                    else if (((Venta_Producto)listacarrito[x]).Precio < 1000 && ((Venta_Producto)listacarrito[x]).Precio >= 100)
                    {
                        e.Graphics.DrawString(((Venta_Producto)listacarrito[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 2, y, new StringFormat());
                    }
                    else if (((Venta_Producto)listacarrito[x]).Precio < 10000 && ((Venta_Producto)listacarrito[x]).Precio >= 1000)
                    {
                        e.Graphics.DrawString(((Venta_Producto)listacarrito[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 3, y, new StringFormat());
                    }
                    else
                    {
                        e.Graphics.DrawString(((Venta_Producto)listacarrito[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 4, y, new StringFormat());
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

                    if (factura.Duplica_en_hoja == true) {
                        e.Graphics.DrawString(((Venta_Producto)listacarrito[x]).Cantidad.ToString(), printFont, Brushes.Black, factura.Cantidad_X, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        e.Graphics.DrawString(detalle.ToString(), printFont, Brushes.Black, factura.Detalle_X, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        if (((Venta_Producto)listacarrito[x]).Precio < 10 && ((Venta_Producto)listacarrito[x]).Precio > 0)
                        {
                            e.Graphics.DrawString(((Venta_Producto)listacarrito[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        else if (((Venta_Producto)listacarrito[x]).Precio < 100 && ((Venta_Producto)listacarrito[x]).Precio >= 10)
                        {
                            e.Graphics.DrawString(((Venta_Producto)listacarrito[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        else if (((Venta_Producto)listacarrito[x]).Precio < 1000 && ((Venta_Producto)listacarrito[x]).Precio >= 100)
                        {
                            e.Graphics.DrawString(((Venta_Producto)listacarrito[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 2, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        else if (((Venta_Producto)listacarrito[x]).Precio < 10000 && ((Venta_Producto)listacarrito[x]).Precio >= 1000)
                        {
                            e.Graphics.DrawString(((Venta_Producto)listacarrito[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 3, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        else
                        {
                            e.Graphics.DrawString(((Venta_Producto)listacarrito[x]).Precio.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 4, y + factura.Duplica_en_hoja_distancia, new StringFormat());
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
            decimal calcular_imprimir_con_descuento = (total_imprimir / 100) * Convert.ToDecimal(txt_descuento_porcent.Text);
            decimal calcular_imprimir_con_descuento_calculado = total_imprimir - calcular_imprimir_con_descuento;
          
            string date = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
 
            if (factura.Duplica_en_hoja == true)
            {
                e.Graphics.DrawString(date, printFont, Brushes.Black, factura.Fecha_X, factura.Fecha_Y +factura.Duplica_en_hoja_distancia, new StringFormat());
                e.Graphics.DrawString(txt_RUT.Text, printFont, Brushes.Black, factura.Rut_X, factura.Rut_y+factura.Duplica_en_hoja_distancia, new StringFormat());
                e.Graphics.DrawString(txt_venta_num.Text, printFont, Brushes.Black, factura.Venta_numero_x, factura.Venta_numero_y +factura.Duplica_en_hoja_distancia, new StringFormat());
            }
            e.Graphics.DrawString(date, printFont, Brushes.Black, factura.Fecha_X, factura.Fecha_Y, new StringFormat());
            e.Graphics.DrawString(txt_RUT.Text, printFont, Brushes.Black, factura.Rut_X, factura.Rut_y, new StringFormat());
                e.Graphics.DrawString(txt_venta_num.Text, printFont, Brushes.Black, factura.Venta_numero_x, factura.Venta_numero_y, new StringFormat());
            if (es_nuevo == true)
            {

                if (factura.Factura_numero_imprime == true)
                {
                    if (factura.Duplica_en_hoja == true)
                    {
                        e.Graphics.DrawString(factura.Factura_Prefijo_dato + factura_numero_conteo.ToString(), printFont, Brushes.Black, factura.Factura_numero_x, factura.Factura_numero_y +factura.Duplica_en_hoja_distancia, new StringFormat());
                    }
                    e.Graphics.DrawString(factura.Factura_Prefijo_dato + factura_numero_conteo.ToString(), printFont, Brushes.Black, factura.Factura_numero_x, factura.Factura_numero_y, new StringFormat());
                    factura_numero_conteo = factura_numero_conteo + 1;
                }
            }
            else
            {
               
                if (factura.Factura_numero_imprime == true)
                {
                    cbox_factura_num.SelectedIndex = cantidad_facturas_existentes;

                    e.Graphics.DrawString(cbox_factura_num.Text, printFont, Brushes.Black, factura.Factura_numero_x, factura.Factura_numero_y, new StringFormat());
                    if (factura.Duplica_en_hoja == true)
                    {
                        e.Graphics.DrawString(cbox_factura_num.Text, printFont, Brushes.Black, factura.Factura_numero_x, factura.Factura_numero_y+factura.Duplica_en_hoja_distancia, new StringFormat());
                    }
                    cantidad_facturas_existentes = cantidad_facturas_existentes + 1;
                }
            }
            if (factura.Observaciones_imprime == true)
            {
                e.Graphics.DrawString(txt_observaciones.Text, printFont, Brushes.Black, factura.Observaciones_x, factura.Observaciones_y, new StringFormat());
            }
            if (factura.Tipo_imprime == true)
            {
                e.Graphics.DrawString("Contado", printFont, Brushes.Black, factura.Tipo_x, factura.Tipo_y, new StringFormat());
            }
            if (txt_RUT.Text == " " || txt_RUT.Text == "")
            {
                e.Graphics.DrawString("X", printFont, Brushes.Black, factura.C_Final_X, factura.C_Final_Y, new StringFormat());
            }
            else
            {

                e.Graphics.DrawString(txt_RUT.Text, printFont, Brushes.Black, factura.Rut_X, factura.Rut_y, new StringFormat());

            }
            e.Graphics.DrawString(txt_subtotal_pesos.Text, printFont, Brushes.Black, factura.Subtotal_X, factura.SubTotal_y, new StringFormat());
            e.Graphics.DrawString(txt_iva_pesos.Text, printFont, Brushes.Black, factura.Iva_X, factura.Iva_Y, new StringFormat());
            // si cliente tiene nombre
            if (txt_cliente.Text == " " || txt_cliente.Text == "")
            {
                e.Graphics.DrawString(" ", printFont, Brushes.Black, factura.Datos_x, factura.Datos_y, new StringFormat());
                e.Graphics.DrawString(" ", printFont, Brushes.Black, factura.Datos_x, factura.Datos_y + factura.Datos_YY, new StringFormat());

            }
            // si cliente no tiene nombre
            else
            {
                e.Graphics.DrawString(txt_cliente.Text, printFont, Brushes.Black, factura.Datos_x, factura.Datos_y, new StringFormat());

                e.Graphics.DrawString(txt_doc.Text, printFont, Brushes.Black, factura.Datos_x, factura.Datos_y + factura.Datos_YY, new StringFormat());




            }
            e.Graphics.DrawString(Math.Round(calcular_imprimir_con_descuento_calculado, 2).ToString(), printFont, Brushes.Black, factura.Total_x, factura.Total_y, new StringFormat());
            if (factura.Duplica_en_hoja == true) {

                if (factura.Observaciones_imprime == true)
                {
                    e.Graphics.DrawString(txt_observaciones.Text, printFont, Brushes.Black, factura.Observaciones_x, factura.Observaciones_y + factura.Duplica_en_hoja_distancia, new StringFormat());
                }
                if (factura.Tipo_imprime == true)
                {
                    e.Graphics.DrawString("Contado", printFont, Brushes.Black, factura.Tipo_x, factura.Tipo_y + factura.Duplica_en_hoja_distancia, new StringFormat());
                }
                if (txt_RUT.Text == " " || txt_RUT.Text == "")
                {
                    e.Graphics.DrawString("X", printFont, Brushes.Black, factura.C_Final_X, factura.C_Final_Y + factura.Duplica_en_hoja_distancia, new StringFormat());
                }
                else
                {
                    e.Graphics.DrawString(txt_RUT.Text, printFont, Brushes.Black, factura.Rut_X, factura.Rut_y, new StringFormat());

                   
                }
                e.Graphics.DrawString(txt_subtotal_pesos.Text, printFont, Brushes.Black, factura.Subtotal_X, factura.SubTotal_y + factura.Duplica_en_hoja_distancia, new StringFormat());
                e.Graphics.DrawString(txt_iva_pesos.Text, printFont, Brushes.Black, factura.Iva_X, factura.Iva_Y + factura.Duplica_en_hoja_distancia, new StringFormat());

                // si cliente tiene nombre
                if (txt_cliente.Text == " " || txt_cliente.Text == "")
                {
                    e.Graphics.DrawString(" ", printFont, Brushes.Black, factura.Datos_x, factura.Datos_y + factura.Duplica_en_hoja_distancia, new StringFormat());
                    e.Graphics.DrawString(" ", printFont, Brushes.Black, factura.Datos_x, factura.Datos_y + factura.Datos_YY + factura.Duplica_en_hoja_distancia, new StringFormat());

                }
                // si cliente no tiene nombre
                else
                {
                    e.Graphics.DrawString(txt_cliente.Text, printFont, Brushes.Black, factura.Datos_x, factura.Datos_y + factura.Duplica_en_hoja_distancia, new StringFormat());

                    e.Graphics.DrawString(txt_doc.Text, printFont, Brushes.Black, factura.Datos_x, factura.Datos_y + factura.Datos_YY + factura.Duplica_en_hoja_distancia, new StringFormat());




                }

                e.Graphics.DrawString(Math.Round(calcular_imprimir_con_descuento_calculado, 2).ToString(), printFont, Brushes.Black, factura.Total_x, factura.Total_y + factura.Duplica_en_hoja_distancia, new StringFormat());
            }
            //   Bitmap bitmap = new Bitmap(this.bdd_print2.Width, this.bdd_print2.Height);
            // this.bdd_print2.DrawToBitmap(bitmap, this.bdd_print2.ClientRectangle);
            //  e.Graphics.DrawImage(bitmap, new Point(10, 250));
            //bdd_print2.Rows.Clear();

            total_imprimir = 0;
        }

        private void VentaProductos_Load(object sender, EventArgs e)
        {

        }

    

    }
}
