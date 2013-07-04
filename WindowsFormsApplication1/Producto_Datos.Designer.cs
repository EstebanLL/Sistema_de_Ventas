namespace SistemaDeGestion
{
    partial class Producto_Datos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto_Datos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_minimo = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_categoria = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_precio_con_iva = new System.Windows.Forms.TextBox();
            this.txt_iva_2 = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_margen_2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_margen_1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.txt_precio_unidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_imagen_no_disponible = new System.Windows.Forms.Label();
            this.chk_imagen_categoria = new System.Windows.Forms.CheckBox();
            this.pbox_imagen = new System.Windows.Forms.PictureBox();
            this.btn_examinar = new System.Windows.Forms.Button();
            this.txt_ruta_imagen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.open_buscar_imagen = new System.Windows.Forms.OpenFileDialog();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_stock);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_minimo);
            this.groupBox2.Controls.Add(this.txt_codigo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_descripcion);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_cantidad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbox_categoria);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 184);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descripción";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(93, 155);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.ReadOnly = true;
            this.txt_stock.Size = new System.Drawing.Size(78, 20);
            this.txt_stock.TabIndex = 5;
            this.txt_stock.TabStop = false;
            this.txt_stock.Text = "0";
            this.txt_stock.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Stock:";
            this.label6.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 86;
            this.label1.Text = "Min:";
            this.label1.Visible = false;
            // 
            // txt_minimo
            // 
            this.txt_minimo.Location = new System.Drawing.Point(214, 155);
            this.txt_minimo.MaxLength = 4;
            this.txt_minimo.Name = "txt_minimo";
            this.txt_minimo.Size = new System.Drawing.Size(53, 20);
            this.txt_minimo.TabIndex = 6;
            this.txt_minimo.Text = "0";
            this.txt_minimo.Visible = false;
            this.txt_minimo.TextChanged += new System.EventHandler(this.txt_minimo_TextChanged);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(94, 24);
            this.txt_codigo.MaxLength = 19;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(255, 20);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            this.txt_codigo.Leave += new System.EventHandler(this.txt_codigo_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 84;
            this.label5.Text = "Codigo:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(94, 49);
            this.txt_descripcion.MaxLength = 440;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(255, 46);
            this.txt_descripcion.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 67;
            this.label8.Text = "Cantidad:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(94, 130);
            this.txt_cantidad.MaxLength = 4;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.ReadOnly = true;
            this.txt_cantidad.Size = new System.Drawing.Size(77, 20);
            this.txt_cantidad.TabIndex = 0;
            this.txt_cantidad.Text = "0";
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 72;
            this.label2.Text = "Categoria:";
            // 
            // cbox_categoria
            // 
            this.cbox_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_categoria.ItemHeight = 13;
            this.cbox_categoria.Location = new System.Drawing.Point(94, 103);
            this.cbox_categoria.Name = "cbox_categoria";
            this.cbox_categoria.Size = new System.Drawing.Size(173, 21);
            this.cbox_categoria.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(13, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 15);
            this.label21.TabIndex = 81;
            this.label21.Text = "Descripción:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_precio_con_iva);
            this.groupBox1.Controls.Add(this.txt_iva_2);
            this.groupBox1.Controls.Add(this.txt_total);
            this.groupBox1.Controls.Add(this.txt_margen_2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_margen_1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_iva);
            this.groupBox1.Controls.Add(this.txt_precio_unidad);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Costos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 118;
            this.label4.Text = "Precio con IVA: ";
            // 
            // txt_precio_con_iva
            // 
            this.txt_precio_con_iva.ForeColor = System.Drawing.Color.Blue;
            this.txt_precio_con_iva.Location = new System.Drawing.Point(102, 68);
            this.txt_precio_con_iva.Name = "txt_precio_con_iva";
            this.txt_precio_con_iva.ReadOnly = true;
            this.txt_precio_con_iva.Size = new System.Drawing.Size(95, 20);
            this.txt_precio_con_iva.TabIndex = 9;
            this.txt_precio_con_iva.TabStop = false;
            // 
            // txt_iva_2
            // 
            this.txt_iva_2.ForeColor = System.Drawing.Color.Blue;
            this.txt_iva_2.Location = new System.Drawing.Point(143, 42);
            this.txt_iva_2.MaxLength = 99;
            this.txt_iva_2.Name = "txt_iva_2";
            this.txt_iva_2.ReadOnly = true;
            this.txt_iva_2.Size = new System.Drawing.Size(53, 20);
            this.txt_iva_2.TabIndex = 8;
            this.txt_iva_2.TabStop = false;
            // 
            // txt_total
            // 
            this.txt_total.ForeColor = System.Drawing.Color.Blue;
            this.txt_total.Location = new System.Drawing.Point(269, 68);
            this.txt_total.MaxLength = 9;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(95, 20);
            this.txt_total.TabIndex = 10;
            this.txt_total.Text = "0";
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            this.txt_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_total_KeyPress);
            // 
            // txt_margen_2
            // 
            this.txt_margen_2.ForeColor = System.Drawing.Color.Blue;
            this.txt_margen_2.Location = new System.Drawing.Point(311, 42);
            this.txt_margen_2.MaxLength = 99;
            this.txt_margen_2.Name = "txt_margen_2";
            this.txt_margen_2.ReadOnly = true;
            this.txt_margen_2.Size = new System.Drawing.Size(53, 20);
            this.txt_margen_2.TabIndex = 11;
            this.txt_margen_2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(204, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 15);
            this.label13.TabIndex = 114;
            this.label13.Text = "TOTAL:";
            // 
            // txt_margen_1
            // 
            this.txt_margen_1.Location = new System.Drawing.Point(270, 42);
            this.txt_margen_1.MaxLength = 8;
            this.txt_margen_1.Name = "txt_margen_1";
            this.txt_margen_1.Size = new System.Drawing.Size(37, 20);
            this.txt_margen_1.TabIndex = 9;
            this.txt_margen_1.Text = "0";
            this.txt_margen_1.TextChanged += new System.EventHandler(this.txt_margen_1_TextChanged);
            this.txt_margen_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_margen_1_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(204, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 15);
            this.label12.TabIndex = 114;
            this.label12.Text = "Margen:";
            // 
            // txt_iva
            // 
            this.txt_iva.Location = new System.Drawing.Point(102, 42);
            this.txt_iva.MaxLength = 8;
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(37, 20);
            this.txt_iva.TabIndex = 8;
            this.txt_iva.Text = "0";
            this.txt_iva.TextChanged += new System.EventHandler(this.txt_iva_TextChanged);
            this.txt_iva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_iva_KeyPress);
            // 
            // txt_precio_unidad
            // 
            this.txt_precio_unidad.Location = new System.Drawing.Point(102, 14);
            this.txt_precio_unidad.MaxLength = 8;
            this.txt_precio_unidad.Name = "txt_precio_unidad";
            this.txt_precio_unidad.Size = new System.Drawing.Size(53, 20);
            this.txt_precio_unidad.TabIndex = 7;
            this.txt_precio_unidad.Text = "0";
            this.txt_precio_unidad.TextChanged += new System.EventHandler(this.txt_precio_unidad_TextChanged);
            this.txt_precio_unidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_unidad_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Precio unidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Iva:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_imagen_no_disponible);
            this.groupBox3.Controls.Add(this.chk_imagen_categoria);
            this.groupBox3.Controls.Add(this.pbox_imagen);
            this.groupBox3.Controls.Add(this.btn_examinar);
            this.groupBox3.Controls.Add(this.txt_ruta_imagen);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(394, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 287);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagen";
            // 
            // label_imagen_no_disponible
            // 
            this.label_imagen_no_disponible.AutoSize = true;
            this.label_imagen_no_disponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_imagen_no_disponible.ForeColor = System.Drawing.Color.Maroon;
            this.label_imagen_no_disponible.Location = new System.Drawing.Point(73, 141);
            this.label_imagen_no_disponible.Name = "label_imagen_no_disponible";
            this.label_imagen_no_disponible.Size = new System.Drawing.Size(142, 17);
            this.label_imagen_no_disponible.TabIndex = 230;
            this.label_imagen_no_disponible.Text = "Imagen no disponible";
            // 
            // chk_imagen_categoria
            // 
            this.chk_imagen_categoria.AutoSize = true;
            this.chk_imagen_categoria.Location = new System.Drawing.Point(17, 25);
            this.chk_imagen_categoria.Name = "chk_imagen_categoria";
            this.chk_imagen_categoria.Size = new System.Drawing.Size(158, 17);
            this.chk_imagen_categoria.TabIndex = 11;
            this.chk_imagen_categoria.Text = "Usar imagen de la categoria";
            this.chk_imagen_categoria.UseVisualStyleBackColor = true;
            this.chk_imagen_categoria.CheckedChanged += new System.EventHandler(this.chk_imagen_categoria_CheckedChanged);
            // 
            // pbox_imagen
            // 
            this.pbox_imagen.Location = new System.Drawing.Point(17, 48);
            this.pbox_imagen.Name = "pbox_imagen";
            this.pbox_imagen.Size = new System.Drawing.Size(246, 198);
            this.pbox_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_imagen.TabIndex = 3;
            this.pbox_imagen.TabStop = false;
            // 
            // btn_examinar
            // 
            this.btn_examinar.Image = global::SistemaDeGestion.Properties.Resources.explorador_de_archivos_icono_6698_161;
            this.btn_examinar.Location = new System.Drawing.Point(189, 253);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(74, 23);
            this.btn_examinar.TabIndex = 12;
            this.btn_examinar.Text = "Examinar";
            this.btn_examinar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_examinar.UseVisualStyleBackColor = true;
            this.btn_examinar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ruta_imagen
            // 
            this.txt_ruta_imagen.Location = new System.Drawing.Point(53, 255);
            this.txt_ruta_imagen.Name = "txt_ruta_imagen";
            this.txt_ruta_imagen.ReadOnly = true;
            this.txt_ruta_imagen.Size = new System.Drawing.Size(130, 20);
            this.txt_ruta_imagen.TabIndex = 1;
            this.txt_ruta_imagen.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ruta:";
            // 
            // open_buscar_imagen
            // 
            this.open_buscar_imagen.FileName = "*.png; *.jpg; *.gif";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(600, 310);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::SistemaDeGestion.Properties.Resources.guardar_archivo_icono_6713_16;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(519, 310);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "&Guardar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Producto_Datos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(692, 345);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btnAceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(708, 383);
            this.MinimumSize = new System.Drawing.Size(708, 383);
            this.Name = "Producto_Datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_categoria;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_iva_2;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_margen_2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_margen_1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.TextBox txt_precio_unidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_precio_con_iva;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbox_imagen;
        private System.Windows.Forms.Button btn_examinar;
        private System.Windows.Forms.TextBox txt_ruta_imagen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog open_buscar_imagen;
        private System.Windows.Forms.CheckBox chk_imagen_categoria;
        private System.Windows.Forms.Label label_imagen_no_disponible;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_minimo;
    }
}