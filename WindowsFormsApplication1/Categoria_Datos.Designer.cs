namespace SistemaDeGestion
{
    partial class Categoria_Datos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categoria_Datos));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_imagen_no_disponible = new System.Windows.Forms.Label();
            this.pbox_imagen = new System.Windows.Forms.PictureBox();
            this.btn_examinar = new System.Windows.Forms.Button();
            this.txt_ruta_imagen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.open_buscar_imagen = new System.Windows.Forms.OpenFileDialog();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_imagen_no_disponible);
            this.groupBox1.Controls.Add(this.pbox_imagen);
            this.groupBox1.Controls.Add(this.btn_examinar);
            this.groupBox1.Controls.Add(this.txt_ruta_imagen);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 285);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label_imagen_no_disponible
            // 
            this.label_imagen_no_disponible.AutoSize = true;
            this.label_imagen_no_disponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_imagen_no_disponible.ForeColor = System.Drawing.Color.Maroon;
            this.label_imagen_no_disponible.Location = new System.Drawing.Point(66, 139);
            this.label_imagen_no_disponible.Name = "label_imagen_no_disponible";
            this.label_imagen_no_disponible.Size = new System.Drawing.Size(142, 17);
            this.label_imagen_no_disponible.TabIndex = 235;
            this.label_imagen_no_disponible.Text = "Imagen no disponible";
            // 
            // pbox_imagen
            // 
            this.pbox_imagen.Location = new System.Drawing.Point(10, 46);
            this.pbox_imagen.Name = "pbox_imagen";
            this.pbox_imagen.Size = new System.Drawing.Size(246, 198);
            this.pbox_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_imagen.TabIndex = 234;
            this.pbox_imagen.TabStop = false;
            // 
            // btn_examinar
            // 
            this.btn_examinar.Image = global::SistemaDeGestion.Properties.Resources.explorador_de_archivos_icono_6698_16;
            this.btn_examinar.Location = new System.Drawing.Point(182, 251);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(74, 23);
            this.btn_examinar.TabIndex = 3;
            this.btn_examinar.Text = "Examinar";
            this.btn_examinar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_examinar.UseVisualStyleBackColor = true;
            this.btn_examinar.Click += new System.EventHandler(this.btn_examinar_Click);
            // 
            // txt_ruta_imagen
            // 
            this.txt_ruta_imagen.Location = new System.Drawing.Point(46, 253);
            this.txt_ruta_imagen.Name = "txt_ruta_imagen";
            this.txt_ruta_imagen.ReadOnly = true;
            this.txt_ruta_imagen.Size = new System.Drawing.Size(130, 20);
            this.txt_ruta_imagen.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 231;
            this.label7.Text = "Ruta:";
            // 
            // open_buscar_imagen
            // 
            this.open_buscar_imagen.FileName = "*.png; *.jpg; *.gif";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Image = global::SistemaDeGestion.Properties.Resources.si_puede_aceptar_icono_7881_16;
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aceptar.Location = new System.Drawing.Point(112, 303);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "&Aceptar";
            this.btn_aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(193, 303);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // Categoria_Datos
            // 
            this.AcceptButton = this.btn_aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(291, 336);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(307, 374);
            this.MinimumSize = new System.Drawing.Size(307, 374);
            this.Name = "Categoria_Datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_imagen_no_disponible;
        private System.Windows.Forms.PictureBox pbox_imagen;
        private System.Windows.Forms.Button btn_examinar;
        private System.Windows.Forms.TextBox txt_ruta_imagen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog open_buscar_imagen;
    }
}