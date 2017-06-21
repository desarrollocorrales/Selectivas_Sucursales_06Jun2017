using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using SelectivasEnSucursales.Modelos;
using SelectivasEnSucursales.Controladores;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using ClasesDeConfiguracion;

namespace SelectivasEnSucursales.GUIs
{
    public partial class FrmAbarrotes : Form
    {
        private List<Articulo> lstArticulos;
        public bool _defConfig { get; set; }

        public FrmAbarrotes()
        {
            InitializeComponent();
            lstArticulos = new List<Articulo>();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this._defConfig)
                    throw new Exception("No se ha definido la configuración");
                Buscar();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Buscar()
        {
            int iAlmacen = Properties.Settings.Default.Almacen;
            string sClave = txbClave.Text.ToUpper();

            FBDAL FbDal = new FBDAL();            
            List<Articulo> lstArticulosEncontrados = FbDal.BuscarArticulo(sClave, iAlmacen);

            if (lstArticulosEncontrados.Count == 0)
            {
                StringBuilder mensaje = new StringBuilder();
                mensaje.AppendLine(string.Format("No se encontró el articulo con clave: [{0}]", sClave));
                MessageBox.Show(mensaje.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = this.txbClave;
                this.txbClave.SelectAll();
                return;
            }

            foreach (Articulo art in lstArticulosEncontrados)
            {
                Articulo buscado = lstArticulos.Find(o => o.Articulo_ID == art.Articulo_ID);

                if (buscado == null)
                    lstArticulos.Add(art);
                else 
                {
                    StringBuilder mensaje = new StringBuilder();
                    mensaje.AppendLine(string.Format("El articulo con clave: [{0}] ya esta en la lista",sClave));
                    mensaje.AppendLine(string.Format("con el nombre: [{0}]", art.Nombre));
                    MessageBox.Show(mensaje.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            gridExistencia.DataSource= lstArticulos;
            gvExistencia.BestFitColumns();

            txbClave.Text = string.Empty;
            txbClave.Focus();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            frmAcceso formA = new frmAcceso();

            var respuesta = formA.ShowDialog();

            if (respuesta == System.Windows.Forms.DialogResult.OK)
            {
                FrmConfiguracionAbarrotes form = new FrmConfiguracionAbarrotes();
                var resultado = form.ShowDialog();

                if (resultado == System.Windows.Forms.DialogResult.OK)
                    this.FrmAbarrotes_Load(null, null);
            }
        }

        private void txbClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Buscar();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this._defConfig)
                    throw new Exception("No se ha definido la configuración");

                Imprimir();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Imprimir()
        {     
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());

            PageHeaderArea headerArea;

            headerArea = new PageHeaderArea();
            headerArea.Content.Add(Environment.NewLine);
            headerArea.Content.Add(Properties.Settings.Default.Sucursal);
            headerArea.Content.Add(DateTime.Today.ToShortDateString());
            headerArea.LineAlignment = BrickAlignment.Center;

            PageFooterArea footerArea;
            PageHeaderFooter headerfooter;

            footerArea = new PageFooterArea();
            footerArea.Content.Add("[Page #]");
            footerArea.LineAlignment = BrickAlignment.Far;

            headerfooter = new PageHeaderFooter(headerArea, footerArea);
            link.PageHeaderFooter = headerfooter;

            link.Component = gridExistencia;
            link.CreateDocument();

            this.gvExistencia.FocusedRowHandle = -1;


            link.ShowPreviewDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lstArticulos = new List<Articulo>();
            gridExistencia.DataSource = null;
            gvExistencia.BestFitColumns();
        }

        private void FrmAbarrotes_Load(object sender, EventArgs e)
        {
            try
            {
                // valida si ya tiene alguna clave guardada para el archivo
                string cveActual = Properties.Settings.Default.accesoConfig;

                if (string.IsNullOrEmpty(cveActual))
                {
                    string acceso = Modelos.Utilerias.Transform("p4ssw0rd");

                    Properties.Settings.Default.accesoConfig = acceso;
                    Properties.Settings.Default.Save();
                }

                
                string fileName = "config.dat";
                string pathConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\SelecSuc\";

                // si no existe el directorio, lo crea
                bool exists = System.IO.Directory.Exists(pathConfigFile);

                if (!exists) System.IO.Directory.CreateDirectory(pathConfigFile);

                // busca en el directorio si exite el archivo con el nombre dado
                var file = Directory.GetFiles(pathConfigFile, fileName, SearchOption.AllDirectories)
                        .FirstOrDefault();

                if (file == null)
                {
                    // no existe
                    // abrir el formulario para llenar la configuracion de conexion 
                    FrmConfiguracionAbarrotes form = new FrmConfiguracionAbarrotes();
                    var resultado = form.ShowDialog();

                    if (resultado != System.Windows.Forms.DialogResult.OK)
                    {
                        this._defConfig = false;
                        throw new Exception("No se ha definido la configuración");
                    }
                }

                file = Directory.GetFiles(pathConfigFile, fileName, SearchOption.AllDirectories)
                        .FirstOrDefault();

                // si existe
                // obtener la cadena de conexion del archivo
                FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.DecryptFile(file, "milagros");

                if (result.status == FEncrypt.Estatus.ERROR)
                    throw new Exception(result.error);

                if (result.status == FEncrypt.Estatus.OK)
                {
                    string[] list = result.resultado.Split(new string[] { "||" }, StringSplitOptions.None);

                    string sucursal = list[0].Substring(2);           // sucursal
                    string servidor = list[1].Substring(2);           // servidor
                    string baseDatos = list[2].Substring(2);           // base de datos
                    string usuario = list[3].Substring(2);               // usuario
                    string contra = list[4].Substring(2);         // contraseña
                    string puerto = list[5].Substring(2);             // puerto
                    string almacen = list[7].Substring(2);             // almacen


                    ConfiguracionFB objConfig = new ConfiguracionFB();
                    objConfig.Database = servidor + ":" + baseDatos;
                    objConfig.Usuario = usuario;
                    objConfig.Contraseña = contra;
                    objConfig.Puerto = Convert.ToInt16(puerto);

                    Properties.Settings.Default.Almacen = Convert.ToInt32(almacen);

                    Properties.Settings.Default.Configuracion = objConfig;

                    Properties.Settings.Default.Save();

                    bool demo = Convert.ToBoolean(list[8].Substring(2));             // demostrativo
                    string fecha = list[9].Substring(2);                             // fechaPrueba

                    if (demo)
                    {
                        // obtiene fecha microsip
                        FBDAL FbDal = new FBDAL();
                        string fechaActual = FbDal.getFecha();

                        // fecha tomada del microsip a partir de la primera vez que se configuro la aplicacion
                        DateTime dtD = DateTime.Parse(fecha).AddDays(7); // siete dias de prueba
                        DateTime dtA = DateTime.Parse(fechaActual);

                        // diferencia entre dias de la fecha actual y la tomada del microsip
                        int dif = (dtD - dtA).Days;

                        //if (dif >= 0)
                        if (dif < 0)
                        {
                            MessageBox.Show("La versión de prueba ha caducado", "Selectivas de Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.txbClave.Enabled = false;
                            this.btnBuscar.Enabled = false;
                            this.btnImprimir.Enabled = false;
                            this.btnLimpiar.Enabled = false;

                            this.label7.Text = "CADUCADO";
                        }
                    }

                }

                this._defConfig = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Selectivas de Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gvExistencia_ShownEditor(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                this.gvExistencia.ActiveEditor.SelectAll();
            }));
        }

        private void gridExistencia_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as DevExpress.XtraGrid.GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete)
            {
                view.DeleteSelectedRows();
                e.Handled = true;
            }
        }

        private void gvExistencia_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.Goldenrod;
                e.Appearance.ForeColor = Color.Black;
            }
        }
    }
}
