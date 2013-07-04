using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaDeGestion
{
    public partial class Configuracion_Factura : Form
    {
   

        Clases.Configuracion_factura cf = new Clases.Configuracion_factura(); 
        public Configuracion_Factura()
        {
            InitializeComponent();
            cf = Datos.Conex.traer_datos_facturas();
            txt_fecha_x.Text = cf.Fecha_X.ToString();
            txt_fecha_y.Text = cf.Fecha_Y.ToString();
            txt_rut_x.Text = cf.Rut_X.ToString();
            txt_rut_y.Text = cf.Rut_y.ToString();
            txt_c_final_x.Text = cf.C_Final_X.ToString();
            txt_c_final_y.Text = cf.C_Final_Y.ToString();
            txt_datos_x.Text = cf.Datos_x.ToString();
            txt_datos_y.Text = cf.Datos_y.ToString();
            txt_xx.Text = cf.Xx.ToString();
            txt_yy.Text = cf.Yy.ToString();
            txt_datos_yy.Text = cf.Datos_YY.ToString();
            txt_cantidad_x.Text = cf.Cantidad_X.ToString();
            txt_detalle_x.Text = cf.Detalle_X.ToString();
            txt_precio_x.Text = cf.Precio_X.ToString();
            txt_importe_x.Text = cf.Importe_X.ToString();
            txt_subtotal_x.Text = cf.Subtotal_X.ToString();
            txt_subtotal_y.Text = cf.SubTotal_y.ToString();
            txt_iva_x.Text = cf.Iva_X.ToString();
            txt_iva_y.Text = cf.Iva_Y.ToString();
            txt_total_x.Text = cf.Total_x.ToString();
            txt_total_y.Text = cf.Total_y.ToString();
            txt_tamano.Text = cf.Tamano.ToString();
            txt_fuente.Text = cf.Fuente;
            txt_items_max.Text = cf.Items_max.ToString();
            txt_ventax.Text = cf.Venta_numero_x.ToString();
            txt_ventay.Text = cf.Venta_numero_y.ToString();
            txt_factura_x.Text = cf.Factura_numero_x.ToString();
            txt_factura_y.Text = cf.Factura_numero_y.ToString();
            txt_observaciones_x.Text = cf.Observaciones_x.ToString();
            txt_observaciones_y.Text = cf.Observaciones_y.ToString();
            txt_tipo_x.Text = cf.Tipo_x.ToString();
            txt_tipo_y.Text = cf.Tipo_y.ToString();
            chk_factura_n_imprimir.Checked = cf.Factura_numero_imprime;
            chk_obsrvaciones_imprimir.Checked = cf.Observaciones_imprime;
            chk_tipo_imprimir.Checked = cf.Tipo_imprime;
            chk_duplicar_en_hoja.Checked = cf.Duplica_en_hoja;
            txt_duplicar_en_hoja_distancia.Text = cf.Duplica_en_hoja_distancia.ToString();
            txt_nombre_comercio.Text = cf.Comercio_nombre;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                cf.Fecha_X = Convert.ToInt32(txt_fecha_x.Text);
                cf.Fecha_Y = Convert.ToInt32(txt_fecha_y.Text);
                cf.Rut_X = Convert.ToInt32(txt_rut_x.Text);
                cf.Rut_y = Convert.ToInt32(txt_rut_y.Text);
                cf.C_Final_X = Convert.ToInt32(txt_c_final_x.Text);
                cf.C_Final_Y = Convert.ToInt32(txt_c_final_y.Text);
                cf.Datos_x = Convert.ToInt32(txt_datos_x.Text);
                cf.Datos_y = Convert.ToInt32(txt_datos_y.Text);
                cf.Datos_YY = Convert.ToInt32(txt_datos_yy.Text);
                cf.Xx = Convert.ToInt32(txt_xx.Text);
                cf.Yy = Convert.ToInt32(txt_yy.Text);
                cf.Cantidad_X = Convert.ToInt32(txt_cantidad_x.Text);
                cf.Detalle_X = Convert.ToInt32(txt_detalle_x.Text);
                cf.Precio_X = Convert.ToInt32(txt_precio_x.Text);
                cf.Importe_X = Convert.ToInt32(txt_importe_x.Text);
                cf.Subtotal_X = Convert.ToInt32(txt_subtotal_x.Text);
                cf.SubTotal_y = Convert.ToInt32(txt_subtotal_y.Text);
                cf.Iva_X = Convert.ToInt32(txt_iva_x.Text);
                cf.Iva_Y = Convert.ToInt32(txt_iva_y.Text);
                cf.Total_x = Convert.ToInt32(txt_total_x.Text);
                cf.Total_y = Convert.ToInt32(txt_total_y.Text);
                cf.Tamano = Convert.ToInt32(txt_tamano.Text);
                cf.Fuente = txt_fuente.Text;
                cf.Items_max = Convert.ToInt32(txt_items_max.Text);
                cf.Venta_numero_x = Convert.ToInt32(txt_ventax.Text);
                cf.Venta_numero_y = Convert.ToInt32(txt_ventay.Text);
                cf.Factura_numero_x = Convert.ToInt32(txt_factura_x.Text);
                cf.Factura_numero_y = Convert.ToInt32(txt_factura_y.Text);
                cf.Observaciones_x = Convert.ToInt32(txt_observaciones_x.Text);
                cf.Observaciones_y = Convert.ToInt32(txt_observaciones_y.Text);
                cf.Tipo_x = Convert.ToInt32(txt_tipo_x.Text);
                cf.Tipo_y = Convert.ToInt32(txt_tipo_y.Text);
                cf.Factura_numero_imprime = chk_factura_n_imprimir.Checked;
                cf.Observaciones_imprime = chk_obsrvaciones_imprimir.Checked;
                cf.Tipo_imprime = chk_tipo_imprimir.Checked;
                cf.Duplica_en_hoja = chk_duplicar_en_hoja.Checked;
                cf.Duplica_en_hoja_distancia = Convert.ToInt32(txt_duplicar_en_hoja_distancia.Text);
                cf.Comercio_nombre = txt_nombre_comercio.Text;
                Datos.Conex.Modificar_Datos_Factura(cf);
                this.Close();
            }
            catch
            {

                MessageBox.Show(this, "Existe(n) dato(s) incocorrecto(s), por favor revisar campos", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
           // grp_fecha.Location = new System.Drawing.Point(Convert.ToInt32(Principal);
            Configuracion_Factura_Info cfi = new Configuracion_Factura_Info();
            cfi.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void chk_factura_n_imprimir_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_factura_n_imprimir.Checked == false)
            {

                txt_factura_x.ReadOnly = true;
                txt_factura_y.ReadOnly = true;
            }
            else
            {
                txt_factura_x.ReadOnly = false;
                txt_factura_y.ReadOnly = false;
            }
        }

        private void chk_obsrvaciones_imprimir_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_obsrvaciones_imprimir.Checked == false)
            {

                txt_observaciones_x.ReadOnly = true;
                txt_observaciones_y.ReadOnly = true;
            }
            else
            {
                txt_observaciones_x.ReadOnly = false;
                txt_observaciones_y.ReadOnly = false;
            }
        }

        private void chk_tipo_imprimir_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_tipo_imprimir.Checked == false)
            {

                txt_tipo_x.ReadOnly = true;
                txt_tipo_y.ReadOnly = true;
            }
            else
            {
                txt_tipo_x.ReadOnly = false;
                txt_tipo_y.ReadOnly = false;
            }
        }

        private void chk_duplicar_en_hoja_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_duplicar_en_hoja.Checked == false)
            {

                txt_duplicar_en_hoja_distancia.ReadOnly = true;
               
            }
            else
            {
                txt_duplicar_en_hoja_distancia.ReadOnly = false;
                
            }
        }


    }
}
