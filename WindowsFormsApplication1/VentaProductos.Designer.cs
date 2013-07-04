namespace SistemaDeGestion
{
    partial class VentaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaProductos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_subtotal_sin_desc = new System.Windows.Forms.TextBox();
            this.bdd_carrito = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbox_factura_num = new System.Windows.Forms.ComboBox();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_RUT = new System.Windows.Forms.TextBox();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_doc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.txt_venta_num = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.txt_con_iva = new System.Windows.Forms.TextBox();
            this.txt_subtotal_pesos = new System.Windows.Forms.TextBox();
            this.txt_descuento_pesos = new System.Windows.Forms.TextBox();
            this.txt_iva_pesos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_descuento_porcent = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_descuento_porcentaje = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txt_observaciones = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label_porcentaje_o_plata = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_carrito)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_subtotal_sin_desc);
            this.groupBox1.Controls.Add(this.bdd_carrito);
            this.groupBox1.Location = new System.Drawing.Point(12, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 257);
            this.groupBox1.TabIndex = 156;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos Comprados";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(373, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 161;
            this.label15.Text = "Subtotal : $";
            // 
            // txt_subtotal_sin_desc
            // 
            this.txt_subtotal_sin_desc.Location = new System.Drawing.Point(438, 227);
            this.txt_subtotal_sin_desc.Name = "txt_subtotal_sin_desc";
            this.txt_subtotal_sin_desc.ReadOnly = true;
            this.txt_subtotal_sin_desc.Size = new System.Drawing.Size(100, 20);
            this.txt_subtotal_sin_desc.TabIndex = 10;
            this.txt_subtotal_sin_desc.TabStop = false;
            this.txt_subtotal_sin_desc.Text = "0";
            this.txt_subtotal_sin_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.dataGridViewTextBoxColumn5,
            this.Categoria,
            this.Cantidad,
            this.dataGridViewTextBoxColumn6,
            this.Column5});
            this.bdd_carrito.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.bdd_carrito.Location = new System.Drawing.Point(6, 19);
            this.bdd_carrito.MultiSelect = false;
            this.bdd_carrito.Name = "bdd_carrito";
            this.bdd_carrito.ReadOnly = true;
            this.bdd_carrito.RowHeadersVisible = false;
            this.bdd_carrito.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bdd_carrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdd_carrito.Size = new System.Drawing.Size(546, 202);
            this.bdd_carrito.TabIndex = 9;
            this.bdd_carrito.TabStop = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dato2";
            this.dataGridViewTextBoxColumn4.HeaderText = "Código";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_venta";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "id_venta_producto";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "producto";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "id_producto";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dato1";
            this.dataGridViewTextBoxColumn5.HeaderText = "Detalle";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 240;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "dato3";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 55;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "precio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "dato4";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "Importe";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbox_factura_num);
            this.groupBox3.Controls.Add(this.txt_tipo);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_RUT);
            this.groupBox3.Controls.Add(this.txt_ciudad);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_direccion);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_doc);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_pais);
            this.groupBox3.Controls.Add(this.txt_venta_num);
            this.groupBox3.Controls.Add(this.fecha);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_cliente);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 159);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos ";
            // 
            // cbox_factura_num
            // 
            this.cbox_factura_num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_factura_num.FormattingEnabled = true;
            this.cbox_factura_num.Location = new System.Drawing.Point(74, 46);
            this.cbox_factura_num.Name = "cbox_factura_num";
            this.cbox_factura_num.Size = new System.Drawing.Size(155, 21);
            this.cbox_factura_num.TabIndex = 2;
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(310, 46);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.ReadOnly = true;
            this.txt_tipo.Size = new System.Drawing.Size(155, 20);
            this.txt_tipo.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 160;
            this.label11.Text = "Tipo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 159;
            this.label10.Text = "Factura Nº:";
            // 
            // txt_RUT
            // 
            this.txt_RUT.Location = new System.Drawing.Point(310, 125);
            this.txt_RUT.Name = "txt_RUT";
            this.txt_RUT.ReadOnly = true;
            this.txt_RUT.Size = new System.Drawing.Size(155, 20);
            this.txt_RUT.TabIndex = 8;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(310, 98);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.ReadOnly = true;
            this.txt_ciudad.Size = new System.Drawing.Size(155, 20);
            this.txt_ciudad.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 155;
            this.label9.Text = "RUT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 154;
            this.label7.Text = "Ciudad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 153;
            this.label6.Text = "Documento:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(74, 98);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.ReadOnly = true;
            this.txt_direccion.Size = new System.Drawing.Size(155, 20);
            this.txt_direccion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 151;
            this.label5.Text = "Dirección:";
            // 
            // txt_doc
            // 
            this.txt_doc.Location = new System.Drawing.Point(310, 71);
            this.txt_doc.Name = "txt_doc";
            this.txt_doc.ReadOnly = true;
            this.txt_doc.Size = new System.Drawing.Size(155, 20);
            this.txt_doc.TabIndex = 5;
            this.txt_doc.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 149;
            this.label4.Text = "País:";
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(74, 125);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.ReadOnly = true;
            this.txt_pais.Size = new System.Drawing.Size(155, 20);
            this.txt_pais.TabIndex = 7;
            this.txt_pais.TabStop = false;
            // 
            // txt_venta_num
            // 
            this.txt_venta_num.Location = new System.Drawing.Point(74, 19);
            this.txt_venta_num.Name = "txt_venta_num";
            this.txt_venta_num.ReadOnly = true;
            this.txt_venta_num.Size = new System.Drawing.Size(155, 20);
            this.txt_venta_num.TabIndex = 1;
            this.txt_venta_num.TabStop = false;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(310, 19);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(196, 20);
            this.fecha.TabIndex = 3;
            this.fecha.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 134;
            this.label1.Text = "Venta Nº:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 147;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 136;
            this.label2.Text = "Nombre:";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(74, 71);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.ReadOnly = true;
            this.txt_cliente.Size = new System.Drawing.Size(155, 20);
            this.txt_cliente.TabIndex = 4;
            this.txt_cliente.TabStop = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.Location = new System.Drawing.Point(729, 453);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 201;
            this.btn_cerrar.Text = "&Cerrar";
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Image = global::SistemaDeGestion.Properties.Resources.imprimir_icono_4607_16;
            this.btn_imprimir.Location = new System.Drawing.Point(648, 453);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir.TabIndex = 200;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // txt_con_iva
            // 
            this.txt_con_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_con_iva.Location = new System.Drawing.Point(136, 134);
            this.txt_con_iva.Name = "txt_con_iva";
            this.txt_con_iva.ReadOnly = true;
            this.txt_con_iva.Size = new System.Drawing.Size(84, 24);
            this.txt_con_iva.TabIndex = 252;
            this.txt_con_iva.TabStop = false;
            this.txt_con_iva.Text = "0";
            this.txt_con_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_subtotal_pesos
            // 
            this.txt_subtotal_pesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subtotal_pesos.Location = new System.Drawing.Point(159, 75);
            this.txt_subtotal_pesos.Name = "txt_subtotal_pesos";
            this.txt_subtotal_pesos.ReadOnly = true;
            this.txt_subtotal_pesos.Size = new System.Drawing.Size(61, 22);
            this.txt_subtotal_pesos.TabIndex = 255;
            this.txt_subtotal_pesos.TabStop = false;
            this.txt_subtotal_pesos.Text = "0";
            this.txt_subtotal_pesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_descuento_pesos
            // 
            this.txt_descuento_pesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descuento_pesos.Location = new System.Drawing.Point(159, 44);
            this.txt_descuento_pesos.Name = "txt_descuento_pesos";
            this.txt_descuento_pesos.ReadOnly = true;
            this.txt_descuento_pesos.Size = new System.Drawing.Size(61, 22);
            this.txt_descuento_pesos.TabIndex = 251;
            this.txt_descuento_pesos.TabStop = false;
            this.txt_descuento_pesos.Text = "0";
            this.txt_descuento_pesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_iva_pesos
            // 
            this.txt_iva_pesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iva_pesos.Location = new System.Drawing.Point(159, 103);
            this.txt_iva_pesos.Name = "txt_iva_pesos";
            this.txt_iva_pesos.ReadOnly = true;
            this.txt_iva_pesos.Size = new System.Drawing.Size(61, 22);
            this.txt_iva_pesos.TabIndex = 248;
            this.txt_iva_pesos.TabStop = false;
            this.txt_iva_pesos.Text = "0";
            this.txt_iva_pesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label13.Location = new System.Drawing.Point(135, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 16);
            this.label13.TabIndex = 260;
            this.label13.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(58, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 259;
            this.label14.Text = "Descuento:";
            // 
            // txt_descuento_porcent
            // 
            this.txt_descuento_porcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descuento_porcent.Location = new System.Drawing.Point(159, 16);
            this.txt_descuento_porcent.Name = "txt_descuento_porcent";
            this.txt_descuento_porcent.ReadOnly = true;
            this.txt_descuento_porcent.Size = new System.Drawing.Size(61, 22);
            this.txt_descuento_porcent.TabIndex = 258;
            this.txt_descuento_porcent.TabStop = false;
            this.txt_descuento_porcent.Text = "0";
            this.txt_descuento_porcent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox5);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.comboBox4);
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.comboBox3);
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.comboBox2);
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.txt_descuento_porcentaje);
            this.groupBox6.Location = new System.Drawing.Point(581, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(230, 159);
            this.groupBox6.TabIndex = 263;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Formas de Pago";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(160, 121);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(64, 20);
            this.textBox5.TabIndex = 11;
            this.textBox5.TabStop = false;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(140, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "$";
            // 
            // comboBox4
            // 
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(13, 120);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 9;
            this.comboBox4.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(160, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(64, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.TabStop = false;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(140, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "$";
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(13, 93);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(64, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TabStop = false;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(140, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "$";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(64, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TabStop = false;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(140, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "$";
            // 
            // txt_descuento_porcentaje
            // 
            this.txt_descuento_porcentaje.Enabled = false;
            this.txt_descuento_porcentaje.FormattingEnabled = true;
            this.txt_descuento_porcentaje.Location = new System.Drawing.Point(13, 40);
            this.txt_descuento_porcentaje.Name = "txt_descuento_porcentaje";
            this.txt_descuento_porcentaje.Size = new System.Drawing.Size(121, 21);
            this.txt_descuento_porcentaje.TabIndex = 0;
            this.txt_descuento_porcentaje.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txt_observaciones);
            this.groupBox8.Location = new System.Drawing.Point(581, 349);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(230, 85);
            this.groupBox8.TabIndex = 262;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Observaciones";
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.Location = new System.Drawing.Point(6, 19);
            this.txt_observaciones.MaxLength = 496;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.ReadOnly = true;
            this.txt_observaciones.Size = new System.Drawing.Size(217, 60);
            this.txt_observaciones.TabIndex = 0;
            this.txt_observaciones.TabStop = false;
            this.txt_observaciones.Text = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label_porcentaje_o_plata);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.txt_con_iva);
            this.groupBox7.Controls.Add(this.txt_descuento_porcent);
            this.groupBox7.Controls.Add(this.txt_subtotal_pesos);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.txt_descuento_pesos);
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Controls.Add(this.txt_iva_pesos);
            this.groupBox7.Location = new System.Drawing.Point(581, 177);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(230, 166);
            this.groupBox7.TabIndex = 261;
            this.groupBox7.TabStop = false;
            // 
            // label_porcentaje_o_plata
            // 
            this.label_porcentaje_o_plata.AutoSize = true;
            this.label_porcentaje_o_plata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_porcentaje_o_plata.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_porcentaje_o_plata.Location = new System.Drawing.Point(137, 48);
            this.label_porcentaje_o_plata.Name = "label_porcentaje_o_plata";
            this.label_porcentaje_o_plata.Size = new System.Drawing.Size(16, 16);
            this.label_porcentaje_o_plata.TabIndex = 248;
            this.label_porcentaje_o_plata.Text = "$";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label20.Location = new System.Drawing.Point(63, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 16);
            this.label20.TabIndex = 244;
            this.label20.Text = "Subtotal: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label21.Location = new System.Drawing.Point(137, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 16);
            this.label21.TabIndex = 246;
            this.label21.Text = "$";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(52, 138);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 20);
            this.label22.TabIndex = 240;
            this.label22.Text = "TOTAL: $";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label26.Location = new System.Drawing.Point(137, 106);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(16, 16);
            this.label26.TabIndex = 239;
            this.label26.Text = "$";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(104, 108);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(27, 13);
            this.label27.TabIndex = 236;
            this.label27.Text = "IVA:";
            // 
            // VentaProductos
            // 
            this.AcceptButton = this.btn_cerrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(822, 485);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(838, 523);
            this.MinimumSize = new System.Drawing.Size(838, 523);
            this.Name = "VentaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos Vendidos";
            this.Load += new System.EventHandler(this.VentaProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_carrito)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView bdd_carrito;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_doc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.TextBox txt_venta_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_RUT;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_con_iva;
        private System.Windows.Forms.TextBox txt_subtotal_pesos;
        private System.Windows.Forms.TextBox txt_descuento_pesos;
        private System.Windows.Forms.TextBox txt_iva_pesos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_subtotal_sin_desc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_descuento_porcent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox txt_descuento_porcentaje;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox txt_observaciones;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label_porcentaje_o_plata;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cbox_factura_num;
    }
}