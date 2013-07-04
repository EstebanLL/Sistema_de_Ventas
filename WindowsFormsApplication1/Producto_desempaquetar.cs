using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SistemaDeGestion.Datos;
using SistemaDeGestion.Clases;
namespace SistemaDeGestion
{
    public partial class Producto_desempaquetar : Form
    {
        Producto caja = new Producto();
        Producto pro = new Producto();
        bool caja_listo = false;
        bool producto_listo = false;
        public Producto_desempaquetar()
        {
            InitializeComponent();
        }

        private void btn_caja_buscar_Click(object sender, EventArgs e)
        {
            if (txt_codigo_caja.Text != "")
            {
                caja = DatosProducto.getProducto_por_id(txt_codigo_caja.Text);
                
                    txt_caja_descripcion.Text = caja.Detalle;
                    if (txt_caja_descripcion.Text == "")
                    {

                        MessageBox.Show(this, "Código incorrecto, intente con un nuevo código", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        caja_listo = false;
                        txt_codigo_caja.SelectAll();
                        txt_codigo_caja.Focus();
                        this.AcceptButton = btn_caja_buscar;
                    }
                    else
                    {
                        caja_listo = true;
                    
                    
                    }
                    validar();
            }
        }
        public void validar() {
            if (caja_listo == true && producto_listo == true)
            {

                btn_guardar.Enabled = true;
            }
            else
            {
                btn_guardar.Enabled = false;
            }
        
        }

        private void txt_codigo_caja_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btn_caja_buscar;
        }

        private void txt_codigo_caja_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btn_caja_buscar;
        }

        private void txt_caja_cantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txt_caja_cantidad.Text) < 0)
                {


                    txt_caja_cantidad.Text = "1";
                    txt_caja_cantidad.SelectAll();

                }
            }
            catch
            {
                txt_caja_cantidad.Text = "1";
                txt_caja_cantidad.SelectAll();
            }
        }

        private void txt_producto_codigo_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btn_caja_buscar;
        }

        private void txt_producto_cantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txt_producto_cantidad.Text) < 0)
                {


                    txt_producto_cantidad.Text = "1";
                    txt_producto_cantidad.SelectAll();

                }
            }
            catch
            {
                txt_producto_cantidad.Text = "1";
                txt_producto_cantidad.SelectAll();
            }
        }

        private void btn_producto_buscar_Click(object sender, EventArgs e)
        {
            if (txt_producto_codigo.Text != "")
            {
                pro = DatosProducto.getProducto_por_id(txt_producto_codigo.Text);

                txt_producto_descripcion.Text = pro.Detalle;
                if (txt_producto_descripcion.Text == "")
                {

                    MessageBox.Show(this, "Código incorrecto, intente con un nuevo código", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    producto_listo = false;
                    txt_producto_codigo.SelectAll();
                    txt_producto_codigo.Focus();
                    this.AcceptButton = btn_producto_buscar;
                }
                else
                {
                    producto_listo = true;


                }
                validar();
            }
        }

        private void txt_codigo_caja_DragEnter(object sender, DragEventArgs e)
        {
            this.AcceptButton = btn_producto_buscar;
        }

        private void txt_producto_codigo_DragEnter(object sender, DragEventArgs e)
        {
            this.AcceptButton = btn_producto_buscar;
        }

        private void txt_producto_codigo_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btn_producto_buscar;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            caja.Stock = caja.Stock - Convert.ToInt32(txt_caja_cantidad.Text);
            pro.Stock = pro.Stock + Convert.ToInt32(txt_producto_cantidad.Text);
            DatosProducto.CambiarStock(caja.Id_producto, caja.Stock);
            DatosProducto.CambiarStock(pro.Id_producto, pro.Stock);
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
