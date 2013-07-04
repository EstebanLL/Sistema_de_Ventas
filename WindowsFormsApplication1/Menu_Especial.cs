using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using SistemaDeGestion.Clases;
using SistemaDeGestion.Datos;

using System.Diagnostics;
using System.ComponentModel;


namespace SistemaDeGestion
{
    public partial class Menu_Especial : Form
    {
        Producto pro = new Producto();
        ArrayList lista_ventas = new ArrayList();
        ArrayList lista_compras = new ArrayList();
        public Menu_Especial()
        {
            InitializeComponent();
        }

        private void btn_borrar_producto_Click(object sender, EventArgs e)
        {
            pro = DatosProducto.getProducto_por_id(txt_codigo.Text);
            if (pro.Detalle != null)
            {
                DialogResult dr = MessageBox.Show(this, "¿Desea dar de baja ´ " + pro.Detalle + " ´ ?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    DatosProducto.setBajaProducto(txt_codigo.Text);
                }
            }
        }

        private void btn_borrar_ventas_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "¿Desea dar de baja todos los pedidos?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                lista_ventas = Datos.DatosVenta_Producto.getVenta_Producto_no_impreso_todos();
                for (int i = 0; i < lista_ventas.Count; i++)
                {

                    DatosVenta.setBajaVenta(((Venta_Producto)lista_ventas[i]).Id_venta);
                    DatosVenta_Producto.setBajaVenta_producto(((Venta_Producto)lista_ventas[i]).Id_venta);

                }


            }


        }

        private void btn_borrar_compras_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "¿Desea dar de baja compras con facturas sin numero ?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {






                lista_compras = Datos.DatosCompra.getCompras("and c.numero_factura like ''");
                for (int i = 0; i < lista_compras.Count; i++)
                {
                    DatosCompra.setBajaCompra(((Compra)lista_compras[i]).Id_compra);
                    DatosCompra_Producto.setBajaCompra_producto(((Compra)lista_compras[i]).Id_compra);


                }
            }
        }
    }
}
