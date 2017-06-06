using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesDeConfiguracion;
using SelectivasEnSucursales.Modelos;
using SelectivasEnSucursales.Controladores;
using AccSettings;

namespace SelectivasEnSucursales.GUIs
{
    public partial class FrmConfiguracionAbarrotes : Form
    {
        ConfiguracionFB objConfig;

        public FrmConfiguracionAbarrotes()
        {
            InitializeComponent();
            objConfig = Properties.Settings.Default.Configuracion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objConfig = new ConfiguracionFB();            
            objConfig.Database = txbDatabase.Text;
            objConfig.Usuario = txbUser.Text;
            objConfig.Contraseña = txbContraseña.Text;
            objConfig.Puerto = (int)nudPuerto.Value;
            Properties.Settings.Default.Configuracion = objConfig;
            
            Almacen AlmacenSeleccionado = (Almacen)cbAlmacenes.SelectedItem;
            if (AlmacenSeleccionado != null)
            {
                Properties.Settings.Default.Almacen = AlmacenSeleccionado.ID;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un almacén", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Properties.Settings.Default.Sucursal = txbSucursal.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("La configuracion se ha guardado con exito!!!");
            this.Close();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            if (objConfig != null)
            {
                txbDatabase.Text = objConfig.Database;
                txbUser.Text = objConfig.Usuario;
                txbContraseña.Text = objConfig.Contraseña;
                txbSucursal.Text = Properties.Settings.Default.Sucursal;
                nudPuerto.Value = objConfig.Puerto;
            }
        }

        private void btnMostrarAlmacenes_Click(object sender, EventArgs e)
        {
            MostrarAlmacenes();
        }
        private void MostrarAlmacenes()
        {
            try
            {
                FBDAL FbDal = new FBDAL();
                List<Almacen> lstAlmacenes = FbDal.BuscarAlmacenes();

                cbAlmacenes.DataSource = lstAlmacenes;
                cbAlmacenes.DisplayMember = "Nombre";
                cbAlmacenes.ValueMember = "ID";
                cbAlmacenes.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarConfiguraciones(string sFilePath)
        {
            //Obtener la ruta del archivo de configuraciones de Asistencia y la SettingsKey*
            MicroSipSettings oConfiguracion = new MicroSipSettings();
            oConfiguracion.FileName = sFilePath;
            oConfiguracion.Key = "C0RR4L35";

            MicroSipSettings MicrosipConfig = oConfiguracion.Deserialize<MicroSipSettings>(true);

            txbSucursal.Text = MicrosipConfig.Conexiones[0].Empresa;
            txbDatabase.Text = MicrosipConfig.Conexiones[0].Host;
            txbUser.Text = MicrosipConfig.Conexiones[0].Usuario;
            txbContraseña.Text = MicrosipConfig.Conexiones[0].PassWord;
            nudPuerto.Value = (decimal)MicrosipConfig.Conexiones[0].Puerto;
        }

        private void btnCargarParametros_Click(object sender, EventArgs e)
        {
            try
            {
                string ConfigPath = ObtenerArchivoDeConfiguracion();

                CargarConfiguraciones(ConfigPath);

                objConfig = new ConfiguracionFB();
                objConfig.Database = txbDatabase.Text;
                objConfig.Usuario = txbUser.Text;
                objConfig.Contraseña = txbContraseña.Text;
                objConfig.Puerto = (int)nudPuerto.Value;
                Properties.Settings.Default.Configuracion = objConfig;

                Properties.Settings.Default.Save();

                cbAlmacenes.DataSource = null;
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Error en el archivo de configuración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerArchivoDeConfiguracion()
        {
            ofdConfiguracion.InitialDirectory = Environment.CurrentDirectory + "\\Configuracion\\";
            ofdConfiguracion.ShowDialog();
            string FileName = ofdConfiguracion.FileName;
            
            return FileName;
        }
    }
}
