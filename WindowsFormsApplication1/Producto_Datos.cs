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
    public partial class Producto_Datos : Form
    {
        Producto pro = new Producto();
        bool modificar;
        bool carga;
        bool alta;
        // incializa carga simples
        public Producto_Datos()
        {
            InitializeComponent();
            Cargarcategorias();
            txt_codigo.Focus();
            cbox_categoria.SelectedIndex = 0;

            if (Principal.test_mode == true)
            {
                txt_stock.Visible = true;
                label6.Visible = true;
                txt_cantidad.ReadOnly = false;
            }

        }

        //incializa carga cuando le pasan el objeto producto
        public Producto_Datos(object prod)
        {
            InitializeComponent();
            Cargarcategorias();

            cbox_categoria.SelectedIndex = 0;
            this.pro = (Producto)prod;
            txt_codigo.Text = pro.Codigo;

            alta = true;
            txt_codigo.ReadOnly = true;
            if (Principal.test_mode == true)
            {
                txt_stock.Visible = true;
                label6.Visible = true;
                txt_cantidad.ReadOnly = false;
            }
            txt_cantidad.Focus();
        }
        //incializa la carga cuando le pasan el objeto producto y si es carga o no
        public Producto_Datos(object prod, bool carga)
        {

            InitializeComponent();
            //verifica si es no es una carga
            if (carga == false)
            {
                txt_cantidad.Enabled = true;

                //verifica si está es testmode
                if (Principal.test_mode == false)
                {
                    txt_cantidad.Visible = false;
                    label8.Visible = false;
                }

            } if (Principal.test_mode == true)
            {
                txt_stock.Visible = true;
                label6.Visible = true;
                txt_cantidad.ReadOnly = false;
                txt_minimo.Visible = true;
            }
            Cargarcategorias();
            this.pro = (Producto)prod;
            modificar = true;
            txt_codigo.Text = pro.Codigo;
            txt_descripcion.Text = pro.Detalle;
            txt_stock.Text = pro.Stock.ToString();
            txt_minimo.Text = pro.Stock_min.ToString();
            txt_precio_unidad.Text = pro.Precio_unidad.ToString();
            txt_iva.Text = pro.Iva.ToString();
            txt_margen_1.Text = pro.Margen.ToString();
            txt_total.Text = pro.Total.ToString();
            txt_ruta_imagen.Text = pro.Imagen;
            if (pro.Imagen != " ")
            {
                try
                {
                    pbox_imagen.Image = Image.FromFile(txt_ruta_imagen.Text);
                    label_imagen_no_disponible.Visible = false;
                }
                catch
                {
                    label_imagen_no_disponible.Visible = true;
                    pbox_imagen.Visible = false;
                }
            }
            chk_imagen_categoria.Checked = pro.Imagen_categoria;
            this.Text = "Modificar Producto";
            this.carga = carga;
            cbox_categoria.Text = pro.Cate.Nombre;
            txt_codigo.ReadOnly = true;
            txt_cantidad.Focus();


        }

        //carga las categorias a el combo box categorias
        private void Cargarcategorias()
        {

            ArrayList categorias = new ArrayList();
            categorias = DatosCategoria.getCategorias();
            cbox_categoria.DataSource = categorias;
            cbox_categoria.DisplayMember = "Nombre";
            cbox_categoria.ValueMember = "Id_categoria";
            cbox_categoria.Refresh();

        }

        //funcion cuando se hace clic en el boton guardar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // verifica si tiene descripcion
            if (txt_codigo.Text != "" || txt_descripcion.Text != "")
            {
                //verifica si no es una alta
                if (alta == false)
                {
                    //verifica si el precio es mayor a 0
                    if (Convert.ToDecimal(txt_total.Text) > 0)
                    {
                        //verifica si no es una modificacion
                        if (modificar == false)
                        {

                            Categoria cate = new Categoria(((Categoria)cbox_categoria.SelectedItem).Nombre, ((Categoria)cbox_categoria.SelectedItem).Id_categoria, ((Categoria)cbox_categoria.SelectedItem).Imagen);

                            Producto pro = new Producto(0, txt_codigo.Text.ToString(), txt_descripcion.Text.ToString(), Convert.ToDecimal(txt_precio_unidad.Text), Convert.ToDecimal(txt_iva.Text), Convert.ToDecimal(txt_total.Text), Convert.ToDecimal(txt_margen_1.Text), Convert.ToInt32(txt_cantidad.Text), Convert.ToInt32(txt_minimo.Text), cate);
                            if (chk_imagen_categoria.Checked == true)
                            {

                                pro.Imagen_categoria = true;
                                pro.Imagen = " ";

                            }
                            else
                            {
                                pro.Imagen_categoria = false;
                                pro.Imagen = txt_ruta_imagen.Text;
                            }
                            DatosProducto.NuevoProducto(pro);
                        }
                            //verifica si es una modificacion de un producto ya existente
                        else if (modificar == true && carga == false)
                        {

                            Categoria cate = new Categoria(((Categoria)cbox_categoria.SelectedItem).Nombre, ((Categoria)cbox_categoria.SelectedItem).Id_categoria, ((Categoria)cbox_categoria.SelectedItem).Imagen);

                            int cantidad = Convert.ToInt32(txt_cantidad.Text) + Convert.ToInt32(txt_stock.Text);
                            Producto prod = new Producto(pro.Id_producto, txt_codigo.Text.ToString(), txt_descripcion.Text.ToString(), Convert.ToDecimal(txt_precio_unidad.Text), Convert.ToDecimal(txt_iva.Text), Convert.ToDecimal(txt_total.Text), Convert.ToDecimal(txt_margen_1.Text), cantidad, Convert.ToInt32(txt_minimo.Text), cate);


                            if (chk_imagen_categoria.Checked == true)
                            {

                                prod.Imagen_categoria = true;
                                prod.Imagen = " ";

                            }
                            else
                            {
                                prod.Imagen_categoria = false;
                                prod.Imagen = txt_ruta_imagen.Text;
                            }
                            DatosProducto.ModificarProducto(prod);

                        }
                        // agrega al carrito de alta de un producto un producto ya existente
                        else if (modificar == true && carga == true)
                        {
                            Categoria cate = new Categoria(((Categoria)cbox_categoria.SelectedItem).Nombre, ((Categoria)cbox_categoria.SelectedItem).Id_categoria, ((Categoria)cbox_categoria.SelectedItem).Imagen);

                            Producto prod = new Producto(pro.Id_producto, txt_codigo.Text.ToString(), txt_descripcion.Text.ToString(), Convert.ToDecimal(Math.Round(Convert.ToDecimal(txt_precio_unidad.Text), 2)), Convert.ToDecimal(txt_iva.Text), Convert.ToDecimal(txt_total.Text), Convert.ToDecimal(txt_margen_1.Text), Convert.ToInt32(txt_cantidad.Text), Convert.ToInt32(txt_minimo.Text), cate);
                            if (chk_imagen_categoria.Checked == true)
                            {

                                prod.Imagen_categoria = true;
                                prod.Imagen = " ";

                            }
                            else
                            {
                                prod.Imagen_categoria = false;
                                prod.Imagen = txt_ruta_imagen.Text;
                            }
                            Producto_Alta.producto_agregar.Add(prod);

                        }
                    }
                }
                else
                {

                    Categoria cate = new Categoria(((Categoria)cbox_categoria.SelectedItem).Nombre, ((Categoria)cbox_categoria.SelectedItem).Id_categoria, ((Categoria)cbox_categoria.SelectedItem).Imagen);

                    Producto prod = new Producto(0, txt_codigo.Text.ToString(), txt_descripcion.Text.ToString(), Convert.ToDecimal(Math.Round(Convert.ToDecimal(txt_precio_unidad.Text), 2)), Convert.ToDecimal(txt_iva.Text), Convert.ToDecimal(txt_total.Text), Convert.ToDecimal(txt_margen_1.Text), Convert.ToInt32(txt_cantidad.Text), Convert.ToInt32(txt_minimo.Text), cate);
                    if (chk_imagen_categoria.Checked == true)
                    {

                        prod.Imagen_categoria = true;
                        prod.Imagen = " ";

                    }
                    else
                    {
                        prod.Imagen_categoria = false;
                        prod.Imagen = txt_ruta_imagen.Text;
                    }
                    Producto_Alta.producto_agregar_nuevo.Add(prod);
                }
                this.Close();

            }
            else
            {


                MessageBox.Show(this, "Debe ingresar un código y una descripción válida", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (txt_codigo.Text == "")
                {
                    txt_codigo.Focus();
                }
                else
                {
                    txt_descripcion.Focus();
                }
            }
        }
        public void calcular()
        {
            decimal precio_unidad = Convert.ToDecimal(txt_precio_unidad.Text);
            decimal iva = Convert.ToDecimal(txt_iva.Text);


            txt_iva_2.Text = ((precio_unidad / 100) * iva).ToString();
            txt_precio_con_iva.Text = (Convert.ToDecimal(txt_iva_2.Text) + precio_unidad).ToString();
            decimal margen = Convert.ToDecimal(txt_margen_1.Text);
            txt_margen_2.Text = ((Convert.ToDecimal(txt_precio_con_iva.Text) / 100) * margen).ToString();
            txt_total.Text = (Convert.ToDecimal(Math.Round(Convert.ToDecimal(txt_precio_con_iva.Text) + Convert.ToDecimal(txt_margen_2.Text), 2))).ToString();

        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {
            if (modificar == false)
            {
                try
                {
                    if (Convert.ToInt32(txt_cantidad.Text) < 0)
                    {


                        txt_cantidad.Text = "1";
                        txt_cantidad.SelectAll();

                    }
                }
                catch
                {
                    txt_cantidad.Text = "1";
                    txt_cantidad.SelectAll();
                }
            }
            else
            {
                try
                {
                    if (Convert.ToInt32(txt_cantidad.Text) < -0)
                    {


                        txt_cantidad.Text = "0";
                        txt_cantidad.SelectAll();

                    }
                }
                catch
                {
                    txt_cantidad.Text = "0";
                    txt_cantidad.SelectAll();
                }
            }
        }

        private void txt_minimo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txt_minimo.Text) < 0)
                {


                    txt_minimo.Text = "0";

                }
            }
            catch
            {
                txt_minimo.Text = "0";
            }
        }

        private void txt_precio_unidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txt_precio_unidad.Text) < 0)
                {


                    txt_precio_unidad.Text = "0";
                    txt_precio_unidad.SelectAll();

                }
            }
            catch
            {
                txt_precio_unidad.Text = "0";
                txt_precio_unidad.SelectAll();
            }

            calcular();

        }

        private void txt_iva_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txt_iva.Text) < 0)
                {


                    txt_iva.Text = "0";
                    txt_iva.SelectAll();

                }
            }
            catch
            {
                txt_iva.Text = "0";
                txt_iva.SelectAll();

            }
            calcular();
        }

        private void txt_margen_1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txt_margen_1.Text) < 0)
                {


                    txt_margen_1.Text = "0";
                    txt_margen_1.SelectAll();


                }
            }
            catch
            {
                txt_margen_1.Text = "0";
                txt_margen_1.SelectAll();
            }

            calcular();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txt_total.Text) < 0)
                {


                    txt_total.Text = "0";
                    txt_total.SelectAll();

                }

            }
            catch
            {
                txt_total.Text = "0";
                txt_total.SelectAll();
            }

        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            if (modificar == false)
            {


                if (DatosProducto.verificar_codigo(txt_codigo.Text) >= 1)
                {

                    MessageBox.Show(this, "Ya existe un producto con el mismo código", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_codigo.Text = "";
                    txt_codigo.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (open_buscar_imagen.ShowDialog() == DialogResult.OK)
            {

                txt_ruta_imagen.Text = open_buscar_imagen.FileName;
                try
                {
                    pbox_imagen.Image = Image.FromFile(txt_ruta_imagen.Text);

                    pbox_imagen.Visible = true;
                    label_imagen_no_disponible.Visible = false;

                }
                catch
                {
                    label_imagen_no_disponible.Visible = true;
                    pbox_imagen.Visible = false;
                }

            }



        }

        private void chk_imagen_categoria_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_imagen_categoria.Checked == true)
            {

                txt_ruta_imagen.Enabled = false;
                btn_examinar.Enabled = false;
                label_imagen_no_disponible.Visible = true;
                pbox_imagen.Visible = false;
                txt_ruta_imagen.Text = " ";
            }
            else
            {
                txt_ruta_imagen.Enabled = true;
                btn_examinar.Enabled = true;
                label_imagen_no_disponible.Visible = true;
                pbox_imagen.Visible = false;
                txt_ruta_imagen.Text = " ";

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_precio_unidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                // si se pulsa en el punto se convertirá en coma
                e.Handled = true;
                SendKeys.Send(",");
            }
        }

        private void txt_iva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                // si se pulsa en el punto se convertirá en coma
                e.Handled = true;
                SendKeys.Send(",");
            }
        }

        private void txt_margen_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                // si se pulsa en el punto se convertirá en coma
                e.Handled = true;
                SendKeys.Send(",");
            }
        }

        private void txt_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                // si se pulsa en el punto se convertirá en coma
                e.Handled = true;
                SendKeys.Send(",");
            }
        }
    }
}
