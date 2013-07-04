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
    public partial class Producto_Admin : Form
    {
        ArrayList listaPDF = new ArrayList();
        ArrayList listaVacia = new ArrayList();
        ArrayList listaCargar = new ArrayList();
        int solo_lectura = 0;
        public Producto_Admin()
        {


            InitializeComponent();
            cbox_filtro_producto.SelectedIndex = 0;
            carga();
            if (Principal.test_mode == true) {

                btn_desempaquetar.Visible = true;
                btn_baja_stock.Visible = true;
                bdd_productos.Columns[2].Width = 240;
                bdd_productos.Columns[8].Width = 75;
                bdd_productos.Columns[9].Visible = true;
                bdd_productos.Columns[9].Width = 50;
            }
            validar_botones();
        }
        public void validar_botones() {

            if (Principal.usuario_valido == 3) {

                btn_baja_stock.Enabled = false;
                btn_modificar.Enabled = false;
                btn_alta.Enabled = false;
            }
        
        }
        public Producto_Admin(bool carga_stock_critico)
        {


            InitializeComponent();
            cbox_filtro_producto.SelectedIndex = 2;
            buscar();
            validar_botones();

        }
        public void guardarPFD()
        {

            Document documento = new Document();

            SaveFileDialog saveDialog = new SaveFileDialog();
            /* SaveDialo para la direccion de donde se guardará el pdf */

            saveDialog.DefaultExt = ".jpg";
            saveDialog.Filter = "PDF files(*.pdf)|*.pdf;";

            if (saveDialog.ShowDialog() != DialogResult.Cancel)
            {
                PdfWriter.GetInstance(documento, new FileStream(saveDialog.FileName, FileMode.OpenOrCreate));
            }

            documento.Open();

            /*  Bitmap bitmap = new Bitmap(600, 600);
              //Creamos una imagen para guardar graficos

              Graphics grafico = Graphics.FromImage(bitmap);//gráfico a partir de imagen
              grafico.Clear(Color.White);

              System.Drawing.Font Fuente = new System.Drawing.Font("Courier New", 9, FontStyle.Bold);

              grafico.DrawString("esto es una prueba" , Fuente, Brushes.Black, 30, 30);
              /* Dibuja cadena en grafico 
              bitmap.Save(Application.StartupPath + "\\l.bmp");
              //Guarda la imagen para posteriormente cargarla

              iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(Application.StartupPath + "\\l.bmp");
              //Carga el grafico para ponerlo en el pdf

              jpg.Alignment = iTextSharp.text.Image.MIDDLE_ALIGN;
              //Alineacion

              documento.Add(jpg);// Se agrega la imagen cargada al documento pdf*/
            documento.Close(); // Se cierra el documento

        }
        public void carga()
        {
            txt_buscar.Text = "";
            string buscar = "and p.detalle like  '%" + txt_buscar.Text + "%'";

            listaCargar = DatosProducto.getProductosBuscarModelo(buscar);
            if (listaCargar.Count > 0)
            {

                bdd_productos.DataSource = listaCargar;
                listaVacia = listaCargar;

            }
            else
            {
                btn_modificar.Enabled = false;
            }
            validar_botones();
        }
        public Producto_Admin(int tipo)
        {

            solo_lectura = 1;
            InitializeComponent();
            cbox_filtro_producto.SelectedIndex = 0;

            string buscar = "and p.detalle like  '%" + txt_buscar.Text + "%'";

            listaCargar = DatosProducto.getProductosBuscarModelo(buscar);
            if (listaCargar.Count > 0)
            {

                bdd_productos.DataSource = listaCargar;

            }

            btn_modificar.Enabled = false;
            btn_alta.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Producto_Alta pa = new Producto_Alta();
            pa.ShowDialog();
            txt_buscar.Text = "";
            cbox_filtro_producto.SelectedIndex = 0;
            buscar();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buscar()
        {

            ArrayList lista = new ArrayList();

            // detalle
            if (cbox_filtro_producto.SelectedIndex == 0)
            {

                string buscar = "and p.detalle like  '%" + txt_buscar.Text + "%'";
                lista = DatosProducto.getProductosBuscarModelo(buscar);
            }
            //codigo
            else if (cbox_filtro_producto.SelectedIndex == 1)
            {

                string buscar = "and p.codigo like '%" + txt_buscar.Text + "%'";
                lista = DatosProducto.getProductosBuscarModelo(buscar);
            }
            else if (cbox_filtro_producto.SelectedIndex == 2)
            {


                lista = DatosProducto.getProductosBuscarModelo("");
                for (int i = lista.Count; i > 0; i--)
                {
                    if (((Producto)lista[i - 1]).Stock > ((Producto)lista[i - 1]).Stock_min)
                    {

                        lista.RemoveAt(i - 1);

                    }
                }
            }

            else
            {
                lista = listaVacia;

            }

            if (lista.Count == 0)
            {
                bdd_productos.DataSource = listaVacia;

                if (cbox_filtro_producto.SelectedIndex == 1)
                {
                    txt_buscar.Text = "";
                }
                if (cbox_filtro_producto.SelectedIndex == 2)
                {
                    MessageBox.Show(this, "No hay productos en stock minimo", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbox_filtro_producto.SelectedIndex = 0;
                }
            }
            else
            {
                listaVacia.Clear();
                listaVacia = lista;
                if (cbox_filtro_producto.SelectedIndex == 1)
                {
                    txt_buscar.SelectAll();
                }
                bdd_productos.DataSource = listaVacia;
                if (solo_lectura == 0)
                {
                    btn_modificar.Enabled = true;
                }
            }

            validar_botones();
        }


        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar();

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (cbox_filtro_producto.SelectedIndex == 0)
            {
                buscar();
            }
            if (txt_buscar.Text == "")
            {

                buscar();
            }

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Producto_Datos pa = new Producto_Datos((Producto)bdd_productos.CurrentRow.DataBoundItem, false);
            pa.ShowDialog();
            txt_buscar.Text = "";
            cbox_filtro_producto.SelectedIndex = 0;
            buscar();

        }

        private void bdd_productos_DoubleClick(object sender, EventArgs e)
        {
            if (Principal.usuario_valido != 3)
            {
                Producto_Datos pa = new Producto_Datos((Producto)bdd_productos.CurrentRow.DataBoundItem, false);
                pa.ShowDialog();
                carga();
            }

        }

        private void bdd_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbox_filtro_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_filtro_producto.SelectedIndex == 2)
            {

                txt_buscar.ReadOnly = true;

            }
            else
            {
                txt_buscar.ReadOnly = false;
            }
            buscar();
            txt_buscar.Focus();
        }

        private void btn_baja_stock_Click(object sender, EventArgs e)
        {
            Producto_Quitar_Stock pqs = new Producto_Quitar_Stock();
            pqs.ShowDialog();
            txt_buscar.Text = "";
            cbox_filtro_producto.SelectedIndex = 0;
            buscar();

        }

        private void btn_a_pdf_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaVacia.Count; i++)
            {

                ProductoPDF ppdf = new ProductoPDF(((Producto)listaVacia[i]).Detalle, ((Producto)listaVacia[i]).Total);
                listaPDF.Add(ppdf);
            }
            bdd_pdf.DataSource = listaPDF;
            try
            {

                Document doc = new Document(PageSize.A4.Rotate(), 10, 10

                , 10, 10);

                string filename = "DataGridViewTest.pdf";

                FileStream file = new FileStream(filename,

                FileMode.OpenOrCreate,

                FileAccess.ReadWrite,

                FileShare.ReadWrite);

                PdfWriter.GetInstance(doc, file);

                doc.Open();

                GenerarDocumento(doc);

                doc.Close();

                Process.Start(filename);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        public void GenerarDocumento(Document document)
        {

            //se crea un objeto PdfTable con el numero de columnas del

            //dataGridView

            PdfPTable datatable = new PdfPTable(bdd_pdf.ColumnCount);

            //asignamos algunas propiedades para el diseño del pdf
            datatable.DefaultCell.Padding = 3;

            float[] headerwidths = GetTamañoColumnas(bdd_pdf);

            datatable.SetWidths(headerwidths);

            datatable.WidthPercentage = 100;

            datatable.DefaultCell.BorderWidth = 2;

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;


            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF

            for (int i = 0; i < bdd_pdf.ColumnCount; i++)
            {

                datatable.AddCell(bdd_pdf.Columns[i].HeaderText);

            }


            datatable.HeaderRows = 1;

            datatable.DefaultCell.BorderWidth = 1;


            //SE GENERA EL CUERPO DEL PDF

            for (int i = 0; i < bdd_pdf.RowCount; i++)
            {

                for (int j = 0; j < bdd_pdf.ColumnCount; j++)
                {

                    datatable.AddCell(bdd_pdf[j, i].Value.ToString());

                }

                datatable.CompleteRow();

            }


            //SE AGREGAR LA PDFPTABLE AL DOCUMENTO

            document.Add(datatable);

        }
        public float[] GetTamañoColumnas(DataGridView dg)
        {

            float[] values = new float[dg.ColumnCount];

            for (int i = 0; i < dg.ColumnCount; i++)
            {

                values[i] = (float)dg.Columns[i].Width;

            }

            return values;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < listaVacia.Count; i++)
                {

                    ProductoPDF ppdf = new ProductoPDF(((Producto)listaVacia[i]).Detalle, ((Producto)listaVacia[i]).Total);
                    listaPDF.Add(ppdf);
                }

                bdd_pdf.DataSource = listaPDF;
                bdd_pdf.Refresh();
            
                ArrayList titulos = new ArrayList();

                DataTable datosTabla = new DataTable();

                //Especificar ruta del archivo con extensión de WORD.

                OtrosFormatos OF = new OtrosFormatos(Application.StartupPath + "test.doc");

                //obtenemos los titulos del grid y creamos las columnas de la tabla

                foreach (DataGridViewColumn item in bdd_pdf.Columns)
                {

                    titulos.Add(item.HeaderText);

                    datosTabla.Columns.Add();

                }

                //se crean los renglones de la tabla

                foreach (DataGridViewRow item in bdd_pdf.Rows)
                {

                    DataRow rowx = datosTabla.NewRow();

                    datosTabla.Rows.Add(rowx);

                }

                //se pasan los datos del dataGridView a la tabla

                foreach (DataGridViewColumn item in bdd_pdf.Columns)
                {

                    foreach (DataGridViewRow itemx in bdd_pdf.Rows)
                    {

                        datosTabla.Rows[itemx.Index][item.Index] =

                        bdd_pdf[item.Index, itemx.Index].Value;

                    }

                }

                OF.Export(titulos, datosTabla);
  

       

                Process.Start(OF.xpath);



            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            Principal.cerrar_ventana_producto_admin = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {   listaPDF.Clear();
        
        }

        private void btn_desempaquetar_Click(object sender, EventArgs e)
        {
            Producto_desempaquetar pd = new Producto_desempaquetar();
            pd.ShowDialog();
            txt_buscar.Text = "";
            cbox_filtro_producto.SelectedIndex = 0;
            buscar();
        }




    }
}
