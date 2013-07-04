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
    public partial class Producto_Alta : Form
    {
        Int64 id_proveedor = 0;
        ArrayList proveedores = new ArrayList();
        ArrayList listaVacia = new ArrayList();
        ArrayList listaInicial = new ArrayList();
        ArrayList listacarrito = new ArrayList();
        ArrayList listacarrito_nuevo = new ArrayList();
        public static ArrayList producto_agregar = new ArrayList();
        public static ArrayList producto_agregar_nuevo = new ArrayList();
        ArrayList listainicial2 = new ArrayList();
        bool existe_producto = false;

        public Producto_Alta()
        {
            InitializeComponent();
            Cargarproveedores();
            cargarpro();
            buscar();
            cbox_tipo_factura.SelectedIndex = 0;
            cbox_filtro_producto.SelectedIndex = 0;
            txt_codigo2.Focus();
        }
        private void Cargarproveedores()
        {
            try
            {
                proveedores = DatosProveedor.getProveedores("");
                cbox_proveedor.DataSource = proveedores;
                cbox_proveedor.DisplayMember = "nombre";
                cbox_proveedor.ValueMember = "Id_proveedor";
                cbox_proveedor.Refresh();
                cbox_proveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbox_proveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbox_filtro_producto.SelectedIndex = 0;

            }
            catch
            {


                MessageBox.Show(this, "No hay provedores, deberá crear uno para realizar la alta de un producto", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
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
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar();

        }

        private void cbox_tipo_factura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_tipo_factura.SelectedIndex == 1)
            {

                date_vencimiento.Enabled = true;

            }
            else
            {
                date_vencimiento.Enabled = false;

            }
        }

        private void cbox_filtro_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_buscar.Text = "";
            txt_buscar.Focus();
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

        private void bdd_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            agregar(((Producto)bdd_productos.CurrentRow.DataBoundItem).Codigo.ToString());

        }
        /*     public void calcular()
             {
                 decimal abonar;
                 txt_pesos.Text = "0";

                 for (int x = 0; x < listacarrito.Count; x++)
                 {



                     abonar = ((Producto)listacarrito[x]).Precio_unidad * ((Producto)listacarrito[x]).Stock;

                     string total = (abonar + Convert.ToDecimal(txt_pesos.Text)).ToString();
                     txt_pesos.Text = (Convert.ToDecimal(Math.Round(Convert.ToDecimal(total), 2))).ToString();
                     bdd_carrito[4, x].Value = abonar;
                     // bdd_print[3, x].Value = abonar;
      

                 }
                 for (int x = 0; x < listacarrito_nuevo.Count; x++)
                 {



                     abonar = ((Producto)listacarrito_nuevo[x]).Precio_unidad * ((Producto)listacarrito_nuevo[x]).Stock;

                     string total = (abonar + Convert.ToDecimal(txt_pesos.Text)).ToString();
                     txt_pesos.Text = (Convert.ToDecimal(Math.Round(Convert.ToDecimal(total), 2))).ToString();
                     bdd_carrito[4, x].Value = abonar;
                     // bdd_print[3, x].Value = abonar;
            

                 }

             }*/
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_codigo2.Text != "")
            {
                if (txt_codigo2.Text != " ")
                {
                    if (txt_codigo2.Text != "  ")
                    {
                        agregar(txt_codigo2.Text);
                    }
                }
            }
        }
        //funcion del boton agregar
        public void agregar(string codigo)
        {

            decimal abonar = 0;
            bool existe = false;

            //verifica si el producto ya existe en el carrito
            for (int x = 0; x < listacarrito.Count; x++)
            {
                if (codigo == ((Producto)listacarrito[x]).Codigo)
                {

                    MessageBox.Show(this, "Ya se agregó un producto similar", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    existe = true;
                }
            }

            //incia si no ya se agrego al carrito
            if (existe == false)
            {
                for (int i = 0; i < listaInicial.Count; i++)
                { 
                    //verifica si el producto existe, lo agrega al array de carrito y se muestra en el datagrid
                    if (codigo == ((Producto)listaInicial[i]).Codigo)
                    {
                        Producto p = new Producto();
                        p = (Producto)listaInicial[i];
                       
                        Producto_Datos pd = new Producto_Datos(p, true);
                        pd.ShowDialog();

                       
                        if (producto_agregar.Count == 1)
                        {
                            p = (Producto)producto_agregar[0];
                      
                            bdd_carrito.Rows.Add(p.Codigo, p.Detalle, p.Stock, p.Precio_unidad, p.Total);
              
                            listacarrito.Add(p);

                            producto_agregar.Clear();

                            //calcula el abono
                            abonar = p.Precio_unidad * p.Stock;

                            decimal total = abonar + Convert.ToDecimal(txt_pesos.Text);
                            txt_pesos.Text = (Convert.ToDecimal(Math.Round(total, 2))).ToString();

                            bdd_carrito[4, bdd_carrito.Rows.Count - 2].Value = abonar;
                        }
                        existe_producto = true;
                    }

                }
               //es un nuevo producto, lo agrga al array de productos, también lo agrega al array de carrito y se muestra en el datagrid
                if (existe_producto == false)
                {

                    DialogResult dr = MessageBox.Show(this, "¿Este producto no está en el stock, desea dar de alta?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Producto p = new Producto();
                        p.Codigo = txt_codigo2.Text;
                        Producto_Datos pd = new Producto_Datos(p);
                        pd.ShowDialog();
                        if (producto_agregar_nuevo.Count == 1)
                        {
                            p = (Producto)producto_agregar_nuevo[0];
                            //   p.Stock = Convert.ToInt32(txt_cantidad.Text);
                            bdd_carrito.Rows.Add(p.Codigo, p.Detalle, p.Stock, p.Precio_unidad, p.Total);
                            //bdd_print.Rows.Add(p.Stock, p.Detalle, p.Total);
                            listacarrito_nuevo.Add(p);
                            producto_agregar_nuevo.Clear();
                            abonar = p.Precio_unidad * p.Stock;

                            decimal total = abonar + Convert.ToDecimal(txt_pesos.Text);
                            txt_pesos.Text = (Convert.ToDecimal(Math.Round(total, 2))).ToString();

                            bdd_carrito[4, bdd_carrito.Rows.Count - 2].Value = abonar;

                        }
                    }
                    else
                    {

                    }

                }
            }
            existe = false;
            txt_codigo2.Text = "";

            txt_codigo2.Focus();
            //calcular();
            existe_producto = false;
            //calcular();

        }

        //inicia cuando se aprenta el botón guardar
        private void btn_no_imprimir_Click(object sender, EventArgs e)
        {
            bool continuar = true;
            //verifica si la facura esta vacia
            if (txt_num_factura.Text == "" || txt_num_factura.Text == " ")
            {
                DialogResult dr = MessageBox.Show(this, "No se ha introducido un número de factura, ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    continuar = true;
                }
                if (dr == DialogResult.No)
                {
                    continuar = false;

                }
            }
            //continua si se habilita por el usuarui
            if (continuar == true)
            {

                if (listacarrito.Count > 0 || listacarrito_nuevo.Count > 0)
                {

                    // verifico si el cliente es nuevo 
                    if (cbox_proveedor.SelectedItem == null)
                    {
                        Pais pa = new Pais();

                        Proveedor pro = new Proveedor(cbox_proveedor.Text, " ", " ", " ", " ", DatosPais.obtener_id_pais_maximo(), 0, " ", pa);
                        DatosProveedor.NuevoProveedor(pro);
                        id_proveedor = DatosProveedor.obtener_id_proveedor_maximo();



                    }
                    //verifico si hay un cliente seleccionado en el cbox_cliente
                    else
                    {
                        id_proveedor = ((Proveedor)cbox_proveedor.SelectedItem).Id_proveedor;

                    }

                    Int64 id_compra;
                    string tipo;
                    string estado;
                    if (cbox_tipo_factura.SelectedIndex == 0)
                    {
                        tipo = "Contado";
                        estado = "Pago";

                    }
                    else
                    {
                        tipo = "Credito";
                        estado = "Debe";
                    }
                    Compra c = new Compra(0, id_proveedor, DateTime.Today, date_fecha.Value, date_vencimiento.Value, tipo, txt_num_factura.Text, estado, Convert.ToDecimal(txt_pesos.Text));
                    DatosCompra.NuevaCompra(c);


                    // obtengo el id max de venta
                    try
                    {
                        id_compra = DatosCompra.obtener_id_compra();
                    }
                    catch
                    {
                        id_compra = 0;

                    }


                    //recorre el array de carrito para registrar la compra en la base de datos, también modifica el stock del  producto
                    for (int i = 0; i < listacarrito.Count; i++)
                    {
                        Compra_Producto cp = new Compra_Producto(0, id_compra, ((Producto)listacarrito[i]).Id_producto, ((Producto)listacarrito[i]).Precio_unidad, ((Producto)listacarrito[i]).Stock);
                        DatosCompra_Producto.NuevaCompraProducto(cp);

                        for (Int32 h = 0; h < listaInicial.Count; h++)
                        {
                            if (((Producto)listacarrito[i]).Id_producto == ((Producto)listainicial2[h]).Id_producto)
                            {
                                ((Producto)listacarrito[i]).Stock = ((Producto)listainicial2[h]).Stock + ((Producto)listacarrito[i]).Stock;
                                DatosProducto.ModificarProducto((Producto)listacarrito[i]);

                            }
                        }
                    }
                    for (int i = 0; i < listacarrito_nuevo.Count; i++)
                    {


                        DatosProducto.NuevoProducto((Producto)listacarrito_nuevo[i]);
                        Int64 id_producto = DatosProducto.obtener_idMax_producto();
                        Compra_Producto cp = new Compra_Producto(0, id_compra, id_producto, ((Producto)listacarrito_nuevo[i]).Precio_unidad, ((Producto)listacarrito_nuevo[i]).Stock);
                        DatosCompra_Producto.NuevaCompraProducto(cp);

                    }
                    this.Close();
                }
                else
                {

                    MessageBox.Show(this, "No hay items para dar de alta", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_codigo2.Focus();
                }
            }

            /*else {
                txt_num_factura.Focus();
            
            }*/
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

   
    }
}
