namespace SistemaDeGestion
{
    partial class Producto_Alta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto_Alta));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_num_factura = new System.Windows.Forms.TextBox();
            this.cbox_proveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.date_fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbox_tipo_factura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bdd_carrito = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_codigo2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbox_filtro_producto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.bdd_productos = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.Pesos = new System.Windows.Forms.Label();
            this.txt_pesos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_carrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor:";
            // 
            // txt_num_factura
            // 
            this.txt_num_factura.Location = new System.Drawing.Point(74, 19);
            this.txt_num_factura.Name = "txt_num_factura";
            this.txt_num_factura.Size = new System.Drawing.Size(188, 20);
            this.txt_num_factura.TabIndex = 1;
            // 
            // cbox_proveedor
            // 
            this.cbox_proveedor.FormattingEnabled = true;
            this.cbox_proveedor.Location = new System.Drawing.Point(74, 72);
            this.cbox_proveedor.Name = "cbox_proveedor";
            this.cbox_proveedor.Size = new System.Drawing.Size(188, 21);
            this.cbox_proveedor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nº Factura:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_vencimiento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.date_fecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbox_tipo_factura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_num_factura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbox_proveedor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura";
            // 
            // date_vencimiento
            // 
            this.date_vencimiento.Location = new System.Drawing.Point(363, 45);
            this.date_vencimiento.Name = "date_vencimiento";
            this.date_vencimiento.Size = new System.Drawing.Size(200, 20);
            this.date_vencimiento.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vencimiento:";
            // 
            // date_fecha
            // 
            this.date_fecha.Location = new System.Drawing.Point(363, 19);
            this.date_fecha.Name = "date_fecha";
            this.date_fecha.Size = new System.Drawing.Size(200, 20);
            this.date_fecha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha:";
            // 
            // cbox_tipo_factura
            // 
            this.cbox_tipo_factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_tipo_factura.FormattingEnabled = true;
            this.cbox_tipo_factura.Items.AddRange(new object[] {
            "Contado",
            "Crédito"});
            this.cbox_tipo_factura.Location = new System.Drawing.Point(74, 45);
            this.cbox_tipo_factura.Name = "cbox_tipo_factura";
            this.cbox_tipo_factura.Size = new System.Drawing.Size(188, 21);
            this.cbox_tipo_factura.TabIndex = 2;
            this.cbox_tipo_factura.SelectedIndexChanged += new System.EventHandler(this.cbox_tipo_factura_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bdd_carrito);
            this.groupBox2.Controls.Add(this.txt_codigo2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbox_filtro_producto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_buscar);
            this.groupBox2.Controls.Add(this.btn_buscar);
            this.groupBox2.Controls.Add(this.bdd_productos);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 377);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // bdd_carrito
            // 
            this.bdd_carrito.AllowUserToResizeRows = false;
            this.bdd_carrito.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bdd_carrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bdd_carrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.dataGridViewTextBoxColumn5,
            this.Cantidad,
            this.dataGridViewTextBoxColumn6,
            this.importe2});
            this.bdd_carrito.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.bdd_carrito.Location = new System.Drawing.Point(19, 188);
            this.bdd_carrito.MultiSelect = false;
            this.bdd_carrito.Name = "bdd_carrito";
            this.bdd_carrito.ReadOnly = true;
            this.bdd_carrito.RowHeadersVisible = false;
            this.bdd_carrito.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bdd_carrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdd_carrito.Size = new System.Drawing.Size(546, 152);
            this.bdd_carrito.TabIndex = 14;
            this.bdd_carrito.TabStop = false;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "detalle";
            this.dataGridViewTextBoxColumn5.HeaderText = "Detalle";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 240;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 65;
            // 
            // importe2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.importe2.DefaultCellStyle = dataGridViewCellStyle4;
            this.importe2.HeaderText = "Importe";
            this.importe2.Name = "importe2";
            this.importe2.ReadOnly = true;
            this.importe2.Width = 65;
            // 
            // txt_codigo2
            // 
            this.txt_codigo2.Location = new System.Drawing.Point(291, 161);
            this.txt_codigo2.MaxLength = 55;
            this.txt_codigo2.Name = "txt_codigo2";
            this.txt_codigo2.Size = new System.Drawing.Size(192, 20);
            this.txt_codigo2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 157;
            this.label6.Text = "Filtrar por:";
            // 
            // cbox_filtro_producto
            // 
            this.cbox_filtro_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_filtro_producto.FormattingEnabled = true;
            this.cbox_filtro_producto.Items.AddRange(new object[] {
            "Código",
            "Detalle"});
            this.cbox_filtro_producto.Location = new System.Drawing.Point(358, 19);
            this.cbox_filtro_producto.Name = "cbox_filtro_producto";
            this.cbox_filtro_producto.Size = new System.Drawing.Size(128, 21);
            this.cbox_filtro_producto.TabIndex = 8;
            this.cbox_filtro_producto.TabStop = false;
            this.cbox_filtro_producto.SelectedIndexChanged += new System.EventHandler(this.cbox_filtro_producto_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 155;
            this.label7.Text = "Buscar [F10]:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(96, 20);
            this.txt_buscar.MaxLength = 18;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(208, 20);
            this.txt_buscar.TabIndex = 7;
            this.txt_buscar.TabStop = false;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = global::SistemaDeGestion.Properties.Resources.buscar_buscar_ampliar_icono_9048_16;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(492, 18);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(71, 23);
            this.btn_buscar.TabIndex = 9;
            this.btn_buscar.TabStop = false;
            this.btn_buscar.Text = "&Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // bdd_productos
            // 
            this.bdd_productos.AllowUserToResizeRows = false;
            this.bdd_productos.CausesValidation = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bdd_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bdd_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Id_producto,
            this.iva,
            this.Detalles,
            this.nombrecategoria,
            this.stock,
            this.cate,
            this.precio_unidad,
            this.margen,
            this.stock_min,
            this.dataGridViewTextBoxColumn2,
            this.imagen,
            this.imagen_categoria});
            this.bdd_productos.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.bdd_productos.Location = new System.Drawing.Point(19, 45);
            this.bdd_productos.MultiSelect = false;
            this.bdd_productos.Name = "bdd_productos";
            this.bdd_productos.ReadOnly = true;
            this.bdd_productos.RowHeadersVisible = false;
            this.bdd_productos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bdd_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdd_productos.Size = new System.Drawing.Size(546, 110);
            this.bdd_productos.TabIndex = 10;
            this.bdd_productos.TabStop = false;
            this.bdd_productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdd_productos_CellDoubleClick);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Image = global::SistemaDeGestion.Properties.Resources.agregar_icono_5633_16;
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(489, 159);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 13;
            this.btn_agregar.TabStop = false;
            this.btn_agregar.Text = "A&gregar";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 139;
            this.label8.Text = "Código:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::SistemaDeGestion.Properties.Resources.guardar_archivo_icono_6713_16;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(424, 545);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(71, 23);
            this.btn_guardar.TabIndex = 17;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_no_imprimir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(504, 545);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(73, 23);
            this.btn_cancelar.TabIndex = 18;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Pesos
            // 
            this.Pesos.AutoSize = true;
            this.Pesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesos.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Pesos.Location = new System.Drawing.Point(479, 512);
            this.Pesos.Name = "Pesos";
            this.Pesos.Size = new System.Drawing.Size(14, 15);
            this.Pesos.TabIndex = 231;
            this.Pesos.Text = "$";
            // 
            // txt_pesos
            // 
            this.txt_pesos.Location = new System.Drawing.Point(499, 509);
            this.txt_pesos.Name = "txt_pesos";
            this.txt_pesos.Size = new System.Drawing.Size(78, 20);
            this.txt_pesos.TabIndex = 16;
            this.txt_pesos.TabStop = false;
            this.txt_pesos.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(426, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 229;
            this.label9.Text = "Total: ";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // Id_producto
            // 
            this.Id_producto.DataPropertyName = "Id_producto";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_producto.DefaultCellStyle = dataGridViewCellStyle6;
            this.Id_producto.HeaderText = "Id_producto";
            this.Id_producto.Name = "Id_producto";
            this.Id_producto.ReadOnly = true;
            this.Id_producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Id_producto.Visible = false;
            // 
            // iva
            // 
            this.iva.DataPropertyName = "iva";
            this.iva.HeaderText = "iva";
            this.iva.Name = "iva";
            this.iva.ReadOnly = true;
            this.iva.Visible = false;
            // 
            // Detalles
            // 
            this.Detalles.DataPropertyName = "detalle";
            this.Detalles.HeaderText = "Detalle";
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            this.Detalles.Width = 240;
            // 
            // nombrecategoria
            // 
            this.nombrecategoria.DataPropertyName = "nombrecategoria";
            this.nombrecategoria.HeaderText = "Categoria";
            this.nombrecategoria.Name = "nombrecategoria";
            this.nombrecategoria.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.stock.DefaultCellStyle = dataGridViewCellStyle7;
            this.stock.HeaderText = "En Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Visible = false;
            this.stock.Width = 40;
            // 
            // cate
            // 
            this.cate.DataPropertyName = "cate";
            this.cate.HeaderText = "cate";
            this.cate.Name = "cate";
            this.cate.ReadOnly = true;
            this.cate.Visible = false;
            // 
            // precio_unidad
            // 
            this.precio_unidad.DataPropertyName = "precio_unidad";
            this.precio_unidad.HeaderText = "precio_unidad";
            this.precio_unidad.Name = "precio_unidad";
            this.precio_unidad.ReadOnly = true;
            this.precio_unidad.Visible = false;
            // 
            // margen
            // 
            this.margen.DataPropertyName = "margen";
            this.margen.HeaderText = "margen";
            this.margen.Name = "margen";
            this.margen.ReadOnly = true;
            this.margen.Visible = false;
            // 
            // stock_min
            // 
            this.stock_min.DataPropertyName = "stock_min";
            this.stock_min.HeaderText = "stock_min";
            this.stock_min.Name = "stock_min";
            this.stock_min.ReadOnly = true;
            this.stock_min.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "total";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn2.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // imagen
            // 
            this.imagen.DataPropertyName = "imagen";
            this.imagen.HeaderText = "imagen";
            this.imagen.Name = "imagen";
            this.imagen.ReadOnly = true;
            this.imagen.Visible = false;
            // 
            // imagen_categoria
            // 
            this.imagen_categoria.DataPropertyName = "imagen_categoria";
            this.imagen_categoria.HeaderText = "imagen_categoria";
            this.imagen_categoria.Name = "imagen_categoria";
            this.imagen_categoria.ReadOnly = true;
            this.imagen_categoria.Visible = false;
            // 
            // Producto_Alta
            // 
            this.AcceptButton = this.btn_agregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(613, 577);
            this.Controls.Add(this.Pesos);
            this.Controls.Add(this.txt_pesos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(629, 615);
            this.MinimumSize = new System.Drawing.Size(629, 615);
            this.Name = "Producto_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Productos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_carrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_num_factura;
        private System.Windows.Forms.ComboBox cbox_proveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_vencimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbox_tipo_factura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView bdd_carrito;
        private System.Windows.Forms.TextBox txt_codigo2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbox_filtro_producto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView bdd_productos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe2;
        private System.Windows.Forms.Label Pesos;
        private System.Windows.Forms.TextBox txt_pesos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cate;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn margen;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_min;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagen_categoria;
    }
}