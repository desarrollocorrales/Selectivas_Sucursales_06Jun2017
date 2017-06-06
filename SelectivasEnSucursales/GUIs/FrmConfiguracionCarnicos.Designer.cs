namespace SelectivasEnSucursales.GUIs
{
    partial class FrmConfiguracionCarnicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracionCarnicos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.webPreview = new System.Windows.Forms.WebBrowser();
            this.txbUrl = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbUrlFriolala = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCargarFriolala = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.webPreview);
            this.panel1.Location = new System.Drawing.Point(13, 181);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 332);
            this.panel1.TabIndex = 0;
            // 
            // webPreview
            // 
            this.webPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webPreview.Location = new System.Drawing.Point(4, 4);
            this.webPreview.Margin = new System.Windows.Forms.Padding(4);
            this.webPreview.MinimumSize = new System.Drawing.Size(27, 28);
            this.webPreview.Name = "webPreview";
            this.webPreview.Size = new System.Drawing.Size(558, 324);
            this.webPreview.TabIndex = 0;
            // 
            // txbUrl
            // 
            this.txbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUrl.Location = new System.Drawing.Point(13, 82);
            this.txbUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(488, 26);
            this.txbUrl.TabIndex = 1;
            this.txbUrl.Text = "http://";
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargar.AutoSize = true;
            this.btnCargar.Location = new System.Drawing.Point(509, 80);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(70, 28);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selectivas de Almacén - Cárnicos";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Carnicerias Los Corrales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "URL del Web Service Abastecedora:";
            // 
            // Guardar
            // 
            this.Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Guardar.AutoSize = true;
            this.Guardar.Location = new System.Drawing.Point(261, 521);
            this.Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(70, 28);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nota: la URL deberá ser como la siguiente: \"http://servidor:85\"";
            // 
            // txbUrlFriolala
            // 
            this.txbUrlFriolala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUrlFriolala.Location = new System.Drawing.Point(13, 134);
            this.txbUrlFriolala.Margin = new System.Windows.Forms.Padding(4);
            this.txbUrlFriolala.Name = "txbUrlFriolala";
            this.txbUrlFriolala.Size = new System.Drawing.Size(488, 26);
            this.txbUrlFriolala.TabIndex = 9;
            this.txbUrlFriolala.Text = "http://";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "URL del Web Service Friolala:";
            // 
            // btnCargarFriolala
            // 
            this.btnCargarFriolala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarFriolala.AutoSize = true;
            this.btnCargarFriolala.Location = new System.Drawing.Point(509, 132);
            this.btnCargarFriolala.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarFriolala.Name = "btnCargarFriolala";
            this.btnCargarFriolala.Size = new System.Drawing.Size(70, 28);
            this.btnCargarFriolala.TabIndex = 11;
            this.btnCargarFriolala.Text = "Cargar";
            this.btnCargarFriolala.UseVisualStyleBackColor = true;
            this.btnCargarFriolala.Click += new System.EventHandler(this.btnCargarFriolala_Click);
            // 
            // FrmConfiguracionCarnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 562);
            this.Controls.Add(this.btnCargarFriolala);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbUrlFriolala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txbUrl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConfiguracionCarnicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración Cárnicos";
            this.Load += new System.EventHandler(this.FrmConfiguracionCarnicos_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webPreview;
        private System.Windows.Forms.TextBox txbUrl;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbUrlFriolala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCargarFriolala;
    }
}