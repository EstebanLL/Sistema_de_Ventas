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
    public partial class Producto_Quitar_Stock : Form
    {
        string detalle;
        decimal importe;
        Font printFont;
        string printString;
        ArrayList clientes = new ArrayList();
        ArrayList listaVacia = new ArrayList();
        ArrayList listaInicial = new ArrayList();
        ArrayList listacarrito = new ArrayList();
        ArrayList listainicial2 = new ArrayList();
        Clases.Configuracion_factura factura = new Clases.Configuracion_factura();
        int conteo;
        bool iniciar;
        bool validar;
        int saldo_stock;
        public Int64 id_cliente;
        decimal iva_global = Principal.iva;
        public Int64 id_pais;
        decimal total_imprimir = 0;
        public Producto_Quitar_Stock()
        {
            InitializeComponent();

       cbox_filtro_producto.SelectedIndex = 0;
      
            buscar();
            txt_codigo2.Focus();
     cargarpro();
            factura = Datos.Conex.traer_datos_facturas();
              }
        public void cargarpro()
        {


            // detalle
            if (cbox_filtro_producto.SelectedIndex == 0)
            {

                string buscar = "and p.detalle like  '%" + txt_buscar.Text + "%'";
                listaInicial = DatosProducto.getProductosBuscarModelo(buscar);
                listainicial2 = DatosProducto.getProductosBuscarModelo(buscar);

            }


        }
        public void buscar()
        {

            ArrayList lista = new ArrayList();

            // detalle
            if (cbox_filtro_producto.SelectedIndex == 1)
            {

                string buscar = "and p.detalle like  '%" + txt_buscar.Text + "%'";
                lista = DatosProducto.getProductosBuscarModelo(buscar);
            }
            //codigo
            else if (cbox_filtro_producto.SelectedIndex == 0)
            {

                string buscar = "and p.codigo like '%" + txt_buscar.Text + "%'";
                lista = DatosProducto.getProductosBuscarModelo(buscar);
            }
            else if (cbox_filtro_producto.SelectedIndex == 2)
            {


                lista = DatosProducto.getProductosBuscarModelo("");
                for (int i = lista.Count; i > 0; i--)
                {
                    if (((Producto)lista[i - 1]).Stock > ((Producto)lista[i - 1]).Stock_min)
                    {

                        lista.RemoveAt(i - 1);

                    }
                }
            }

            else
            {
                lista = listaVacia;

            }

            if (lista.Count == 0)
            {
                bdd_productos.DataSource = listaVacia;

                if (cbox_filtro_producto.SelectedIndex == 0)
                {
                    txt_buscar.Text = "";
                }
            }
            else
            {
                listaVacia.Clear();
                listaVacia = lista;
                if (cbox_filtro_producto.SelectedIndex == 0)
                {
                    txt_buscar.SelectAll();
                }
                bdd_productos.DataSource = listaVacia;
            }
            if (cbox_filtro_producto.SelectedIndex == 0)
            {
                this.AcceptButton = btn_agregar;
                txt_codigo2.Focus();

            }

        }

        private void Venta_Generar_Load(object sender, EventArgs e)
        {

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        { DialogResult dr = MessageBox.Show(this, "A continuacion se imprimirá el listado en hoja A4, ¿Desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
            guardar_imprimir(true);
        }

        }
        public void guardar_imprimir(bool imprime)
        {
            
            //verifico si hay items en el carrito
            if (listacarrito.Count > 0)
            {
                // verifico si el cliente es nuevo 
 
                //verifico si hay un cliente seleccionado en el cbox_cliente
             
                int impre = 0;
                //creo una nueva venta en la bdd 
                Int64 id_venta;
                if (imprime == true)
                {
                    impre = 1;
                }
      


                // obtengo el id max de venta


                //agrego items a Venta_producto en la bdd
                for (int i = 0; i < listacarrito.Count; i++)
                {


                    for (Int32 h = 0; h < listaInicial.Count; h++)
                    {
                        if (((Producto)listacarrito[i]).Id_producto == ((Producto)listainicial2[h]).Id_producto)
                        {
                            DatosProducto.CambiarStock(((Producto)listacarrito[i]).Id_producto, ((Producto)listainicial2[h]).Stock - ((Producto)listacarrito[i]).Stock);
                        }
                    }
                }
                if (imprime == true)
                {
                    PrintAString(0);
                }

                Principal.cerrar_ventana_generar_venta = false;
                this.Close();

            }
            else
            {


                MessageBox.Show(this, "No hay items para eliminar", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_codigo2.Focus();
            }

        }
        private void Cargarclientes()
        {

        }

        private void cbox_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar();

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (cbox_filtro_producto.SelectedIndex == 1)
            {
                buscar();
            }
            else
            {

                this.AcceptButton = btn_buscar;
            }
            if (txt_buscar.Text == "")
            {

                buscar();
            }
        }
        public void calcular()
        {
            decimal abonar;
            txt_pesos.Text = "0";

            for (int x = 0; x < listacarrito.Count; x++)
            {



                abonar = ((Producto)listacarrito[x]).Total * ((Producto)listacarrito[x]).Stock;

                string total = (abonar + Convert.ToDecimal(txt_pesos.Text)).ToString();
                txt_pesos.Text = (Convert.ToDecimal(Math.Round(Convert.ToDecimal(total), 2))).ToString();
                bdd_carrito[4, x].Value = abonar;
                // bdd_print[3, x].Value = abonar;
                ((Producto)listacarrito[x]).Precio_unidad = abonar;

            }


        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (chk_eliminar.Checked == false)
            {
                agregar(txt_codigo2.Text);
            }
            else
            {

                eliminar(txt_codigo2.Text);
                chk_eliminar.Checked = false;
                txt_codigo2.Focus();
            }

        }
        public void eliminar(string codigo)
        {


            for (int x = 0; x < listacarrito.Count; x++)
            {
                if (codigo == ((Producto)listacarrito[x]).Codigo)
                {


                    ((Producto)listacarrito[x]).Stock = ((Producto)listacarrito[x]).Stock - 1;
                    bdd_carrito[2, x].Value = ((Producto)listacarrito[x]).Stock;
                    //   bdd_print[2, x].Value = ((Producto)listacarrito[x]).Stock;
                    txt_cantidad.Text = "1";
                    if (((Producto)listacarrito[x]).Stock <= 0)
                    {

                        listacarrito.RemoveAt(x);
                        bdd_carrito.Rows.RemoveAt(x);
                    }
                }
            }
            txt_codigo2.Text = "";

            txt_codigo2.Focus();
            calcular();
        }
        public void agregar(string codigo)
        {
            bool existe = false;


            for (int x = 0; x < listacarrito.Count; x++)
            {
                if (codigo == ((Producto)listacarrito[x]).Codigo)
                {

                    existe = true;
                    ((Producto)listacarrito[x]).Stock = Convert.ToInt32(txt_cantidad.Text) + ((Producto)listacarrito[x]).Stock;
                    bdd_carrito[2, x].Value = ((Producto)listacarrito[x]).Stock;
                    // bdd_print[0, x].Value = ((Producto)listacarrito[x]).Stock;
                    txt_cantidad.Text = "1";
                }
            }


            if (existe == false)
            {
                for (int i = 0; i < listaInicial.Count; i++)
                {
                    if (codigo == ((Producto)listaInicial[i]).Codigo)
                    {
                        Producto p = new Producto();
                        p = (Producto)listaInicial[i];
                        p.Stock = Convert.ToInt32(txt_cantidad.Text);
                        bdd_carrito.Rows.Add(p.Codigo, p.Detalle, p.Stock, p.Total);
                        //bdd_print.Rows.Add(p.Stock, p.Detalle, p.Total);
                        listacarrito.Add(p);
                        txt_cantidad.Text = "1";
                    }
                }
            }
            existe = false;
            txt_codigo2.Text = "";

            txt_codigo2.Focus();
            calcular();
        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txt_cantidad.Text) > 0)
                {


                }
                else
                {
                    txt_cantidad.Text = "1";
                }
            }
            catch
            {

                txt_cantidad.Text = "1";


            }
            txt_codigo2.TabIndex = 7;

        }

        private void btn_carrito_limpiar_Click(object sender, EventArgs e)
        {
            listacarrito.Clear();
            bdd_carrito.Rows.Clear();
            txt_pesos.Text = "0";

        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Principal.cerrar_ventana_generar_venta = true;
            this.Close();
        }



        private void cbox_filtro_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_buscar.Text = "";
            txt_buscar.Focus();
        }

        private void txt_codigo2_TextChanged(object sender, EventArgs e)
        {
            txt_codigo2.TabIndex = 5;
            txt_cantidad.TabIndex = 6;
        }


        public void PrintAString(int iniciar)
        {

            PrintDocument pd = new PrintDocument();

            printFont = new Font(factura.Fuente, factura.Tamano);



            pd.PrintPage += new PrintPageEventHandler(PrintPage);

            pd.Print();
            // printPreviewDialog1.Document = pd;
            //    printPreviewDialog1.ShowDialog();
           
        

        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {

            int y = 150;
            int contador_lineas = y;

            for (int x = conteo; x < listacarrito.Count; x++)
            {


                importe = ((Producto)listacarrito[x]).Stock * ((Producto)listacarrito[x]).Total;

                // bdd_print2.Rows.Add(((Producto)listacarrito[x]).Stock, ((Producto)listacarrito[x]).Detalle, ((Producto)listacarrito[x]).Total, importe);
                if (contador_lineas>1000)
                {
                  //  conteo = conteo + factura.Items_max;

                   // x = listacarrito.Count;
                    importe = 0;
                    e.HasMorePages = true;
                    break;
                }
                else
                {
                    conteo = conteo + 1;
                    e.HasMorePages = false;
                    contador_lineas = contador_lineas + 15;

                    int count = ((Producto)listacarrito[x]).Detalle.Count();
                    if (count > 27)
                    {
                        detalle = ((Producto)listacarrito[x]).Detalle.Substring(0, 26);
                    }
                    else
                    {

                        detalle = ((Producto)listacarrito[x]).Detalle;

                    }
                    e.Graphics.DrawString(((Producto)listacarrito[x]).Stock.ToString(), printFont, Brushes.Black, factura.Cantidad_X+100, y, new StringFormat());
                    e.Graphics.DrawString(detalle.ToString(), printFont, Brushes.Black, factura.Detalle_X + 100, y, new StringFormat());
                    if (((Producto)listacarrito[x]).Total < 10 && ((Producto)listacarrito[x]).Total > 0)
                    {
                        e.Graphics.DrawString(((Producto)listacarrito[x]).Total.ToString(), printFont, Brushes.Black, factura.Precio_X + 100, y, new StringFormat());
                    }
                    else if (((Producto)listacarrito[x]).Total < 100 && ((Producto)listacarrito[x]).Total >= 10)
                    {
                        e.Graphics.DrawString(((Producto)listacarrito[x]).Total.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx + 100, y, new StringFormat());
                    }
                    else if (((Producto)listacarrito[x]).Total < 1000 && ((Producto)listacarrito[x]).Total >= 100)
                    {
                        e.Graphics.DrawString(((Producto)listacarrito[x]).Total.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 2 + 100, y, new StringFormat());
                    }
                    else if (((Producto)listacarrito[x]).Total < 10000 && ((Producto)listacarrito[x]).Total >= 1000)
                    {
                        e.Graphics.DrawString(((Producto)listacarrito[x]).Total.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 3 + 100, y, new StringFormat());
                    }
                    else
                    {
                        e.Graphics.DrawString(((Producto)listacarrito[x]).Total.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 4 + 100, y, new StringFormat());
                    }
                    //importe
                    if (importe < 10 && importe >= 0)
                    {
                        e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, factura.Importe_X + 100, y, new StringFormat());
                    }
                    else if (importe < 100 && importe >= 10)
                    {
                        e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, factura.Importe_X - factura.Xx + 100, y, new StringFormat());
                    }
                    else if (importe < 1000 && importe >= 100)
                    {
                        e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, factura.Importe_X - factura.Xx * 2 + 100, y, new StringFormat());
                    }
                    else if (importe < 10000 && importe >= 1000)
                    {
                        e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, factura.Importe_X - factura.Xx * 3 + 100, y, new StringFormat());
                    }
                    else
                    {
                        e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, factura.Importe_X - factura.Xx * 4 + 100, y, new StringFormat());
                    }
                    //   e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, 340, y, new StringFormat());
                    y = y + factura.Datos_YY;
                }

                total_imprimir = total_imprimir + importe;
            }
 
     
        
            e.Graphics.DrawString(DateTime.Now + " // " + factura.Comercio_nombre , printFont, Brushes.Black, 200, 80, new StringFormat());
            e.Graphics.DrawString("Se ha quitado los siguientes items del stock // con un total de: " + total_imprimir.ToString(), printFont, Brushes.Black, 50, 100, new StringFormat());
            // si cliente no tiene nombre

         //   e.Graphics.DrawString(total_imprimir.ToString(), printFont, Brushes.Black, factura.Total_x, factura.Total_y, new StringFormat());

            //   Bitmap bitmap = new Bitmap(this.bdd_print2.Width, this.bdd_print2.Height);
            // this.bdd_print2.DrawToBitmap(bitmap, this.bdd_print2.ClientRectangle);
            //  e.Graphics.DrawImage(bitmap, new Point(10, 250));
            //bdd_print2.Rows.Clear();

            total_imprimir = 0;
        }



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bdd_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chk_eliminar.Checked == false)
            {
                agregar(((Producto)bdd_productos.CurrentRow.DataBoundItem).Codigo);
            }
            else
            {

                eliminar(((Producto)bdd_productos.CurrentRow.DataBoundItem).Codigo);
                chk_eliminar.Checked = false;
                txt_codigo2.Focus();
            }
        }

        private void bdd_carrito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chk_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            txt_codigo2.Focus();
        }


        private void bdd_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_no_imprimir_Click(object sender, EventArgs e)
        {
            guardar_imprimir(false);
        }

        private void Venta_Generar_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                guardar_imprimir(false);
            }
            if (e.KeyCode == Keys.F11)
            {
                guardar_imprimir(true);
            }
            if (e.KeyCode == Keys.F10)
            {
                txt_buscar.Focus();
            }
            if (e.KeyCode == Keys.F9)
            {
                if (chk_eliminar.Checked == false)
                {
                    chk_eliminar.Checked = true;
                    txt_codigo2.Focus();
                }
                else
                {

                    chk_eliminar.Checked = false;
                    txt_codigo2.Focus();
                }
            }
        }





        private void txt_codigo2_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void cbox_cliente_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void txt_direccion_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void cbox_pais_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void txt_n_documento_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void chk_rut_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void txt_rut_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void txt_buscar_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void txt_cantidad_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void chk_eliminar_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void btn_imprimir_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void btn_no_imprimir_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void btn_cancelar_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void txt_cotizacion_real_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscar_Click(object sender, EventArgs e)
        {
            txt_buscar.SelectAll();
        }

        private void txt_codigo2_TextChanged_1(object sender, EventArgs e)
        {
            txt_codigo2.TabIndex = 5;
            txt_cantidad.TabIndex = 6;
            this.AcceptButton = btn_agregar;
        }

        private void btn_carrito_eliminar_Click(object sender, EventArgs e)
        {
            listacarrito.Clear();
            bdd_carrito.Rows.Clear();
            txt_pesos.Text = "0";
        }

        private void bdd_carrito_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = bdd_carrito.CurrentRow.Index;
            if (listacarrito.Count > 0)
            {
                eliminar(((Producto)listacarrito[posicion]).Codigo);
            }
            chk_eliminar.Checked = false;
            txt_codigo2.Focus();
        }

        private void txt_codigo2_KeyDown_1(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void bdd_productos_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void bdd_carrito_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void txt_cantidad_KeyDown_1(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void txt_buscar_KeyDown_1(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void cbox_filtro_producto_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }




     
    }
}
