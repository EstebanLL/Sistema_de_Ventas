namespace SistemaDeGestion
{
    partial class Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_categorias = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_nueva = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_categorias);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // dgv_categorias
            // 
            this.dgv_categorias.AllowUserToAddRows = false;
            this.dgv_categorias.AllowUserToOrderColumns = true;
            this.dgv_categorias.AllowUserToResizeColumns = false;
            this.dgv_categorias.AllowUserToResizeRows = false;
            this.dgv_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.id_categoria,
            this.Column1,
            this.Imagen});
            this.dgv_categorias.Location = new System.Drawing.Point(14, 19);
            this.dgv_categorias.MultiSelect = false;
            this.dgv_categorias.Name = "dgv_categorias";
            this.dgv_categorias.ReadOnly = true;
            this.dgv_categorias.RowHeadersVisible = false;
            this.dgv_categorias.RowTemplate.ReadOnly = true;
            this.dgv_categorias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_categorias.Size = new System.Drawing.Size(326, 165);
            this.dgv_categorias.TabIndex = 1;
            this.dgv_categorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_categorias_CellDoubleClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 130;
            // 
            // id_categoria
            // 
            this.id_categoria.DataPropertyName = "Id_tipo_cliente";
            this.id_categoria.HeaderText = "Column1";
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.ReadOnly = true;
            this.id_categoria.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id_categoria";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Imagen
            // 
            this.Imagen.DataPropertyName = "Imagen";
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Width = 170;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(279, 227);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "&Cerrar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_nueva
            // 
            this.btn_nueva.Image = global::SistemaDeGestion.Properties.Resources.agregar_icono_5633_16;
            this.btn_nueva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nueva.Location = new System.Drawing.Point(117, 227);
            this.btn_nueva.Name = "btn_nueva";
            this.btn_nueva.Size = new System.Drawing.Size(75, 23);
            this.btn_nueva.TabIndex = 2;
            this.btn_nueva.Text = "&Nueva";
            this.btn_nueva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nueva.UseVisualStyleBackColor = true;
            this.btn_nueva.Click += new System.EventHandler(this.btn_nueva_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = global::SistemaDeGestion.Properties.Resources.dibujo_a_lapiz_modificar_escribir_icono_8118_16;
            this.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar.Location = new System.Drawing.Point(198, 227);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "&Modificar";
            this.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click_1);
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(383, 262);
            this.Controls.Add(this.btn_nueva);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(399, 300);
            this.MinimumSize = new System.Drawing.Size(399, 300);
            this.Name = "Categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nueva;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_categorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
    }
}