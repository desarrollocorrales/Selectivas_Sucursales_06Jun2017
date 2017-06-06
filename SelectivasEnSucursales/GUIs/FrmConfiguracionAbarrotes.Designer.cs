namespace SelectivasEnSucursales.GUIs
{
    partial class FrmConfiguracionAbarrotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracionAbarrotes));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDatabase = new System.Windows.Forms.TextBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.nudPuerto = new System.Windows.Forms.NumericUpDown();
            this.btnGuardarTodo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbSucursal = new System.Windows.Forms.TextBox();
            this.btnCargarParametros = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrarAlmacenes = new System.Windows.Forms.Button();
            this.cbAlmacenes = new System.Windows.Forms.ComboBox();
            this.ofdConfiguracion = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuerto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(592, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Configuración";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sucursal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base de Datos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Puerto:";
            // 
            // txbDatabase
            // 
            this.txbDatabase.Location = new System.Drawing.Point(130, 70);
            this.txbDatabase.Name = "txbDatabase";
            this.txbDatabase.Size = new System.Drawing.Size(430, 26);
            this.txbDatabase.TabIndex = 7;
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(130, 102);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(220, 26);
            this.txbUser.TabIndex = 8;
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(130, 134);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '*';
            this.txbContraseña.Size = new System.Drawing.Size(220, 26);
            this.txbContraseña.TabIndex = 9;
            // 
            // nudPuerto
            // 
            this.nudPuerto.Location = new System.Drawing.Point(130, 164);
            this.nudPuerto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPuerto.Name = "nudPuerto";
            this.nudPuerto.Size = new System.Drawing.Size(98, 26);
            this.nudPuerto.TabIndex = 11;
            // 
            // btnGuardarTodo
            // 
            this.btnGuardarTodo.Location = new System.Drawing.Point(259, 415);
            this.btnGuardarTodo.Name = "btnGuardarTodo";
            this.btnGuardarTodo.Size = new System.Drawing.Size(75, 26);
            this.btnGuardarTodo.TabIndex = 12;
            this.btnGuardarTodo.Text = "Guardar";
            this.btnGuardarTodo.UseVisualStyleBackColor = true;
            this.btnGuardarTodo.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbSucursal);
            this.groupBox1.Controls.Add(this.btnCargarParametros);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudPuerto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbContraseña);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbDatabase);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(14, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 243);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base de Datos";
            // 
            // txbSucursal
            // 
            this.txbSucursal.Location = new System.Drawing.Point(130, 38);
            this.txbSucursal.Name = "txbSucursal";
            this.txbSucursal.Size = new System.Drawing.Size(392, 26);
            this.txbSucursal.TabIndex = 0;
            // 
            // btnCargarParametros
            // 
            this.btnCargarParametros.Location = new System.Drawing.Point(183, 207);
            this.btnCargarParametros.Name = "btnCargarParametros";
            this.btnCargarParametros.Size = new System.Drawing.Size(200, 30);
            this.btnCargarParametros.TabIndex = 12;
            this.btnCargarParametros.Text = "Cargar Parametros";
            this.btnCargarParametros.UseVisualStyleBackColor = true;
            this.btnCargarParametros.Click += new System.EventHandler(this.btnCargarParametros_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMostrarAlmacenes);
            this.groupBox2.Controls.Add(this.cbAlmacenes);
            this.groupBox2.Location = new System.Drawing.Point(14, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Almacen";
            // 
            // btnMostrarAlmacenes
            // 
            this.btnMostrarAlmacenes.Location = new System.Drawing.Point(208, 64);
            this.btnMostrarAlmacenes.Name = "btnMostrarAlmacenes";
            this.btnMostrarAlmacenes.Size = new System.Drawing.Size(150, 30);
            this.btnMostrarAlmacenes.TabIndex = 1;
            this.btnMostrarAlmacenes.Text = "Mostrar Almacenes";
            this.btnMostrarAlmacenes.UseVisualStyleBackColor = true;
            this.btnMostrarAlmacenes.Click += new System.EventHandler(this.btnMostrarAlmacenes_Click);
            // 
            // cbAlmacenes
            // 
            this.cbAlmacenes.Enabled = false;
            this.cbAlmacenes.FormattingEnabled = true;
            this.cbAlmacenes.Location = new System.Drawing.Point(87, 32);
            this.cbAlmacenes.Name = "cbAlmacenes";
            this.cbAlmacenes.Size = new System.Drawing.Size(392, 26);
            this.cbAlmacenes.TabIndex = 0;
            // 
            // ofdConfiguracion
            // 
            this.ofdConfiguracion.FileName = "*.set";
            this.ofdConfiguracion.Filter = "Archivos de configuracion corrales | *.set";
            // 
            // FrmConfiguracionAbarrotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardarTodo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(600, 480);
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "FrmConfiguracionAbarrotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPuerto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDatabase;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.NumericUpDown nudPuerto;
        private System.Windows.Forms.Button btnGuardarTodo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrarAlmacenes;
        private System.Windows.Forms.ComboBox cbAlmacenes;
        private System.Windows.Forms.Button btnCargarParametros;
        private System.Windows.Forms.TextBox txbSucursal;
        private System.Windows.Forms.OpenFileDialog ofdConfiguracion;
    }
}