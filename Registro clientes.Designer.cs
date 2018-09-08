namespace TALLER_DE_MODA
{
    partial class Cliente_registrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente_registrado));
            this.Regresar_Empleado_menu = new System.Windows.Forms.Button();
            this.formulario_empleado = new System.Windows.Forms.Label();
            this.buscar_registro_cliente = new System.Windows.Forms.Button();
            this.clear_registro_empleado = new System.Windows.Forms.Button();
            this.btneliminar_Registro_cliente = new System.Windows.Forms.Button();
            this.imagen_registro_empleado = new System.Windows.Forms.PictureBox();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.Foto_fashion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_registro_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto_fashion)).BeginInit();
            this.SuspendLayout();
            // 
            // Regresar_Empleado_menu
            // 
            this.Regresar_Empleado_menu.BackColor = System.Drawing.Color.DarkCyan;
            this.Regresar_Empleado_menu.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar_Empleado_menu.ForeColor = System.Drawing.Color.White;
            this.Regresar_Empleado_menu.Location = new System.Drawing.Point(740, 100);
            this.Regresar_Empleado_menu.Name = "Regresar_Empleado_menu";
            this.Regresar_Empleado_menu.Size = new System.Drawing.Size(128, 28);
            this.Regresar_Empleado_menu.TabIndex = 24;
            this.Regresar_Empleado_menu.Text = "Regresar al Menu";
            this.Regresar_Empleado_menu.UseVisualStyleBackColor = false;
            this.Regresar_Empleado_menu.Click += new System.EventHandler(this.Regresar_Empleado_menu_Click);
            // 
            // formulario_empleado
            // 
            this.formulario_empleado.AutoSize = true;
            this.formulario_empleado.BackColor = System.Drawing.Color.Transparent;
            this.formulario_empleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formulario_empleado.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulario_empleado.ForeColor = System.Drawing.Color.Orchid;
            this.formulario_empleado.Location = new System.Drawing.Point(466, 39);
            this.formulario_empleado.Name = "formulario_empleado";
            this.formulario_empleado.Size = new System.Drawing.Size(300, 38);
            this.formulario_empleado.TabIndex = 22;
            this.formulario_empleado.Text = "REGISTRO DE  CLIENTES";
            // 
            // buscar_registro_cliente
            // 
            this.buscar_registro_cliente.BackColor = System.Drawing.Color.DarkCyan;
            this.buscar_registro_cliente.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_registro_cliente.ForeColor = System.Drawing.Color.White;
            this.buscar_registro_cliente.Location = new System.Drawing.Point(548, 101);
            this.buscar_registro_cliente.Name = "buscar_registro_cliente";
            this.buscar_registro_cliente.Size = new System.Drawing.Size(75, 27);
            this.buscar_registro_cliente.TabIndex = 17;
            this.buscar_registro_cliente.Text = "Enseñar";
            this.buscar_registro_cliente.UseVisualStyleBackColor = false;
            this.buscar_registro_cliente.Click += new System.EventHandler(this.Buscar_registro_cliente_Click);
            // 
            // clear_registro_empleado
            // 
            this.clear_registro_empleado.BackColor = System.Drawing.Color.DarkCyan;
            this.clear_registro_empleado.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_registro_empleado.ForeColor = System.Drawing.Color.White;
            this.clear_registro_empleado.Location = new System.Drawing.Point(643, 100);
            this.clear_registro_empleado.Name = "clear_registro_empleado";
            this.clear_registro_empleado.Size = new System.Drawing.Size(70, 28);
            this.clear_registro_empleado.TabIndex = 19;
            this.clear_registro_empleado.Text = "Ocultar";
            this.clear_registro_empleado.UseVisualStyleBackColor = false;
            this.clear_registro_empleado.Click += new System.EventHandler(this.Limpiar_registro_empleado_Click);
            // 
            // btneliminar_Registro_cliente
            // 
            this.btneliminar_Registro_cliente.BackColor = System.Drawing.Color.DarkCyan;
            this.btneliminar_Registro_cliente.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar_Registro_cliente.ForeColor = System.Drawing.Color.White;
            this.btneliminar_Registro_cliente.Location = new System.Drawing.Point(403, 103);
            this.btneliminar_Registro_cliente.Name = "btneliminar_Registro_cliente";
            this.btneliminar_Registro_cliente.Size = new System.Drawing.Size(128, 25);
            this.btneliminar_Registro_cliente.TabIndex = 18;
            this.btneliminar_Registro_cliente.Text = "Eliminar";
            this.btneliminar_Registro_cliente.UseVisualStyleBackColor = false;
            this.btneliminar_Registro_cliente.Click += new System.EventHandler(this.Btneliminar_Registro_cliente_Click);
            // 
            // imagen_registro_empleado
            // 
            this.imagen_registro_empleado.BackgroundImage = global::TALLER_DE_MODA.Properties.Resources.cliente;
            this.imagen_registro_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagen_registro_empleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagen_registro_empleado.Location = new System.Drawing.Point(48, 9);
            this.imagen_registro_empleado.Name = "imagen_registro_empleado";
            this.imagen_registro_empleado.Size = new System.Drawing.Size(324, 119);
            this.imagen_registro_empleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen_registro_empleado.TabIndex = 21;
            this.imagen_registro_empleado.TabStop = false;
            // 
            // datalistado
            // 
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.Location = new System.Drawing.Point(48, 134);
            this.datalistado.Name = "datalistado";
            this.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado.Size = new System.Drawing.Size(820, 267);
            this.datalistado.TabIndex = 8;
            // 
            // Foto_fashion
            // 
            this.Foto_fashion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Foto_fashion.Image = global::TALLER_DE_MODA.Properties.Resources.fondo11;
            this.Foto_fashion.Location = new System.Drawing.Point(48, 134);
            this.Foto_fashion.Name = "Foto_fashion";
            this.Foto_fashion.Size = new System.Drawing.Size(820, 267);
            this.Foto_fashion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto_fashion.TabIndex = 14;
            this.Foto_fashion.TabStop = false;
            // 
            // Cliente_registrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 416);
            this.Controls.Add(this.Foto_fashion);
            this.Controls.Add(this.Regresar_Empleado_menu);
            this.Controls.Add(this.btneliminar_Registro_cliente);
            this.Controls.Add(this.formulario_empleado);
            this.Controls.Add(this.buscar_registro_cliente);
            this.Controls.Add(this.clear_registro_empleado);
            this.Controls.Add(this.imagen_registro_empleado);
            this.Controls.Add(this.datalistado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente_registrado";
            this.Text = "REGISTRO DE CLIENTES";
            this.Load += new System.EventHandler(this.Cliente_registrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen_registro_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto_fashion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Regresar_Empleado_menu;
        internal System.Windows.Forms.Label formulario_empleado;
        internal System.Windows.Forms.Button buscar_registro_cliente;
        internal System.Windows.Forms.Button clear_registro_empleado;
        internal System.Windows.Forms.PictureBox imagen_registro_empleado;
        internal System.Windows.Forms.Button btneliminar_Registro_cliente;
        internal System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.PictureBox Foto_fashion;
    }
}