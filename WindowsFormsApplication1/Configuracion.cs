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
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
            tx_iva.Text = (Datos.Conex.traer_iva()).ToString();
            txt_real.Text = (Datos.Conex.contizacion_real()).ToString();
            if (Principal.test_mode == true) {
                btn_mas.Visible = true;
            }
        }
        public Configuracion(bool dato)
        {
            InitializeComponent();
            this.Text = "Cotización";
            txt_real.Text = (Datos.Conex.contizacion_real()).ToString();
            tx_iva.Text = Principal.iva.ToString();
            tx_iva.ReadOnly = true;
            txt_conexion.Text = "local";
            if (Principal.test_mode == true)
            {
                btn_mas.Visible = true;
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Principal.real = Convert.ToDecimal(txt_real.Text);
            Datos.Conex.Modificar_Cotizacion_REAL(Convert.ToDecimal(txt_real.Text));
            
            Principal.iva = Convert.ToDecimal(tx_iva.Text);
            Datos.Conex.Modificar_IVA(Convert.ToDecimal(tx_iva.Text));
            this.Close();
        }

        private void txt_real_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txt_real.Text) <= 0)
                {


                    txt_real.Text = "1";

                }
            }
            catch
            {
                txt_real.Text = "1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tx_iva_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(tx_iva.Text) <= 0)
                {


                    tx_iva.Text = "0";

                }
            }
            catch
            {
                tx_iva.Text = "0";
            }
        }

        private void btn_mas_Click(object sender, EventArgs e)
        {
            Menu_Especial me = new Menu_Especial();
            me.ShowDialog();
        }
    }
}
