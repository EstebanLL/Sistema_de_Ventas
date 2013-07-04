namespace SistemaDeGestion
{
    partial class Venta_Imprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta_Imprimir));
            this.bnt_imprimir = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_hasta = new System.Windows.Forms.DateTimePicker();
            this.date_desde = new System.Windows.Forms.DateTimePicker();
            this.txt_pesos = new System.Windows.Forms.TextBox();
            this.chk_imprime_caja = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnt_imprimir
            // 
            this.bnt_imprimir.Image = global::SistemaDeGestion.Properties.Resources.imprimir_icono_4607_16;
            this.bnt_imprimir.Location = new System.Drawing.Point(110, 119);
            this.bnt_imprimir.Name = "bnt_imprimir";
            this.bnt_imprimir.Size = new System.Drawing.Size(75, 23);
            this.bnt_imprimir.TabIndex = 4;
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
            this.btn_cerrar.Location = new System.Drawing.Point(191, 119);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.Text = "&Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.date_hasta);
            this.groupBox1.Controls.Add(this.date_desde);
            this.groupBox1.Controls.Add(this.txt_pesos);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 170;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 169;
            this.label1.Text = "Desde:";
            // 
            // date_hasta
            // 
            this.date_hasta.Location = new System.Drawing.Point(53, 45);
            this.date_hasta.Name = "date_hasta";
            this.date_hasta.Size = new System.Drawing.Size(200, 20);
            this.date_hasta.TabIndex = 2;
            this.date_hasta.ValueChanged += new System.EventHandler(this.date_hasta_ValueChanged);
            // 
            // date_desde
            // 
            this.date_desde.Location = new System.Drawing.Point(53, 19);
            this.date_desde.Name = "date_desde";
            this.date_desde.Size = new System.Drawing.Size(200, 20);
            this.date_desde.TabIndex = 1;
            this.date_desde.ValueChanged += new System.EventHandler(this.date_desde_ValueChanged);
            // 
            // txt_pesos
            // 
            this.txt_pesos.Location = new System.Drawing.Point(60, 6);
            this.txt_pesos.Name = "txt_pesos";
            this.txt_pesos.Size = new System.Drawing.Size(100, 20);
            this.txt_pesos.TabIndex = 3;
            this.txt_pesos.Visible = false;
            // 
            // chk_imprime_caja
            // 
            this.chk_imprime_caja.AutoSize = true;
            this.chk_imprime_caja.Location = new System.Drawing.Point(66, 98);
            this.chk_imprime_caja.Name = "chk_imprime_caja";
            this.chk_imprime_caja.Size = new System.Drawing.Size(84, 17);
            this.chk_imprime_caja.TabIndex = 3;
            this.chk_imprime_caja.Text = "Imprimir caja";
            this.chk_imprime_caja.UseVisualStyleBackColor = true;
            this.chk_imprime_caja.CheckedChanged += new System.EventHandler(this.chk_imprime_caja_CheckedChanged);
            // 
            // Venta_Imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(284, 154);
            this.Controls.Add(this.chk_imprime_caja);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnt_imprimir);
            this.Controls.Add(this.btn_cerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 192);
            this.MinimumSize = new System.Drawing.Size(300, 192);
            this.Name = "Venta_Imprimir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir Listado de Ventas Realizadas";
            this.Load += new System.EventHandler(this.Venta_Imprimir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_imprimir;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_hasta;
        private System.Windows.Forms.DateTimePicker date_desde;
        private System.Windows.Forms.TextBox txt_pesos;
        private System.Windows.Forms.CheckBox chk_imprime_caja;
    }
}