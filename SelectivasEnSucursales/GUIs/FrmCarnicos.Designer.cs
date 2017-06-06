namespace SelectivasEnSucursales.GUIs
{
    partial class FrmCarnicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarnicos));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txbRutaArchivoEscaneo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridEtiquetas = new DevExpress.XtraGrid.GridControl();
            this.etiquetasGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEtiquetas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumeroDeEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaDeEmpaque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaDeCaducidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.ofdEscaneo = new System.Windows.Forms.OpenFileDialog();
            this.btnBuscarArchivo = new System.Windows.Forms.Button();
            this.bgwConsulta = new System.ComponentModel.BackgroundWorker();
            this.pbCargando = new System.Windows.Forms.PictureBox();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.bgwConsultaFriolala = new System.ComponentModel.BackgroundWorker();
            this.lblTiempoFriolala = new System.Windows.Forms.Label();
            this.tvTarimas = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selectivas de Almacén - Cárnicos";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carnicerias Los Corrales";
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfigurar.Image")));
            this.btnConfigurar.Location = new System.Drawing.Point(12, 12);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(48, 48);
            this.btnConfigurar.TabIndex = 4;
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConsultar.AutoSize = true;
            this.btnConsultar.Location = new System.Drawing.Point(403, 119);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 30);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txbRutaArchivoEscaneo
            // 
            this.txbRutaArchivoEscaneo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbRutaArchivoEscaneo.BackColor = System.Drawing.Color.White;
            this.txbRutaArchivoEscaneo.Enabled = false;
            this.txbRutaArchivoEscaneo.Location = new System.Drawing.Point(12, 89);
            this.txbRutaArchivoEscaneo.Name = "txbRutaArchivoEscaneo";
            this.txbRutaArchivoEscaneo.Size = new System.Drawing.Size(810, 26);
            this.txbRutaArchivoEscaneo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Archivo de escaneo:";
            // 
            // gridEtiquetas
            // 
            this.gridEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEtiquetas.DataSource = this.etiquetasGridBindingSource;
            this.gridEtiquetas.Location = new System.Drawing.Point(219, 155);
            this.gridEtiquetas.MainView = this.gvEtiquetas;
            this.gridEtiquetas.Name = "gridEtiquetas";
            this.gridEtiquetas.Size = new System.Drawing.Size(653, 374);
            this.gridEtiquetas.TabIndex = 8;
            this.gridEtiquetas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEtiquetas});
            // 
            // etiquetasGridBindingSource
            // 
            this.etiquetasGridBindingSource.DataSource = typeof(SelectivasEnSucursales.SegConService.EtiquetasGrid);
            // 
            // gvEtiquetas
            // 
            this.gvEtiquetas.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEtiquetas.Appearance.FooterPanel.Options.UseFont = true;
            this.gvEtiquetas.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEtiquetas.Appearance.GroupFooter.Options.UseFont = true;
            this.gvEtiquetas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumeroDeEtiqueta,
            this.colClaveNombre,
            this.colFechaDeEmpaque,
            this.colFechaDeCaducidad,
            this.colCantidad,
            this.colUnidad});
            this.gvEtiquetas.GridControl = this.gridEtiquetas;
            this.gvEtiquetas.GroupCount = 1;
            this.gvEtiquetas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NumeroDeEtiqueta", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", this.colCantidad, "")});
            this.gvEtiquetas.Name = "gvEtiquetas";
            this.gvEtiquetas.OptionsBehavior.Editable = false;
            this.gvEtiquetas.OptionsView.ShowFooter = true;
            this.gvEtiquetas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colClaveNombre, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvEtiquetas.EndGrouping += new System.EventHandler(this.gvEtiquetas_EndGrouping);
            // 
            // colNumeroDeEtiqueta
            // 
            this.colNumeroDeEtiqueta.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroDeEtiqueta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroDeEtiqueta.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroDeEtiqueta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroDeEtiqueta.FieldName = "NumeroDeEtiqueta";
            this.colNumeroDeEtiqueta.Name = "colNumeroDeEtiqueta";
            this.colNumeroDeEtiqueta.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NumeroDeEtiqueta", "{0:0,0}")});
            this.colNumeroDeEtiqueta.Visible = true;
            this.colNumeroDeEtiqueta.VisibleIndex = 0;
            // 
            // colClaveNombre
            // 
            this.colClaveNombre.FieldName = "ClaveNombre";
            this.colClaveNombre.Name = "colClaveNombre";
            this.colClaveNombre.Visible = true;
            this.colClaveNombre.VisibleIndex = 1;
            // 
            // colFechaDeEmpaque
            // 
            this.colFechaDeEmpaque.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaDeEmpaque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaDeEmpaque.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaDeEmpaque.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaDeEmpaque.FieldName = "FechaDeEmpaque";
            this.colFechaDeEmpaque.Name = "colFechaDeEmpaque";
            this.colFechaDeEmpaque.Visible = true;
            this.colFechaDeEmpaque.VisibleIndex = 1;
            // 
            // colFechaDeCaducidad
            // 
            this.colFechaDeCaducidad.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaDeCaducidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaDeCaducidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaDeCaducidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaDeCaducidad.FieldName = "FechaDeCaducidad";
            this.colFechaDeCaducidad.Name = "colFechaDeCaducidad";
            this.colFechaDeCaducidad.Visible = true;
            this.colFechaDeCaducidad.VisibleIndex = 2;
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 3;
            // 
            // colUnidad
            // 
            this.colUnidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 4;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Location = new System.Drawing.Point(405, 572);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 28);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // ofdEscaneo
            // 
            this.ofdEscaneo.FileName = "*.txt";
            this.ofdEscaneo.Filter = "Archivos de Texto | *.txt";
            // 
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarArchivo.AutoSize = true;
            this.btnBuscarArchivo.Location = new System.Drawing.Point(828, 89);
            this.btnBuscarArchivo.Name = "btnBuscarArchivo";
            this.btnBuscarArchivo.Size = new System.Drawing.Size(44, 28);
            this.btnBuscarArchivo.TabIndex = 10;
            this.btnBuscarArchivo.Text = "...";
            this.btnBuscarArchivo.UseVisualStyleBackColor = true;
            this.btnBuscarArchivo.Click += new System.EventHandler(this.btnBuscarArchivo_Click);
            // 
            // bgwConsulta
            // 
            this.bgwConsulta.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConsulta_DoWork);
            this.bgwConsulta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwConsulta_RunWorkerCompleted);
            // 
            // pbCargando
            // 
            this.pbCargando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCargando.Image = global::SelectivasEnSucursales.Properties.Resources.cargando;
            this.pbCargando.Location = new System.Drawing.Point(358, 259);
            this.pbCargando.Name = "pbCargando";
            this.pbCargando.Size = new System.Drawing.Size(169, 94);
            this.pbCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCargando.TabIndex = 11;
            this.pbCargando.TabStop = false;
            this.pbCargando.Visible = false;
            // 
            // lbltiempo
            // 
            this.lbltiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiempo.Location = new System.Drawing.Point(25, 532);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(127, 13);
            this.lbltiempo.TabIndex = 12;
            this.lbltiempo.Text = "Tiempo de consulta ACC:";
            // 
            // bgwConsultaFriolala
            // 
            this.bgwConsultaFriolala.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConsultaFriolala_DoWork);
            this.bgwConsultaFriolala.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwConsultaFriolala_RunWorkerCompleted);
            // 
            // lblTiempoFriolala
            // 
            this.lblTiempoFriolala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTiempoFriolala.AutoSize = true;
            this.lblTiempoFriolala.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoFriolala.Location = new System.Drawing.Point(12, 548);
            this.lblTiempoFriolala.Name = "lblTiempoFriolala";
            this.lblTiempoFriolala.Size = new System.Drawing.Size(140, 13);
            this.lblTiempoFriolala.TabIndex = 13;
            this.lblTiempoFriolala.Text = "Tiempo de consulta Friolala:";
            // 
            // tvTarimas
            // 
            this.tvTarimas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvTarimas.Location = new System.Drawing.Point(12, 155);
            this.tvTarimas.Name = "tvTarimas";
            this.tvTarimas.Size = new System.Drawing.Size(201, 374);
            this.tvTarimas.TabIndex = 15;
            this.tvTarimas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTarimas_AfterSelect);
            // 
            // FrmCarnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 612);
            this.Controls.Add(this.tvTarimas);
            this.Controls.Add(this.lblTiempoFriolala);
            this.Controls.Add(this.lbltiempo);
            this.Controls.Add(this.pbCargando);
            this.Controls.Add(this.btnBuscarArchivo);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gridEtiquetas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txbRutaArchivoEscaneo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCarnicos";
            this.Text = "Selectivas de Carnicos";
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txbRutaArchivoEscaneo;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridEtiquetas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEtiquetas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.OpenFileDialog ofdEscaneo;
        private System.Windows.Forms.Button btnBuscarArchivo;
        private System.Windows.Forms.BindingSource etiquetasGridBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroDeEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDeEmpaque;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDeCaducidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private System.ComponentModel.BackgroundWorker bgwConsulta;
        private System.Windows.Forms.PictureBox pbCargando;
        private System.Windows.Forms.Label lbltiempo;
        private System.ComponentModel.BackgroundWorker bgwConsultaFriolala;
        private System.Windows.Forms.Label lblTiempoFriolala;
        private System.Windows.Forms.TreeView tvTarimas;
    }
}