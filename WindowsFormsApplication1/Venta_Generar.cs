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
    public partial class Venta_Generar : Form
    {
        decimal calcular_porcentaje;
        decimal total_provisorio;
        string tipo = "Contado";
        string detalle;
        decimal importe;
        decimal porcentaje_imprimir;

        decimal subtotal_sin_descuento = 0;
        Font printFont;
        string printString;
        ArrayList clientes = new ArrayList();
        ArrayList listaVacia = new ArrayList();
        ArrayList listaInicial = new ArrayList();
        ArrayList listacarrito = new ArrayList();
        ArrayList listainicial2 = new ArrayList();
        Clases.Configuracion_factura factura = new Clases.Configuracion_factura();
        int conteo;
        // bool iniciar;
        bool validar;
        //  int saldo_stock;
        public Int64 id_cliente;
        decimal iva_global = Principal.iva;
        public Int64 id_pais;
        decimal total_imprimir = 0;
        public Venta_Generar()
        {
            InitializeComponent();
            this.Cursor = Cursors.WaitCursor;
            Cargarclientes();
            //  CargarPaises();
            cargarpro();
            buscar();
            txt_codigo2.Focus();
            txt_cotizacion_real.Text = (Datos.Conex.contizacion_real()).ToString();
            //   cbox_pais.Text = "Brasil";
            txt_cotizacion_real.Text = Principal.real.ToString();
            factura = Datos.Conex.traer_datos_facturas();
            cbox_filtro_producto.SelectedIndex = 1;

            txt_factura_num.Text = factura.Factura_Prefijo_dato + factura.Factura_numero_dato.ToString();

            txt_venta_num.Text = factura.Venta_Prefijo_dato + factura.Venta_numero_dato.ToString();
            label_iva.Text = "IVA " + Convert.ToInt32(Principal.iva).ToString() + "% :";
            cbox_descuentos.SelectedIndex = 0;
            //  label_fecha.Text = DateTime.Today.Date.ToShortDateString();
            this.Cursor = Cursors.Default;
            this.Text = "Venta Contado - " + factura.Comercio_nombre;
            cbox_descuentos.SelectedIndex = 1;
        }
        public void cargarpro()
        {


            // detalle
            if (cbox_filtro_producto.SelectedIndex == 0)
            {

                string buscar = "and p.detalle like  '%" + txt_buscar.Text + "%'";
                listaInicial = DatosProducto.getProductosBuscarModelo(buscar);
                listainicial2 = DatosProducto.getProductosBuscarModelo(buscar);
                //   bdd_productos.DataSource = listaInicial;
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
        {
            guardar_imprimir(true);


        }
        int cant_facturas;
        Int64 factura_numero_conteo;
        public void guardar_imprimir(bool imprime)
        {

            //verifico si hay items en el carrito


            if (listacarrito.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;
                int conteo;
                for (conteo = listacarrito.Count; conteo > 0; )
                {
                    conteo = conteo - factura.Items_max;

                    cant_facturas = cant_facturas + 1;
                }


                factura_numero_conteo = factura.Factura_numero_dato;

                // verifico si el cliente es nuevo 
                if (cbox_cliente.SelectedItem == null)
                {
                    if (txt_rut.Text == "")
                    {
                        txt_rut.Text = " ";
                    }


                    id_pais = DatosPais.obtener_id_pais_maximo();


                    Cliente c = new Cliente(0, cbox_cliente.Text, txt_n_documento.Text, " ", " ", " ", " ", id_pais, txt_rut.Text, Convert.ToDateTime("1/1/2000"));
                    DatosCliente.NuevoCliente(c);
                    id_cliente = DatosCliente.obtener_id_cliente_maximo();



                }
                //verifico si hay un cliente seleccionado en el cbox_cliente
                else
                {
                    id_cliente = ((Cliente)cbox_cliente.SelectedItem).Id_cliente;

                }
                int impre = 0;
                //creo una nueva venta en la bdd 
                Int64 id_venta;
                if (imprime == true)
                {
                    impre = 1;
                }
                else
                {

                    txt_factura_num.Text = " ";
                    txt_venta_num.Text = " ";
                }
                if (txt_observaciones.Text == "")
                {
                    txt_observaciones.Text = " ";
                }
                Venta v = new Venta(0, id_cliente, DateTime.Now, Convert.ToDecimal(txt_total_pesos.Text), impre, txt_venta_num.Text, " ", tipo, "Pago", 1, 1, 1, 1, 0, 0, 0, 0, descuento_monto, Convert.ToDecimal(Principal.iva), txt_observaciones.Text,Convert.ToDecimal(txt_enPesos.Text));
                DatosVenta.NuevaVenta(v);


                // obtengo el id max de venta
                try
                {
                    id_venta = DatosVenta.obtener_id_venta();
                }
                catch
                {
                    id_venta = 0;

                }


                //agrego items a Venta_producto en la bdd
                for (int i = 0; i < listacarrito.Count; i++)
                {

                    Venta_Producto vp = new Venta_Producto(0, id_venta, ((Producto)listacarrito[i]).Id_producto, ((Producto)listacarrito[i]).Total, ((Producto)listacarrito[i]).Stock);
                    DatosVenta_Producto.NuevaVentaProducto(vp);
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
                    try
                    {
                        PrintAString(0);
                    }
                    catch
                    {
                        MessageBox.Show(this, "Error al imprimir factura", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }


                tipo = null;
                detalle = null;


                Font printFont = null;
                string printString = null;
                clientes = null;
                listaVacia = null;
                listaInicial = null;
                listacarrito = null;
                listainicial2 = null;
                factura = null;


                Principal.cerrar_ventana_generar_venta = false;
                this.Close();

            }
            else
            {


                MessageBox.Show(this, "No hay items en el carrito", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_codigo2.Focus();
            }

        }
        private void Cargarclientes()
        {
            try
            {
                clientes = DatosCliente.getClientes("");
                cbox_cliente.DataSource = clientes;
                cbox_cliente.DisplayMember = "nombre";
                cbox_cliente.ValueMember = "Id_cliente";
                cbox_cliente.Refresh();
                cbox_cliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbox_cliente.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbox_filtro_producto.SelectedIndex = 0;

            }
            catch
            {


                MessageBox.Show(this, "No hay clientes, deberá crear uno para realizar la venta", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void cbox_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clientes.Count; i++)
            {

                if (((Cliente)clientes[i]).Id_cliente == ((Cliente)cbox_cliente.SelectedItem).Id_cliente)
                {
                    //cbox_pais.Text = ((Cliente)clientes[i]).Pais.Nombre;
                    txt_n_documento.Text = ((Cliente)clientes[i]).Documento;
                    //txt_direccion.Text = ((Cliente)clientes[i]).Direccion;
                    txt_rut.Text = ((Cliente)clientes[i]).RUT;

                    break;

                }
                else
                {

                    txt_n_documento.Text = " ";
                }

            }
        }
        /*  private void CargarPaises()
          {
              ArrayList paises = new ArrayList();
              paises = DatosPais.getPaises();
              cbox_pais.DataSource = paises;
              cbox_pais.DisplayMember = "Nombre";
              cbox_pais.ValueMember = "Id_pais";
              cbox_pais.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
              cbox_pais.AutoCompleteSource = AutoCompleteSource.ListItems;
              cbox_pais.Refresh();


          }*/
        private void cbox_cliente_TextChanged(object sender, EventArgs e)
        {
            txt_n_documento.Text = "";
            // cbox_pais.Text = "Brasil";
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
            subtotal_sin_descuento = 0;
            decimal abonar;
            txt_subtotal_pesos.Text = "0";

            for (int x = 0; x < listacarrito.Count; x++)
            {



                abonar = ((Producto)listacarrito[x]).Total * ((Producto)listacarrito[x]).Stock;

                decimal total = abonar + subtotal_sin_descuento;
                subtotal_sin_descuento = Math.Round(total, 2);
                bdd_carrito[4, x].Value = abonar;
                // bdd_print[3, x].Value = abonar;
                ((Producto)listacarrito[x]).Precio_unidad = abonar;

            }

            calcular_abono();


        }
        decimal descuento_monto = 0;
        public void calcular_abono()
        {
            if (subtotal_sin_descuento != 0)
            {
                calcular_porcentaje = 0;
                total_provisorio = 0;

                if (cbox_descuentos.SelectedIndex == 0)
                {
                    porcentaje_imprimir = Convert.ToDecimal(txt_descuento_porcent.Text);
                    calcular_porcentaje = (subtotal_sin_descuento / 100) * Convert.ToDecimal(txt_descuento_porcent.Text);

                    txt_descuento_pesos.Text = Math.Round(calcular_porcentaje, 2).ToString();
                    total_provisorio = subtotal_sin_descuento - calcular_porcentaje;
                    descuento_monto = calcular_porcentaje;
                    if (txt_descuento_porcent.Text != "0")
                    {

                        txt_observaciones.Text = "Se realizó un descuento de " + txt_descuento_porcent.Text + " %";
                    }
                    else
                    {
                        txt_observaciones.Text = " ";
                    }
                }
                else
                {

                    decimal calculos = (100 / subtotal_sin_descuento) * Convert.ToDecimal(txt_descuento_porcent.Text);
                    porcentaje_imprimir = calculos;
                    txt_descuento_pesos.Text = Math.Round(calculos, 3).ToString();
                    total_provisorio = subtotal_sin_descuento - Convert.ToDecimal(txt_descuento_porcent.Text);
                    descuento_monto = Convert.ToDecimal(txt_descuento_porcent.Text);
                    if (txt_descuento_pesos.Text != "0")
                    {

                        txt_observaciones.Text = "Se realizó un descuento de " + txt_descuento_pesos.Text + " %";
                    }
                    else
                    {
                        txt_observaciones.Text = " ";
                    }
                }

                txt_total_pesos.Text = Math.Round(total_provisorio, 2).ToString();
                txt_reales.Text = (Math.Round(total_provisorio / Convert.ToDecimal(Principal.real), 2)).ToString();

                decimal iva_pesos = total_provisorio  ;
                decimal subtotal = Math.Round((total_provisorio / ((Principal.iva / 100) + 1)), 2);
                txt_subtotal_pesos.Text = subtotal.ToString();
                txt_iva_pesos.Text = (total_provisorio-subtotal).ToString();
                if (txt_descuento_porcent.Text != "0")
                {

                    btn_no_imprimir.Enabled = false;
                }
                else
                {
                    btn_no_imprimir.Enabled = true;
                }

                if (chk_en_pesos.Checked == true)
                {

                    txt_enPesos.Text = txt_total_pesos.Text;
     

                }
            }
            else
            {

                txt_descuento_porcent.Text = "0";
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
                    try
                    {
                        if (((Producto)listacarrito[x]).Imagen_categoria == true)
                        {

                            pbox_imagen.Visible = true;
                            pbox_imagen.Image = Image.FromFile(((Producto)listacarrito[x]).Cate.Imagen);
                            label_imagen_no_disponible.Visible = false;
                        }
                        else
                        {
                            if (((Producto)listacarrito[x]).Imagen != " ")
                            {
                                pbox_imagen.Visible = true;
                                pbox_imagen.Image = Image.FromFile(((Producto)listacarrito[x]).Imagen);
                                label_imagen_no_disponible.Visible = false;
                            }
                            else
                            {
                                pbox_imagen.Visible = false;
                                label_imagen_no_disponible.Visible = true;
                            }


                        }
                    }
                    catch
                    {
                        pbox_imagen.Visible = false;
                        label_imagen_no_disponible.Visible = true;
                    }


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
                        try
                        {
                            if (p.Imagen_categoria == true)
                            {

                                pbox_imagen.Visible = true;
                                pbox_imagen.Image = Image.FromFile(p.Cate.Imagen);
                                label_imagen_no_disponible.Visible = false;
                            }
                            else
                            {
                                if (p.Imagen != " ")
                                {
                                    pbox_imagen.Visible = true;
                                    pbox_imagen.Image = Image.FromFile(p.Imagen);
                                    label_imagen_no_disponible.Visible = false;
                                }
                                else
                                {
                                    pbox_imagen.Visible = false;
                                    label_imagen_no_disponible.Visible = true;
                                }
                            }
                        }
                        catch
                        {
                            pbox_imagen.Visible = false;
                            label_imagen_no_disponible.Visible = true;
                        }
                    }
                }
            }
            existe = false;
            txt_codigo2.Text = "";

            txt_codigo2.Focus();
            bdd_carrito.FirstDisplayedCell = bdd_carrito.Rows[bdd_carrito.Rows.Count - 1].Cells[0];

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
            subtotal_sin_descuento = 0;
            //txt_total_.Text = "0";
            txt_total_pesos.Text = "0";
            txt_iva_pesos.Text = "0";
            txt_subtotal_pesos.Text = "0";
            txt_reales.Text = "0";
            cbox_cliente.Text = " ";
            chk_rut.Checked = false;
            //  cbox_pais.Text = "Brasil";
            // txt_direccion.Text = " ";
            txt_rut.Text = " ";
            txt_n_documento.Text = " ";
            txt_descuento_porcent.Text = "0";
            txt_observaciones.Text = " ";
            txt_codigo2.Focus();
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
            this.AcceptButton = btn_agregar;
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

            int y = factura.Yy;

            for (int x = conteo; x < listacarrito.Count; x++)
            {


                importe = ((Producto)listacarrito[x]).Stock * ((Producto)listacarrito[x]).Total;

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

                    int count = ((Producto)listacarrito[x]).Detalle.Count();
                    if (count > 27)
                    {
                        detalle = ((Producto)listacarrito[x]).Detalle.Substring(0, 26);
                    }
                    else
                    {

                        detalle = ((Producto)listacarrito[x]).Detalle;

                    }
                    e.Graphics.DrawString(((Producto)listacarrito[x]).Stock.ToString(), printFont, Brushes.Black, factura.Cantidad_X, y, new StringFormat());
                    e.Graphics.DrawString(detalle.ToString(), printFont, Brushes.Black, factura.Detalle_X, y, new StringFormat());
                    if (((Producto)listacarrito[x]).Total < 10 && ((Producto)listacarrito[x]).Total > 0)
                    {
                        e.Graphics.DrawString(((Producto)listacarrito[x]).Total.ToString(), printFont, Brushes.Black, factura.Precio_X, y, new StringFormat());
                    }
                    else if (((Producto)listacarrito[x]).Total < 100 && ((Producto)listacarrito[x]).Total >= 10)
                    {
                        e.Graphics.DrawString(((Producto)listacarrito[x]).Total.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx, y, new StringFormat());
                    }
                    else if (((Producto)listacarrito[x]).Total < 1000 && ((Producto)listacarrito[x]).Total >= 100)
                    {
                        e.Graphics.DrawString(((Producto)listacarrito[x]).Total.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 2, y, new StringFormat());
                    }
                    else if (((Producto)listacarrito[x]).Total < 10000 && ((Producto)listacarrito[x]).Total >= 1000)
                    {
                        e.Graphics.DrawString(((Producto)listacarrito[x]).Total.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 3, y, new StringFormat());
                    }
                    else
                    {
                        e.Graphics.DrawString(((Producto)listacarrito[x]).Total.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 4, y, new StringFormat());
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
                        e.Graphics.DrawString(((Producto)listacarrito[x]).Stock.ToString(), printFont, Brushes.Black, factura.Cantidad_X, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        e.Graphics.DrawString(detalle.ToString(), printFont, Brushes.Black, factura.Detalle_X, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        if (((Producto)listacarrito[x]).Total < 10 && ((Producto)listacarrito[x]).Total > 0)
                        {
                            e.Graphics.DrawString(((Producto)listacarrito[x]).Total.ToString(), printFont, Brushes.Black, factura.Precio_X, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        else if (((Producto)listacarrito[x]).Total < 100 && ((Producto)listacarrito[x]).Total >= 10)
                        {
                            e.Graphics.DrawString(((Producto)listacarrito[x]).Total.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        else if (((Producto)listacarrito[x]).Total < 1000 && ((Producto)listacarrito[x]).Total >= 100)
                        {
                            e.Graphics.DrawString(((Producto)listacarrito[x]).Total.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 2, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        else if (((Producto)listacarrito[x]).Total < 10000 && ((Producto)listacarrito[x]).Total >= 1000)
                        {
                            e.Graphics.DrawString(((Producto)listacarrito[x]).Total.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 3, y + factura.Duplica_en_hoja_distancia, new StringFormat());
                        }
                        else
                        {
                            e.Graphics.DrawString(((Producto)listacarrito[x]).Total.ToString(), printFont, Brushes.Black, factura.Precio_X - factura.Xx * 4, y + factura.Duplica_en_hoja_distancia, new StringFormat());
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
                        //   e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, 340, y, new StringFormat());


                    }
                    //   e.Graphics.DrawString(importe.ToString(), printFont, Brushes.Black, 340, y, new StringFormat());
                    y = y + factura.Datos_YY;
                }

                total_imprimir = total_imprimir + importe;
            }
            decimal calcular_total_con_descuento = (total_imprimir / 100) * porcentaje_imprimir;
            decimal calcular_total_con_descuento_a_imprimir = total_imprimir - calcular_total_con_descuento;


            string date = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
  
            e.Graphics.DrawString(date, printFont, Brushes.Black, factura.Fecha_X, factura.Fecha_Y, new StringFormat());
            e.Graphics.DrawString(txt_venta_num.Text, printFont, Brushes.Black, factura.Venta_numero_x, factura.Venta_numero_y, new StringFormat());

            if (factura.Observaciones_imprime == true)
            {
                e.Graphics.DrawString(txt_observaciones.Text, printFont, Brushes.Black, factura.Observaciones_x, factura.Observaciones_y, new StringFormat());
            }
            if (factura.Tipo_imprime == true)
            {
                e.Graphics.DrawString(cbox_tipo.Text, printFont, Brushes.Black, factura.Tipo_x, factura.Tipo_y, new StringFormat());
            }
            e.Graphics.DrawString(txt_rut.Text, printFont, Brushes.Black, factura.Rut_X, factura.Rut_y, new StringFormat());
            if (chk_rut.Checked == false)
            {
                e.Graphics.DrawString("X", printFont, Brushes.Black, factura.C_Final_X, factura.C_Final_Y, new StringFormat());
            }
            else
            {
                e.Graphics.DrawString(txt_rut.Text, printFont, Brushes.Black, factura.Rut_X, factura.Rut_y, new StringFormat());

  

            }
            e.Graphics.DrawString(txt_subtotal_pesos.Text, printFont, Brushes.Black, factura.Subtotal_X, factura.SubTotal_y, new StringFormat());
            e.Graphics.DrawString(txt_iva_pesos.Text, printFont, Brushes.Black, factura.Iva_X, factura.Iva_Y, new StringFormat());
            // si cliente no tiene nombre
            if (cbox_cliente.Text == " " || cbox_cliente.Text == "")
            {
                e.Graphics.DrawString(" ", printFont, Brushes.Black, factura.Datos_x, factura.Datos_y, new StringFormat());
                e.Graphics.DrawString(" ", printFont, Brushes.Black, factura.Datos_x, factura.Datos_y + factura.Datos_YY, new StringFormat());
                e.Graphics.DrawString(" ", printFont, Brushes.Black, factura.Datos_x, factura.Datos_y + factura.Datos_YY * 2, new StringFormat());
                e.Graphics.DrawString(" ", printFont, Brushes.Black, factura.Datos_x, factura.Datos_y + factura.Datos_YY * 3, new StringFormat());
            }
            // si cliente tiene nombre
            else
            {
                e.Graphics.DrawString(cbox_cliente.Text, printFont, Brushes.Black, factura.Datos_x, factura.Datos_y, new StringFormat());

                e.Graphics.DrawString(txt_n_documento.Text, printFont, Brushes.Black, factura.Datos_x, factura.Datos_y + factura.Datos_YY, new StringFormat());
            }
      
            e.Graphics.DrawString(Math.Round(calcular_total_con_descuento_a_imprimir, 2).ToString(), printFont, Brushes.Black, factura.Total_x, factura.Total_y, new StringFormat());
            if (factura.Duplica_en_hoja == true)
            {

                e.Graphics.DrawString(date, printFont, Brushes.Black, factura.Fecha_X, factura.Fecha_Y + factura.Duplica_en_hoja_distancia, new StringFormat());
                e.Graphics.DrawString(txt_venta_num.Text, printFont, Brushes.Black, factura.Venta_numero_x, factura.Venta_numero_y + factura.Duplica_en_hoja_distancia, new StringFormat());

                if (factura.Observaciones_imprime == true)
                {
                    e.Graphics.DrawString(txt_observaciones.Text, printFont, Brushes.Black, factura.Observaciones_x, factura.Observaciones_y + factura.Duplica_en_hoja_distancia, new StringFormat());
                }
                if (factura.Tipo_imprime == true)
                {
                    e.Graphics.DrawString(cbox_tipo.Text, printFont, Brushes.Black, factura.Tipo_x, factura.Tipo_y + factura.Duplica_en_hoja_distancia, new StringFormat());
                }
                e.Graphics.DrawString(txt_rut.Text, printFont, Brushes.Black, factura.Rut_X, factura.Rut_y + factura.Duplica_en_hoja_distancia, new StringFormat());
                if (chk_rut.Checked == false)
                {
                    e.Graphics.DrawString("X", printFont, Brushes.Black, factura.C_Final_X, factura.C_Final_Y + factura.Duplica_en_hoja_distancia, new StringFormat());
                }
                else
                {
                    e.Graphics.DrawString(txt_rut.Text, printFont, Brushes.Black, factura.Rut_X, factura.Rut_y + factura.Duplica_en_hoja_distancia, new StringFormat());

                   
                }
                e.Graphics.DrawString(txt_subtotal_pesos.Text, printFont, Brushes.Black, factura.Subtotal_X, factura.SubTotal_y + factura.Duplica_en_hoja_distancia, new StringFormat());
                e.Graphics.DrawString(txt_iva_pesos.Text, printFont, Brushes.Black, factura.Iva_X, factura.Iva_Y + factura.Duplica_en_hoja_distancia, new StringFormat());

                // si cliente no tiene nombre
                if (cbox_cliente.Text == " " || cbox_cliente.Text == "")
                {
                    e.Graphics.DrawString(" ", printFont, Brushes.Black, factura.Datos_x, factura.Datos_y, new StringFormat());
                    e.Graphics.DrawString(" ", printFont, Brushes.Black, factura.Datos_x, factura.Datos_y + factura.Datos_YY + factura.Duplica_en_hoja_distancia, new StringFormat());
                    e.Graphics.DrawString(" ", printFont, Brushes.Black, factura.Datos_x, factura.Datos_y + factura.Datos_YY * 2 + factura.Duplica_en_hoja_distancia, new StringFormat());
                    e.Graphics.DrawString(" ", printFont, Brushes.Black, factura.Datos_x, factura.Datos_y + factura.Datos_YY * 3 + factura.Duplica_en_hoja_distancia, new StringFormat());
                }
                // si cliente tiene nombre
                else
                {
                    e.Graphics.DrawString(cbox_cliente.Text, printFont, Brushes.Black, factura.Datos_x, factura.Datos_y + factura.Duplica_en_hoja_distancia, new StringFormat());

                    e.Graphics.DrawString(txt_n_documento.Text, printFont, Brushes.Black, factura.Datos_x, factura.Datos_y + factura.Datos_YY + factura.Duplica_en_hoja_distancia, new StringFormat());
                }
                e.Graphics.DrawString(Math.Round(calcular_total_con_descuento_a_imprimir, 2).ToString(), printFont, Brushes.Black, factura.Total_x, factura.Total_y + factura.Duplica_en_hoja_distancia, new StringFormat());
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



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_rut.Checked == false)
            {

                txt_rut.Text = "";
                txt_rut.ReadOnly = true;

            }
            else
            {
                txt_rut.ReadOnly = false;
                txt_rut.Focus();
            }
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
           int posicion = bdd_carrito.CurrentRow.Index;
            if (listacarrito.Count > 0)
            {
                eliminar(((Producto)listacarrito[posicion]).Codigo);
            }
            chk_eliminar.Checked = false;
            txt_codigo2.Focus();
        }

        private void chk_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            txt_codigo2.Focus();
        }

        private void btn_no_imprimir_Click(object sender, EventArgs e)
        {
            guardar_imprimir(false);
        }

        private void Venta_Generar_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                if (chk_en_pesos.Checked == false)
                {
                    chk_en_pesos.Checked = true;
                }
                else
                {
                    chk_en_pesos.Checked = false;
                }
            }
            if (e.KeyCode == Keys.F8)
            {
                guardar_imprimir(false);
            }
            if (e.KeyCode == Keys.F12)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {


            try
            {
                if (cbox_descuentos.SelectedIndex == 0)
                {
                    if (Convert.ToDecimal(txt_descuento_porcent.Text) < 0 || Convert.ToDecimal(txt_descuento_porcent.Text) > 100)
                    {
                        txt_descuento_porcent.Text = "0";
                        txt_descuento_porcent.SelectAll();
                    }
                }
                else
                {
                    if (Convert.ToDecimal(txt_descuento_porcent.Text) < 0)
                    {
                        txt_descuento_porcent.Text = "0";
                        txt_descuento_porcent.SelectAll();
                    }
                }

            }
            catch
            {
                txt_descuento_porcent.Text = "0";
                txt_descuento_porcent.SelectAll();
            }
            calcular_abono();

            if (Convert.ToDecimal(txt_total_pesos.Text) < 0)
            {
                txt_descuento_porcent.Text = "0";
                txt_descuento_porcent.SelectAll();
            }

        }

        private void txt_descuento_pesos_TextChanged(object sender, EventArgs e)
        {

        }



        private void cbox_descuentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_descuentos.SelectedIndex == 0)
            {

                label_porcentaje_o_plata.Text = "$";

            }
            else
            {

                label_porcentaje_o_plata.Text = "%";
            }
            txt_descuento_porcent.Text = "0";
        }

        private void txt_descuento_porcent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                // si se pulsa en el punto se convertirá en coma
                e.Handled = true;
                SendKeys.Send(",");
            }
        }



        private void bdd_productos_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void bdd_carrito_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void txt_descuento_porcent_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void cbox_descuentos_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void txt_cantidad_Click(object sender, EventArgs e)
        {
            txt_cantidad.SelectAll();
        }

        private void chk_en_pesos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_en_pesos.Checked == true)
            {

                txt_enPesos.Text = txt_total_pesos.Text;
                txt_enPesos.Enabled = true;
                txt_enPesos.Focus();
                txt_enPesos.SelectAll();

            }
            else
            {
                txt_enPesos.Text = "0";
                txt_enPesos.Enabled = false;
                txt_codigo2.Focus();
            }
        }

        private void txt_enPesos_KeyDown(object sender, KeyEventArgs e)
        {
            Venta_Generar_KeyPress(sender, e);
        }

        private void txt_enPesos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txt_total_pesos.Text) < 0 || Convert.ToDecimal(txt_enPesos.Text) > Convert.ToDecimal(txt_total_pesos.Text))
                {
                    txt_enPesos.Text = "0";
                    txt_enPesos.SelectAll();
                }
            }
            catch
            {
                txt_enPesos.Text = "0";
                txt_enPesos.SelectAll();
            }
        }

    




    }
}
