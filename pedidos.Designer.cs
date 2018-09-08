namespace TALLER_DE_MODA
{
    partial class pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pedidos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxbuscar = new System.Windows.Forms.ComboBox();
            this.butonRegresar = new System.Windows.Forms.Button();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_precio = new System.Windows.Forms.Label();
            this.label_descripcion = new System.Windows.Forms.Label();
            this.label_existencias = new System.Windows.Forms.Label();
            this.labelpedidos = new System.Windows.Forms.Label();
            this.textBoxprecio = new System.Windows.Forms.TextBox();
            this.textBoxproducto = new System.Windows.Forms.TextBox();
            this.textBoxexistencias = new System.Windows.Forms.TextBox();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.comboBoxproveedor = new System.Windows.Forms.ComboBox();
            this.labelproveedor = new System.Windows.Forms.Label();
            this.labelempleado = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxpedidos = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.comboBoxbuscar);
            this.panel1.Controls.Add(this.butonRegresar);
            this.panel1.Controls.Add(this.buttonbuscar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(22, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 315);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TALLER_DE_MODA.Properties.Resources.producto;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(18, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 247);
            this.panel2.TabIndex = 14;
            // 
            // comboBoxbuscar
            // 
            this.comboBoxbuscar.FormattingEnabled = true;
            this.comboBoxbuscar.Location = new System.Drawing.Point(132, 283);
            this.comboBoxbuscar.Name = "comboBoxbuscar";
            this.comboBoxbuscar.Size = new System.Drawing.Size(254, 21);
            this.comboBoxbuscar.TabIndex = 13;
            this.comboBoxbuscar.SelectedIndexChanged += new System.EventHandler(this.comboBoxbuscar_SelectedIndexChanged);
            // 
            // butonRegresar
            // 
            this.butonRegresar.BackColor = System.Drawing.Color.DarkCyan;
            this.butonRegresar.ForeColor = System.Drawing.Color.White;
            this.butonRegresar.Location = new System.Drawing.Point(441, 281);
            this.butonRegresar.Name = "butonRegresar";
            this.butonRegresar.Size = new System.Drawing.Size(75, 23);
            this.butonRegresar.TabIndex = 8;
            this.butonRegresar.Text = "Regresar";
            this.butonRegresar.UseVisualStyleBackColor = false;
            this.butonRegresar.Click += new System.EventHandler(this.ButonRegresar_Click);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonbuscar.ForeColor = System.Drawing.Color.White;
            this.buttonbuscar.Location = new System.Drawing.Point(32, 281);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonbuscar.TabIndex = 7;
            this.buttonbuscar.Text = "Buscar";
            this.buttonbuscar.UseVisualStyleBackColor = false;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_precio.Location = new System.Drawing.Point(614, 131);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(74, 13);
            this.label_precio.TabIndex = 2;
            this.label_precio.Text = "Precio Unidad";
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_descripcion.Location = new System.Drawing.Point(614, 163);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(125, 13);
            this.label_descripcion.TabIndex = 3;
            this.label_descripcion.Text = "Descripcion del producto";
            // 
            // label_existencias
            // 
            this.label_existencias.AutoSize = true;
            this.label_existencias.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_existencias.Location = new System.Drawing.Point(614, 196);
            this.label_existencias.Name = "label_existencias";
            this.label_existencias.Size = new System.Drawing.Size(49, 13);
            this.label_existencias.TabIndex = 4;
            this.label_existencias.Text = "Cantidad";
            // 
            // labelpedidos
            // 
            this.labelpedidos.AutoSize = true;
            this.labelpedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpedidos.ForeColor = System.Drawing.Color.Orchid;
            this.labelpedidos.Location = new System.Drawing.Point(603, 61);
            this.labelpedidos.Name = "labelpedidos";
            this.labelpedidos.Size = new System.Drawing.Size(279, 29);
            this.labelpedidos.TabIndex = 2;
            this.labelpedidos.Text = "ALMACEN DE PEDIDOS";
            // 
            // textBoxprecio
            // 
            this.textBoxprecio.Location = new System.Drawing.Point(745, 124);
            this.textBoxprecio.Name = "textBoxprecio";
            this.textBoxprecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxprecio.TabIndex = 6;
            // 
            // textBoxproducto
            // 
            this.textBoxproducto.Location = new System.Drawing.Point(745, 160);
            this.textBoxproducto.Name = "textBoxproducto";
            this.textBoxproducto.Size = new System.Drawing.Size(151, 20);
            this.textBoxproducto.TabIndex = 7;
            // 
            // textBoxexistencias
            // 
            this.textBoxexistencias.Location = new System.Drawing.Point(745, 196);
            this.textBoxexistencias.Name = "textBoxexistencias";
            this.textBoxexistencias.Size = new System.Drawing.Size(100, 20);
            this.textBoxexistencias.TabIndex = 8;
            // 
            // buttonguardar
            // 
            this.buttonguardar.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguardar.ForeColor = System.Drawing.Color.White;
            this.buttonguardar.Location = new System.Drawing.Point(631, 268);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(228, 23);
            this.buttonguardar.TabIndex = 8;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.UseVisualStyleBackColor = false;
            this.buttonguardar.Click += new System.EventHandler(this.Buttonguardar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.BackColor = System.Drawing.Color.DarkCyan;
            this.buttoneliminar.ForeColor = System.Drawing.Color.White;
            this.buttoneliminar.Location = new System.Drawing.Point(594, 346);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(78, 23);
            this.buttoneliminar.TabIndex = 9;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = false;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // comboBoxproveedor
            // 
            this.comboBoxproveedor.FormattingEnabled = true;
            this.comboBoxproveedor.Location = new System.Drawing.Point(745, 222);
            this.comboBoxproveedor.Name = "comboBoxproveedor";
            this.comboBoxproveedor.Size = new System.Drawing.Size(151, 21);
            this.comboBoxproveedor.TabIndex = 13;
            this.comboBoxproveedor.SelectedIndexChanged += new System.EventHandler(this.comboBoxproveedor_SelectedIndexChanged);
            // 
            // labelproveedor
            // 
            this.labelproveedor.AutoSize = true;
            this.labelproveedor.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelproveedor.Location = new System.Drawing.Point(614, 231);
            this.labelproveedor.Name = "labelproveedor";
            this.labelproveedor.Size = new System.Drawing.Size(107, 13);
            this.labelproveedor.TabIndex = 12;
            this.labelproveedor.Text = "Lista de Proveedores";
            // 
            // labelempleado
            // 
            this.labelempleado.AutoSize = true;
            this.labelempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelempleado.ForeColor = System.Drawing.Color.Orchid;
            this.labelempleado.Location = new System.Drawing.Point(231, 28);
            this.labelempleado.Name = "labelempleado";
            this.labelempleado.Size = new System.Drawing.Size(44, 16);
            this.labelempleado.TabIndex = 15;
            this.labelempleado.Text = "---------";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.ForeColor = System.Drawing.Color.Orchid;
            this.labelnombre.Location = new System.Drawing.Point(19, 25);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(65, 20);
            this.labelnombre.TabIndex = 14;
            this.labelnombre.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(631, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxpedidos
            // 
            this.textBoxpedidos.Location = new System.Drawing.Point(689, 349);
            this.textBoxpedidos.Name = "textBoxpedidos";
            this.textBoxpedidos.Size = new System.Drawing.Size(64, 20);
            this.textBoxpedidos.TabIndex = 17;
            // 
            // pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(908, 399);
            this.Controls.Add(this.textBoxpedidos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelempleado);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.comboBoxproveedor);
            this.Controls.Add(this.labelproveedor);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.textBoxexistencias);
            this.Controls.Add(this.textBoxproducto);
            this.Controls.Add(this.textBoxprecio);
            this.Controls.Add(this.labelpedidos);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.label_descripcion);
            this.Controls.Add(this.label_existencias);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pedidos";
            this.Text = "pedidos";
            this.Load += new System.EventHandler(this.pedidos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.Label label_existencias;
        private System.Windows.Forms.Label labelpedidos;
        private System.Windows.Forms.Button butonRegresar;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.TextBox textBoxprecio;
        private System.Windows.Forms.TextBox textBoxproducto;
        private System.Windows.Forms.TextBox textBoxexistencias;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxbuscar;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.ComboBox comboBoxproveedor;
        private System.Windows.Forms.Label labelproveedor;
        private System.Windows.Forms.Label labelempleado;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxpedidos;
    }
}