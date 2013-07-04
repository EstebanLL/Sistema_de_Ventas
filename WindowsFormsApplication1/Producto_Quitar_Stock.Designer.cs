namespace SistemaDeGestion
{
    partial class Producto_Quitar_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto_Quitar_Stock));
            this.Pesos = new System.Windows.Forms.Label();
            this.txt_pesos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_eliminar = new System.Windows.Forms.CheckBox();
            this.txt_codigo2 = new System.Windows.Forms.TextBox();
            this.bdd_carrito = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_filtro_producto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.bdd_productos = new System.Windows.Forms.DataGridView();
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
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_carrito_eliminar = new System.Windows.Forms.Button();
            this.btn_no_imprimir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_carrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // Pesos
            // 
            this.Pesos.AutoSize = true;
            this.Pesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesos.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Pesos.Location = new System.Drawing.Point(477, 408);
            this.Pesos.Name = "Pesos";
            this.Pesos.Size = new System.Drawing.Size(14, 15);
            this.Pesos.TabIndex = 232;
            this.Pesos.Text = "$";
            // 
            // txt_pesos
            // 
            this.txt_pesos.Location = new System.Drawing.Point(497, 405);
            this.txt_pesos.Name = "txt_pesos";
            this.txt_pesos.ReadOnly = true;
            this.txt_pesos.Size = new System.Drawing.Size(78, 20);
            this.txt_pesos.TabIndex = 231;
            this.txt_pesos.TabStop = false;
            this.txt_pesos.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(424, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 230;
            this.label8.Text = "Total: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_eliminar);
            this.groupBox2.Controls.Add(this.txt_codigo2);
            this.groupBox2.Controls.Add(this.bdd_carrito);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbox_filtro_producto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_buscar);
            this.groupBox2.Controls.Add(this.btn_buscar);
            this.groupBox2.Controls.Add(this.bdd_productos);
            this.groupBox2.Controls.Add(this.txt_cantidad);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_carrito_eliminar);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 377);
            this.groupBox2.TabIndex = 227;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // chk_eliminar
            // 
            this.chk_eliminar.AutoSize = true;
            this.chk_eliminar.Location = new System.Drawing.Point(157, 163);
            this.chk_eliminar.Name = "chk_eliminar";
            this.chk_eliminar.Size = new System.Drawing.Size(83, 17);
            this.chk_eliminar.TabIndex = 159;
            this.chk_eliminar.TabStop = false;
            this.chk_eliminar.Text = "Eliminar [F9]";
            this.chk_eliminar.UseVisualStyleBackColor = true;
            // 
            // txt_codigo2
            // 
            this.txt_codigo2.Location = new System.Drawing.Point(291, 161);
            this.txt_codigo2.MaxLength = 55;
            this.txt_codigo2.Name = "txt_codigo2";
            this.txt_codigo2.Size = new System.Drawing.Size(192, 20);
            this.txt_codigo2.TabIndex = 5;
            this.txt_codigo2.TextChanged += new System.EventHandler(this.txt_codigo2_TextChanged_1);
            this.txt_codigo2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_codigo2_KeyDown_1);
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
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Cantidad,
            this.dataGridViewTextBoxColumn6,
            this.Importe});
            this.bdd_carrito.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.bdd_carrito.Location = new System.Drawing.Point(17, 188);
            this.bdd_carrito.MultiSelect = false;
            this.bdd_carrito.Name = "bdd_carrito";
            this.bdd_carrito.ReadOnly = true;
            this.bdd_carrito.RowHeadersVisible = false;
            this.bdd_carrito.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bdd_carrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdd_carrito.Size = new System.Drawing.Size(546, 152);
            this.bdd_carrito.TabIndex = 158;
            this.bdd_carrito.TabStop = false;
            this.bdd_carrito.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdd_carrito_CellDoubleClick_1);
            this.bdd_carrito.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bdd_carrito_KeyDown);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Código";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
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
            this.Cantidad.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // Importe
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle4;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 157;
            this.label2.Text = "Filtrar por:";
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
            this.cbox_filtro_producto.TabIndex = 156;
            this.cbox_filtro_producto.TabStop = false;
            this.cbox_filtro_producto.SelectedIndexChanged += new System.EventHandler(this.cbox_filtro_producto_SelectedIndexChanged);
            this.cbox_filtro_producto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbox_filtro_producto_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 155;
            this.label3.Text = "Buscar [F10]:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(96, 20);
            this.txt_buscar.MaxLength = 18;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(208, 20);
            this.txt_buscar.TabIndex = 154;
            this.txt_buscar.TabStop = false;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            this.txt_buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyDown_1);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = global::SistemaDeGestion.Properties.Resources.buscar_buscar_ampliar_icono_9048_16;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(492, 18);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(71, 23);
            this.btn_buscar.TabIndex = 153;
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
            this.bdd_productos.TabIndex = 152;
            this.bdd_productos.TabStop = false;
            this.bdd_productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdd_productos_CellDoubleClick);
            this.bdd_productos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bdd_productos_KeyDown);
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
            this.dataGridViewTextBoxColumn2.Width = 50;
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
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(69, 161);
            this.txt_cantidad.MaxLength = 4;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(82, 20);
            this.txt_cantidad.TabIndex = 6;
            this.txt_cantidad.Text = "1";
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            this.txt_cantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cantidad_KeyDown_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 149;
            this.label10.Text = "Cantidad:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Image = global::SistemaDeGestion.Properties.Resources.agregar_icono_5633_16;
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(489, 159);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 8;
            this.btn_agregar.TabStop = false;
            this.btn_agregar.Text = "A&gregar";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 139;
            this.label6.Text = "Código:";
            // 
            // btn_carrito_eliminar
            // 
            this.btn_carrito_eliminar.Image = global::SistemaDeGestion.Properties.Resources.recyclebin_vacio_icono_9473_16;
            this.btn_carrito_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_carrito_eliminar.Location = new System.Drawing.Point(489, 346);
            this.btn_carrito_eliminar.Name = "btn_carrito_eliminar";
            this.btn_carrito_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_carrito_eliminar.TabIndex = 11;
            this.btn_carrito_eliminar.TabStop = false;
            this.btn_carrito_eliminar.Text = "Limpiar";
            this.btn_carrito_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_carrito_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_carrito_eliminar.UseVisualStyleBackColor = true;
            this.btn_carrito_eliminar.Click += new System.EventHandler(this.btn_carrito_eliminar_Click);
            // 
            // btn_no_imprimir
            // 
            this.btn_no_imprimir.Image = global::SistemaDeGestion.Properties.Resources.guardar_archivo_icono_6713_16;
            this.btn_no_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_no_imprimir.Location = new System.Drawing.Point(368, 443);
            this.btn_no_imprimir.Name = "btn_no_imprimir";
            this.btn_no_imprimir.Size = new System.Drawing.Size(97, 23);
            this.btn_no_imprimir.TabIndex = 235;
            this.btn_no_imprimir.Text = "Guardar [F12]";
            this.btn_no_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_no_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_no_imprimir.UseVisualStyleBackColor = true;
            this.btn_no_imprimir.Click += new System.EventHandler(this.btn_no_imprimir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(471, 443);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(105, 23);
            this.btn_cancelar.TabIndex = 234;
            this.btn_cancelar.Text = "Cancelar [Esc]";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Image = global::SistemaDeGestion.Properties.Resources.imprimir_icono_4607_16;
            this.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_imprimir.Location = new System.Drawing.Point(266, 443);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(95, 23);
            this.btn_imprimir.TabIndex = 228;
            this.btn_imprimir.Text = "Imprimir [F11]";
            this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // Producto_Quitar_Stock
            // 
            this.AcceptButton = this.btn_agregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(608, 478);
            this.Controls.Add(this.btn_no_imprimir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.Pesos);
            this.Controls.Add(this.txt_pesos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(624, 516);
            this.MinimumSize = new System.Drawing.Size(624, 516);
            this.Name = "Producto_Quitar_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quitar productos del stock";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_carrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_no_imprimir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Label Pesos;
        private System.Windows.Forms.TextBox txt_pesos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_eliminar;
        private System.Windows.Forms.TextBox txt_codigo2;
        private System.Windows.Forms.DataGridView bdd_carrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_filtro_producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView bdd_productos;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_carrito_eliminar;
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