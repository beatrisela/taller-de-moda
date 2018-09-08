namespace TALLER_DE_MODA
{
    partial class cuadrante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cuadrante));
            this.formulario_empleado = new System.Windows.Forms.Label();
            this.Eliminar_cuadrante = new System.Windows.Forms.Button();
            this.introducir_turno = new System.Windows.Forms.Button();
            this.imagen_imprimir_cuadrante = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.cbocampo = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // formulario_empleado
            // 
            this.formulario_empleado.AutoSize = true;
            this.formulario_empleado.BackColor = System.Drawing.Color.Transparent;
            this.formulario_empleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formulario_empleado.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulario_empleado.ForeColor = System.Drawing.Color.Orchid;
            this.formulario_empleado.Location = new System.Drawing.Point(104, 19);
            this.formulario_empleado.Name = "formulario_empleado";
            this.formulario_empleado.Size = new System.Drawing.Size(367, 38);
            this.formulario_empleado.TabIndex = 33;
            this.formulario_empleado.Text = "TURNOS DE LOS EMPLEADOS";
            // 
            // Eliminar_cuadrante
            // 
            this.Eliminar_cuadrante.BackColor = System.Drawing.Color.DarkCyan;
            this.Eliminar_cuadrante.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.Eliminar_cuadrante.ForeColor = System.Drawing.Color.White;
            this.Eliminar_cuadrante.Location = new System.Drawing.Point(246, 302);
            this.Eliminar_cuadrante.Name = "Eliminar_cuadrante";
            this.Eliminar_cuadrante.Size = new System.Drawing.Size(124, 31);
            this.Eliminar_cuadrante.TabIndex = 25;
            this.Eliminar_cuadrante.Text = "Eliminar";
            this.Eliminar_cuadrante.UseVisualStyleBackColor = false;
            // 
            // introducir_turno
            // 
            this.introducir_turno.BackColor = System.Drawing.Color.DarkCyan;
            this.introducir_turno.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.introducir_turno.ForeColor = System.Drawing.Color.White;
            this.introducir_turno.Location = new System.Drawing.Point(31, 302);
            this.introducir_turno.Name = "introducir_turno";
            this.introducir_turno.Size = new System.Drawing.Size(120, 31);
            this.introducir_turno.TabIndex = 27;
            this.introducir_turno.Text = "cambiar  turnos";
            this.introducir_turno.UseVisualStyleBackColor = false;
            this.introducir_turno.Click += new System.EventHandler(this.introducir_turno_Click);
            // 
            // imagen_imprimir_cuadrante
            // 
            this.imagen_imprimir_cuadrante.BackColor = System.Drawing.Color.DarkCyan;
            this.imagen_imprimir_cuadrante.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.imagen_imprimir_cuadrante.ForeColor = System.Drawing.Color.White;
            this.imagen_imprimir_cuadrante.Location = new System.Drawing.Point(477, 257);
            this.imagen_imprimir_cuadrante.Name = "imagen_imprimir_cuadrante";
            this.imagen_imprimir_cuadrante.Size = new System.Drawing.Size(120, 31);
            this.imagen_imprimir_cuadrante.TabIndex = 26;
            this.imagen_imprimir_cuadrante.Text = " imprimir";
            this.imagen_imprimir_cuadrante.UseVisualStyleBackColor = false;
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.DarkCyan;
            this.Regresar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.ForeColor = System.Drawing.Color.White;
            this.Regresar.Location = new System.Drawing.Point(477, 312);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(124, 31);
            this.Regresar.TabIndex = 29;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // cbocampo
            // 
            this.cbocampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocampo.FormattingEnabled = true;
            this.cbocampo.Items.AddRange(new object[] {
            "Turno,Hora_entrada,Hora_salida"});
            this.cbocampo.Location = new System.Drawing.Point(161, 257);
            this.cbocampo.Name = "cbocampo";
            this.cbocampo.Size = new System.Drawing.Size(310, 23);
            this.cbocampo.TabIndex = 31;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnbuscar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(31, 257);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(124, 31);
            this.btnbuscar.TabIndex = 28;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(545, 172);
            this.dataGridView2.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::TALLER_DE_MODA.Properties.Resources.turno;
            this.pictureBox2.Location = new System.Drawing.Point(31, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(545, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // cuadrante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 345);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.formulario_empleado);
            this.Controls.Add(this.Eliminar_cuadrante);
            this.Controls.Add(this.introducir_turno);
            this.Controls.Add(this.imagen_imprimir_cuadrante);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.cbocampo);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cuadrante";
            this.Text = "cuadrante";
            this.Load += new System.EventHandler(this.cuadrante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label formulario_empleado;
        private System.Windows.Forms.Button Eliminar_cuadrante;
        private System.Windows.Forms.Button introducir_turno;
        private System.Windows.Forms.Button imagen_imprimir_cuadrante;
        internal System.Windows.Forms.Button Regresar;
        internal System.Windows.Forms.ComboBox cbocampo;
        internal System.Windows.Forms.Button btnbuscar;
        internal System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}