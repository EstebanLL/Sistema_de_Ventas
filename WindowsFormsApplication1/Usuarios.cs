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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            CargarUsuarios();
            validar_btn();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

        }
        private void CargarUsuarios()
        {
            bdd_usuario.DataSource = DatosUsuario.getDatosUsuarios();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Usuarios_Datos ud = new Usuarios_Datos();
            ud.ShowDialog();
            CargarUsuarios();
            validar_btn();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

            Usuarios_Datos u = new Usuarios_Datos((Usuario)bdd_usuario.CurrentRow.DataBoundItem);
            u.ShowDialog();
            CargarUsuarios();
     
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string nom = ((Usuario)bdd_usuario.CurrentRow.DataBoundItem).Usuarios;
            DialogResult dr = MessageBox.Show(this, "Esta seguro que desea eliminar el Usuario: " + nom + "?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                DatosUsuario.setBajaUsuario(((Usuario)bdd_usuario.CurrentRow.DataBoundItem).Id_usuario);
                CargarUsuarios();
            }
            else
            {

            }
            validar_btn();
        }


        public void validar_btn()
        {

            if (bdd_usuario.Rows.Count == 1)
            {

                btn_eliminar.Enabled = false;

            }
            else
            {
                btn_eliminar.Enabled = true;

            }


        }

    }
}
