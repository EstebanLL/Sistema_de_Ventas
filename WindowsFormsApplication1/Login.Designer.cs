namespace SistemaDeGestion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label3 = new System.Windows.Forms.Label();
            this.cbox_catego = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(11, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Iniciar Como: ";
            // 
            // cbox_catego
            // 
            this.cbox_catego.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_catego.FormattingEnabled = true;
            this.cbox_catego.Location = new System.Drawing.Point(86, 62);
            this.cbox_catego.Name = "cbox_catego";
            this.cbox_catego.Size = new System.Drawing.Size(140, 21);
            this.cbox_catego.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Contraseña: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Usuario:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(86, 39);
            this.txt_password.MaxLength = 10;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(140, 20);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "1234lcda";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(86, 16);
            this.txt_usuario.MaxLength = 10;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(140, 20);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.Text = "Admin";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Image = global::SistemaDeGestion.Properties.Resources.si_puede_aceptar_icono_7881_16;
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_aceptar.Location = new System.Drawing.Point(70, 105);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "&Aceptar";
            this.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_salir.Image = global::SistemaDeGestion.Properties.Resources.cancelar_icono_4624_482;
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_salir.Location = new System.Drawing.Point(151, 105);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "&Cancelar";
            this.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click_1);
            // 
            // Login
            // 
            this.AcceptButton = this.btn_aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_salir;
            this.ClientSize = new System.Drawing.Size(265, 160);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbox_catego);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(271, 188);
            this.MinimumSize = new System.Drawing.Size(271, 188);
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbox_catego;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button btn_aceptar;
    }
}