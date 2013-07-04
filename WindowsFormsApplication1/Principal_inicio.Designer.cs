namespace SistemaDeGestion
{
    partial class Principal_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_real = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_factura_numero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_venta_numero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_factura_prefijo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_venta_prefijo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_facturas_vencidas = new System.Windows.Forms.Button();
            this.label_facturas_vencidas = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_ver_productos = new System.Windows.Forms.Button();
            this.label_productos_stock = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_ver_clientes = new System.Windows.Forms.Button();
            this.label_clientes_aniversario = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al sistema";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Location = new System.Drawing.Point(208, 36);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(35, 13);
            this.label_fecha.TabIndex = 4;
            this.label_fecha.Text = "label4";
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_usuario.Location = new System.Drawing.Point(127, 18);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(70, 13);
            this.label_usuario.TabIndex = 1;
            this.label_usuario.Text = "Administrador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label_fecha);
            this.groupBox1.Controls.Add(this.txt_real);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_monto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caja";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Hoy :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "(1 R$ a Pesos)";
            // 
            // txt_real
            // 
            this.txt_real.Location = new System.Drawing.Point(61, 59);
            this.txt_real.MaxLength = 8;
            this.txt_real.Name = "txt_real";
            this.txt_real.Size = new System.Drawing.Size(100, 20);
            this.txt_real.TabIndex = 5;
            this.txt_real.Text = "0";
            this.txt_real.TextChanged += new System.EventHandler(this.txt_real_TextChanged);
            this.txt_real.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_real_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Real:";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(61, 33);
            this.txt_monto.MaxLength = 8;
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(100, 20);
            this.txt_monto.TabIndex = 4;
            this.txt_monto.Text = "0";
            this.txt_monto.TextChanged += new System.EventHandler(this.txt_monto_TextChanged);
            this.txt_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_factura_numero);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_venta_numero);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_factura_prefijo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_venta_prefijo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Facturación";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(248, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "(Númerico)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(92, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "(AlfaNúmerico)";
            // 
            // txt_factura_numero
            // 
            this.txt_factura_numero.Location = new System.Drawing.Point(219, 61);
            this.txt_factura_numero.MaxLength = 15;
            this.txt_factura_numero.Name = "txt_factura_numero";
            this.txt_factura_numero.Size = new System.Drawing.Size(115, 20);
            this.txt_factura_numero.TabIndex = 10;
            this.txt_factura_numero.TextChanged += new System.EventHandler(this.txt_factura_numero_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Número:";
            // 
            // txt_venta_numero
            // 
            this.txt_venta_numero.Location = new System.Drawing.Point(219, 35);
            this.txt_venta_numero.MaxLength = 15;
            this.txt_venta_numero.Name = "txt_venta_numero";
            this.txt_venta_numero.Size = new System.Drawing.Size(115, 20);
            this.txt_venta_numero.TabIndex = 8;
            this.txt_venta_numero.TextChanged += new System.EventHandler(this.txt_venta_numero_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Número:";
            // 
            // txt_factura_prefijo
            // 
            this.txt_factura_prefijo.Location = new System.Drawing.Point(92, 61);
            this.txt_factura_prefijo.MaxLength = 15;
            this.txt_factura_prefijo.Name = "txt_factura_prefijo";
            this.txt_factura_prefijo.Size = new System.Drawing.Size(68, 20);
            this.txt_factura_prefijo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Factura Prefijo:";
            // 
            // txt_venta_prefijo
            // 
            this.txt_venta_prefijo.Location = new System.Drawing.Point(92, 35);
            this.txt_venta_prefijo.MaxLength = 15;
            this.txt_venta_prefijo.Name = "txt_venta_prefijo";
            this.txt_venta_prefijo.Size = new System.Drawing.Size(68, 20);
            this.txt_venta_prefijo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Venta Prefijo:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::SistemaDeGestion.Properties.Resources.guardar_archivo_icono_6713_16;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(194, 361);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(71, 23);
            this.btn_guardar.TabIndex = 11;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(274, 361);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(73, 23);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_facturas_vencidas
            // 
            this.btn_facturas_vencidas.Location = new System.Drawing.Point(211, 69);
            this.btn_facturas_vencidas.Name = "btn_facturas_vencidas";
            this.btn_facturas_vencidas.Size = new System.Drawing.Size(75, 23);
            this.btn_facturas_vencidas.TabIndex = 241;
            this.btn_facturas_vencidas.Text = "Ver";
            this.btn_facturas_vencidas.UseVisualStyleBackColor = true;
            this.btn_facturas_vencidas.Click += new System.EventHandler(this.btn_facturas_vencidas_Click_1);
            // 
            // label_facturas_vencidas
            // 
            this.label_facturas_vencidas.AutoSize = true;
            this.label_facturas_vencidas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_facturas_vencidas.Location = new System.Drawing.Point(164, 74);
            this.label_facturas_vencidas.Name = "label_facturas_vencidas";
            this.label_facturas_vencidas.Size = new System.Drawing.Size(41, 13);
            this.label_facturas_vencidas.TabIndex = 247;
            this.label_facturas_vencidas.Text = "label13";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(58, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 246;
            this.label15.Text = "Facturas vencidas :";
            // 
            // btn_ver_productos
            // 
            this.btn_ver_productos.Location = new System.Drawing.Point(211, 98);
            this.btn_ver_productos.Name = "btn_ver_productos";
            this.btn_ver_productos.Size = new System.Drawing.Size(75, 23);
            this.btn_ver_productos.TabIndex = 240;
            this.btn_ver_productos.Text = "Ver";
            this.btn_ver_productos.UseVisualStyleBackColor = true;
            this.btn_ver_productos.Visible = false;
            this.btn_ver_productos.Click += new System.EventHandler(this.btn_ver_productos_Click_1);
            // 
            // label_productos_stock
            // 
            this.label_productos_stock.AutoSize = true;
            this.label_productos_stock.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_productos_stock.Location = new System.Drawing.Point(164, 103);
            this.label_productos_stock.Name = "label_productos_stock";
            this.label_productos_stock.Size = new System.Drawing.Size(41, 13);
            this.label_productos_stock.TabIndex = 245;
            this.label_productos_stock.Text = "label13";
            this.label_productos_stock.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 13);
            this.label14.TabIndex = 244;
            this.label14.Text = "Productos en Stock Critico :";
            this.label14.Visible = false;
            // 
            // btn_ver_clientes
            // 
            this.btn_ver_clientes.Location = new System.Drawing.Point(211, 40);
            this.btn_ver_clientes.Name = "btn_ver_clientes";
            this.btn_ver_clientes.Size = new System.Drawing.Size(75, 23);
            this.btn_ver_clientes.TabIndex = 239;
            this.btn_ver_clientes.Text = "Ver";
            this.btn_ver_clientes.UseVisualStyleBackColor = true;
            this.btn_ver_clientes.Click += new System.EventHandler(this.btn_ver_clientes_Click_1);
            // 
            // label_clientes_aniversario
            // 
            this.label_clientes_aniversario.AutoSize = true;
            this.label_clientes_aniversario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_clientes_aniversario.Location = new System.Drawing.Point(164, 45);
            this.label_clientes_aniversario.Name = "label_clientes_aniversario";
            this.label_clientes_aniversario.Size = new System.Drawing.Size(41, 13);
            this.label_clientes_aniversario.TabIndex = 243;
            this.label_clientes_aniversario.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 13);
            this.label12.TabIndex = 242;
            this.label12.Text = "Cumpleaños de Usuarios : ";
            // 
            // Principal_inicio
            // 
            this.AcceptButton = this.btn_guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(384, 393);
            this.Controls.Add(this.btn_facturas_vencidas);
            this.Controls.Add(this.label_facturas_vencidas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_ver_productos);
            this.Controls.Add(this.label_productos_stock);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_ver_clientes);
            this.Controls.Add(this.label_clientes_aniversario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 431);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 431);
            this.Name = "Principal_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_inicio_FormClosing);
            this.Load += new System.EventHandler(this.Principal_inicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_real;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_factura_numero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_venta_numero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_factura_prefijo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_venta_prefijo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_facturas_vencidas;
        private System.Windows.Forms.Label label_facturas_vencidas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_ver_productos;
        private System.Windows.Forms.Label label_productos_stock;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_ver_clientes;
        private System.Windows.Forms.Label label_clientes_aniversario;
        private System.Windows.Forms.Label label12;
    }
}