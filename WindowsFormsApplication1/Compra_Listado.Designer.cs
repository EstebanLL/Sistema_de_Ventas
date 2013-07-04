namespace SistemaDeGestion
{
    partial class Compra_Listado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra_Listado));
            this.Pesos = new System.Windows.Forms.Label();
            this.txt_pesos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.date_fecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_filtro_producto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.bdd_compra = new System.Windows.Forms.DataGridView();
            this.id_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleinte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnt_imprimir = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_compra)).BeginInit();
            this.SuspendLayout();
            // 
            // Pesos
            // 
            this.Pesos.AutoSize = true;
            this.Pesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesos.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Pesos.Location = new System.Drawing.Point(488, 314);
            this.Pesos.Name = "Pesos";
            this.Pesos.Size = new System.Drawing.Size(14, 15);
            this.Pesos.TabIndex = 173;
            this.Pesos.Text = "$";
            // 
            // txt_pesos
            // 
            this.txt_pesos.Location = new System.Drawing.Point(508, 311);
            this.txt_pesos.Name = "txt_pesos";
            this.txt_pesos.ReadOnly = true;
            this.txt_pesos.Size = new System.Drawing.Size(78, 20);
            this.txt_pesos.TabIndex = 5;
            this.txt_pesos.TabStop = false;
            this.txt_pesos.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(435, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 171;
            this.label8.Text = "Total: ";
            // 
            // date_fecha
            // 
            this.date_fecha.Location = new System.Drawing.Point(69, 28);
            this.date_fecha.Name = "date_fecha";
            this.date_fecha.Size = new System.Drawing.Size(205, 20);
            this.date_fecha.TabIndex = 0;
            this.date_fecha.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 170;
            this.label2.Text = "Filtrar por:";
            // 
            // cbox_filtro_producto
            // 
            this.cbox_filtro_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_filtro_producto.FormattingEnabled = true;
            this.cbox_filtro_producto.Items.AddRange(new object[] {
            "Factura",
            "Fecha",
            "Proveedor",
            "Debe",
            "Vencidos"});
            this.cbox_filtro_producto.Location = new System.Drawing.Point(337, 27);
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
            this.label1.TabIndex = 169;
            this.label1.Text = "Buscar:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(69, 28);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(205, 20);
            this.txt_buscar.TabIndex = 168;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // bdd_compra
            // 
            this.bdd_compra.AllowUserToResizeColumns = false;
            this.bdd_compra.AllowUserToResizeRows = false;
            this.bdd_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdd_compra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_venta,
            this.fecha,
            this.cleinte,
            this.nombre,
            this.Tipo,
            this.Estado,
            this.pro,
            this.id_cliente,
            this.fecha_vencimiento,
            this.fecha_factura,
            this.Importe});
            this.bdd_compra.Location = new System.Drawing.Point(12, 64);
            this.bdd_compra.Name = "bdd_compra";
            this.bdd_compra.ReadOnly = true;
            this.bdd_compra.RowHeadersVisible = false;
            this.bdd_compra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdd_compra.Size = new System.Drawing.Size(574, 231);
            this.bdd_compra.TabIndex = 4;
            this.bdd_compra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdd_compra_CellDoubleClick);
            // 
            // id_venta
            // 
            this.id_venta.DataPropertyName = "numero_factura";
            this.id_venta.HeaderText = "Factura";
            this.id_venta.Name = "id_venta";
            this.id_venta.ReadOnly = true;
            this.id_venta.Width = 130;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 80;
            // 
            // cleinte
            // 
            this.cleinte.DataPropertyName = "id_proveedor";
            this.cleinte.HeaderText = "id_proveedor";
            this.cleinte.Name = "cleinte";
            this.cleinte.ReadOnly = true;
            this.cleinte.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "dato";
            this.nombre.HeaderText = "Proveedor";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 130;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 70;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 62;
            // 
            // pro
            // 
            this.pro.DataPropertyName = "Proveedor";
            this.pro.HeaderText = "pro";
            this.pro.Name = "pro";
            this.pro.ReadOnly = true;
            this.pro.Visible = false;
            // 
            // id_cliente
            // 
            this.id_cliente.DataPropertyName = "id_compra";
            this.id_cliente.HeaderText = "id_venta";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            this.id_cliente.Visible = false;
            // 
            // fecha_vencimiento
            // 
            this.fecha_vencimiento.DataPropertyName = "fecha_vencimiento";
            this.fecha_vencimiento.HeaderText = "fecha_vencimiento";
            this.fecha_vencimiento.Name = "fecha_vencimiento";
            this.fecha_vencimiento.ReadOnly = true;
            this.fecha_vencimiento.Visible = false;
            // 
            // fecha_factura
            // 
            this.fecha_factura.DataPropertyName = "fecha_factura";
            this.fecha_factura.HeaderText = "fecha_factura";
            this.fecha_factura.Name = "fecha_factura";
            this.fecha_factura.ReadOnly = true;
            this.fecha_factura.Visible = false;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle1;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 80;
            // 
            // bnt_imprimir
            // 
            this.bnt_imprimir.Image = global::SistemaDeGestion.Properties.Resources.imprimir_icono_4607_16;
            this.bnt_imprimir.Location = new System.Drawing.Point(349, 347);
            this.bnt_imprimir.Name = "bnt_imprimir";
            this.bnt_imprimir.Size = new System.Drawing.Size(75, 23);
            this.bnt_imprimir.TabIndex = 6;
            this.bnt_imprimir.Text = "Imprimir";
            this.bnt_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnt_imprimir.UseVisualStyleBackColor = true;
            this.bnt_imprimir.Click += new System.EventHandler(this.bnt_imprimir_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.Location = new System.Drawing.Point(511, 347);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 8;
            this.btn_cerrar.Text = "&Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // button1
            // 
            this.button1.Image = global::SistemaDeGestion.Properties.Resources.buscar_buscar_ampliar_icono_9048_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(509, 25);
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
            this.btn_ver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ver.Location = new System.Drawing.Point(430, 347);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(75, 23);
            this.btn_ver.TabIndex = 7;
            this.btn_ver.Text = "&Ver";
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // Compra_Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(609, 386);
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
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.bdd_compra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(625, 424);
            this.MinimumSize = new System.Drawing.Size(625, 424);
            this.Name = "Compra_Listado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras Realizadas";
            ((System.ComponentModel.ISupportInitialize)(this.bdd_compra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_imprimir;
        private System.Windows.Forms.Label Pesos;
        private System.Windows.Forms.TextBox txt_pesos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker date_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_filtro_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_ver;
        private System.Windows.Forms.DataGridView bdd_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleinte;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}