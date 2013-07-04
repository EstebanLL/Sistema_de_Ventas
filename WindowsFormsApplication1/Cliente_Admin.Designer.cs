namespace SistemaDeGestion
{
    partial class Cliente_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente_Admin));
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_filtro_producto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.bdd_clientes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_modifica = new System.Windows.Forms.Button();
            this.btn_Nuevo_cli = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Filtrar por:";
            // 
            // cbox_filtro_producto
            // 
            this.cbox_filtro_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_filtro_producto.FormattingEnabled = true;
            this.cbox_filtro_producto.Items.AddRange(new object[] {
            "Nombre",
            "Documento",
            "Email",
            "Direccion",
            "Teléfono ",
            "Cumpleaños"});
            this.cbox_filtro_producto.Location = new System.Drawing.Point(386, 21);
            this.cbox_filtro_producto.Name = "cbox_filtro_producto";
            this.cbox_filtro_producto.Size = new System.Drawing.Size(179, 21);
            this.cbox_filtro_producto.TabIndex = 2;
            this.cbox_filtro_producto.SelectedIndexChanged += new System.EventHandler(this.cbox_filtro_producto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "Buscar:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(67, 22);
            this.txt_buscar.MaxLength = 18;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(254, 20);
            this.txt_buscar.TabIndex = 1;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // bdd_clientes
            // 
            this.bdd_clientes.AllowUserToAddRows = false;
            this.bdd_clientes.AllowUserToOrderColumns = true;
            this.bdd_clientes.AllowUserToResizeRows = false;
            this.bdd_clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bdd_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdd_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.nac,
            this.rut,
            this.Dni,
            this.pais,
            this.Email,
            this.Calle,
            this.Tipo_cli,
            this.Id_cliente,
            this.Loc,
            this.Telefono});
            this.bdd_clientes.Location = new System.Drawing.Point(14, 57);
            this.bdd_clientes.MultiSelect = false;
            this.bdd_clientes.Name = "bdd_clientes";
            this.bdd_clientes.ReadOnly = true;
            this.bdd_clientes.RowHeadersVisible = false;
            this.bdd_clientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bdd_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdd_clientes.Size = new System.Drawing.Size(631, 238);
            this.bdd_clientes.TabIndex = 4;
            this.bdd_clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdd_clientes_CellDoubleClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // nac
            // 
            this.nac.DataPropertyName = "nacimiento";
            this.nac.HeaderText = "nac";
            this.nac.Name = "nac";
            this.nac.ReadOnly = true;
            this.nac.Visible = false;
            // 
            // rut
            // 
            this.rut.DataPropertyName = "rut";
            this.rut.HeaderText = "rut";
            this.rut.Name = "rut";
            this.rut.ReadOnly = true;
            this.rut.Visible = false;
            // 
            // Dni
            // 
            this.Dni.DataPropertyName = "documento";
            this.Dni.HeaderText = "Documento";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            this.Dni.Width = 110;
            // 
            // pais
            // 
            this.pais.DataPropertyName = "pais";
            this.pais.HeaderText = "pais";
            this.pais.Name = "pais";
            this.pais.ReadOnly = true;
            this.pais.Visible = false;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "direccion";
            this.Calle.HeaderText = "Direccion";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            // 
            // Tipo_cli
            // 
            this.Tipo_cli.DataPropertyName = "ciudad";
            this.Tipo_cli.HeaderText = "Ciudad";
            this.Tipo_cli.Name = "Tipo_cli";
            this.Tipo_cli.ReadOnly = true;
            this.Tipo_cli.Visible = false;
            // 
            // Id_cliente
            // 
            this.Id_cliente.DataPropertyName = "Id_cliente";
            this.Id_cliente.HeaderText = "Id_cliente";
            this.Id_cliente.Name = "Id_cliente";
            this.Id_cliente.ReadOnly = true;
            this.Id_cliente.Visible = false;
            // 
            // Loc
            // 
            this.Loc.DataPropertyName = "id_pais";
            this.Loc.HeaderText = "Loc";
            this.Loc.Name = "Loc";
            this.Loc.ReadOnly = true;
            this.Loc.Visible = false;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.Location = new System.Drawing.Point(571, 320);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 7;
            this.btn_cerrar.Text = "&Cerrar";
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_modifica
            // 
            this.btn_modifica.Image = global::SistemaDeGestion.Properties.Resources.dibujo_a_lapiz_modificar_escribir_icono_8118_16;
            this.btn_modifica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modifica.Location = new System.Drawing.Point(490, 320);
            this.btn_modifica.Name = "btn_modifica";
            this.btn_modifica.Size = new System.Drawing.Size(75, 23);
            this.btn_modifica.TabIndex = 6;
            this.btn_modifica.Text = "Modificar";
            this.btn_modifica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modifica.UseVisualStyleBackColor = true;
            this.btn_modifica.Click += new System.EventHandler(this.btn_modifica_Click);
            // 
            // btn_Nuevo_cli
            // 
            this.btn_Nuevo_cli.Image = global::SistemaDeGestion.Properties.Resources.agregar_icono_5633_16;
            this.btn_Nuevo_cli.Location = new System.Drawing.Point(409, 320);
            this.btn_Nuevo_cli.Name = "btn_Nuevo_cli";
            this.btn_Nuevo_cli.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo_cli.TabIndex = 5;
            this.btn_Nuevo_cli.Text = "&Nuevo";
            this.btn_Nuevo_cli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Nuevo_cli.UseVisualStyleBackColor = true;
            this.btn_Nuevo_cli.Click += new System.EventHandler(this.btn_Nuevo_cli_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = global::SistemaDeGestion.Properties.Resources.buscar_buscar_ampliar_icono_9048_16;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(572, 20);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "&Buscar";
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click_1);
            // 
            // Cliente_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(659, 362);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_Nuevo_cli);
            this.Controls.Add(this.btn_modifica);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox_filtro_producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.bdd_clientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(675, 400);
            this.MinimumSize = new System.Drawing.Size(675, 400);
            this.Name = "Cliente_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.bdd_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_filtro_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView bdd_clientes;
        private System.Windows.Forms.Button btn_modifica;
        private System.Windows.Forms.Button btn_Nuevo_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Button btn_buscar;
    }
}