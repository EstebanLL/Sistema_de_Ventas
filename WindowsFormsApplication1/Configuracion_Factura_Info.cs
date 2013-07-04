using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace SistemaDeGestion
{
    public partial class Configuracion_Factura_Info : Form
    {
        Font printFont;
        string printString;

        public Configuracion_Factura_Info()
        {
            InitializeComponent();
            txt_cm.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try {

                txt_pxl.Text = (Convert.ToDouble(txt_cm.Text) * (37.795275591)).ToString();
            }

            catch {
                txt_cm.Text = "";
                txt_cm.Focus();
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {

        }

        private void Configuracion_Factura_Info_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintAString(0);
        }
        public void PrintAString(int iniciar)
        {

            PrintDocument pd = new PrintDocument();

            printFont = new Font("Courier", 9);



            pd.PrintPage += new PrintPageEventHandler(PrintPage);

            pd.Print();
            // printPreviewDialog1.Document = pd;
            //    printPreviewDialog1.ShowDialog();


        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {


            e.Graphics.DrawString("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯↑ y = 0 píxeles ↑ ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯", printFont, Brushes.Black, 0, 0, new StringFormat());
            for (int i = 0; i < 700; )
            {
                e.Graphics.DrawString("▌", printFont, Brushes.Black, 0, i, new StringFormat());
                if (i == 400) {
                    e.Graphics.DrawString(" ← x = 0 píxeles ", printFont, Brushes.Black, 0, i, new StringFormat());
                
                }
                i = i + 10;
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datos.DatosVenta.ModificarVentaReset();
        }
    }
}
