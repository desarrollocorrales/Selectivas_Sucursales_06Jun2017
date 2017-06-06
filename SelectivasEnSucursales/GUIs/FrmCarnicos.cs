using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraGrid.Views.Base;
using SelectivasEnSucursales.Modelos;

namespace SelectivasEnSucursales.GUIs
{
    public partial class FrmCarnicos : Form
    {
        private TimeSpan tiempoConsultaInicial, tiempoConsultaFinal;
        private string sError;
        private string sEtiquetas;
        private string sArchivoDeEscaneo;
        private List<Etiqueta> lstEtiquetas;
        private List<SegConService.EtiquetasGrid> lstEtiquetasACC;
        private List<WebServiceFriolala.EtiquetasGrid> lstEtiquetasFriolala;

        // Creando componentes de impresión.
        PrintingSystem SistemaImpresion = new PrintingSystem();
        PrintableComponentLink ComponenteImpresion = new PrintableComponentLink();

        public FrmCarnicos()
        {
            InitializeComponent();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            new FrmConfiguracionCarnicos().ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                lstEtiquetas = new List<Etiqueta>();
                sEtiquetas = obtenerListaDeEtiquetetasDeEscaneo();
                pbCargando.Visible = true;
                ConsultarEtiquetas();
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            obtenerArchivoDeEscaneo();
        }

