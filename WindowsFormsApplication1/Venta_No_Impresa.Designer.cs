namespace SistemaDeGestion
{
    partial class Venta_No_Impresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta_No_Impresa));
            this.Pesos = new System.Windows.Forms.Label();
            this.txt_pesos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bdd_ventas = new System.Windows.Forms.DataGridView();
            this.id_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleinte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factura_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venta_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.en_pesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.date_fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_ver = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.txt_en_pesos = new System.Windows.Forms.TextBox();
            this.lbl_S_en_pesos = new System.Windows.Forms.Label();
            this.lbl_en_pesos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // Pesos
            // 
            this.Pesos.AutoSize = true;
            this.Pesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesos.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Pesos.Location = new System.Drawing.Point(488, 302);
            this.Pesos.Name = "Pesos";
            this.Pesos.Size = new System.Drawing.Size(14, 15);
            this.Pesos.TabIndex = 172;
            this.Pesos.Text = "$";
            // 
            // txt_pesos
            // 
            this.txt_pesos.Location = new System.Drawing.Point(508, 299);
            this.txt_pesos.Name = "txt_pesos";
            this.txt_pesos.ReadOnly = true;
            this.txt_pesos.Size = new System.Drawing.Size(78, 20);
            this.txt_pesos.TabIndex = 171;
            this.txt_pesos.TabStop = false;
            this.txt_pesos.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(435, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 170;
            this.label8.Text = "Total: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 168;
            this.label1.Text = "Fecha:";
            // 
            // bdd_ventas
            // 
            this.bdd_ventas.AllowUserToResizeColumns = false;
            this.bdd_ventas.AllowUserToResizeRows = false;
            this.bdd_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdd_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_venta,
            this.impres,
            this.nombre,
            this.id_cliente,
            this.cleinte,
            this.fecha,
            this.Monto,
            this.factura_numero,
            this.venta_numero,
            this.tipo,
            this.estado,
            this.iv,
            this.descuento,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.observciones,
            this.en_pesos});
            this.bdd_ventas.Location = new System.Drawing.Point(12, 52);
            this.bdd_ventas.Name = "bdd_ventas";
            this.bdd_ventas.ReadOnly = true;
            this.bdd_ventas.RowHeadersVisible = false;
            this.bdd_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdd_ventas.Size = new System.Drawing.Size(574, 231);
            this.bdd_ventas.TabIndex = 3;
            this.bdd_ventas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bdd_ventas_CellDoubleClick);
            // 
            // id_venta
            // 
            this.id_venta.DataPropertyName = "id_venta";
            this.id_venta.HeaderText = "Numero";
            this.id_venta.Name = "id_venta";
            this.id_venta.ReadOnly = true;
            this.id_venta.Width = 120;
            // 
            // impres
            // 
            this.impres.DataPropertyName = "impreso";
            this.impres.HeaderText = "impreso";
            this.impres.Name = "impres";
            this.impres.ReadOnly = true;
            this.impres.Visible = false;
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
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 130;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "total";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 122;
            // 
            // factura_numero
            // 
            this.factura_numero.DataPropertyName = "factura_numero";
            this.factura_numero.HeaderText = "factura_numero";
            this.factura_numero.Name = "factura_numero";
            this.factura_numero.ReadOnly = true;
            this.factura_numero.Visible = false;
            // 
            // venta_numero
            // 
            this.venta_numero.DataPropertyName = "venta_numero";
            this.venta_numero.HeaderText = "venta_numero";
            this.venta_numero.Name = "venta_numero";
            this.venta_numero.ReadOnly = true;
            this.venta_numero.Visible = false;
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
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // iv
            // 
            this.iv.DataPropertyName = "iva";
            this.iv.HeaderText = "Column1";
            this.iv.Name = "iv";
            this.iv.ReadOnly = true;
            this.iv.Visible = false;
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "descuento";
            this.descuento.HeaderText = "Column1";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "fdp1_monto";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "fdp2_monto";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "fdp3_monto";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "fdp4_monto";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "id_fdp_1";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "id_fdp_2";
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "id_fdp_3";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "id_fdp_4";
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // observciones
            // 
            this.observciones.DataPropertyName = "observaciones";
            this.observciones.HeaderText = "observaciones";
            this.observciones.Name = "observciones";
            this.observciones.ReadOnly = true;
            this.observciones.Visible = false;
            // 
            // en_pesos
            // 
            this.en_pesos.DataPropertyName = "en_pesos";
            this.en_pesos.HeaderText = "en_pesos";
            this.en_pesos.Name = "en_pesos";
            this.en_pesos.ReadOnly = true;
            this.en_pesos.Visible = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_cerrar.Location = new System.Drawing.Point(511, 335);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 7;
            this.btn_cerrar.Text = "&Cerrar";
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // button1
            // 
            this.button1.Image = global::SistemaDeGestion.Properties.Resources.buscar_buscar_ampliar_icono_9048_16;
            this.button1.Location = new System.Drawing.Point(283, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Buscar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date_fecha
            // 
            this.date_fecha.Location = new System.Drawing.Point(65, 16);
            this.date_fecha.Name = "date_fecha";
            this.date_fecha.Size = new System.Drawing.Size(212, 20);
            this.date_fecha.TabIndex = 1;
            // 
            // btn_ver
            // 
            this.btn_ver.Enabled = false;
            this.btn_ver.Image = global::SistemaDeGestion.Properties.Resources.ver_icono_5784_16;
            this.btn_ver.Location = new System.Drawing.Point(427, 335);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(75, 23);
            this.btn_ver.TabIndex = 6;
            this.btn_ver.Text = "&Ver";
            this.btn_ver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Image = global::SistemaDeGestion.Properties.Resources.imprimir_icono_4607_16;
            this.btn_imprimir.Location = new System.Drawing.Point(346, 335);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir.TabIndex = 5;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Visible = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // txt_en_pesos
            // 
            this.txt_en_pesos.Location = new System.Drawing.Point(346, 299);
            this.txt_en_pesos.Name = "txt_en_pesos";
            this.txt_en_pesos.Size = new System.Drawing.Size(73, 20);
            this.txt_en_pesos.TabIndex = 175;
            this.txt_en_pesos.Text = "0";
            // 
            // lbl_S_en_pesos
            // 
            this.lbl_S_en_pesos.AutoSize = true;
            this.lbl_S_en_pesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_S_en_pesos.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_S_en_pesos.Location = new System.Drawing.Point(328, 301);
            this.lbl_S_en_pesos.Name = "lbl_S_en_pesos";
            this.lbl_S_en_pesos.Size = new System.Drawing.Size(14, 15);
            this.lbl_S_en_pesos.TabIndex = 174;
            this.lbl_S_en_pesos.Text = "$";
            // 
            // lbl_en_pesos
            // 
            this.lbl_en_pesos.AutoSize = true;
            this.lbl_en_pesos.ForeColor = System.Drawing.Color.Black;
            this.lbl_en_pesos.Location = new System.Drawing.Point(276, 302);
            this.lbl_en_pesos.Name = "lbl_en_pesos";
            this.lbl_en_pesos.Size = new System.Drawing.Size(54, 13);
            this.lbl_en_pesos.TabIndex = 173;
            this.lbl_en_pesos.Text = "En pesos:";
            // 
            // Venta_No_Impresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(602, 371);
            this.Controls.Add(this.txt_en_pesos);
            this.Controls.Add(this.lbl_S_en_pesos);
            this.Controls.Add(this.lbl_en_pesos);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.date_fecha);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.Pesos);
            this.Controls.Add(this.txt_pesos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bdd_ventas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(618, 409);
            this.MinimumSize = new System.Drawing.Size(618, 409);
            this.Name = "Venta_No_Impresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos no impresos";
            ((System.ComponentModel.ISupportInitialize)(this.bdd_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pesos;
        private System.Windows.Forms.TextBox txt_pesos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bdd_ventas;
        private System.Windows.Forms.DateTimePicker date_fecha;
        private System.Windows.Forms.Button btn_ver;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn impres;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleinte;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn factura_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn venta_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn iv;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn observciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn en_pesos;
        private System.Windows.Forms.TextBox txt_en_pesos;
        private System.Windows.Forms.Label lbl_S_en_pesos;
        private System.Windows.Forms.Label lbl_en_pesos;
    }
}