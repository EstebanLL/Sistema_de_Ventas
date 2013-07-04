using System;
using System.Collections.Generic;
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
    public partial class Categorias : Form
    {   int tipo;
        public Categorias(int tip)
        {
            
            this.tipo = tip;
            InitializeComponent();
            if (tipo == 1)
            {

                //  dgv_categorias.DataSource = DatosTipoCliente.gettiposclientes();

            }
            if (tipo == 2)
            {
               dgv_categorias.DataSource = DatosCategoria.getCategorias();


            }
            ValidarBts();
        }
           
              public void ValidarBts()
        {
            if (dgv_categorias.Rows.Count == 0)
            {
                btn_modificar.Enabled = false;
            }
            else
            {
                btn_modificar.Enabled = true;
            }
        }
   

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            try
            {
                if (tipo == 1)
                {
                  // Categoria_Datos cn = new Categoria_Datos(1, 0, "");
                //   cn.ShowDialog();
                 //  dgv_categorias.DataSource = DatosTipoCliente.gettiposclientes();
                }
                else
                {
//
                   Categoria_Datos cn = new Categoria_Datos(2, 0, "");
                   cn.ShowDialog();
                   dgv_categorias.DataSource = DatosCategoria.getCategorias();
                }
                ValidarBts();
            }
            catch
            {
                MessageBox.Show(this, "[0003]Error al cargar datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            modificar();
        }
        public void modificar(){
             try{
            if (tipo == 1)
            {
             //   Categoria_Nueva cn = new Categoria_Nueva(1,1,((TipoCliente)dgv_categorias.CurrentRow.DataBoundItem).Nombre.ToString());
              //  cn.ShowDialog();
              //  dgv_categorias.DataSource = DatosTipoCliente.gettiposclientes();
            }
            else
            {

                Categoria_Datos cn = new Categoria_Datos(2,1,((Categoria)dgv_categorias.CurrentRow.DataBoundItem).Nombre.ToString());
                cn.ShowDialog();
             dgv_categorias.DataSource = DatosCategoria.getCategorias();
            }
            }
            catch
            {
                MessageBox.Show(this, "[0004]Error al cargar datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click_1(object sender, EventArgs e)
        {
           // try
          //  {
                if (tipo == 1)
                {
                  //  Categoria_Nueva cn = new Categoria_Nueva(1, 1, ((TipoCliente)dgv_categorias.CurrentRow.DataBoundItem).Nombre.ToString());
                  //  cn.ShowDialog();
                   // dgv_categorias.DataSource = DatosTipoCliente.gettiposclientes();
                }
                else
                {

                    Categoria_Datos cn = new Categoria_Datos((Categoria)dgv_categorias.CurrentRow.DataBoundItem);
                    cn.ShowDialog();
                    dgv_categorias.DataSource = DatosCategoria.getCategorias();
                }
           /* }
            catch
            {
                MessageBox.Show(this, "[0004]Error al cargar datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void dgv_categorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Categoria_Datos cn = new Categoria_Datos((Categoria)dgv_categorias.CurrentRow.DataBoundItem);
            cn.ShowDialog();
            dgv_categorias.DataSource = DatosCategoria.getCategorias();
        }
    }
}
