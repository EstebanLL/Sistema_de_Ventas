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
using iTextSharp.text;
using System.Diagnostics;
using System.ComponentModel;
using iTextSharp.text.pdf;

using System.IO;

namespace SistemaDeGestion
{


    public class OtrosFormatos
    {

        StreamWriter w;

        string ruta;

        public string xpath { get { return ruta; } set { value = ruta; } }


        /// <summary>

        /// Constructor que establece el path del archivo

        /// </summary>

        /// <param name="path"></param>

        public OtrosFormatos(string path)
        {

            ruta = @path;

        }



        /// <summary>

        /// Exporta datos a un archivo

        /// </summary>

        /// <param name="titulos"></param>

        /// <param name="datos"></param>

        public void Export(ArrayList titulos, DataTable datos)
        {

            try
            {

                FileStream fs = new FileStream(ruta, FileMode.Create,

                FileAccess.ReadWrite);

                w = new StreamWriter(fs);

                string comillas = char.ConvertFromUtf32(34);

                StringBuilder html = new StringBuilder();

                html.Append(@"<!DOCTYPE html PUBLIC" + comillas + "-//W3C//DTD XHTML 1.0 Transitional//EN" + comillas + " " + comillas + "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" + comillas + ">");

                html.Append(@"<html xmlns=" + comillas + "http://www.w3.org/1999/xhtml" + comillas + ">");
                html.Append(@"<head>");

                html.Append(@"<meta http-equiv=" + comillas + "Content-Type"

                + comillas + "content=" + comillas

                + "text/html; charset=utf-8" + comillas + "/>");

                html.Append(@"<title>Untitled Document</title>");

                html.Append(@"</head>");

                html.Append(@"<body>");



                //Generando encabezados del archivo

                //(aquí podemos dar el formato como a una tabla de HTML)

                html.Append(@"<table WIDTH=730 CELLSPACING=0 CELLPADDING=10 border=8 BORDERCOLOR=" + comillas + "#333366"

                + comillas + " bgcolor=" + comillas + "#FFFFFF"

                + comillas + ">");

                html.Append(@"<tr> <b>");

                foreach (object item in titulos)
                {

                    html.Append(@"<th>" + item.ToString() + "</th>");

                }

                html.Append(@"</b> </tr>");


                //Generando datos del archivo

                for (int i = 0; i < datos.Rows.Count; i++)
                {

                    html.Append(@"<tr>");

                    for (int j = 0; j < datos.Columns.Count; j++)
                    {

                        html.Append(@"<td>" +

                        datos.Rows[i][j].ToString() + "</td>");

                    }

                    html.Append(@"</tr>");

                }

                html.Append(@"</body>");

                html.Append(@"</html>");

                w.Write(html.ToString());

                w.Close();

            }

            catch (Exception ex)
            {

                throw ex;

            }

        } //Fin de la Función Export



        /// <summary>

        /// Genera un archivo CSV

        /// </summary>

        /// <param name="titulos"></param>

        /// <param name="datos"></param>

        public void ExportCSV(ArrayList titulos, DataTable datos)
        {

            try
            {

                FileStream fs = new FileStream(ruta, FileMode.Create,

                FileAccess.ReadWrite);

                w = new StreamWriter(fs);

                string comillas = char.ConvertFromUtf32(34);

                StringBuilder CSV = new StringBuilder();


                //Encabezados

                for (int i = 0; i < titulos.Count; i++)
                {

                    if (i != (titulos.Count - 1))

                        CSV.Append(comillas + titulos[i].ToString() + comillas + ",");

                    else

                        CSV.Append(comillas + titulos[i].ToString() + comillas

                        + Environment.NewLine);

                }



                // se generan datos

                for (int i = 0; i < datos.Rows.Count; i++)
                {

                    for (int j = 0; j < datos.Columns.Count; j++)
                    {

                        if (j != (titulos.Count - 1))

                            CSV.Append(comillas + datos.Rows[i][j].ToString()

                            + comillas + ",");

                        else

                            CSV.Append(comillas + datos.Rows[i][j].ToString()

                            + comillas + Environment.NewLine);

                    }

                }

                w.Write(CSV.ToString()); //se escribe la cadena en el archivo

                w.Close();

            }

            catch (Exception ex)
            {

                throw ex;

            }

        } //Fin de ExportCSV

    }
}
