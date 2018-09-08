namespace TALLER_DE_MODA
{
    partial class Ventana_User
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
            this.SuspendLayout();
            // 
            // boton_menu_administrador
            // 
           
            // 
            // boton_contraseña_administrador
            // 
            this.boton_contraseña_administrador.Location = new System.Drawing.Point(26, 169);
            // 
            // boton_cerrar_administrador
            // 
            this.boton_cerrar_administrador.Location = new System.Drawing.Point(26, 207);
            // 
            // salir_administrador
            // 
            this.iniciar_administrador.Location = new System.Drawing.Point(233, 198);
            this.iniciar_administrador.Click += new System.EventHandler(this.salir_administrador_Click);
            // 
            // administrador
            // 
            this.administrador.Location = new System.Drawing.Point(23, 70);
            this.administrador.Size = new System.Drawing.Size(37, 13);
            this.administrador.Text = "Usario";
            // 
            // Nomnbre_administrador
            // 
            this.Nomnbre_administrador.Size = new System.Drawing.Size(50, 13);
            this.Nomnbre_administrador.Text = "Nombre  ";
            // 
            // boton_administrador_usario
            // 
            this.boton_administrador_usario.Location = new System.Drawing.Point(147, 175);
            this.boton_administrador_usario.Size = new System.Drawing.Size(10, 10);
            this.boton_administrador_usario.Text = "";
            // 
            // Ventana_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 251);
            this.Name = "Ventana_User";
            this.Text = "Ventana_User";
            this.Load += new System.EventHandler(this.Ventana_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}