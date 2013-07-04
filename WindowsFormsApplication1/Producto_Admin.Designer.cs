namespace SistemaDeGestion
{
    partial class Producto_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto_Admin));
            this.bdd_productos = new System.Windows.Forms.DataGridView();
            this.Id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_filtro_producto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_a_pdf = new System.Windows.Forms.Button();
            this.bdd_pdf = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_desempaquetar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_baja_stock = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_alta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_pdf)).BeginInit();
            this.SuspendLayout();
            // 
            // bdd_productos
            // 
            this.bdd_productos.AllowUserToResizeRows = false;
            this.bdd_productos.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bdd_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bdd_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_producto,
            this.Codigo,
            this.Detalles,
            this.cate,
            this.precio_unidad,
            this.iva,
            this.margen,
            this.stock_min,
            this.nombrecategoria,
            this.stock,
            this.imagen,
            this.imagen_categoria,
            this.Precio});
            this.bdd_productos.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.bdd_productos.Location = new System.Drawing.Point(12, 67);
            this.bdd_productos.MultiSelect = false;
            this.bdd_productos.Name = "bdd_productos";
            this.bdd_productos.ReadOnly = true;
            this.bdd_productos.RowHeadersVisible = false;
            this.bdd_productos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bdd_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdd_productos.Size = new System.Drawing.Size(627, 253);
            this.bdd_productos.TabIndex = 4;
            this.bdd_productos.TabStop = false;
            this.bdd_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdd_productos_CellContentClick);
            this.bdd_productos.DoubleClick += new System.EventHandler(this.bdd_productos_DoubleClick);
            // 
            // Id_producto
            // 
            this.Id_producto.DataPropertyName = "Id_producto";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_producto.DefaultCellStyle = dataGridViewCellStyle2;
            this.Id_producto.HeaderText = "Id_producto";
            this.Id_producto.Name = "Id_producto";
            this.Id_producto.ReadOnly = true;
            this.Id_producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Id_producto.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 130;
            // 
            // Detalles
            // 
            this.Detalles.DataPropertyName = "detalle";
            this.Detalles.HeaderText = "Detalle";
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            this.Detalles.Width = 280;
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
            // iva
            // 
            this.iva.DataPropertyName = "iva";
            this.iva.HeaderText = "iva";
            this.iva.Name = "iva";
            this.iva.ReadOnly = true;
            this.iva.Visible = false;
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
            // nombrecategoria
            // 
            this.nombrecategoria.DataPropertyName = "nombrecategoria";
            this.nombrecategoria.HeaderText = "Categoria";
            this.nombrecategoria.Name = "nombrecategoria";
            this.nombrecategoria.ReadOnly = true;
            this.nombrecategoria.Width = 130;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.stock.DefaultCellStyle = dataGridViewCellStyle3;
            this.stock.HeaderText = "En Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Visible = false;
            this.stock.Width = 60;
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
            this.imagen_categoria.HeaderText = "Column1";
            this.imagen_categoria.Name = "imagen_categoria";
            this.imagen_categoria.ReadOnly = true;
            this.imagen_categoria.Visible = false;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "total";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle4;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 150;
            this.label2.Text = "Filtrar por:";
            // 
            // cbox_filtro_producto
            // 
            this.cbox_filtro_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_filtro_producto.FormattingEnabled = true;
            this.cbox_filtro_producto.Items.AddRange(new object[] {
            "Detalle",
            "Código",
            "Stock Bajo"});
            this.cbox_filtro_producto.Location = new System.Drawing.Point(392, 27);
            this.cbox_filtro_producto.Name = "cbox_filtro_producto";
            this.cbox_filtro_producto.Size = new System.Drawing.Size(166, 21);
            this.cbox_filtro_producto.TabIndex = 2;
            this.cbox_filtro_producto.SelectedIndexChanged += new System.EventHandler(this.cbox_filtro_producto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 148;
            this.label1.Text = "Buscar:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(64, 28);
            this.txt_buscar.MaxLength = 18;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(263, 20);
            this.txt_buscar.TabIndex = 1;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // btn_a_pdf
            // 
            this.btn_a_pdf.Location = new System.Drawing.Point(158, 335);
            this.btn_a_pdf.Name = "btn_a_pdf";
            this.btn_a_pdf.Size = new System.Drawing.Size(75, 23);
            this.btn_a_pdf.TabIndex = 152;
            this.btn_a_pdf.Text = "Informe";
            this.btn_a_pdf.UseVisualStyleBackColor = true;
            this.btn_a_pdf.Visible = false;
            this.btn_a_pdf.Click += new System.EventHandler(this.btn_a_pdf_Click);
            // 
            // bdd_pdf
            // 
            this.bdd_pdf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdd_pdf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.PrecioUnidad});
            this.bdd_pdf.Location = new System.Drawing.Point(710, 134);
            this.bdd_pdf.Name = "bdd_pdf";
            this.bdd_pdf.RowHeadersVisible = false;
            this.bdd_pdf.Size = new System.Drawing.Size(313, 150);
            this.bdd_pdf.TabIndex = 154;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // PrecioUnidad
            // 
            this.PrecioUnidad.DataPropertyName = "total";
            this.PrecioUnidad.HeaderText = "Precio";
            this.PrecioUnidad.Name = "PrecioUnidad";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = global::SistemaDeGestion.Properties.Resources.buscar_buscar_ampliar_icono_9048_16;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(564, 26);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "&Buscar";
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.Location = new System.Drawing.Point(564, 335);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 9;
            this.btn_cerrar.Text = "&Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_desempaquetar
            // 
            this.btn_desempaquetar.Image = global::SistemaDeGestion.Properties.Resources.paquete_de_caja_icono_5213_16;
            this.btn_desempaquetar.Location = new System.Drawing.Point(401, 335);
            this.btn_desempaquetar.Name = "btn_desempaquetar";
            this.btn_desempaquetar.Size = new System.Drawing.Size(76, 23);
            this.btn_desempaquetar.TabIndex = 155;
            this.btn_desempaquetar.Text = "Abrir Caja";
            this.btn_desempaquetar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_desempaquetar.UseVisualStyleBackColor = true;
            this.btn_desempaquetar.Visible = false;
            this.btn_desempaquetar.Click += new System.EventHandler(this.btn_desempaquetar_Click);
            // 
            // button1
            // 
            this.button1.Image = global::SistemaDeGestion.Properties.Resources.microsoft_office_word_2003_icono_8261_16;
            this.button1.Location = new System.Drawing.Point(158, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exportar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_baja_stock
            // 
            this.btn_baja_stock.Image = global::SistemaDeGestion.Properties.Resources.eliminar_icono_4912_16;
            this.btn_baja_stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_baja_stock.Location = new System.Drawing.Point(483, 335);
            this.btn_baja_stock.Name = "btn_baja_stock";
            this.btn_baja_stock.Size = new System.Drawing.Size(75, 23);
            this.btn_baja_stock.TabIndex = 8;
            this.btn_baja_stock.Text = "&Quitar";
            this.btn_baja_stock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_baja_stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_baja_stock.UseVisualStyleBackColor = true;
            this.btn_baja_stock.Visible = false;
            this.btn_baja_stock.Click += new System.EventHandler(this.btn_baja_stock_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = global::SistemaDeGestion.Properties.Resources.dibujo_a_lapiz_modificar_escribir_icono_8118_16;
            this.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar.Location = new System.Drawing.Point(320, 335);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 7;
            this.btn_modificar.Text = "&Modificar";
            this.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_alta
            // 
            this.btn_alta.Image = global::SistemaDeGestion.Properties.Resources.agregar_icono_5633_16;
            this.btn_alta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alta.Location = new System.Drawing.Point(239, 335);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(75, 23);
            this.btn_alta.TabIndex = 6;
            this.btn_alta.Text = "&Agregar";
            this.btn_alta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.button5_Click);
            // 
            // Producto_Admin
            // 
            this.AcceptButton = this.btn_buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(656, 370);
            this.Controls.Add(this.btn_desempaquetar);
            this.Controls.Add(this.bdd_pdf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_a_pdf);
            this.Controls.Add(this.btn_baja_stock);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.bdd_productos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox_filtro_producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_buscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(672, 408);
            this.MinimumSize = new System.Drawing.Size(672, 408);
            this.Name = "Producto_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Productos";
            ((System.ComponentModel.ISupportInitialize)(this.bdd_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_pdf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bdd_productos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_filtro_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_baja_stock;
        private System.Windows.Forms.Button btn_a_pdf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView bdd_pdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnidad;
        private System.Windows.Forms.Button btn_desempaquetar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn cate;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn margen;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_min;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagen_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}