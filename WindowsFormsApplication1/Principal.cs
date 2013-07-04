using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaDeGestion;
using System.IO;


namespace SistemaDeGestion
{
    public partial class Principal : Form
    {
        public static int validar;
        public static int usuario_valido = 99;
        public static bool existe = false;
        public static string conexion;
        public static bool cerrar_ventana_generar_venta = true;
        public static bool cerrar_ventana_producto_admin = true;
        public static decimal real;
        public static decimal iva;
        public static bool cerrar_venta_no_impresa = true;
        public static string usuario;
        public static bool test_mode = false;
        public Principal()
        {
            leer_txt();
            InitializeComponent();


            Login log = new Login();
            log.ShowDialog();
            loguear();
            try
            {
                real = Datos.Conex.contizacion_real();
                iva = Datos.Conex.traer_iva();
            }
            catch
            {
                MessageBox.Show(this, "Error al leer la base de datos!", "¡Error al iniciar!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            btn_ventas_no_impresas.Visible = true;
        }
        public void loguear()
        {

            if (usuario_valido == 0)
            {
                tabPage4.Enabled = false;
                tabPage3.Enabled = false;
                tabPage2.Enabled = false;
                tabPage1.Enabled = false;

            }
            if (usuario_valido == 2)
            {
                tabPage4.Enabled = false;
                tabPage3.Enabled = false;
                tabPage2.Enabled = false;
                if (Datos.Datos_Caja.get_Contar_caja_por_fecha(DateTime.Today.Date) == 0)
                {
                    Principal_inicio pis = new Principal_inicio(false);
                    pis.ShowDialog();

                }
            }
            if (usuario_valido == 1)
            {

                if (Datos.Datos_Caja.get_Contar_caja_por_fecha(DateTime.Today.Date) == 0)
                {
                    Principal_inicio pis = new Principal_inicio(false);
                    pis.ShowDialog();


                }

            }
            if (usuario_valido == 5)
            {

                if (Datos.Datos_Caja.get_Contar_caja_por_fecha(DateTime.Today.Date) == 0)
                {
                    Principal_inicio pis = new Principal_inicio(false);
                    pis.ShowDialog();

                }
                test_mode = true;
                btn_ventas_no_impresas.Visible = true;
                label4.Visible = true;

            }
            if (usuario_valido == 3)
            {

                tabPage4.Enabled = false;

                if (Datos.Datos_Caja.get_Contar_caja_por_fecha(DateTime.Today.Date) == 0)
                {
                    Principal_inicio pis = new Principal_inicio(false);
                    pis.ShowDialog();

                }
            }

            /* using (StreamWriter w = File.AppendText("C:\\sistemadeventas\\log.txt"))
             {
                 Datos.Conex.Log("Inició sesion ", w);

                 // Close the writer and underlying file.
                 w.Close();
             }*/
            // Open and read the file.

        }



        public void leer_txt()
        {
            try
            {
                StreamReader sr = new StreamReader("c:\\config.ini");


                conexion = sr.ReadLine();

            }
            catch
            {
                MessageBox.Show(this, "Error al intentar leer el archivo de configuracion", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void item_producto_aministrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
           /* try
            {*/
                this.Hide();
                cargar_generar_venta();

                this.Show();

           /* }
            catch (Exception ex)
            {
                Ventana_Error ve = new Ventana_Error(ex);
                ve.ShowDialog();

            }*/
        }
        public void cargar_Prdocuto_admin()
        {
            Producto_Admin pro = new Producto_Admin();

            pro.ShowDialog();
            if (cerrar_ventana_producto_admin == false)
            {
                cerrar_ventana_producto_admin = true;
                cargar_Prdocuto_admin();

            }

        }
        public void cargar_generar_venta()
        {

            Venta_Generar vent = new Venta_Generar();

            vent.ShowDialog();
            vent = null;

            //    GC.Collect();
            if (cerrar_ventana_generar_venta == false)
            {
                cerrar_ventana_generar_venta = true;
                cargar_generar_venta();

            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Producto_Admin p = new Producto_Admin(2);
                p.ShowDialog();
            }
            catch (Exception ex)
            {
                Ventana_Error ve = new Ventana_Error(ex);
                ve.ShowDialog();

            }
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            //try
            //  {
            cerrar_ventana_producto_admin = true;

            cargar_Prdocuto_admin();
            /*  }
              catch (Exception ex)
              {
                  Ventana_Error ve = new Ventana_Error(ex);
                  ve.ShowDialog();

              }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Categorias cate = new Categorias(2);
                cate.ShowDialog();
            }
            catch (Exception ex)
            {
                Ventana_Error ve = new Ventana_Error(ex);
                ve.ShowDialog();

            }
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente_Admin c = new Cliente_Admin();
                c.ShowDialog();
            }
            catch (Exception ex)
            {
                Ventana_Error ve = new Ventana_Error(ex);
                ve.ShowDialog();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Principal_inicio pi = new Principal_inicio(true);
                pi.ShowDialog();
            }
            catch (Exception ex)
            {
                Ventana_Error ve = new Ventana_Error(ex);
                ve.ShowDialog();

            }
        }

        private void btn_venta_no_impr_Click(object sender, EventArgs e)
        {

        }


        public void cargar_venta_no_impresa()
        {
            Venta_No_Impresa vni = new Venta_No_Impresa();
            vni.ShowDialog();

            if (cerrar_venta_no_impresa == false)
            {
                cerrar_venta_no_impresa = true;
                cargar_venta_no_impresa();

            }

        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                Configuracion_Factura cf = new Configuracion_Factura();
                cf.ShowDialog();
            }
            catch (Exception ex)
            {
                Ventana_Error ve = new Ventana_Error(ex);
                ve.ShowDialog();

            }
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            try
            {
                Compra_Listado cl = new Compra_Listado();
                cl.ShowDialog();
            }
            catch (Exception ex)
            {
                Ventana_Error ve = new Ventana_Error(ex);
                ve.ShowDialog();

            }
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor_Admin p = new Proveedor_Admin();
                p.ShowDialog();
            }
            catch (Exception ex)
            {
                Ventana_Error ve = new Ventana_Error(ex);
                ve.ShowDialog();

            }
        }



        private void button8_Click_2(object sender, EventArgs e)
        {
            try
            {
                Cliente_Generar_Email cge = new Cliente_Generar_Email();
                cge.ShowDialog();
            }
            catch (Exception ex)
            {
                Ventana_Error ve = new Ventana_Error(ex);
                ve.ShowDialog();

            }
        }



        private void btn_ventas_realizadas_Click(object sender, EventArgs e)
        {
            try
            {
                Venta_Listado v = new Venta_Listado();
                v.ShowDialog();

            }
            catch (Exception ex)
            {
                Ventana_Error ve = new Ventana_Error(ex);
                ve.ShowDialog();

            }
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            try
            {

                Usuarios u = new Usuarios();
                u.ShowDialog();
            }
            catch (Exception ex)
            {
                Ventana_Error ve = new Ventana_Error(ex);
                ve.ShowDialog();

            }
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            try
            {

                Configuracion c = new Configuracion();
                c.ShowDialog();
            }
            catch (Exception ex)
            {
                Ventana_Error ve = new Ventana_Error(ex);
                ve.ShowDialog();

            }
        }


        private void uno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 102)
            {
               
            }
        }

        private void btn_ventas_no_impresas_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_venta_no_impresa();
            }
            catch (Exception ex)
            {
                Ventana_Error ve = new Ventana_Error(ex);
                ve.ShowDialog();

            }
        }

        private void btn_ventas_no_impresas_Click_1(object sender, EventArgs e)
        {
            
                cargar_venta_no_impresa();
        
              
          
        }


      
    }
}
