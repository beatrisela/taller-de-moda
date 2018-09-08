namespace TALLER_DE_MODA
{
    partial class usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuario));
            this.boton_volver_al_login = new System.Windows.Forms.Button();
            this.groupBoxclaveusario = new System.Windows.Forms.GroupBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.comboBox1_nombre = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.Label();
            this.textBox_permisos = new System.Windows.Forms.TextBox();
            this.textBox_clave = new System.Windows.Forms.TextBox();
            this.labelPermisos = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.Label();
            this.Nomnbre = new System.Windows.Forms.Label();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buscar = new System.Windows.Forms.Button();
            this.comboBox_busqueda = new System.Windows.Forms.ComboBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Foto_fashion = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxclaveusario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto_fashion)).BeginInit();
            this.SuspendLayout();
            // 
            // boton_volver_al_login
            // 
            this.boton_volver_al_login.BackColor = System.Drawing.Color.DarkCyan;
            this.boton_volver_al_login.ForeColor = System.Drawing.Color.White;
            this.boton_volver_al_login.Location = new System.Drawing.Point(440, 258);
            this.boton_volver_al_login.Name = "boton_volver_al_login";
            this.boton_volver_al_login.Size = new System.Drawing.Size(75, 23);
            this.boton_volver_al_login.TabIndex = 37;
            this.boton_volver_al_login.Text = "volver";
            this.boton_volver_al_login.UseVisualStyleBackColor = false;
            this.boton_volver_al_login.Click += new System.EventHandler(this.Boton_volver_al_login_Click);
            // 
            // groupBoxclaveusario
            // 
            this.groupBoxclaveusario.Controls.Add(this.label3);
            this.groupBoxclaveusario.Controls.Add(this.label2);
            this.groupBoxclaveusario.Controls.Add(this.label1);
            this.groupBoxclaveusario.Controls.Add(this.textBox_ID);
            this.groupBoxclaveusario.Controls.Add(this.comboBox1_nombre);
            this.groupBoxclaveusario.Controls.Add(this.ID);
            this.groupBoxclaveusario.Controls.Add(this.textBox_permisos);
            this.groupBoxclaveusario.Controls.Add(this.textBox_clave);
            this.groupBoxclaveusario.Controls.Add(this.labelPermisos);
            this.groupBoxclaveusario.Controls.Add(this.Clave);
            this.groupBoxclaveusario.Controls.Add(this.Nomnbre);
            this.groupBoxclaveusario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxclaveusario.ForeColor = System.Drawing.Color.DarkViolet;
            this.groupBoxclaveusario.Location = new System.Drawing.Point(192, 30);
            this.groupBoxclaveusario.Name = "groupBoxclaveusario";
            this.groupBoxclaveusario.Size = new System.Drawing.Size(349, 220);
            this.groupBoxclaveusario.TabIndex = 38;
            this.groupBoxclaveusario.TabStop = false;
            this.groupBoxclaveusario.Text = "Introduccion de claves";
            // 
            // textBox_ID
            // 
            this.textBox_ID.BackColor = System.Drawing.Color.White;
            this.textBox_ID.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.textBox_ID.Location = new System.Drawing.Point(89, 47);
            this.textBox_ID.Multiline = true;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(45, 24);
            this.textBox_ID.TabIndex = 75;
            // 
            // comboBox1_nombre
            // 
            this.comboBox1_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1_nombre.FormattingEnabled = true;
            this.comboBox1_nombre.Location = new System.Drawing.Point(89, 86);
            this.comboBox1_nombre.Name = "comboBox1_nombre";
            this.comboBox1_nombre.Size = new System.Drawing.Size(234, 24);
            this.comboBox1_nombre.TabIndex = 76;
            this.comboBox1_nombre.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_nombre_SelectedIndexChanged_1);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ID.Location = new System.Drawing.Point(18, 55);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 16);
            this.ID.TabIndex = 74;
            this.ID.Text = "ID";
            // 
            // textBox_permisos
            // 
            this.textBox_permisos.BackColor = System.Drawing.Color.White;
            this.textBox_permisos.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.textBox_permisos.Location = new System.Drawing.Point(89, 171);
            this.textBox_permisos.Multiline = true;
            this.textBox_permisos.Name = "textBox_permisos";
            this.textBox_permisos.Size = new System.Drawing.Size(150, 24);
            this.textBox_permisos.TabIndex = 73;
            // 
            // textBox_clave
            // 
            this.textBox_clave.BackColor = System.Drawing.Color.White;
            this.textBox_clave.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.textBox_clave.Location = new System.Drawing.Point(89, 130);
            this.textBox_clave.Multiline = true;
            this.textBox_clave.Name = "textBox_clave";
            this.textBox_clave.Size = new System.Drawing.Size(150, 24);
            this.textBox_clave.TabIndex = 72;
            // 
            // labelPermisos
            // 
            this.labelPermisos.AutoSize = true;
            this.labelPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPermisos.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelPermisos.Location = new System.Drawing.Point(18, 179);
            this.labelPermisos.Name = "labelPermisos";
            this.labelPermisos.Size = new System.Drawing.Size(65, 16);
            this.labelPermisos.TabIndex = 27;
            this.labelPermisos.Text = "Permisos";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Clave.Location = new System.Drawing.Point(18, 138);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(43, 16);
            this.Clave.TabIndex = 3;
            this.Clave.Text = "Clave";
            // 
            // Nomnbre
            // 
            this.Nomnbre.AutoSize = true;
            this.Nomnbre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nomnbre.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Nomnbre.Location = new System.Drawing.Point(18, 94);
            this.Nomnbre.Name = "Nomnbre";
            this.Nomnbre.Size = new System.Drawing.Size(57, 16);
            this.Nomnbre.TabIndex = 2;
            this.Nomnbre.Text = "Nombre";
            // 
            // button_aceptar
            // 
            this.button_aceptar.BackColor = System.Drawing.Color.DarkCyan;
            this.button_aceptar.ForeColor = System.Drawing.Color.White;
            this.button_aceptar.Location = new System.Drawing.Point(200, 258);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_aceptar.TabIndex = 36;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = false;
            this.button_aceptar.Click += new System.EventHandler(this.Button_aceptar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(556, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 211);
            this.dataGridView1.TabIndex = 40;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.DarkCyan;
            this.buscar.ForeColor = System.Drawing.Color.White;
            this.buscar.Location = new System.Drawing.Point(714, 255);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 41;
            this.buscar.Text = "buscar";
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // comboBox_busqueda
            // 
            this.comboBox_busqueda.FormattingEnabled = true;
            this.comboBox_busqueda.Items.AddRange(new object[] {
            "*",
            "clave, permisos"});
            this.comboBox_busqueda.Location = new System.Drawing.Point(813, 258);
            this.comboBox_busqueda.Name = "comboBox_busqueda";
            this.comboBox_busqueda.Size = new System.Drawing.Size(99, 21);
            this.comboBox_busqueda.TabIndex = 42;
            this.comboBox_busqueda.SelectedIndexChanged += new System.EventHandler(this.ComboBox_busqueda_SelectedIndexChanged);
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.DarkCyan;
            this.Limpiar.ForeColor = System.Drawing.Color.White;
            this.Limpiar.Location = new System.Drawing.Point(317, 258);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 44;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TALLER_DE_MODA.Properties.Resources._272456;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(15, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 240);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // Foto_fashion
            // 
            this.Foto_fashion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Foto_fashion.Image = global::TALLER_DE_MODA.Properties.Resources.fondo11;
            this.Foto_fashion.Location = new System.Drawing.Point(556, 41);
            this.Foto_fashion.Name = "Foto_fashion";
            this.Foto_fashion.Size = new System.Drawing.Size(368, 212);
            this.Foto_fashion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto_fashion.TabIndex = 45;
            this.Foto_fashion.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(255, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(255, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 78;
            this.label2.Text = "!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Magenta;
            this.label3.Location = new System.Drawing.Point(329, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 79;
            this.label3.Text = "!";
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(935, 302);
            this.Controls.Add(this.Foto_fashion);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.comboBox_busqueda);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boton_volver_al_login);
            this.Controls.Add(this.groupBoxclaveusario);
            this.Controls.Add(this.button_aceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "usuario";
            this.Text = " Administrador asigna contraseña";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.groupBoxclaveusario.ResumeLayout(false);
            this.groupBoxclaveusario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto_fashion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button boton_volver_al_login;
        private System.Windows.Forms.GroupBox groupBoxclaveusario;
        private System.Windows.Forms.TextBox textBox_permisos;
        private System.Windows.Forms.TextBox textBox_clave;
        public System.Windows.Forms.Label labelPermisos;
        public System.Windows.Forms.Label Clave;
        public System.Windows.Forms.Label Nomnbre;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.ComboBox comboBox_busqueda;
        public System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.ComboBox comboBox1_nombre;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.PictureBox Foto_fashion;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
    }
}