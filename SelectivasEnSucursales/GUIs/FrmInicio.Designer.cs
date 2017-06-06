namespace SelectivasEnSucursales.GUIs
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCarnicos = new System.Windows.Forms.Button();
            this.btnAbarrotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carnicerias Los Corrales";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selectivas de Almacén";
            // 
            // btnCarnicos
            // 
            this.btnCarnicos.Image = global::SelectivasEnSucursales.Properties.Resources.meats;
            this.btnCarnicos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCarnicos.Location = new System.Drawing.Point(171, 70);
            this.btnCarnicos.Name = "btnCarnicos";
            this.btnCarnicos.Size = new System.Drawing.Size(150, 177);
            this.btnCarnicos.TabIndex = 3;
            this.btnCarnicos.Text = "Cárnicos";
            this.btnCarnicos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCarnicos.UseVisualStyleBackColor = true;
            this.btnCarnicos.Click += new System.EventHandler(this.btnCarnicos_Click);
            // 
            // btnAbarrotes
            // 
            this.btnAbarrotes.Image = global::SelectivasEnSucursales.Properties.Resources.groceries;
            this.btnAbarrotes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbarrotes.Location = new System.Drawing.Point(15, 70);
            this.btnAbarrotes.Name = "btnAbarrotes";
            this.btnAbarrotes.Size = new System.Drawing.Size(150, 177);
            this.btnAbarrotes.TabIndex = 2;
            this.btnAbarrotes.Text = "Abarrotes";
            this.btnAbarrotes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbarrotes.UseVisualStyleBackColor = true;
            this.btnAbarrotes.Click += new System.EventHandler(this.btnAbarrotes_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 273);
            this.Controls.Add(this.btnCarnicos);
            this.Controls.Add(this.btnAbarrotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(345, 300);
            this.MinimumSize = new System.Drawing.Size(345, 300);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAbarrotes;
        private System.Windows.Forms.Button btnCarnicos;
    }
}