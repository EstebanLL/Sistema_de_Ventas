namespace SistemaDeGestion
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.bdd_usuario = new System.Windows.Forms.DataGridView();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // bdd_usuario
            // 
            this.bdd_usuario.AllowUserToAddRows = false;
            this.bdd_usuario.AllowUserToResizeRows = false;
            this.bdd_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bdd_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.bdd_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario,
            this.Nombre,
            this.Column1,
            this.pass,
            this.Column2,
            this.Column3});
            this.bdd_usuario.Location = new System.Drawing.Point(7, 10);
            this.bdd_usuario.MultiSelect = false;
            this.bdd_usuario.Name = "bdd_usuario";
            this.bdd_usuario.ReadOnly = true;
            this.bdd_usuario.RowHeadersVisible = false;
            this.bdd_usuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.bdd_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdd_usuario.Size = new System.Drawing.Size(423, 204);
            this.bdd_usuario.TabIndex = 1;
            this.bdd_usuario.Tag = "3";
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "Usuarios";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Apellido";
            this.Column1.HeaderText = "Apellido";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // pass
            // 
            this.pass.DataPropertyName = "Pass";
            this.pass.HeaderText = "pass";
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            this.pass.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Categoria";
            this.Column2.HeaderText = "Categoria";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Id_usuario";
            this.Column3.HeaderText = "Id_usuario";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_salir.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.Location = new System.Drawing.Point(354, 219);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Tag = "7";
            this.btn_salir.Text = "&Cerrar";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = global::SistemaDeGestion.Properties.Resources.dibujo_a_lapiz_modificar_escribir_icono_8118_16;
            this.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar.Location = new System.Drawing.Point(192, 219);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "&Modificar";
            this.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Nuevo.Image = global::SistemaDeGestion.Properties.Resources.agregar_icono_5633_16;
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.Location = new System.Drawing.Point(111, 219);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 2;
            this.btn_Nuevo.Tag = "6";
            this.btn_Nuevo.Text = "&Nuevo";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.Image = global::SistemaDeGestion.Properties.Resources.recyclebin_vacio_icono_9473_16;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(273, 219);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Tag = "4";
            this.btn_eliminar.Text = "&Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_salir;
            this.ClientSize = new System.Drawing.Size(437, 253);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.bdd_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(453, 291);
            this.MinimumSize = new System.Drawing.Size(453, 291);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.bdd_usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridView bdd_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;

    }
}