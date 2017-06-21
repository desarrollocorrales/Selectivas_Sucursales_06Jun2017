namespace SelectivasEnSucursales.GUIs
{
    partial class FrmAbarrotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbarrotes));
            this.label1 = new System.Windows.Forms.Label();
            this.txbClave = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gridExistencia = new DevExpress.XtraGrid.GridControl();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvExistencia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClavePrincipal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave del artículo:";
            // 
            // txbClave
            // 
            this.txbClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbClave.Location = new System.Drawing.Point(12, 89);
            this.txbClave.Name = "txbClave";
            this.txbClave.Size = new System.Drawing.Size(687, 26);
            this.txbClave.TabIndex = 1;
            this.txbClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbClave_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.Location = new System.Drawing.Point(705, 89);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 26);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridExistencia
            // 
            this.gridExistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridExistencia.DataSource = this.articuloBindingSource;
            this.gridExistencia.Location = new System.Drawing.Point(12, 121);
            this.gridExistencia.MainView = this.gvExistencia;
            this.gridExistencia.Name = "gridExistencia";
            this.gridExistencia.Size = new System.Drawing.Size(768, 406);
            this.gridExistencia.TabIndex = 3;
            this.gridExistencia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvExistencia});
            this.gridExistencia.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridExistencia_ProcessGridKey);
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataSource = typeof(SelectivasEnSucursales.Modelos.Articulo);
            // 
            // gvExistencia
            // 
            this.gvExistencia.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvExistencia.Appearance.FocusedRow.Options.UseFont = true;
            this.gvExistencia.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvExistencia.Appearance.GroupFooter.Options.UseFont = true;
            this.gvExistencia.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvExistencia.Appearance.GroupPanel.Options.UseFont = true;
            this.gvExistencia.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvExistencia.Appearance.GroupRow.Options.UseFont = true;
            this.gvExistencia.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvExistencia.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvExistencia.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvExistencia.Appearance.Row.Options.UseFont = true;
            this.gvExistencia.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvExistencia.Appearance.TopNewRow.Options.UseFont = true;
            this.gvExistencia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClavePrincipal,
            this.colClave,
            this.colNombre,
            this.colExistencia,
            this.colFisico});
            this.gvExistencia.GridControl = this.gridExistencia;
            this.gvExistencia.Name = "gvExistencia";
            this.gvExistencia.OptionsView.ShowGroupPanel = false;
            this.gvExistencia.ShownEditor += new System.EventHandler(this.gvExistencia_ShownEditor);
            // 
            // colClavePrincipal
            // 
            this.colClavePrincipal.FieldName = "ClavePrincipal";
            this.colClavePrincipal.Name = "colClavePrincipal";
            this.colClavePrincipal.Visible = true;
            this.colClavePrincipal.VisibleIndex = 0;
            // 
            // colClave
            // 
            this.colClave.FieldName = "Clave";
            this.colClave.Name = "colClave";
            this.colClave.OptionsColumn.AllowEdit = false;
            this.colClave.Visible = true;
            this.colClave.VisibleIndex = 1;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            // 
            // colExistencia
            // 
            this.colExistencia.DisplayFormat.FormatString = "###,##0.###";
            this.colExistencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colExistencia.FieldName = "Existencia";
            this.colExistencia.Name = "colExistencia";
            this.colExistencia.OptionsColumn.AllowEdit = false;
            this.colExistencia.Visible = true;
            this.colExistencia.VisibleIndex = 3;
            // 
            // colFisico
            // 
            this.colFisico.DisplayFormat.FormatString = "###,##0.###";
            this.colFisico.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFisico.FieldName = "Fisico";
            this.colFisico.Name = "colFisico";
            this.colFisico.Visible = true;
            this.colFisico.VisibleIndex = 4;
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfigurar.Image")));
            this.btnConfigurar.Location = new System.Drawing.Point(12, 12);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(48, 48);
            this.btnConfigurar.TabIndex = 1;
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Location = new System.Drawing.Point(359, 533);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 28);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label2.Location = new System.Drawing.Point(230, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selectivas de Almacén - Abarrotes";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 533);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 28);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(674, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "DEMO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmAbarrotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.gridExistencia);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAbarrotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selectivas para sucursales";
            this.Load += new System.EventHandler(this.FrmAbarrotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbClave;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraGrid.GridControl gridExistencia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvExistencia;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colClave;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colExistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colFisico;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Button btnImprimir;
        private DevExpress.XtraGrid.Columns.GridColumn colClavePrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label7;
    }
}