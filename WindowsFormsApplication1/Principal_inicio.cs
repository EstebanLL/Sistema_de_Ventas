using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaDeGestion.Clases;

using System.Collections;

namespace SistemaDeGestion
{
    public partial class Principal_inicio : Form
    {
        ArrayList listafacturas = new ArrayList();
        ArrayList listaclientes = new ArrayList();
        ArrayList listaproductos = new ArrayList();
        Caja cj = new Caja();
        Clases.Configuracion_factura factura = new Clases.Configuracion_factura();
        bool ya_existe;
        public Principal_inicio(bool ya_existe)
        {
            InitializeComponent();
            label_usuario.Text = Principal.usuario;
            label_fecha.Text = DateTime.Today.ToShortDateString();
            txt_real.Text = (Datos.Conex.contizacion_real()).ToString();
            factura = Datos.Conex.traer_datos_facturas();
            txt_factura_numero.Text = factura.Factura_numero_dato.ToString();
            txt_factura_prefijo.Text = factura.Factura_Prefijo_dato;
            txt_venta_prefijo.Text = factura.Venta_Prefijo_dato;
            txt_venta_numero.Text = factura.Venta_numero_dato.ToString();
            if (ya_existe == true)
            {
                cj = Datos.Datos_Caja.get_caja_por_fecha(DateTime.Today);
                txt_monto.Text = cj.Monto.ToString();
            }
            else
            {

                cj.Fecha = DateTime.Today.Date;
            }
            this.ya_existe = ya_existe;
            cumples();
            productos_stock();
            facturas();
            if (Principal.test_mode == true) {
                label14.Visible = true;
                label_productos_stock.Visible = true;
                btn_ver_productos.Visible = true;
            
            }
        }
        public void facturas() {
            int facturas = 0;
            string buscar = "and " + DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year + " >= c.fecha_vencimiento and c.estado like '%Debe%'";
            listafacturas = Datos.DatosCompra.getCompras_Vencidad();
            // tets
            for (int i = 0; i < listafacturas.Count; i++)
            {

                facturas++;


            }
            if (facturas == 0)
            {
                btn_facturas_vencidas.Enabled = false;
            }
            label_facturas_vencidas.Text = facturas.ToString();
        }
        public void cumples() {
            int cumples = 0;
            listaclientes = Datos.DatosCliente.getClientes("");
            for (int i = 0; i < listaclientes.Count; i++) {

                if (((Cliente)listaclientes[i]).Nacimiento.Day == DateTime.Today.Day && ((Cliente)listaclientes[i]).Nacimiento.Month == DateTime.Today.Month) {

                    cumples = cumples + 1;
                }
            
            }
            if (cumples == 0) {
                btn_ver_clientes.Enabled = false;
            }
            label_clientes_aniversario.Text = cumples.ToString();
        
        }
        public void productos_stock()
        {

            int productos = 0;

            listaproductos = Datos.DatosProducto.getProductosBuscarModelo("");
            for (int i = listaproductos.Count; i > 0; i--)
            {
                if (((Producto)listaproductos[i - 1]).Stock > ((Producto)listaproductos[i - 1]).Stock_min)
                {

                    listaproductos.RemoveAt(i - 1);

                }
                else
                {

                    productos++;
                }
            }
         label_productos_stock.Text = productos.ToString();

        if (productos == 0) { btn_ver_productos.Enabled = false;}
            
                 

        }
        private void Principal_inicio_Load(object sender, EventArgs e)
        {

        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (ya_existe == false)
            {

                Datos.Datos_Caja.NuevaCaja(Convert.ToDecimal(txt_monto.Text));

            }
            this.Close();
        }
        public bool guarda = false;
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Principal.real = Convert.ToDecimal(txt_real.Text);
            Datos.Conex.Modificar_Cotizacion_REAL(Convert.ToDecimal(txt_real.Text));
            factura.Venta_Prefijo_dato = txt_venta_prefijo.Text;
            factura.Venta_numero_dato = Convert.ToInt64(txt_venta_numero.Text);
            factura.Factura_Prefijo_dato = txt_factura_prefijo.Text;
            factura.Factura_numero_dato = Convert.ToInt64(txt_factura_numero.Text);
            cj.Monto = Math.Round(Convert.ToDecimal(txt_monto.Text),2);
            if (ya_existe == true)
            {

                Datos.Datos_Caja.ModificarCaja(cj);

            }
            else
            {
                Datos.Datos_Caja.NuevaCaja(Math.Round(Convert.ToDecimal(txt_monto.Text),2));
            }
            guarda = true;
            Datos.Conex.Modificar_Factura(factura);
            this.Close();
        }

        private void Principal_inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (guarda == false)
            {
                if (ya_existe == false)
                {

                    Datos.Datos_Caja.NuevaCaja(Convert.ToDecimal(txt_monto.Text));

                }
            }
        }

        private void txt_monto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txt_monto.Text) < 0)
                {


                    txt_monto.Text = "0";
                    txt_monto.SelectAll();

                }
            }
            catch
            {
                txt_monto.Text = "0";
                txt_monto.SelectAll();
            }
        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                // si se pulsa en el punto se convertirá en coma
                e.Handled = true;
                SendKeys.Send(",");
            }
        }

        private void txt_real_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                // si se pulsa en el punto se convertirá en coma
                e.Handled = true;
                SendKeys.Send(",");
            }
        }

        private void txt_real_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txt_real.Text) < 0)
                {


                    txt_real.Text = "0";
                    txt_real.SelectAll();

                }
            }
            catch
            {
                txt_real.Text = "0";
                txt_real.SelectAll();
            }
        }

        private void txt_venta_numero_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txt_venta_numero.Text) < 0)
                {


                    txt_venta_numero.Text = "0";
                    txt_venta_numero.SelectAll();

                }
            }
            catch
            {
                txt_venta_numero.Text = "0";
                txt_venta_numero.SelectAll();
            }
        }

        private void txt_factura_numero_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txt_factura_numero.Text) < 0)
                {


                    txt_factura_numero.Text = "0";
                    txt_factura_numero.SelectAll();

                }
            }
            catch
            {
                txt_factura_numero.Text = "0";
                txt_factura_numero.SelectAll();
            }
        }

        private void btn_ver_clientes_Click(object sender, EventArgs e)
        {
            Cliente_Admin ca = new Cliente_Admin(true);
            ca.ShowDialog();
        }

        private void btn_ver_productos_Click(object sender, EventArgs e)
        {
            Producto_Admin pa = new Producto_Admin(true);
            pa.ShowDialog();
        }

        private void btn_facturas_vencidas_Click(object sender, EventArgs e)
        {
            Compra_Listado cl = new Compra_Listado(true);
            cl.ShowDialog();
        }

        private void btn_ver_clientes_Click_1(object sender, EventArgs e)
        {
            Cliente_Admin ca = new Cliente_Admin(true);
            ca.ShowDialog();
        }

        private void btn_ver_productos_Click_1(object sender, EventArgs e)
        {
            Producto_Admin pa = new Producto_Admin(true);
            pa.ShowDialog();
        }

        private void btn_facturas_vencidas_Click_1(object sender, EventArgs e)
        {
            Compra_Listado cl = new Compra_Listado(true);
            cl.ShowDialog();
        }

     

    }
}
