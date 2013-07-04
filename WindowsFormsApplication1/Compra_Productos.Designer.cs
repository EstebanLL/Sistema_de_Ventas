namespace SistemaDeGestion
{
    partial class Compra_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra_Productos));
            this.label8 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bdd_carrito = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.date_fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_num_factura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_total_pesos = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_carrito)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(424, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 179;
            this.label8.Text = "TOTAL: ";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(475, 256);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(69, 20);
            this.txt_total.TabIndex = 8;
            this.txt_total.TabStop = false;
            this.txt_total.Text = "0";
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.bdd_carrito);
            this.groupBox2.Controls.Add(this.txt_total);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 286);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 176;
            this.label6.Text = "Subtotal :";
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.dataGridViewTextBoxColumn5,
            this.Cantidad,
            this.dataGridViewTextBoxColumn6,
            this.importe2});
            this.bdd_carrito.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.bdd_carrito.Location = new System.Drawing.Point(18, 29);
            this.bdd_carrito.MultiSelect = false;
            this.bdd_carrito.Name = "bdd_carrito";
            this.bdd_carrito.ReadOnly = true;
            this.bdd_carrito.RowHeadersVisible = false;
            this.bdd_carrito.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bdd_carrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdd_carrito.Size = new System.Drawing.Size(546, 221);
            this.bdd_carrito.TabIndex = 7;
            this.bdd_carrito.TabStop = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "dato2";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_compra";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "id_compra_producto";
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
            this.Column4.DataPropertyName = "dato3";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "id_producto";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "dato4";
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dato1";
            this.dataGridViewTextBoxColumn5.HeaderText = "Detalle";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 240;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "cantidad";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "precio";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // importe2
            // 
            this.importe2.DataPropertyName = "dato4";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.importe2.DefaultCellStyle = dataGridViewCellStyle4;
            this.importe2.HeaderText = "Importe";
            this.importe2.Name = "importe2";
            this.importe2.ReadOnly = true;
            this.importe2.Width = 75;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_proveedor);
            this.groupBox1.Controls.Add(this.txt_tipo);
            this.groupBox1.Controls.Add(this.txt_estado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.date_vencimiento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.date_fecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_num_factura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 106);
            this.groupBox1.TabIndex = 181;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura";
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Location = new System.Drawing.Point(74, 71);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.ReadOnly = true;
            this.txt_proveedor.Size = new System.Drawing.Size(188, 20);
            this.txt_proveedor.TabIndex = 3;
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(74, 45);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.ReadOnly = true;
            this.txt_tipo.Size = new System.Drawing.Size(188, 20);
            this.txt_tipo.TabIndex = 2;
            // 
            // txt_estado
            // 
            this.txt_estado.ForeColor = System.Drawing.Color.Black;
            this.txt_estado.Location = new System.Drawing.Point(363, 72);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.ReadOnly = true;
            this.txt_estado.Size = new System.Drawing.Size(200, 20);
            this.txt_estado.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Estado:";
            // 
            // date_vencimiento
            // 
            this.date_vencimiento.Enabled = false;
            this.date_vencimiento.Location = new System.Drawing.Point(363, 45);
            this.date_vencimiento.Name = "date_vencimiento";
            this.date_vencimiento.Size = new System.Drawing.Size(200, 20);
            this.date_vencimiento.TabIndex = 5;
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
            this.date_fecha.Enabled = false;
            this.date_fecha.Location = new System.Drawing.Point(363, 19);
            this.date_fecha.Name = "date_fecha";
            this.date_fecha.Size = new System.Drawing.Size(200, 20);
            this.date_fecha.TabIndex = 4;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // txt_num_factura
            // 
            this.txt_num_factura.Location = new System.Drawing.Point(74, 19);
            this.txt_num_factura.Name = "txt_num_factura";
            this.txt_num_factura.ReadOnly = true;
            this.txt_num_factura.Size = new System.Drawing.Size(188, 20);
            this.txt_num_factura.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nº Factura:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Proveedor:";
            // 
            // txt_total_pesos
            // 
            this.txt_total_pesos.Location = new System.Drawing.Point(487, 424);
            this.txt_total_pesos.Name = "txt_total_pesos";
            this.txt_total_pesos.Size = new System.Drawing.Size(69, 20);
            this.txt_total_pesos.TabIndex = 183;
            this.txt_total_pesos.Text = "9";
            this.txt_total_pesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_aceptar.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aceptar.Location = new System.Drawing.Point(501, 454);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 10;
            this.btn_aceptar.Text = "&Cerrar";
            this.btn_aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_pagar
            // 
            this.btn_pagar.Enabled = false;
            this.btn_pagar.Image = global::SistemaDeGestion.Properties.Resources.moneda_verde_dinero_en_efectivo_en_dolares_icono_5593_16;
            this.btn_pagar.Location = new System.Drawing.Point(420, 454);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(75, 23);
            this.btn_pagar.TabIndex = 9;
            this.btn_pagar.Text = "&Pagar";
            this.btn_pagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_pagar.UseVisualStyleBackColor = true;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // Compra_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_aceptar;
            this.ClientSize = new System.Drawing.Size(611, 489);
            this.Controls.Add(this.txt_total_pesos);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_aceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(627, 527);
            this.MinimumSize = new System.Drawing.Size(627, 527);
            this.Name = "Compra_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos Comprados";
            this.Load += new System.EventHandler(this.Compra_Productos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_carrito)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView bdd_carrito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_vencimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_num_factura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_proveedor;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe2;
        private System.Windows.Forms.TextBox txt_total_pesos;
    }
}