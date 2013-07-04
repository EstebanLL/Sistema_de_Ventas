namespace SistemaDeGestion
{
    partial class Venta_Listado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta_Listado));
            this.date_fecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_filtro_producto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.bdd_ventas = new System.Windows.Forms.DataGridView();
            this.Pesos = new System.Windows.Forms.Label();
            this.txt_pesos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.bnt_imprimir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ver = new System.Windows.Forms.Button();
            this.lbl_caja = new System.Windows.Forms.Label();
            this.lbl_caja_pesos = new System.Windows.Forms.Label();
            this.txt_caja = new System.Windows.Forms.TextBox();
            this.venta_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleinte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_fdp_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.en_pesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_en_pesos = new System.Windows.Forms.TextBox();
            this.lbl_S_en_pesos = new System.Windows.Forms.Label();
            this.lbl_en_pesos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // date_fecha
            // 
            this.date_fecha.Location = new System.Drawing.Point(69, 28);
            this.date_fecha.Name = "date_fecha";
            this.date_fecha.Size = new System.Drawing.Size(260, 20);
            this.date_fecha.TabIndex = 1;
            this.date_fecha.Visible = false;
            this.date_fecha.ValueChanged += new System.EventHandler(this.date_fecha_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Filtrar por:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbox_filtro_producto
            // 
            this.cbox_filtro_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_filtro_producto.FormattingEnabled = true;
            this.cbox_filtro_producto.Items.AddRange(new object[] {
            "Nº Venta",
            "Nombre",
            "Fecha",
            "Observaciones"});
            this.cbox_filtro_producto.Location = new System.Drawing.Point(394, 27);
            this.cbox_filtro_producto.Name = "cbox_filtro_producto";
            this.cbox_filtro_producto.Size = new System.Drawing.Size(166, 21);
            this.cbox_filtro_producto.TabIndex = 2;
            this.cbox_filtro_producto.SelectedIndexChanged += new System.EventHandler(this.cbox_filtro_producto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "Buscar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(69, 28);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(260, 20);
            this.txt_buscar.TabIndex = 52;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // bdd_ventas
            // 
            this.bdd_ventas.AllowUserToResizeColumns = false;
            this.bdd_ventas.AllowUserToResizeRows = false;
            this.bdd_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdd_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.venta_numero,
            this.id_venta,
            this.mpreso,
            this.nombre,
            this.id_cliente,
            this.cleinte,
            this.tipo,
            this.estado,
            this.fecha,
            this.Monto,
            this.iva,
            this.id_fdp_1,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.decuento,
            this.observaciones,
            this.facturaNum,
            this.en_pesos});
            this.bdd_ventas.Location = new System.Drawing.Point(12, 64);
            this.bdd_ventas.Name = "bdd_ventas";
            this.bdd_ventas.ReadOnly = true;
            this.bdd_ventas.RowHeadersVisible = false;
            this.bdd_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdd_ventas.Size = new System.Drawing.Size(632, 231);
            this.bdd_ventas.TabIndex = 4;
            this.bdd_ventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdd_ventas_CellContentClick);
            this.bdd_ventas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdd_ventas_CellContentDoubleClick);
            this.bdd_ventas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdd_ventas_CellDoubleClick);
            // 
            // Pesos
            // 
            this.Pesos.AutoSize = true;
            this.Pesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesos.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Pesos.Location = new System.Drawing.Point(546, 312);
            this.Pesos.Name = "Pesos";
            this.Pesos.Size = new System.Drawing.Size(14, 15);
            this.Pesos.TabIndex = 160;
            this.Pesos.Text = "$";
            this.Pesos.Click += new System.EventHandler(this.Pesos_Click);
            // 
            // txt_pesos
            // 
            this.txt_pesos.Location = new System.Drawing.Point(566, 309);
            this.txt_pesos.Name = "txt_pesos";
            this.txt_pesos.ReadOnly = true;
            this.txt_pesos.Size = new System.Drawing.Size(78, 20);
            this.txt_pesos.TabIndex = 159;
            this.txt_pesos.TabStop = false;
            this.txt_pesos.Text = "0";
            this.txt_pesos.TextChanged += new System.EventHandler(this.txt_pesos_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(444, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 158;
            this.label8.Text = "Total Facturas: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.Location = new System.Drawing.Point(569, 341);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 8;
            this.btn_cerrar.Text = "&Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // bnt_imprimir
            // 
            this.bnt_imprimir.Image = global::SistemaDeGestion.Properties.Resources.imprimir_icono_4607_16;
            this.bnt_imprimir.Location = new System.Drawing.Point(405, 341);
            this.bnt_imprimir.Name = "bnt_imprimir";
            this.bnt_imprimir.Size = new System.Drawing.Size(75, 23);
            this.bnt_imprimir.TabIndex = 6;
            this.bnt_imprimir.Text = "Imprimir";
            this.bnt_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnt_imprimir.UseVisualStyleBackColor = true;
            this.bnt_imprimir.Click += new System.EventHandler(this.bnt_imprimir_Click);
            // 
            // button1
            // 
            this.button1.Image = global::SistemaDeGestion.Properties.Resources.buscar_buscar_ampliar_icono_9048_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(566, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Buscar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ver
            // 
            this.btn_ver.Image = global::SistemaDeGestion.Properties.Resources.ver_icono_5784_16;
            this.btn_ver.Location = new System.Drawing.Point(488, 341);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(75, 23);
            this.btn_ver.TabIndex = 7;
            this.btn_ver.Text = "&Ver";
            this.btn_ver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_caja
            // 
            this.lbl_caja.AutoSize = true;
            this.lbl_caja.ForeColor = System.Drawing.Color.Black;
            this.lbl_caja.Location = new System.Drawing.Point(146, 314);
            this.lbl_caja.Name = "lbl_caja";
            this.lbl_caja.Size = new System.Drawing.Size(31, 13);
            this.lbl_caja.TabIndex = 161;
            this.lbl_caja.Text = "Caja:";
            this.lbl_caja.Visible = false;
            // 
            // lbl_caja_pesos
            // 
            this.lbl_caja_pesos.AutoSize = true;
            this.lbl_caja_pesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caja_pesos.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_caja_pesos.Location = new System.Drawing.Point(176, 312);
            this.lbl_caja_pesos.Name = "lbl_caja_pesos";
            this.lbl_caja_pesos.Size = new System.Drawing.Size(14, 15);
            this.lbl_caja_pesos.TabIndex = 162;
            this.lbl_caja_pesos.Text = "$";
            this.lbl_caja_pesos.Visible = false;
            // 
            // txt_caja
            // 
            this.txt_caja.Location = new System.Drawing.Point(196, 309);
            this.txt_caja.Name = "txt_caja";
            this.txt_caja.Size = new System.Drawing.Size(73, 20);
            this.txt_caja.TabIndex = 163;
            this.txt_caja.Visible = false;
            // 
            // venta_numero
            // 
            this.venta_numero.DataPropertyName = "venta_numero";
            this.venta_numero.HeaderText = "Nº Venta:";
            this.venta_numero.Name = "venta_numero";
            this.venta_numero.ReadOnly = true;
            this.venta_numero.Width = 120;
            // 
            // id_venta
            // 
            this.id_venta.DataPropertyName = "id_venta";
            this.id_venta.HeaderText = "Numero";
            this.id_venta.Name = "id_venta";
            this.id_venta.ReadOnly = true;
            this.id_venta.Visible = false;
            this.id_venta.Width = 120;
            // 
            // mpreso
            // 
            this.mpreso.DataPropertyName = "impreso";
            this.mpreso.HeaderText = "impreso";
            this.mpreso.Name = "mpreso";
            this.mpreso.ReadOnly = true;
            this.mpreso.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "provisorio";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 180;
            // 
            // id_cliente
            // 
            this.id_cliente.DataPropertyName = "id_cliente";
            this.id_cliente.HeaderText = "id_cliente";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            this.id_cliente.Visible = false;
            // 
            // cleinte
            // 
            this.cleinte.DataPropertyName = "clientes";
            this.cleinte.HeaderText = "cliente";
            this.cleinte.Name = "cleinte";
            this.cleinte.ReadOnly = true;
            this.cleinte.Visible = false;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Visible = false;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 85;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "total";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Monto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // iva
            // 
            this.iva.DataPropertyName = "iva";
            this.iva.HeaderText = "iva";
            this.iva.Name = "iva";
            this.iva.ReadOnly = true;
            this.iva.Visible = false;
            // 
            // id_fdp_1
            // 
            this.id_fdp_1.DataPropertyName = "id_fdp_1";
            this.id_fdp_1.HeaderText = "Column1";
            this.id_fdp_1.Name = "id_fdp_1";
            this.id_fdp_1.ReadOnly = true;
            this.id_fdp_1.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_fdp_2";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "id_fdp_3";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "id_fdp_4";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "fdp1_monto";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "fdp2_monto";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "fdp3_monto";
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "fdp4_monto";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // decuento
            // 
            this.decuento.DataPropertyName = "descuento";
            this.decuento.HeaderText = "descuento";
            this.decuento.Name = "decuento";
            this.decuento.ReadOnly = true;
            this.decuento.Visible = false;
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "observaciones";
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Width = 120;
            // 
            // facturaNum
            // 
            this.facturaNum.DataPropertyName = "factura_numero";
            this.facturaNum.HeaderText = "factunum";
            this.facturaNum.Name = "facturaNum";
            this.facturaNum.ReadOnly = true;
            this.facturaNum.Visible = false;
            // 
            // en_pesos
            // 
            this.en_pesos.DataPropertyName = "en_pesos";
            this.en_pesos.HeaderText = "en_pesos";
            this.en_pesos.Name = "en_pesos";
            this.en_pesos.ReadOnly = true;
            this.en_pesos.Visible = false;
            // 
            // txt_en_pesos
            // 
            this.txt_en_pesos.Location = new System.Drawing.Point(353, 309);
            this.txt_en_pesos.Name = "txt_en_pesos";
            this.txt_en_pesos.Size = new System.Drawing.Size(73, 20);
            this.txt_en_pesos.TabIndex = 166;
            this.txt_en_pesos.Text = "0";
            this.txt_en_pesos.Visible = false;
            // 
            // lbl_S_en_pesos
            // 
            this.lbl_S_en_pesos.AutoSize = true;
            this.lbl_S_en_pesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_S_en_pesos.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_S_en_pesos.Location = new System.Drawing.Point(335, 311);
            this.lbl_S_en_pesos.Name = "lbl_S_en_pesos";
            this.lbl_S_en_pesos.Size = new System.Drawing.Size(14, 15);
            this.lbl_S_en_pesos.TabIndex = 165;
            this.lbl_S_en_pesos.Text = "$";
            this.lbl_S_en_pesos.Visible = false;
            // 
            // lbl_en_pesos
            // 
            this.lbl_en_pesos.AutoSize = true;
            this.lbl_en_pesos.ForeColor = System.Drawing.Color.Black;
            this.lbl_en_pesos.Location = new System.Drawing.Point(283, 312);
            this.lbl_en_pesos.Name = "lbl_en_pesos";
            this.lbl_en_pesos.Size = new System.Drawing.Size(54, 13);
            this.lbl_en_pesos.TabIndex = 164;
            this.lbl_en_pesos.Text = "En pesos:";
            this.lbl_en_pesos.Visible = false;
            // 
            // Venta_Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(656, 370);
            this.Controls.Add(this.txt_en_pesos);
            this.Controls.Add(this.lbl_S_en_pesos);
            this.Controls.Add(this.lbl_en_pesos);
            this.Controls.Add(this.txt_caja);
            this.Controls.Add(this.lbl_caja_pesos);
            this.Controls.Add(this.lbl_caja);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.bnt_imprimir);
            this.Controls.Add(this.Pesos);
            this.Controls.Add(this.txt_pesos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox_filtro_producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.bdd_ventas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(672, 408);
            this.MinimumSize = new System.Drawing.Size(623, 408);
            this.Name = "Venta_Listado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas Realizadas";
            ((System.ComponentModel.ISupportInitialize)(this.bdd_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker date_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_filtro_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView bdd_ventas;
        private System.Windows.Forms.Label Pesos;
        private System.Windows.Forms.TextBox txt_pesos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bnt_imprimir;
        private System.Windows.Forms.Button btn_ver;
        private System.Windows.Forms.Label lbl_caja;
        private System.Windows.Forms.Label lbl_caja_pesos;
        private System.Windows.Forms.TextBox txt_caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn venta_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleinte;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fdp_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn decuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn en_pesos;
        private System.Windows.Forms.TextBox txt_en_pesos;
        private System.Windows.Forms.Label lbl_S_en_pesos;
        private System.Windows.Forms.Label lbl_en_pesos;
    }
}