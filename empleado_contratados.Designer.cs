namespace TALLER_DE_MODA
{
    partial class Registro_Empleados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Empleados));
            this.clear_registro_empleado = new System.Windows.Forms.Button();
            this.formulario_empleado = new System.Windows.Forms.Label();
            this.Foto_fashion = new System.Windows.Forms.PictureBox();
            this.Regresar_Empleado_menu = new System.Windows.Forms.Button();
            this.imagen_registro_empleado = new System.Windows.Forms.PictureBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.clientenuevoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Foto_fashion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_registro_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientenuevoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clear_registro_empleado
            // 
            this.clear_registro_empleado.BackColor = System.Drawing.Color.DarkCyan;
            this.clear_registro_empleado.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_registro_empleado.ForeColor = System.Drawing.Color.White;
            this.clear_registro_empleado.Location = new System.Drawing.Point(635, 105);
            this.clear_registro_empleado.Name = "clear_registro_empleado";
            this.clear_registro_empleado.Size = new System.Drawing.Size(70, 28);
            this.clear_registro_empleado.TabIndex = 9;
            this.clear_registro_empleado.Text = "Ocultar";
            this.clear_registro_empleado.UseVisualStyleBackColor = false;
            this.clear_registro_empleado.Click += new System.EventHandler(this.Clear_registro_empleado_Click);
            // 
            // formulario_empleado
            // 
            this.formulario_empleado.AutoSize = true;
            this.formulario_empleado.BackColor = System.Drawing.Color.Transparent;
            this.formulario_empleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formulario_empleado.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulario_empleado.ForeColor = System.Drawing.Color.Orchid;
            this.formulario_empleado.Location = new System.Drawing.Point(450, 50);
            this.formulario_empleado.Name = "formulario_empleado";
            this.formulario_empleado.Size = new System.Drawing.Size(333, 38);
            this.formulario_empleado.TabIndex = 14;
            this.formulario_empleado.Text = "REGISTRO DE EMPLEADOS";
            // 
            // Foto_fashion
            // 
            this.Foto_fashion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Foto_fashion.Image = global::TALLER_DE_MODA.Properties.Resources.fondo11;
            this.Foto_fashion.Location = new System.Drawing.Point(49, 139);
            this.Foto_fashion.Name = "Foto_fashion";
            this.Foto_fashion.Size = new System.Drawing.Size(884, 277);
            this.Foto_fashion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto_fashion.TabIndex = 14;
            this.Foto_fashion.TabStop = false;
            // 
            // Regresar_Empleado_menu
            // 
            this.Regresar_Empleado_menu.BackColor = System.Drawing.Color.DarkCyan;
            this.Regresar_Empleado_menu.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar_Empleado_menu.ForeColor = System.Drawing.Color.White;
            this.Regresar_Empleado_menu.Location = new System.Drawing.Point(734, 105);
            this.Regresar_Empleado_menu.Name = "Regresar_Empleado_menu";
            this.Regresar_Empleado_menu.Size = new System.Drawing.Size(128, 28);
            this.Regresar_Empleado_menu.TabIndex = 16;
            this.Regresar_Empleado_menu.Text = "Regresar al Menu";
            this.Regresar_Empleado_menu.UseVisualStyleBackColor = false;
            this.Regresar_Empleado_menu.Click += new System.EventHandler(this.Regresar_Empleado_menu_Click);
            // 
            // imagen_registro_empleado
            // 
            this.imagen_registro_empleado.BackgroundImage = global::TALLER_DE_MODA.Properties.Resources.empleado;
            this.imagen_registro_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagen_registro_empleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagen_registro_empleado.Location = new System.Drawing.Point(99, 22);
            this.imagen_registro_empleado.Name = "imagen_registro_empleado";
            this.imagen_registro_empleado.Size = new System.Drawing.Size(269, 111);
            this.imagen_registro_empleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen_registro_empleado.TabIndex = 13;
            this.imagen_registro_empleado.TabStop = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_eliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(397, 105);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(115, 28);
            this.btn_eliminar.TabIndex = 23;
            this.btn_eliminar.Text = "Elimina y actualiza";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // datalistado
            // 
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.Location = new System.Drawing.Point(49, 139);
            this.datalistado.Name = "datalistado";
            this.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado.Size = new System.Drawing.Size(884, 267);
            this.datalistado.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(546, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "Enseñar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // clientenuevoBindingSource
            // 
            this.clientenuevoBindingSource.DataSource = typeof(TALLER_DE_MODA.Cliente_nuevo);
            // 
            // Registro_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(962, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Foto_fashion);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.Regresar_Empleado_menu);
            this.Controls.Add(this.formulario_empleado);
            this.Controls.Add(this.clear_registro_empleado);
            this.Controls.Add(this.imagen_registro_empleado);
            this.Controls.Add(this.datalistado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registro_Empleados";
            this.Text = "Registro de Empleados";
            this.Load += new System.EventHandler(this.Empleado_contratados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Foto_fashion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_registro_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientenuevoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button clear_registro_empleado;
        internal System.Windows.Forms.Label formulario_empleado;
        internal System.Windows.Forms.PictureBox imagen_registro_empleado;
        internal System.Windows.Forms.Button Regresar_Empleado_menu;
        private System.Windows.Forms.PictureBox Foto_fashion;
        public System.Windows.Forms.BindingSource clientenuevoBindingSource;
        internal System.Windows.Forms.Button btn_eliminar;
        internal System.Windows.Forms.DataGridView datalistado;
        internal System.Windows.Forms.Button button1;
    }
}