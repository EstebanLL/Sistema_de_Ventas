namespace SistemaDeGestion
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tx_iva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_iva = new System.Windows.Forms.Label();
            this.txt_real = new System.Windows.Forms.TextBox();
            this.txt_conexion = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_mas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tx_iva);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_iva);
            this.groupBox1.Controls.Add(this.txt_real);
            this.groupBox1.Controls.Add(this.txt_conexion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurar Sistema";
            // 
            // tx_iva
            // 
            this.tx_iva.Location = new System.Drawing.Point(128, 43);
            this.tx_iva.Name = "tx_iva";
            this.tx_iva.Size = new System.Drawing.Size(100, 20);
            this.tx_iva.TabIndex = 2;
            this.tx_iva.TextChanged += new System.EventHandler(this.tx_iva_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IVA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dirección de conexión:";
            // 
            // txt_iva
            // 
            this.txt_iva.AutoSize = true;
            this.txt_iva.Location = new System.Drawing.Point(92, 16);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(35, 13);
            this.txt_iva.TabIndex = 1;
            this.txt_iva.Text = "Real :";
            // 
            // txt_real
            // 
            this.txt_real.Location = new System.Drawing.Point(128, 13);
            this.txt_real.Name = "txt_real";
            this.txt_real.Size = new System.Drawing.Size(100, 20);
            this.txt_real.TabIndex = 1;
            this.txt_real.TextChanged += new System.EventHandler(this.txt_real_TextChanged);
            // 
            // txt_conexion
            // 
            this.txt_conexion.Location = new System.Drawing.Point(128, 74);
            this.txt_conexion.Name = "txt_conexion";
            this.txt_conexion.ReadOnly = true;
            this.txt_conexion.Size = new System.Drawing.Size(200, 20);
            this.txt_conexion.TabIndex = 3;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Image = global::SistemaDeGestion.Properties.Resources.guardar_archivo_icono_6713_16;
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aceptar.Location = new System.Drawing.Point(181, 118);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "&Guardar";
            this.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(271, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_mas
            // 
            this.btn_mas.Location = new System.Drawing.Point(90, 118);
            this.btn_mas.Name = "btn_mas";
            this.btn_mas.Size = new System.Drawing.Size(75, 23);
            this.btn_mas.TabIndex = 6;
            this.btn_mas.Text = "Ver Más";
            this.btn_mas.UseVisualStyleBackColor = true;
            this.btn_mas.Visible = false;
            this.btn_mas.Click += new System.EventHandler(this.btn_mas_Click);
            // 
            // Configuracion
            // 
            this.AcceptButton = this.btn_aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(360, 153);
            this.Controls.Add(this.btn_mas);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(376, 191);
            this.MinimumSize = new System.Drawing.Size(376, 191);
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txt_iva;
        private System.Windows.Forms.TextBox txt_real;
        private System.Windows.Forms.TextBox tx_iva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_conexion;
        private System.Windows.Forms.Button btn_mas;
    }
}