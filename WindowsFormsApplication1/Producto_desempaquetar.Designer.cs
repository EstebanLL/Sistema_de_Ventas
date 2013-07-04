namespace SistemaDeGestion
{
    partial class Producto_desempaquetar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto_desempaquetar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo_caja = new System.Windows.Forms.TextBox();
            this.txt_caja_cantidad = new System.Windows.Forms.TextBox();
            this.txt_caja_descripcion = new System.Windows.Forms.RichTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_caja_buscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_producto_buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_producto_descripcion = new System.Windows.Forms.RichTextBox();
            this.txt_producto_cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_producto_codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cantidad:";
            // 
            // txt_codigo_caja
            // 
            this.txt_codigo_caja.Location = new System.Drawing.Point(86, 19);
            this.txt_codigo_caja.Name = "txt_codigo_caja";
            this.txt_codigo_caja.Size = new System.Drawing.Size(161, 20);
            this.txt_codigo_caja.TabIndex = 1;
            this.txt_codigo_caja.TextChanged += new System.EventHandler(this.txt_codigo_caja_TextChanged);
            this.txt_codigo_caja.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_codigo_caja_DragEnter);
            this.txt_codigo_caja.Enter += new System.EventHandler(this.txt_codigo_caja_Enter);
            // 
            // txt_caja_cantidad
            // 
            this.txt_caja_cantidad.Location = new System.Drawing.Point(86, 45);
            this.txt_caja_cantidad.Name = "txt_caja_cantidad";
            this.txt_caja_cantidad.Size = new System.Drawing.Size(64, 20);
            this.txt_caja_cantidad.TabIndex = 3;
            this.txt_caja_cantidad.Text = "1";
            this.txt_caja_cantidad.TextChanged += new System.EventHandler(this.txt_caja_cantidad_TextChanged);
            // 
            // txt_caja_descripcion
            // 
            this.txt_caja_descripcion.Location = new System.Drawing.Point(86, 71);
            this.txt_caja_descripcion.Name = "txt_caja_descripcion";
            this.txt_caja_descripcion.ReadOnly = true;
            this.txt_caja_descripcion.Size = new System.Drawing.Size(161, 79);
            this.txt_caja_descripcion.TabIndex = 26;
            this.txt_caja_descripcion.TabStop = false;
            this.txt_caja_descripcion.Text = "";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(5, 71);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 15);
            this.label21.TabIndex = 82;
            this.label21.Text = "Descripción:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(592, 201);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Enabled = false;
            this.btn_guardar.Image = global::SistemaDeGestion.Properties.Resources.guardar_archivo_icono_6713_16;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(506, 201);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "&Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_caja_buscar);
            this.groupBox1.Controls.Add(this.txt_codigo_caja);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_caja_descripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_caja_cantidad);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caja";
            // 
            // btn_caja_buscar
            // 
            this.btn_caja_buscar.Image = global::SistemaDeGestion.Properties.Resources.buscar_buscar_ampliar_icono_9048_16;
            this.btn_caja_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_caja_buscar.Location = new System.Drawing.Point(253, 17);
            this.btn_caja_buscar.Name = "btn_caja_buscar";
            this.btn_caja_buscar.Size = new System.Drawing.Size(66, 23);
            this.btn_caja_buscar.TabIndex = 2;
            this.btn_caja_buscar.Text = "&Buscar";
            this.btn_caja_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_caja_buscar.UseVisualStyleBackColor = true;
            this.btn_caja_buscar.Click += new System.EventHandler(this.btn_caja_buscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_producto_buscar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_producto_descripcion);
            this.groupBox2.Controls.Add(this.txt_producto_cantidad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_producto_codigo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(347, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 171);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            // 
            // btn_producto_buscar
            // 
            this.btn_producto_buscar.Image = global::SistemaDeGestion.Properties.Resources.buscar_buscar_ampliar_icono_9048_16;
            this.btn_producto_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_producto_buscar.Location = new System.Drawing.Point(254, 18);
            this.btn_producto_buscar.Name = "btn_producto_buscar";
            this.btn_producto_buscar.Size = new System.Drawing.Size(66, 23);
            this.btn_producto_buscar.TabIndex = 6;
            this.btn_producto_buscar.Text = "&Buscar";
            this.btn_producto_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_producto_buscar.UseVisualStyleBackColor = true;
            this.btn_producto_buscar.Click += new System.EventHandler(this.btn_producto_buscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 91;
            this.label5.Text = "Descripción:";
            // 
            // txt_producto_descripcion
            // 
            this.txt_producto_descripcion.Location = new System.Drawing.Point(87, 73);
            this.txt_producto_descripcion.Name = "txt_producto_descripcion";
            this.txt_producto_descripcion.ReadOnly = true;
            this.txt_producto_descripcion.Size = new System.Drawing.Size(161, 79);
            this.txt_producto_descripcion.TabIndex = 90;
            this.txt_producto_descripcion.TabStop = false;
            this.txt_producto_descripcion.Text = "";
            // 
            // txt_producto_cantidad
            // 
            this.txt_producto_cantidad.Location = new System.Drawing.Point(87, 47);
            this.txt_producto_cantidad.Name = "txt_producto_cantidad";
            this.txt_producto_cantidad.Size = new System.Drawing.Size(64, 20);
            this.txt_producto_cantidad.TabIndex = 7;
            this.txt_producto_cantidad.Text = "1";
            this.txt_producto_cantidad.TextChanged += new System.EventHandler(this.txt_producto_cantidad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Código:";
            // 
            // txt_producto_codigo
            // 
            this.txt_producto_codigo.Location = new System.Drawing.Point(87, 21);
            this.txt_producto_codigo.Name = "txt_producto_codigo";
            this.txt_producto_codigo.Size = new System.Drawing.Size(161, 20);
            this.txt_producto_codigo.TabIndex = 5;
            this.txt_producto_codigo.TextChanged += new System.EventHandler(this.txt_producto_codigo_TextChanged);
            this.txt_producto_codigo.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_producto_codigo_DragEnter);
            this.txt_producto_codigo.Enter += new System.EventHandler(this.txt_producto_codigo_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Cantidad:";
            // 
            // Producto_desempaquetar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(701, 245);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(717, 283);
            this.MinimumSize = new System.Drawing.Size(717, 283);
            this.Name = "Producto_desempaquetar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Caja de Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo_caja;
        private System.Windows.Forms.TextBox txt_caja_cantidad;
        private System.Windows.Forms.RichTextBox txt_caja_descripcion;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_caja_buscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_producto_buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txt_producto_descripcion;
        private System.Windows.Forms.TextBox txt_producto_cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_producto_codigo;
        private System.Windows.Forms.Label label4;
    }
}