namespace SistemaDeGestion
{
    partial class Ventana_Error
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_error = new System.Windows.Forms.RichTextBox();
            this.btn_copiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.saveExportar = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Se ha producido un error en el sitema. ";
            // 
            // txt_error
            // 
            this.txt_error.Location = new System.Drawing.Point(12, 110);
            this.txt_error.Name = "txt_error";
            this.txt_error.Size = new System.Drawing.Size(433, 119);
            this.txt_error.TabIndex = 0;
            this.txt_error.Text = "";
            // 
            // btn_copiar
            // 
            this.btn_copiar.Image = global::SistemaDeGestion.Properties.Resources.pagina_copiar_icono_4625_16;
            this.btn_copiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_copiar.Location = new System.Drawing.Point(208, 235);
            this.btn_copiar.Name = "btn_copiar";
            this.btn_copiar.Size = new System.Drawing.Size(75, 23);
            this.btn_copiar.TabIndex = 1;
            this.btn_copiar.Text = "Copiar";
            this.btn_copiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_copiar.UseVisualStyleBackColor = true;
            this.btn_copiar.Click += new System.EventHandler(this.btn_copiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SistemaDeGestion.Properties.Resources.cerca_de_la_cruz_eliminar_la_salida_de_error_icono_5953_128;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_cerrar.Location = new System.Drawing.Point(370, 235);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 3;
            this.btn_cerrar.Text = "Cerrar  ";
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::SistemaDeGestion.Properties.Resources.guardar_archivo_icono_6713_161;
            this.btn_guardar.Location = new System.Drawing.Point(289, 235);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "Exportar";
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "email";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ventana_Error
            // 
            this.AcceptButton = this.btn_guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_copiar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_guardar);
            this.Name = "Ventana_Error";
            this.Text = "Ventana_Error";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_error;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_copiar;
        private System.Windows.Forms.SaveFileDialog saveExportar;
        private System.Windows.Forms.Button button1;
    }
}