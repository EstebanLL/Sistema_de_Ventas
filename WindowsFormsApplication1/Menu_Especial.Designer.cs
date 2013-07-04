namespace SistemaDeGestion
{
    partial class Menu_Especial
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
            this.btn_borrar_ventas = new System.Windows.Forms.Button();
            this.btn_borrar_compras = new System.Windows.Forms.Button();
            this.btn_borrar_producto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btm_cerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_borrar_ventas
            // 
            this.btn_borrar_ventas.Location = new System.Drawing.Point(203, 27);
            this.btn_borrar_ventas.Name = "btn_borrar_ventas";
            this.btn_borrar_ventas.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar_ventas.TabIndex = 0;
            this.btn_borrar_ventas.Text = "Borrar";
            this.btn_borrar_ventas.UseVisualStyleBackColor = true;
            this.btn_borrar_ventas.Click += new System.EventHandler(this.btn_borrar_ventas_Click);
            // 
            // btn_borrar_compras
            // 
            this.btn_borrar_compras.Location = new System.Drawing.Point(203, 66);
            this.btn_borrar_compras.Name = "btn_borrar_compras";
            this.btn_borrar_compras.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar_compras.TabIndex = 1;
            this.btn_borrar_compras.Text = "Borrar";
            this.btn_borrar_compras.UseVisualStyleBackColor = true;
            this.btn_borrar_compras.Click += new System.EventHandler(this.btn_borrar_compras_Click);
            // 
            // btn_borrar_producto
            // 
            this.btn_borrar_producto.Location = new System.Drawing.Point(202, 17);
            this.btn_borrar_producto.Name = "btn_borrar_producto";
            this.btn_borrar_producto.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar_producto.TabIndex = 2;
            this.btn_borrar_producto.Text = "Borrar";
            this.btn_borrar_producto.UseVisualStyleBackColor = true;
            this.btn_borrar_producto.Click += new System.EventHandler(this.btn_borrar_producto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pedidos no impresos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Compras sin Facturas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_borrar_ventas);
            this.groupBox1.Controls.Add(this.btn_borrar_compras);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 103);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Varios";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_codigo);
            this.groupBox2.Controls.Add(this.btn_borrar_producto);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 86);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(61, 19);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(135, 20);
            this.txt_codigo.TabIndex = 3;
            // 
            // btm_cerrar
            // 
            this.btm_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btm_cerrar.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btm_cerrar.Location = new System.Drawing.Point(215, 223);
            this.btm_cerrar.Name = "btm_cerrar";
            this.btm_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btm_cerrar.TabIndex = 9;
            this.btm_cerrar.Text = "&Cerrar";
            this.btm_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btm_cerrar.UseVisualStyleBackColor = true;
            // 
            // Menu_Especial
            // 
            this.AcceptButton = this.btn_borrar_producto;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 252);
            this.Controls.Add(this.btm_cerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu_Especial";
            this.Text = "Menu_Especial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_borrar_ventas;
        private System.Windows.Forms.Button btn_borrar_compras;
        private System.Windows.Forms.Button btn_borrar_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button btm_cerrar;
    }
}