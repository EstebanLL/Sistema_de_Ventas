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
using System.Reflection;
using System.Web;
using System.Net.Mail;
namespace SistemaDeGestion
{
    public partial class Ventana_Error : Form
    {
        public Ventana_Error(Exception ex)
        {
            InitializeComponent();

            Assembly assembly = Assembly.GetExecutingAssembly();
            txt_error.Text = txt_error.Text +  assembly.FullName.Split(',')[1] +"        // Mensaje :"+ ex.Message + "          //--- fuente: " + ex.Source + "          //--- Stac Trace :" + ex.StackTrace;  
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_error.Text);
            }
            catch
            {
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1;
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Guardar Archivo de Texto";
            saveFileDialog1.Filter = "Archivo de Texto (.txt) |*.txt";

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = @"H:\LO DEL ESCRITORIO";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = saveFileDialog1.FileName;

                StreamWriter fichero = new StreamWriter(ruta);
                fichero.Write(txt_error.Text);
                fichero.Close();
  
            }
            else
            {
            
            }
            saveFileDialog1.Dispose();
            saveFileDialog1 = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage();



            msg.To.Add(new MailAddress("marceportillo@gmail.com"));

            msg.From = new MailAddress("marceportillo@gmail.com");

            msg.Subject = "El asunto del mensaje(2.0)";

            msg.Body = "El contenido del mensaje";



            SmtpClient clienteSmtp = new SmtpClient("WIN02");



            try
            {

                clienteSmtp.Send(msg);

            }

            catch (Exception ex)
            {

                Console.Write(ex.Message);

                Console.ReadLine();

            }
        }
    }
}