        private string obtenerListaDeEtiquetetasDeEscaneo()
        {
            //Leer el archivo de escaneo
            string ArrayEtiquetas = string.Empty;

            try
            {                
                if (sArchivoDeEscaneo != null)
                {
                    StreamReader sr = new StreamReader(sArchivoDeEscaneo);
                    ArrayEtiquetas = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }

            Tarimificar(ArrayEtiquetas);

            return ArrayEtiquetas;
        }
        private void ConsultarEtiquetas()
        {
            tiempoConsultaInicial = DateTime.Now.TimeOfDay;
            btnConsultar.Enabled = false;
            bgwConsulta.RunWorkerAsync();
            bgwConsultaFriolala.RunWorkerAsync();
        }
        
        private void obtenerArchivoDeEscaneo()
        {
            DialogResult DR = ofdEscaneo.ShowDialog();

            if (DR == DialogResult.OK)
            {
                sArchivoDeEscaneo = ofdEscaneo.FileName;
                txbRutaArchivoEscaneo.Text = ofdEscaneo.FileName;
            }
        }        

        private void bgwConsulta_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                SegConService.ServicioWeb Servicio = new SegConService.ServicioWeb();
                Servicio.Url = Properties.Settings.Default.URLWebService;

                lstEtiquetasACC = Servicio.ConsultarEtiquetas(sEtiquetas).ToList();

                Etiqueta etiqueta;
                foreach (SegConService.EtiquetasGrid DatosEtiqueta in lstEtiquetasACC)
                {
                    etiqueta = new Etiqueta();
                    etiqueta.ClaveNombre = DatosEtiqueta.ClaveNombre;
                    etiqueta.NumeroDeEtiqueta = DatosEtiqueta.NumeroDeEtiqueta;
                    etiqueta.FechaDeEmpaque = DatosEtiqueta.FechaDeEmpaque;
                    etiqueta.FechaDeCaducidad = DatosEtiqueta.FechaDeCaducidad;
                    etiqueta.Cantidad = DatosEtiqueta.Cantidad;
                    etiqueta.Unidad = DatosEtiqueta.Unidad;

                    lstEtiquetas.Add(etiqueta);
                }
                sError = string.Empty;
            }
            catch (Exception ex)
            {
                sError = "Ocurrio un error con el Servicio Web: " + Environment.NewLine + ex.Message;
            }
        }
        private void bgwConsulta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (sError.Equals(string.Empty))
            {
                if (bgwConsultaFriolala.IsBusy == false)
                {
                    lstEtiquetas = lstEtiquetas.ToLookup(o => o.NumeroDeEtiqueta).Select(col => col.First()).ToList();

                    gridEtiquetas.DataSource = lstEtiquetas;
                    gvEtiquetas.BestFitColumns();
                    pbCargando.Visible = false;
                    btnConsultar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(sError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            tiempoConsultaFinal = DateTime.Now.TimeOfDay;
            TimeSpan tiempoTotal = tiempoConsultaFinal - tiempoConsultaInicial;
            lbltiempo.Text = "Tiempo de consulta ACC: " + tiempoTotal.Seconds + " segundos.";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirGrid();
        }
        private void ImprimirGrid()
        {
            /******************************/
            // Creamos el Header
            PageHeaderArea Header = new PageHeaderArea();
            ComponenteImpresion.Images.Add(Image.FromFile(Environment.CurrentDirectory+"\\logomini.png"));
            Header.Content.AddRange(new string[] { "[Image 0]", Properties.Settings.Default.Sucursal, "[Time Printed]" });
            Header.LineAlignment = BrickAlignment.Far;
            /******************************/

            /******************************/
            //Creamos el Footer
            string izquierda = "Paginas: [Page # of Pages #]";
            string centro = "Usuario: [User Name]";
            string derecha = "Fecha: [Date Printed]";
            PageFooterArea Footer = new PageFooterArea();
            Footer.Content.AddRange(new string[] { izquierda, centro, derecha });
            Footer.LineAlignment = BrickAlignment.Near;
            /*****************************/

            /******************************/
            //Agregar el Grid al documento
            ComponenteImpresion.Component = gridEtiquetas;
            //Agregar el header y el footer al documento
            ComponenteImpresion.PageHeaderFooter = new PageHeaderFooter(Header, Footer);
            //Crear el documento
            ComponenteImpresion.CreateDocument(SistemaImpresion);
            //Mostrar la vista previa para imprimir
            ComponenteImpresion.ShowPreviewDialog();
        }

        private void bgwConsultaFriolala_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                WebServiceFriolala.ServicioWeb Servicio = new WebServiceFriolala.ServicioWeb();
                Servicio.Url = Properties.Settings.Default.URLWebServiceFriolala;

                lstEtiquetasFriolala = Servicio.ConsultarEtiquetas(sEtiquetas).ToList();

                Etiqueta etiqueta;
                foreach (WebServiceFriolala.EtiquetasGrid DatosEtiqueta in lstEtiquetasFriolala)
                {
                    etiqueta = new Etiqueta();
                    etiqueta.ClaveNombre = DatosEtiqueta.ClaveNombre;
                    etiqueta.NumeroDeEtiqueta = DatosEtiqueta.NumeroDeEtiqueta;
                    etiqueta.FechaDeEmpaque = DatosEtiqueta.FechaDeEmpaque;
                    etiqueta.FechaDeCaducidad = DatosEtiqueta.FechaDeCaducidad;
                    etiqueta.Cantidad = DatosEtiqueta.Cantidad;
                    etiqueta.Unidad = DatosEtiqueta.Unidad;

                    lstEtiquetas.Add(etiqueta);
                }

                sError = string.Empty;
            }
            catch (Exception ex)
            {
                sError = "Ocurrio un error con el Servicio Web: " + Environment.NewLine + ex.Message;
            }
        }
        private void bgwConsultaFriolala_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (sError.Equals(string.Empty))
            {
                if (bgwConsulta.IsBusy == false)
                {
                    lstEtiquetas = lstEtiquetas.ToLookup(o => o.NumeroDeEtiqueta).Select(col => col.First()).ToList();
                    
                    gridEtiquetas.DataSource = lstEtiquetas;
                    gvEtiquetas.BestFitColumns();
                    pbCargando.Visible = false;
                    btnConsultar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(sError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            tiempoConsultaFinal = DateTime.Now.TimeOfDay;
            TimeSpan tiempoTotal = tiempoConsultaFinal - tiempoConsultaInicial;
            lblTiempoFriolala.Text = "Tiempo de consulta Friolala: " + tiempoTotal.Seconds + " segundos.";
        }

        private void gvEtiquetas_EndGrouping(object sender, EventArgs e)
        {
            //Expandir los grupos
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }

        private void ShowException(Exception ex)
        {
            string TipoException = ex.GetType().ToString();
            StringBuilder SB = new StringBuilder();
            if (ex.InnerException != null)
                SB.AppendLine(ex.InnerException.Message);
            else
                SB.AppendLine(ex.Message);

            MessageBox.Show(SB.ToString(), TipoException, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }        

        private void Tarimificar(string sEscaneo)
        {
            string[] sTarimificado = sEscaneo.Split('.');

            int i = 1;
            tvTarimas.Nodes.Clear();
            foreach (string tarima in sTarimificado)
            {
                tvTarimas.Nodes.Add("Tarima " + (i++).ToString().PadLeft(3));
            }
        }

        private void ActualizarGridPorTarima(int indexTarima)
        {
            string sEscaneo = obtenerListaDeEtiquetetasDeEscaneo();
            string[] sTarimificado = sEscaneo.Split('.');
            string sEtiquetas = sTarimificado[indexTarima];
            string[] numerosdeetiquetas = sEtiquetas.Replace("\r\n","\n").Split('\n');

            List<Etiqueta> lstEtiquetasAMostrar = new List<Etiqueta>();
            foreach (string numeroetiqueta in numerosdeetiquetas)
            {
                lstEtiquetasAMostrar.Add(lstEtiquetas.FirstOrDefault(o => o.NumeroDeEtiqueta == numeroetiqueta));
            }

            lstEtiquetasAMostrar.RemoveAll(o=>o == null);
            gridEtiquetas.DataSource = lstEtiquetasAMostrar;
            gvEtiquetas.BestFitColumns();
        }

        private void tvTarimas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode SelectedNode = tvTarimas.SelectedNode;
            ActualizarGridPorTarima(tvTarimas.SelectedNode.Index);
            tvTarimas.SelectedNode = SelectedNode;
        }

    }
}
