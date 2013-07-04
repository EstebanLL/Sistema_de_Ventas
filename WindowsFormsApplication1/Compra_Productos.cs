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
    public partial class Compra_Productos : Form
    {
        Compra c = new Compra();
        ArrayList listacarrito = new ArrayList();
        decimal abonar = 0;
        public Compra_Productos()
        {
            InitializeComponent();
        }
        public Compra_Productos(object compra)
        {
            InitializeComponent();
            c = (Compra)compra;
            txt_num_factura.Text = c.Numero_factura;
            txt_proveedor.Text = c.Dato;
            txt_tipo.Text = c.Tipo;
            date_fecha.Value = c.Fecha_factura;
            date_vencimiento.Value = c.Fecha_vencimiento;
            txt_estado.Text = c.Estado;
           // txt_estado.Font.Style = Color.Red;
            
            listacarrito = DatosCompra_Producto.getCompra_Producto(c.Id_compra);
            bdd_carrito.DataSource = listacarrito;
            for (int x = 0; x < listacarrito.Count; x++)
            {



                abonar = ((Compra_Producto)listacarrito[x]).Precio * ((Compra_Producto)listacarrito[x]).Cantidad;

                string total = (abonar + Convert.ToDecimal(txt_total.Text)).ToString();
                txt_total.Text = (Convert.ToDecimal(Math.Round(Convert.ToDecimal(total), 2))).ToString();
                bdd_carrito[10, x].Value = abonar;
      


            }
            if (c.Estado == "Debe"){
                btn_pagar.Enabled = true;
            
            }
            txt_total_pesos.Text = c.Importe.ToString();
        }
        private void btn_imprimir_Click(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "¿Desea pagar la deuda?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DatosCompra.ModificaCompraPagarDeuda(c);
                txt_estado.Text = "Pago";
                btn_pagar.Enabled = false;
           
            }
        }

        private void Compra_Productos_Load(object sender, EventArgs e)
        {

        }
    }
}
