namespace TALLER_DE_MODA
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
            this.Nomnbre = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.Label();
            this.boton_menu_tipo_usario = new System.Windows.Forms.Button();
            this.boton_cerrar_tipo_usario = new System.Windows.Forms.Button();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.text_clave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nomnbre
            // 
            this.Nomnbre.AutoSize = true;
            this.Nomnbre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nomnbre.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Nomnbre.Location = new System.Drawing.Point(197, 31);
            this.Nomnbre.Name = "Nomnbre";
            this.Nomnbre.Size = new System.Drawing.Size(68, 16);
            this.Nomnbre.TabIndex = 1;
            this.Nomnbre.Text = "IDUsuario";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Clave.Location = new System.Drawing.Point(197, 68);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(43, 16);
            this.Clave.TabIndex = 2;
            this.Clave.Text = "Clave";
            // 
            // boton_menu_tipo_usario
            // 
            this.boton_menu_tipo_usario.BackColor = System.Drawing.Color.DarkCyan;
            this.boton_menu_tipo_usario.ForeColor = System.Drawing.Color.White;
            this.boton_menu_tipo_usario.Location = new System.Drawing.Point(29, 323);
            this.boton_menu_tipo_usario.Name = "boton_menu_tipo_usario";
            this.boton_menu_tipo_usario.Size = new System.Drawing.Size(105, 22);
            this.boton_menu_tipo_usario.TabIndex = 3;
            this.boton_menu_tipo_usario.Text = "Iniciar Menu";
            this.boton_menu_tipo_usario.UseVisualStyleBackColor = false;
            this.boton_menu_tipo_usario.Click += new System.EventHandler(this.Boton_login_Click);
            // 
            // boton_cerrar_tipo_usario
            // 
            this.boton_cerrar_tipo_usario.BackColor = System.Drawing.Color.DarkCyan;
            this.boton_cerrar_tipo_usario.ForeColor = System.Drawing.Color.White;
            this.boton_cerrar_tipo_usario.Location = new System.Drawing.Point(29, 351);
            this.boton_cerrar_tipo_usario.Name = "boton_cerrar_tipo_usario";
            this.boton_cerrar_tipo_usario.Size = new System.Drawing.Size(105, 23);
            this.boton_cerrar_tipo_usario.TabIndex = 9;
            this.boton_cerrar_tipo_usario.Text = "Cerrar sesíon";
            this.boton_cerrar_tipo_usario.UseVisualStyleBackColor = false;
            this.boton_cerrar_tipo_usario.Click += new System.EventHandler(this.Boton_cerrar_Click);
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(273, 24);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(86, 20);
            this.text_nombre.TabIndex = 0;
            // 
            // text_clave
            // 
            this.text_clave.Location = new System.Drawing.Point(273, 65);
            this.text_clave.Name = "text_clave";
            this.text_clave.PasswordChar = '*';
            this.text_clave.Size = new System.Drawing.Size(86, 20);
            this.text_clave.TabIndex = 1;
            // 
            // Login
            // 
            this.AcceptButton = this.boton_menu_tipo_usario;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImage = global::TALLER_DE_MODA.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 391);
            this.Controls.Add(this.text_clave);
            this.Controls.Add(this.text_nombre);
            this.Controls.Add(this.boton_cerrar_tipo_usario);
            this.Controls.Add(this.boton_menu_tipo_usario);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.Nomnbre);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_clave;
        public System.Windows.Forms.Button boton_menu_tipo_usario;
        public System.Windows.Forms.Button boton_cerrar_tipo_usario;
        public System.Windows.Forms.Label Clave;
        public System.Windows.Forms.Label Nomnbre;
        public System.Windows.Forms.TextBox text_nombre;
    }
}