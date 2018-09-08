namespace TALLER_DE_MODA
{
    partial class Cambiar_contraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cambiar_contraseña));
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.text_clave_nueva = new System.Windows.Forms.TextBox();
            this.text_repite_clave = new System.Windows.Forms.TextBox();
            this.button_cambiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.foto = new System.Windows.Forms.PictureBox();
            this.boton_volver_menu = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.textnombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.White;
            this.txt_ID.Location = new System.Drawing.Point(270, 40);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(63, 20);
            this.txt_ID.TabIndex = 13;
            // 
            // text_clave_nueva
            // 
            this.text_clave_nueva.Location = new System.Drawing.Point(270, 76);
            this.text_clave_nueva.Name = "text_clave_nueva";
            this.text_clave_nueva.PasswordChar = '*';
            this.text_clave_nueva.Size = new System.Drawing.Size(63, 20);
            this.text_clave_nueva.TabIndex = 14;
            // 
            // text_repite_clave
            // 
            this.text_repite_clave.Location = new System.Drawing.Point(270, 115);
            this.text_repite_clave.Name = "text_repite_clave";
            this.text_repite_clave.PasswordChar = '*';
            this.text_repite_clave.Size = new System.Drawing.Size(63, 20);
            this.text_repite_clave.TabIndex = 16;
            // 
            // button_cambiar
            // 
            this.button_cambiar.BackColor = System.Drawing.Color.DarkCyan;
            this.button_cambiar.ForeColor = System.Drawing.Color.White;
            this.button_cambiar.Location = new System.Drawing.Point(187, 163);
            this.button_cambiar.Name = "button_cambiar";
            this.button_cambiar.Size = new System.Drawing.Size(75, 23);
            this.button_cambiar.TabIndex = 17;
            this.button_cambiar.Text = "Cambiar";
            this.button_cambiar.UseVisualStyleBackColor = false;
            this.button_cambiar.Click += new System.EventHandler(this.Button_cambiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "IdUsuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nueva Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Repetir Clave";
            // 
            // foto
            // 
            this.foto.BackgroundImage = global::TALLER_DE_MODA.Properties.Resources.boton_empleado;
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foto.Location = new System.Drawing.Point(12, 40);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(165, 204);
            this.foto.TabIndex = 22;
            this.foto.TabStop = false;
            // 
            // boton_volver_menu
            // 
            this.boton_volver_menu.BackColor = System.Drawing.Color.DarkCyan;
            this.boton_volver_menu.ForeColor = System.Drawing.Color.White;
            this.boton_volver_menu.Location = new System.Drawing.Point(286, 241);
            this.boton_volver_menu.Name = "boton_volver_menu";
            this.boton_volver_menu.Size = new System.Drawing.Size(75, 23);
            this.boton_volver_menu.TabIndex = 23;
            this.boton_volver_menu.Text = "volver";
            this.boton_volver_menu.UseVisualStyleBackColor = false;
            this.boton_volver_menu.Click += new System.EventHandler(this.Boton_volver_menu_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(270, 163);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // textnombre
            // 
            this.textnombre.BackColor = System.Drawing.Color.White;
            this.textnombre.Location = new System.Drawing.Point(12, 12);
            this.textnombre.Name = "textnombre";
            this.textnombre.ReadOnly = true;
            this.textnombre.Size = new System.Drawing.Size(165, 20);
            this.textnombre.TabIndex = 25;
            this.textnombre.Text = "Usuario:    ";
            // 
            // Cambiar_contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(364, 265);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.boton_volver_menu);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cambiar);
            this.Controls.Add(this.text_repite_clave);
            this.Controls.Add(this.text_clave_nueva);
            this.Controls.Add(this.txt_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cambiar_contraseña";
            this.Text = "                                CAMBIAR CONTRASEÑA";
            this.Load += new System.EventHandler(this.Cambiar_contraseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox text_clave_nueva;
        private System.Windows.Forms.TextBox text_repite_clave;
        private System.Windows.Forms.Button button_cambiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Button boton_volver_menu;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox textnombre;
    }
}